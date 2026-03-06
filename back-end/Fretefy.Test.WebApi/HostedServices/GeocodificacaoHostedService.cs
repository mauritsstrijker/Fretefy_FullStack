using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.HostedServices
{
    public class GeocodificacaoHostedService : IHostedService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<GeocodificacaoHostedService> _logger;
        private readonly bool _habilitado;

        public GeocodificacaoHostedService(
            IServiceScopeFactory scopeFactory,
            ILogger<GeocodificacaoHostedService> logger,
            IOptions<GoogleSettings> googleSettings)
        {
            _scopeFactory = scopeFactory;
            _logger = logger;
            _habilitado = googleSettings.Value.Enabled;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (!_habilitado)
            {
                _logger.LogWarning("Google:GeocodingApiKey não configurada. Sincronização de coordenadas ignorada.");
                return;
            }

            try
            {
                using var scope = _scopeFactory.CreateScope();
                var cidadeService = scope.ServiceProvider.GetRequiredService<ICidadeService>();
                var total = await cidadeService.GeocodeAllPendingAsync();

                if (total > 0)
                    _logger.LogInformation("Geocodificação concluída: {Total} cidade(s) atualizada(s).", total);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Falha ao sincronizar coordenadas.");
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
