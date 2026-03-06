using Fretefy.Test.Domain.Entities;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetByTokenAsync(string token);
        Task CreateAsync(RefreshToken refreshToken);
        Task UpdateAsync(RefreshToken refreshToken);
        Task RevokeAllByUsernameAsync(string username);
    }
}
