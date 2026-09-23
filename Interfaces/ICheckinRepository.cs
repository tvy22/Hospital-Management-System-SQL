using Hospital_Management_System_SQL.Models;
using System.Collections.Generic;

namespace Hospital_Management_System_SQL.Interfaces
{
    public interface ICheckinRepository : IEntityRepository<Checkin>
    {
        List<Checkin> GetActiveVisits();
        List<Checkin> GetCompletedVisits();
        void CompleteCheckOut(string appId, decimal finalCost);
    }
}
