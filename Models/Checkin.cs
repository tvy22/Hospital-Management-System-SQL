using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Models
{
    [Serializable]
    public class Checkin
    {
        public string AppID { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string DocName { get; set; }
        public string DocSpeciality { get; set; }
        public DateTime Date { get; set; }
        public string RoomNumber { get; set; }
        public string Reason { get; set; }
    }
}
