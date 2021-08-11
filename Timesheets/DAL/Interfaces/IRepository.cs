using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timesheets.DAL.Interfaces
{
    public interface IRepository <T> where T:class
    {
        Task<IEnumerable<T>> GetAll(); // получение всех объектов
        Task<T> GetById(int id); // получение одного объекта по id
        Task Add(T item); // создание объекта
       


    }
}
