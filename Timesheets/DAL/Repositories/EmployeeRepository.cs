using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheets.Model;

namespace Timesheets.DAL.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await _db.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(uint id)
        {
            return await _db.Employees.FindAsync(id);
        }

        public async Task<Employee> Add(Employee obj)
        {
            if (obj == null) return null;
            
            _db.Employees.Add(obj);
            await _db.SaveChangesAsync();
            return obj;

        }
    }
}