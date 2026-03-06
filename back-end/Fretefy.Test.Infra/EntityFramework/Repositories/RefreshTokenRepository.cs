using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<RefreshToken> _dbSet;

        public RefreshTokenRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<RefreshToken>();
        }

        public async Task<RefreshToken> GetByTokenAsync(string token)
        {
            return await _dbSet.FirstOrDefaultAsync(r => r.Token == token);
        }

        public async Task CreateAsync(RefreshToken refreshToken)
        {
            await _dbSet.AddAsync(refreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RefreshToken refreshToken)
        {
            _dbSet.Update(refreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task RevokeAllByUsernameAsync(string username)
        {
            var tokens = await _dbSet
                .Where(r => r.Username == username && r.RevogadoEm == null)
                .ToListAsync();

            foreach (var token in tokens)
                token.Revogar();

            await _context.SaveChangesAsync();
        }
    }
}
