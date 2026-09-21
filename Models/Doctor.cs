using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Models
{
    [Serializable]
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
    }
}
