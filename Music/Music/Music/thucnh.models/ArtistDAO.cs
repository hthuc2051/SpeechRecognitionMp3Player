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

        public List<ArtistDTO> searchArtists(string searchValue)
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
                    using (command = new SqlCommand("Select ID,name,label,image From Artists Where name Like @searchValue", sqlConnection))
                    command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
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
    }
}
