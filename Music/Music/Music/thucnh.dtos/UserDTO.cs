using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.dtos
{
    class UserDTO
    {
        private string username, fullname, role, dateOfBirth;

        public UserDTO(string username, string fullname, string role, string dateOfBirth)
        {
            this.Username = username;
            this.Fullname = fullname;
            this.Role = role;
            this.DateOfBirth = dateOfBirth;
        }

        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Role { get => role; set => role = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
