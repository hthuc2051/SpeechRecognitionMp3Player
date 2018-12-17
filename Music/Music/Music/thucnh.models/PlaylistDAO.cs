using Music.thucnh.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.models
{
    class PlaylistDAO
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

        public List<PlaylistDTO> GetPlaylistsOfUser(string username)
        {
            List<PlaylistDTO> result = null;
            int id;
            string playlistName, dateCreate, image;


            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<PlaylistDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select Playlists.ID,Playlists.PlaylistName,Playlists.dateCreate,Playlists.image From Playlists Where Username = @username", sqlConnection))
                        command.Parameters.AddWithValue("@username", username);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            playlistName = reader.GetString(1);
                            dateCreate = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                            image = reader.GetString(3);
                            PlaylistDTO dto = new PlaylistDTO(id, playlistName, dateCreate, image);
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

        public List<PlaylistDTO> searchPlaylistsOfUser(string username, string searchValue)
        {
            List<PlaylistDTO> result = null;
            int id;
            string playlistName, dateCreate, image;


            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<PlaylistDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select Playlists.ID,Playlists.PlaylistName,Playlists.dateCreate,Playlists.image " +
                        " From Playlists Where Username =@username AND Playlists.PlaylistName " +
                        "LIKE @nameValue OR  Playlists.dateCreate LIKE @dateValue ", sqlConnection))
                        command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@nameValue", "%" + searchValue + "%");
                    command.Parameters.AddWithValue("@dateValue", "%" + searchValue + "%");
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            playlistName = reader.GetString(1);
                            dateCreate = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                            image = reader.GetString(3);
                            PlaylistDTO dto = new PlaylistDTO(id, playlistName, dateCreate, image);
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


        public Boolean addPlaylist(string username, string playlistName, string dateCreate,string image)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("INSERT INTO PlayLists(Username, PlaylistName, dateCreate,image) VALUES(@username, @playlistName, @dateCreate,@image)", sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@playlistName", playlistName);
                    command.Parameters.AddWithValue("@dateCreate", dateCreate);
                    command.Parameters.AddWithValue("@image", image);
                        check = command.ExecuteNonQuery()>0;
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
        public Boolean addSong_Playlist( int playlistID, int songID)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("INSERT INTO Playlist_Songs(PlaylistID, songID) VALUES(@playlistID, @songID)", sqlConnection))
                {
                    command.Parameters.AddWithValue("@playlistID", playlistID);
                    command.Parameters.AddWithValue("@songID", songID);
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
        public Boolean checkExistedSong_Playlist(int playlistID, int songID)
        {
            Boolean check = false;
            Console.WriteLine(playlistID + " - "+songID);
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select ID From Playlist_Songs Where PlaylistID = @playlistID AND songID = @songID", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@playlistID", playlistID);
                        command.Parameters.AddWithValue("@songID", songID);
                        using (reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                check = true;
                            }
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
            return check;
        }
        public Boolean deleteSong_PlaylistBySongIDAndPlayListID(int songID, int playListID)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("DELETE Playlist_Songs Where songID = @songID PlaylistID = @PlaylistID", sqlConnection))
                {
                    command.Parameters.AddWithValue("@songID", songID);
                    command.Parameters.AddWithValue("@playListID", playListID);
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

        public Boolean updatePlaylist(int id, string playlistName, string dateCreate)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("UPDATE PlayLists SET PlaylistName = @playlistName ,dateCreate = @dateCreate WHERE ID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@playlistName", playlistName);
                    command.Parameters.AddWithValue("@dateCreate", dateCreate);
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
        public Boolean deletePlaylist(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("DELETE PlayLists Where ID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
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
        public Boolean deleteSong_PlaylistByPlayListID(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("DELETE Playlist_Songs Where PlaylistID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
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
    }
}
