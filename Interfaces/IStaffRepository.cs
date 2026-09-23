using Hospital_Management_System_SQL.Models;


namespace Hospital_Management_System_SQL.Interfaces
{
    public interface IStaffRepository
    {
        Staff Login(string username, string password);
    }
}
