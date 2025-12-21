using BLL.OmanDigitalShop.Context;
using DAL.OmanDigitalShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.OmanDigitalShop.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            _dbContext.Remove(_dbContext.Set<T>().Find(id)!);
            return _dbContext.SaveChangesAsync();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = _dbContext.Set<T>().AsEnumerable();
            return Task.FromResult(entities);
        }

        public Task<T> GetByIdAsync(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            return Task.FromResult(entity!);
        }

        public Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            return _dbContext.SaveChangesAsync();
        }
    }
}
