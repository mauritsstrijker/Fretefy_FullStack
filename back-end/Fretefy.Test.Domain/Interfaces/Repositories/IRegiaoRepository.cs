using Fretefy.Test.Domain.Entities;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IRepository<Regiao>
    {
        Task<bool> ExistsByNameAsync(string nome);
    }
}