using Projeto_Gabriel.Domain.Entity.Base;
using System.Linq.Expressions;

namespace Projeto_Gabriel.Domain.Generic
{
    public interface IRepositoryAsync<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<int> SaveChangesAsync();
    }
}