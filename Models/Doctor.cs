using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Models
{
    [Serializable]
    public class Doctor
    {
        public string DoctorID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Speciality { get; set; }
        public string RoomNumber { get; set; }
        public decimal ConsultationFee { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Shift { get; set; }
        public byte[] DoctorImage { get; set; }

        //to display name in combo boxes
        public override string ToString()
        {
            return FullName;
        }
    }
}
