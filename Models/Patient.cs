using System;

namespace Hospital_Management_System_SQL.Models
{
    public class Patient : Person
    {
        public string PatientID { get; set; }
        public string MedicalHistory { get; set; }

        public Patient() : base() { }

        public Patient(string patientID, string fullName, string phone, string gender, DateTime dateOfBirth, string medicalHistory)
            : base(fullName, phone, gender, dateOfBirth)
        {
            PatientID = patientID;
            MedicalHistory = medicalHistory;
        }
    }
}