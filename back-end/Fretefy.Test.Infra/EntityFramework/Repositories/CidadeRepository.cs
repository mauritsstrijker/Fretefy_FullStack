using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(DbContext context) : base(context) { }

        public async Task<IEnumerable<Cidade>> ListByUfAsync(string uf)
        {
            return await _dbSet.Where(w => EF.Functions.Like(w.UF, $"%{uf}%")).ToListAsync();
        }

        public async Task<IEnumerable<Cidade>> QueryAsync(string terms)
        {
            return await _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.UF, $"%{terms}%")).ToListAsync();
        }

        public async Task<IEnumerable<Cidade>> GetByIdsAsync(IEnumerable<Guid> ids) =>
            await _dbSet.Where(c => ids.Contains(c.Id)).ToListAsync();

        public async Task<IEnumerable<Cidade>> ListWithoutCoordinatesAsync() =>
            await _dbSet.Where(c => c.Latitude == null || c.Longitude == null).ToListAsync();
    }
}
