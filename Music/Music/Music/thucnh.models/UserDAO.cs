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

    }
}
