using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Models
{
    public abstract class Person
    {
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return FullName ?? string.Empty;
        }
    }
}
