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
        void SaveAllToFile();
        void LoadData();

        // Shared UI & Helper methods
        void ClearForm();
        void ShowData();
        void FormatGrid();
        string GenerateNextID();
        bool IsValid();
    }
}
