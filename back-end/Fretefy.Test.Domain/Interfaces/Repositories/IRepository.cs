using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
    }
}