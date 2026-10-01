using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Logic
{
    public class CheckInOutRepository : ICheckinRepository
    {
        // 1. Get Active Visits (for Check-Out Grid)
        public List<Checkin> GetActiveVisits()
        {
            return GetVisitsByQuery("SELECT AppID, PatientID, PatientName, DoctorID, DocName, DocSpeciality, Date, RoomNumber, Reason, Status, Fee FROM CheckIns WHERE Status = 'Active' OR Status IS NULL");
        }

        // 2. Get Completed Visits (for Visit History)
        public List<Checkin> GetCompletedVisits()
        {
            return GetVisitsByQuery("SELECT AppID, PatientID, PatientName, DoctorID, DocName, DocSpeciality, Date, RoomNumber, Reason, Status, Fee FROM CheckIns WHERE Status = 'Completed'");
        }

        // 3. IEntityRepository<Checkin> - GetAll (defaults to active visits)
        public List<Checkin> GetAll()
        {
            return GetActiveVisits();
        }

        // 4. IEntityRepository<Checkin> - Save
        public void Save(Checkin entity)
        {
            string query = @"INSERT INTO CheckIns (AppID, PatientID, PatientName, DoctorID, DocName, DocSpeciality, Date, RoomNumber, Reason, Status, Fee)
                            VALUES (@AppID, @PatientID, @PatientName, @DoctorID, @DocName, @DocSpeciality, @Date, @RoomNumber, @Reason, 'Active', @Fee)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppID", entity.AppID);
                cmd.Parameters.AddWithValue("@PatientID", entity.PatientID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PatientName", entity.PatientName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DoctorID", entity.DoctorID ?? (object)DBNull.Value);
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

        // 5. Complete Check-Out
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

        // 6. IEntityRepository<Checkin> - GenerateNextID
        public string GenerateNextID()
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

        // 7. Required by IEntityRepository<Checkin> interface
        public Checkin GetById(string id)
        {
            return null; // Implement if needed
        }

        public void Delete(string id)
        {
            string query = "DELETE FROM CheckIns WHERE AppID = @AppID";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Helper method to eliminate duplicate reading code
        private List<Checkin> GetVisitsByQuery(string query)
        {
            List<Checkin> list = new List<Checkin>();

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
                            DoctorID = reader["DoctorID"].ToString(),
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
    }
}