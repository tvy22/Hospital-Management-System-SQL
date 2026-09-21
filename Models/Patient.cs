using System;

namespace Hospital_Management_System_SQL.Models
{
    [Serializable]
    public class Patient : Person
    {
        public string PatientID { get; set; }
        public string MedicalHistory { get; set; }
    }
}