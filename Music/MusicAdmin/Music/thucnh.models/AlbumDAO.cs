using Music.thucnh.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.models
{
    class AlbumDAO
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

        public List<AlbumDTO> getAllAlbums()
        {
            List<AlbumDTO> result = null;
            int id;
            string albumName, image;


            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<AlbumDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select ID,name,image From Albums", sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            albumName = reader.GetString(1);
                            image = reader.GetString(2);
                            AlbumDTO dto = new AlbumDTO(id, albumName, image);
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
        public Boolean addAlbum(AlbumDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Insert into " +
                        " Albums(ID,name,image) " +
                        " Values (@ID, @name,@image)", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@ID", dto.Id);
                        command.Parameters.AddWithValue("@name", dto.Name);
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
        public Boolean updateAlbum(AlbumDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Albums SET name = @name " +
                        "WHERE ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", dto.Id);
                    command.Parameters.AddWithValue("@name", dto.Name);
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
                    command = new SqlCommand("UPDATE Albums SET image = @image WHERE ID = @id", sqlConnection);
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
        public Boolean deleteAlbum(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Albums where ID = @id", sqlConnection);
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
        public void deleteSongAlbumArtisByAlbumID(int id)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Song_Album_Artist where albumID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery() ;
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
        }
    }
}
