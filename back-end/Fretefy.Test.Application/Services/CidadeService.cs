using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Mappings;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IGeocodingService _geocodingService;

        public CidadeService(ICidadeRepository cidadeRepository, IGeocodingService geocodingService)
        {
            _cidadeRepository = cidadeRepository;
            _geocodingService = geocodingService;
        }

        public async Task<CidadeDto> GetAsync(Guid id)
        {
            var cidade = await _cidadeRepository.GetByIdAsync(id);
            return cidade?.ToDto();
        }

        public async Task<IEnumerable<CidadeDto>> ListAsync()
        {
            var cidades = await _cidadeRepository.ListAsync();
            return cidades.Select(c => c.ToDto());
        }

        public async Task<IEnumerable<CidadeDto>> ListByUfAsync(string uf)
        {
            var cidades = await _cidadeRepository.ListByUfAsync(uf);
            return cidades.Select(c => c.ToDto());
        }

        public async Task<IEnumerable<CidadeDto>> QueryAsync(string terms)
        {
            var cidades = await _cidadeRepository.QueryAsync(terms);
            return cidades.Select(c => c.ToDto());
        }

        public async Task<int> GeocodeAllPendingAsync()
        {
            var cidades = await _cidadeRepository.ListWithoutCoordinatesAsync();
            var count = 0;

            foreach (var cidade in cidades)
            {
                var result = await _geocodingService.GetCoordinatesAsync(cidade.Nome, cidade.UF);
                if (result != null)
                {
                    cidade.AtualizarCoordenadas(result.Latitude, result.Longitude);
                    await _cidadeRepository.UpdateAsync(cidade);
                    count++;
                }
            }

            return count;
        }
    }
}
