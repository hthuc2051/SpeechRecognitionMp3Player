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
            string albumName,image;


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

        public List<AlbumDTO> searchAlbums(string searchValue)
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
                    using (command = new SqlCommand("Select ID,name,image From Albums Where name Like @searchValue", sqlConnection))
                        command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
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

        public List<AlbumDTO> getAlbumsByArtistID(int artisID)
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
                    using (command = new SqlCommand("Select distinct Albums.ID,Albums.name,Albums.image " +
                        "From Artists, Albums, Song_Album_Artist " +
                        "Where Artists.ID = Song_Album_Artist.artistID AND Albums.ID = Song_Album_Artist.albumID " +
                        "AND Artists.ID = @artistID", sqlConnection))
                        command.Parameters.AddWithValue("@artistID", artisID);
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
    }
}
