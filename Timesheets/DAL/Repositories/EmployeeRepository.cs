using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Model;

namespace Timesheets.DAL.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Employee> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Add(Employee item)
        {
            throw new System.NotImplementedException();
        }
    }
}