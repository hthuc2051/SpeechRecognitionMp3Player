using Music.thucnh.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.models
{
    class ArtistDAO
    {
        const string connectionString = "Data Source=DATBCSE63154\\SQLEXPRESS;Initial Catalog=MusicPlayer;Persist Security Info=True;User ID =sa; Password=123456";
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataReader reader;

        private void closeConnect()
        {
            reader.Close();
            sqlConnection.Close();
        }

        public List<ArtistDTO> getAllArtists()
        {
            List<ArtistDTO> result = null;
            int id;
            string name;
            string label, image;


            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<ArtistDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select ID,name,label,image From Artists", sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            name = reader.GetString(1);
                            label = reader.GetString(2);
                            image = reader.GetString(3);
                            ArtistDTO dto = new ArtistDTO(id, name, label, image);
                            result.Add(dto);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }


            return result;

        }
        public Boolean addArtist(ArtistDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Insert into " +
                        " Artists(ID,name,label,image) " +
                        " Values (@ID, @name,@label,@image)", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@ID", dto.Id);
                        command.Parameters.AddWithValue("@name", dto.Name);
                        command.Parameters.AddWithValue("@label", dto.Label);
                        command.Parameters.AddWithValue("@image", dto.Image);
                        check = command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return check;
        }
        public Boolean updateArtist(ArtistDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Artists SET name = @name, label = @label " +
                        "WHERE ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", dto.Id);
                    command.Parameters.AddWithValue("@name", dto.Name);
                    command.Parameters.AddWithValue("@label", dto.Label);
                    check = command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return check;
        }
        public Boolean updateImg(string imgName, int ID)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Artists SET image = @image WHERE ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@image", imgName);
                    check = command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return check;
        }
        public Boolean deleteArtist(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Artists where ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return check;
        }
        public Boolean deleteSongAlbumArtisByArtistID(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Song_Album_Artist where artistID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return check;
        }
    }
}
