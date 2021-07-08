using Core.Interfaces;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly AppDbContext _context = null;
        private readonly DbSet<TEntity> _entities = null;
        public RepositoryBase(AppDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<int> Add(TEntity item)
        {
            await _entities.AddAsync(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(TEntity item)
        {
            _entities.Update(item);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(TEntity item)
        {
            _entities.Remove(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<ICollection<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression == null)
            {
                return await _entities.ToListAsync();
            }

            return await _entities.Where(expression).ToListAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return await _entities.FirstOrDefaultAsync(expression);
        }

    }
}
