using Microsoft.EntityFrameworkCore;
using Timesheets.Model;

namespace Timesheets.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        
        public DbSet<Employee> Employees { get; set; }
    }
    
    

}