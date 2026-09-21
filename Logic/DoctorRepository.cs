using Hospital_Management_System_SQL.Interfaces;
using Hospital_Management_System_SQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Hospital_Management_System_SQL.Logic
{
    public class DoctorRepository : IDoctorRepository
    {
        public List<Doctor> GetAll()
        {
            List<Doctor> list = new List<Doctor>();
            string query = "SELECT DoctorID, FullName, Email, Phone, Speciality, RoomNumber, " +
                           "ConsultationFee, DateOfBirth, Gender, Status, Shift, DoctorImage FROM Doctors";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Doctor
                        {
                            DoctorID = reader["DoctorID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Speciality = reader["Speciality"].ToString(),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            ConsultationFee = Convert.ToDecimal(reader["ConsultationFee"]),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),
                            Status = reader["Status"].ToString(),
                            Shift = reader["Shift"].ToString(),
                            DoctorImage = reader["DoctorImage"] != DBNull.Value ? (byte[])reader["DoctorImage"] : null
                        });
                    }
                }
            }
            return list;
        }

        public Doctor GetById(string id)
        {
            string query = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor
                        {
                            DoctorID = reader["DoctorID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Speciality = reader["Speciality"].ToString(),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            ConsultationFee = Convert.ToDecimal(reader["ConsultationFee"]),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Gender = reader["Gender"].ToString(),
                            Status = reader["Status"].ToString(),
                            Shift = reader["Shift"].ToString(),
                            DoctorImage = reader["DoctorImage"] != DBNull.Value ? (byte[])reader["DoctorImage"] : null
                        };
                    }
                }
            }
            return null;
        }

        public void Save(Doctor entity)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM Doctors WHERE DoctorID = @DoctorID)
                BEGIN
                    UPDATE Doctors SET 
                        FullName = @FullName, Email = @Email, Phone = @Phone, Speciality = @Speciality, 
                        RoomNumber = @RoomNumber, ConsultationFee = @ConsultationFee, DateOfBirth = @DateOfBirth, 
                        Gender = @Gender, Status = @Status, Shift = @Shift, DoctorImage = @DoctorImage
                    WHERE DoctorID = @DoctorID
                END
                ELSE
                BEGIN
                    INSERT INTO Doctors (DoctorID, FullName, Email, Phone, Speciality, RoomNumber, ConsultationFee, DateOfBirth, Gender, Status, Shift, DoctorImage)
                    VALUES (@DoctorID, @FullName, @Email, @Phone, @Speciality, @RoomNumber, @ConsultationFee, @DateOfBirth, @Gender, @Status, @Shift, @DoctorImage)
                END";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", entity.DoctorID);
                cmd.Parameters.AddWithValue("@FullName", entity.FullName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", entity.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", entity.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Speciality", entity.Speciality ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@RoomNumber", entity.RoomNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ConsultationFee", entity.ConsultationFee);
                cmd.Parameters.AddWithValue("@DateOfBirth", entity.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", entity.Gender ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", entity.Status ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Shift", entity.Shift ?? (object)DBNull.Value);
                
                if (entity.DoctorImage != null)
                {
                    cmd.Parameters.Add("@DoctorImage", SqlDbType.VarBinary, -1).Value = entity.DoctorImage;
                }
                else
                {
                    cmd.Parameters.Add("@DoctorImage", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GenerateNextID()
        {
            int maxId = 0;
            string query = "SELECT DoctorID FROM Doctors WHERE DoctorID LIKE 'DOC-%'";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string docId = reader["DoctorID"].ToString();
                        if (docId.Length > 4 && int.TryParse(docId.Substring(4), out int idVal))
                        {
                            if (idVal > maxId) maxId = idVal;
                        }
                    }
                }
            }

            return "DOC-" + (maxId + 1).ToString("000");
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;

            using (Bitmap tempBitmap = new Bitmap(imageIn))
            using (MemoryStream ms = new MemoryStream())
            {
                tempBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}