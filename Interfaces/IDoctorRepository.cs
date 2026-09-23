using Hospital_Management_System_SQL.Models;
using System.Drawing;


namespace Hospital_Management_System_SQL.Interfaces
{
    public interface IDoctorRepository : IEntityRepository<Doctor>
    {
        byte[] ImageToByteArray(Image imageIn);
    }
}
