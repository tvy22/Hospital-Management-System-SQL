using System;

namespace Hospital_Management_System_SQL.Models
{
    [Serializable]
    public class Patient
    {
        public string PatientID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string MedicalHistory { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        // Useful for linking patients to appointments
        public override string ToString()
        {
            return FullName;
        }
    }
}