using System;

namespace Hospital_Management_System_SQL.Models
{
    public class Staff : Person
    {
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Staff() : base() { }

        public Staff(string username, string password) :base()
        {
            this.Username = username;
            this.Password = password;
        }

        public Staff(int staffID, string fullName, string phone, string gender, DateTime dateOfBirth, string username, string password, string role)
            : base(fullName, phone, gender, dateOfBirth)
        {
            StaffID = staffID;
            Username = username;
            Password = password;
            Role = role;
        }
    }
}