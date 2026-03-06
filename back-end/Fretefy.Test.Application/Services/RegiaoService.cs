using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Mappings;
using Fretefy.Test.Domain.Constants;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Exceptions;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public RegiaoService(
            IRegiaoRepository regionRepository,
            ICidadeRepository cidadeRepository)
        {
            _regiaoRepository = regionRepository;
            _cidadeRepository = cidadeRepository;
        }

        public async Task<IEnumerable<RegiaoDto>> ListAsync() =>
            (await _regiaoRepository.ListAsync()).Select(r => r.ToDto());

        public async Task<RegiaoDto?> GetByIdAsync(Guid id)
        {
            var region = await _regiaoRepository.GetByIdAsync(id);
            return region?.ToDto();
        }

        public async Task<RegiaoDto> CreateAsync(string name, IEnumerable<Guid> cityIds)
        {
            if (await _regiaoRepository.ExistsByNameAsync(name))
                throw new DomainException(DomainMessages.Regiao.NameAlreadyExists);

            var cities = await GetCitiesAsync(cityIds);

            var region = Regiao.Criar(name, cities);

            var created = await _regiaoRepository.CreateAsync(region);
            return created.ToDto();
        }

        public async Task UpdateAsync(Guid id, string name, IEnumerable<Guid> cityIds)
        {
            var region = await _regiaoRepository.GetByIdAsync(id);

            if (region == null)
                throw new DomainException(DomainMessages.Geral.NotFound);

            if (await _regiaoRepository.ExistsByNameAsync(name) &&
                region.Nome != name)
                throw new DomainException(DomainMessages.Regiao.NameAlreadyExists);

            var cities = await GetCitiesAsync(cityIds);

            region.Atualizar(name, cities);

            await _regiaoRepository.UpdateAsync(region);
        }

        public async Task ActivateAsync(Guid id)
        {
            var region = await _regiaoRepository.GetByIdAsync(id);

            if (region == null)
                throw new DomainException(DomainMessages.Geral.NotFound);

            region.Ativar();

            await _regiaoRepository.UpdateAsync(region);
        }

        public async Task DeactivateAsync(Guid id)
        {
            var region = await _regiaoRepository.GetByIdAsync(id);

            if (region == null)
                throw new DomainException(DomainMessages.Geral.NotFound);

            region.Desativar();

            await _regiaoRepository.UpdateAsync(region);
        }

        public async Task<bool> ExistsByNameAsync(string name) => await _regiaoRepository.ExistsByNameAsync(name);

        private async Task<IEnumerable<Cidade>> GetCitiesAsync(IEnumerable<Guid> cityIds)
        {
            var cities = (await _cidadeRepository.GetByIdsAsync(cityIds)).ToList();

            if (!cities.Any())
                throw new DomainException(
                    DomainMessages.Regiao.MustContainAtLeastOneCity);

            return cities;
        }
    }
}
