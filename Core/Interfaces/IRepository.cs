using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity,new()
    {
        Task<int> Add (TEntity item);
        Task<int> Delete(TEntity itemId);
        Task<int> Update(TEntity item);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        Task<ICollection<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression = null);
    }
}
