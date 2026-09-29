using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management_System_SQL.Logic
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = @"Server=LAPTOP-QGUJ85C2\SQLEXPRESS;Database=HospitalDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Database Connection Successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}