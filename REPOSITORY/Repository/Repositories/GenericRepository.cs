using Microsoft.EntityFrameworkCore;
using REPOSITORY.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.Repository.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _entities;
        public GenericRepository(DataContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task Create(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            var result = _entities.Where(expression);

            if (result == null)
            {
                throw new ArgumentNullException("Not Found!");
            }

            return await Task.FromResult(result.ToList());
        }

        public async Task<T?> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
