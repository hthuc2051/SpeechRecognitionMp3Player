using Music.thucnh.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.models
{
    class UserDAO
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
        public UserDTO checkLogin(string username, string password)
        {
            UserDTO dto = null;
            string fullname, role, dateOfBirth;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select FullName,Role,DateOfBirth From Users Where Username = @username AND Password = @password", sqlConnection))
                        command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fullname = reader.GetString(0);
                            role = reader.GetString(1);
                            dateOfBirth = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                            dto = new UserDTO(username, fullname, role, dateOfBirth);
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
            return dto;
        }
        public List<UserDTO> getAllUsers()
        {
            List<UserDTO> result = null;
            UserDTO dto = null;
            string fullname, role, dateOfBirth,username,password;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<UserDTO>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("Select Username,Password,FullName,Role,DateOfBirth From Users", sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            username = reader.GetString(0);
                            password = reader.GetString(1);
                            fullname = reader.GetString(2);
                            role = reader.GetString(3);
                            dateOfBirth = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                            dto = new UserDTO(username, fullname, role, dateOfBirth);
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

        public Boolean addUser(string username, string password, string fullname, string role, string dateOfBirth)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("INSERT INTO Users(Username, Password, Fullname, Role, DateOfBirth) VALUES(@username, @password, @fullname, @role, @dateOfBirth)", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
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

        public Boolean udpateUser(string username, string password, string fullname, string role, string dateOfBirth)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("UPDATE Users SET Password = @password ,Fullname = @fullname, Role = @role, DateOfBirth = @dateOfBirth WHERE Username = @username", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
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

        public Boolean deleteUser(string username)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("DELETE Users Where Username = @username", sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
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
        public Boolean deleteSong_PlaylistByUsername(string username)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                using (command = new SqlCommand("DELETE Playlist_Songs  FROM Playlist_Songs " +
                    "INNER JOIN Playlists ON Playlist_Songs.PlaylistID = Playlists.ID " +
                    "WHERE Playlists.Username = @username; ", sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
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
                sqlConnection.Close();
            }
            return check;
        }
        public Boolean deletePlaylistOfUser(string username)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("DELETE Playlist Username = @username; ", sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
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
            sqlConnection.Close();
            }
            return check;
        }
    }
}
