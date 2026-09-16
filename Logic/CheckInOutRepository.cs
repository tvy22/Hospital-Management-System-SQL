using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Logic
{
    public class CheckInOutRepository
    {
        public List<Checkin> GetActiveVisits()
        {
            List<Checkin> list = new List<Checkin>();
            string query = @"SELECT AppID, PatientID, PatientName, DocName, DocSpeciality, 
                            Date, RoomNumber, Reason, Status, Fee 
                            FROM CheckIns WHERE Status = 'Active' OR Status IS NULL";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Checkin
                        {
                            AppID = reader["AppID"].ToString(),
                            PatientID = reader["PatientID"].ToString(),
                            PatientName = reader["PatientName"].ToString(),
                            DocName = reader["DocName"].ToString(),
                            DocSpeciality = reader["DocSpeciality"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            Reason = reader["Reason"].ToString(),
                            Fee = reader["Fee"] != DBNull.Value ? Convert.ToDecimal(reader["Fee"]) : 0
                        });
                    }
                }
            }
            return list;
        }

        public void RegisterCheckIn(Checkin entity)
        {
            string query = @"INSERT INTO CheckIns (AppID, PatientID, PatientName, DocName, DocSpeciality, Date, RoomNumber, Reason, Status, Fee)
                            VALUES (@AppID, @PatientID, @PatientName, @DocName, @DocSpeciality, @Date, @RoomNumber, @Reason, 'Active', @Fee)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppID", entity.AppID);
                cmd.Parameters.AddWithValue("@PatientID", entity.PatientID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PatientName", entity.PatientName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DocName", entity.DocName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DocSpeciality", entity.DocSpeciality ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Date", entity.Date);
                cmd.Parameters.AddWithValue("@RoomNumber", entity.RoomNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Reason", entity.Reason ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Fee", entity.Fee);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CompleteCheckOut(string appId, decimal finalCost)
        {
            string query = "UPDATE CheckIns SET Status = 'Completed', Fee = @Fee WHERE AppID = @AppID";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppID", appId);
                cmd.Parameters.AddWithValue("@Fee", finalCost);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GenerateNextAppID()
        {
            int maxId = 0;
            string query = "SELECT AppID FROM CheckIns WHERE AppID LIKE 'APP-%'";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string appId = reader["AppID"].ToString();
                        if (appId.Length > 4 && int.TryParse(appId.Substring(4), out int idVal))
                        {
                            if (idVal > maxId) maxId = idVal;
                        }
                    }
                }
            }
            return "APP-" + (maxId + 1).ToString("000");
        }
    }
}