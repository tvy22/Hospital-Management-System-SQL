using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Logic
{
    public class StaffRepository : IStaffRepository
    {
        public Staff Login(string username, string password)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT StaffID, Username, Password, Role, FullName FROM Staff WHERE Username = @Username AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Staff staff = new Staff
                            {
                                StaffID = Convert.ToInt32(reader["StaffID"]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"] != DBNull.Value ? reader["Role"].ToString() : string.Empty,
                                FullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : string.Empty
                            };
                            return staff;
                        }
                    }
                }
            }
            return null; 
        }
    }
}
