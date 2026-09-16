using Hospital_Management_System_SQL.Models;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Interfaces
{
    public interface IDoctorRepository : IEntityRepository<Doctor>
    {
        byte[] ImageToByteArray(Image imageIn);
    }
}
