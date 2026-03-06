using Fretefy.Test.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IRegiaoService
    {
        Task<RegiaoDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<RegiaoDto>> ListAsync();
        Task<RegiaoDto> CreateAsync(string name, IEnumerable<Guid> cityIds);
        Task UpdateAsync(Guid id, string name, IEnumerable<Guid> cityIds);
        Task ActivateAsync(Guid id);
        Task DeactivateAsync(Guid id);
        Task<bool> ExistsByNameAsync(string name);
    }
}
