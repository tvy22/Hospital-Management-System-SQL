using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_SQL.Interfaces
{
    public interface IEntityRepository<T>
    {
        // Shared File I/O
        void Save(T entity);
        void Delete(string id);
        List<T> GetAll();
        T GetById(string id);
        string GenerateNextID();
    }
}
