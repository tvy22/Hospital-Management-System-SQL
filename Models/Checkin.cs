using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Models
{
    public class Checkin
    {
        public string AppID { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string DoctorID { get; set; }
        public string DocName { get; set; }
        public string DocSpeciality { get; set; }
        public DateTime Date { get; set; }
        public string RoomNumber { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public decimal Fee { get; set; }

        public Checkin() { }

        public Checkin(string appId, string patientId, string patientName, string doctorId, string docName,
                       string docSpeciality, DateTime date, string roomNumber,
                       string reason, string status, decimal fee, DateTime? checkoutDate = null)
        {
            AppID = appId;
            PatientID = patientId;
            PatientName = patientName;
            DoctorID = doctorId;
            DocName = docName;
            DocSpeciality = docSpeciality;
            Date = date;
            RoomNumber = roomNumber;
            Reason = reason;
            Status = status;
            Fee = fee;
            CheckoutDate = checkoutDate;
        }
    }
}
 