using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.DAL.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IList<Employee>> GetAll();
        Task<Employee> GetById(uint id);
        Task<Employee> Add(Employee obj);
        string Authenticate(string login, string password);
    }
}