using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.OmanDigitalShop.Interfaces
{
    public interface IGenericRepository<T>
    {

        Task<IEnumerable<T>> GetAllAsync(); // Returns a list of all entities
        Task<T> GetByIdAsync(int id); // Returns an entity by its ID
        Task AddAsync(T entity);  // Adds a new entity
        Task UpdateAsync(T entity); // Updates an existing entity
        Task DeleteAsync(int id); // Deletes an entity by its ID
    }
}
