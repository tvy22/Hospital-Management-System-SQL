using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Models
{
    public class Doctor : Person
    {
        public string DoctorID { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }
        public string RoomNumber { get; set; }
        public decimal ConsultationFee { get; set; }
        public string Status { get; set; }
        public string Shift { get; set; }
        public byte[] DoctorImage { get; set; }

        public Doctor() { }

        public Doctor(string doctorID, string fullName, string phone, string gender, DateTime dateOfBirth, string email, string speciality, string roomNumber, decimal fee, string status, string shift, byte[] doctorImage)
            : base(fullName, phone, gender, dateOfBirth)
        {
            DoctorID = doctorID;
            Email = email;
            Speciality = speciality;
            RoomNumber = roomNumber;
            ConsultationFee = fee;
            Status = status;
            Shift = shift;
            DoctorImage = doctorImage;
        }
    }
}
