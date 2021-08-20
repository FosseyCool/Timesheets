using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timesheets.DAL.Repositories.Interfaces
{
    public interface IRepository <T> where T:class
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(uint id);
        Task<T> Add(T obj);
       


    }
}
