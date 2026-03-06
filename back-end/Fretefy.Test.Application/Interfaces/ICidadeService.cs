using Fretefy.Test.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface ICidadeService
    {
        Task<CidadeDto> GetAsync(Guid id);
        Task<IEnumerable<CidadeDto>> ListAsync();
        Task<IEnumerable<CidadeDto>> ListByUfAsync(string uf);
        Task<IEnumerable<CidadeDto>> QueryAsync(string terms);
        Task<int> GeocodeAllPendingAsync();
    }
}
