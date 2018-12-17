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

        public List<PlaylistDTO> GetAllPlayList()
        {
            List<PlaylistDTO> result = null;
            int id;
            string playlistName, dateCreate, image,username;


            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<PlaylistDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select Playlists.ID,Playlists.Username,Playlists.PlaylistName,Playlists.dateCreate,Playlists.image From Playlists ", sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            username = reader.GetString(1);
                            playlistName = reader.GetString(2);       
                            dateCreate = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            image = reader.GetString(4);
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
        public Boolean updatePlaylist(int id, string playlistName, string dateCreate)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (command = new SqlCommand("UPDATE PlayLists SET PlaylistName = @playlistName ,dateCreate = @dateCreate WHERE ID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@playlistName", playlistName);
                    command.Parameters.AddWithValue("@dateCreate", dateCreate);
                    check = command.ExecuteNonQuery()>0;
                }
                sqlConnection.Close();
            }
            return check;
        }

        public Boolean deletePlaylist(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (command = new SqlCommand("DELETE PlayLists Where ID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
                }
                sqlConnection.Close();
            }
            return check;
        }
        public Boolean deleteSong_PlaylistByPlayListID(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (command = new SqlCommand("DELETE Playlist_Songs Where PlaylistID = @id", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    check =  command.ExecuteNonQuery()>0;
                }
                sqlConnection.Close();
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
                    command = new SqlCommand("UPDATE PlayLists SET image = @image WHERE ID = @id", sqlConnection);
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
        public Boolean addSong_Playlist(int id, int playlistID, int songID)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (command = new SqlCommand("INSERT INTO Playlist_Songs(PlaylistID, songID) VALUES(@id, @playlistID, @songID)", sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@playlistID", playlistID);
                    command.Parameters.AddWithValue("@songID", songID);
                    check = command.ExecuteNonQuery() > 0;
                }
                sqlConnection.Close();
            }
            return check;
        }
        
    }
}
