using Hospital_Management_System_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Interfaces
{
    public interface ICheckinRepository : IEntityRepository<Checkin>
    {
        void LoadCheckins();
        void ClearFields();
    }
}
