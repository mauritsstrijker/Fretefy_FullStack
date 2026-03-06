using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        Task<IEnumerable<Cidade>> ListByUfAsync(string uf);
        Task<IEnumerable<Cidade>> QueryAsync(string terms);
        Task<IEnumerable<Cidade>> GetByIdsAsync(IEnumerable<Guid> ids);
        Task<IEnumerable<Cidade>> ListWithoutCoordinatesAsync();
    }
}
