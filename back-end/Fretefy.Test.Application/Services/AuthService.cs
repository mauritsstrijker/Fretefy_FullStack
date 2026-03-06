using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Settings;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly AuthSettings _authSettings;

        public AuthService(IRefreshTokenRepository refreshTokenRepository, IOptions<AuthSettings> authSettings)
        {
            _refreshTokenRepository = refreshTokenRepository;
            _authSettings = authSettings.Value;
        }

        public async Task<AuthResult> LoginAsync(string username, string password)
        {
            if (username != _authSettings.Username || password != _authSettings.Password)
                return AuthResult.Fail("Usuário ou senha inválidos.");

            var refreshToken = RefreshToken.Criar(username, _authSettings.RefreshTokenDays);
            await _refreshTokenRepository.CreateAsync(refreshToken);

            return AuthResult.Ok(username, refreshToken.Token);
        }

        public async Task<AuthResult> RefreshAsync(string refreshTokenValue)
        {
            if (string.IsNullOrEmpty(refreshTokenValue))
                return AuthResult.Fail("Refresh token não informado.");

            var storedToken = await _refreshTokenRepository.GetByTokenAsync(refreshTokenValue);

            if (storedToken == null || !storedToken.Ativo)
                return AuthResult.Fail("Refresh token inválido ou expirado.");

            storedToken.Revogar();
            await _refreshTokenRepository.UpdateAsync(storedToken);

            var newRefreshToken = RefreshToken.Criar(storedToken.Username, _authSettings.RefreshTokenDays);
            await _refreshTokenRepository.CreateAsync(newRefreshToken);

            return AuthResult.Ok(storedToken.Username, newRefreshToken.Token);
        }

        public async Task RevokeAsync(string refreshTokenValue)
        {
            if (string.IsNullOrEmpty(refreshTokenValue))
                return;

            var storedToken = await _refreshTokenRepository.GetByTokenAsync(refreshTokenValue);
            if (storedToken != null && storedToken.Ativo)
            {
                storedToken.Revogar();
                await _refreshTokenRepository.UpdateAsync(storedToken);
            }
        }

        public async Task RevokeAllAsync(string username)
        {
            await _refreshTokenRepository.RevokeAllByUsernameAsync(username);
        }
    }
}
