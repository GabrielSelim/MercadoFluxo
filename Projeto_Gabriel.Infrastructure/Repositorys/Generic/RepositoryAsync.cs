using Microsoft.EntityFrameworkCore;
using Projeto_Gabriel.Domain.Entity.Base;
using Projeto_Gabriel.Domain.Generic;
using Projeto_Gabriel.Domain.ServiceInterface;
using Projeto_Gabriel.Infrastructure.Services.Validation;
using Projeto_Gabriel.Model.Context;
using System.Linq.Expressions;

namespace Projeto_Gabriel.Infrastructure.Repositorys.Generic
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : BaseEntity
    {
        protected MySQLContext _context;
        private DbSet<T> dataset;
        private readonly IEntityValidationService<T> _validationService;

        public RepositoryAsync(MySQLContext context)
        {
            _validationService = ValidationServiceFactory.GetValidationService<T>();
            _context = context;
            dataset = _context.Set<T>();
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
