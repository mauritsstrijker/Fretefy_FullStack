using Fretefy.Test.Application.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Services
{
    public class RegiaoExportService : IRegiaoExportService
    {
        private readonly IRegiaoService _regiaoService;
        private readonly IExportService _exportService;

        public RegiaoExportService(IRegiaoService regiaoService, IExportService exportService)
        {
            _regiaoService = regiaoService;
            _exportService = exportService;
        }

        public async Task<byte[]> ExportAsync()
        {
            var regioes = await _regiaoService.ListAsync();

            var headers = new[] { "Nome", "Status", "Cidades" };
            var rows = regioes.Select(r => new[]
            {
                r.Nome,
                r.Status,
                string.Join(", ", r.Cidades.Select(c => $"{c.Nome}/{c.UF}"))
            });

            return _exportService.Export("Regiões", headers, rows);
        }
    }
}
