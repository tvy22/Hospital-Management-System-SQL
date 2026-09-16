using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Models;

namespace Hospital_Management_System_SQL.Logic
{
    public class PatientRepository : IPatientRepository
    {
        public List<Patient> GetAll()
        {
            List<Patient> list = new List<Patient>();
            string query = "SELECT PatientID, FullName, Phone, DateOfBirth, Gender, MedicalHistory FROM Patients";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Patient
                        {
                            PatientID = reader["PatientID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),
                            MedicalHistory = reader["MedicalHistory"] != DBNull.Value ? reader["MedicalHistory"].ToString() : ""
                        });
                    }
                }
            }
            return list;
        }

        public Patient GetById(string id)
        {
            string query = "SELECT * FROM Patients WHERE PatientID = @PatientID";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient
                        {
                            PatientID = reader["PatientID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),
                            MedicalHistory = reader["MedicalHistory"] != DBNull.Value ? reader["MedicalHistory"].ToString() : ""
                        };
                    }
                }
            }
            return null;
        }

        public void Save(Patient entity)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM Patients WHERE PatientID = @PatientID)
                BEGIN
                    UPDATE Patients SET 
                        FullName = @FullName, Phone = @Phone, DateOfBirth = @DateOfBirth, 
                        Gender = @Gender, MedicalHistory = @MedicalHistory
                    WHERE PatientID = @PatientID
                END
                ELSE
                BEGIN
                    INSERT INTO Patients (PatientID, FullName, Phone, DateOfBirth, Gender, MedicalHistory)
                    VALUES (@PatientID, @FullName, @Phone, @DateOfBirth, @Gender, @MedicalHistory)
                END";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", entity.PatientID);
                cmd.Parameters.AddWithValue("@FullName", entity.FullName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", entity.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfBirth", entity.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", entity.Gender ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MedicalHistory", entity.MedicalHistory ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GenerateNextID()
        {
            int maxId = 0;
            string query = "SELECT PatientID FROM Patients WHERE PatientID LIKE 'PAT-%'";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string patId = reader["PatientID"].ToString();
                        if (patId.Length > 4 && int.TryParse(patId.Substring(4), out int idVal))
                        {
                            if (idVal > maxId) maxId = idVal;
                        }
                    }
                }
            }

            return "PAT-" + (maxId + 1).ToString("000");
        }
    }
}