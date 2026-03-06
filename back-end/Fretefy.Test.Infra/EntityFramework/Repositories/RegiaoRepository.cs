using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : Repository<Regiao>, IRegiaoRepository
    {
        public RegiaoRepository(DbContext context) : base(context) { }

        protected override IQueryable<Regiao> Query() =>
            _dbSet.Include(r => r.Cidades);

        public async Task<bool> ExistsByNameAsync(string name) =>
            _dbSet.Any(r => r.Nome.ToLower().Trim() == name.ToLower().Trim());
    }
}