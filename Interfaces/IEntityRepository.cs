using System;
using System.Collections.Generic;

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
