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
        List<Checkin> GetActiveVisits();
        List<Checkin> GetCompletedVisits();
        void CompleteCheckOut(string appId, decimal finalCost);
    }
}
