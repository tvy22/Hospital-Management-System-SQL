using System;

namespace Hospital_Management_System_SQL.Models
{
    public class Staff : Person
    {
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Staff() { }

        public Staff(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}