using System;
using System.Security.Cryptography;

namespace Fretefy.Test.Domain.Entities
{
    public class RefreshToken : IEntity
    {
        protected RefreshToken() { }

        public Guid Id { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime ExpiraEm { get; set; }
        public DateTime? RevogadoEm { get; set; }

        public bool Expirado => DateTime.UtcNow >= ExpiraEm;
        public bool Revogado => RevogadoEm.HasValue;
        public bool Ativo => !Revogado && !Expirado;

        public static RefreshToken Criar(string username, int diasExpiracao)
        {
            var bytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(bytes);

            return new RefreshToken
            {
                Token = Convert.ToBase64String(bytes),
                Username = username,
                CriadoEm = DateTime.UtcNow,
                ExpiraEm = DateTime.UtcNow.AddDays(diasExpiracao)
            };
        }

        public void Revogar()
        {
            RevogadoEm = DateTime.UtcNow;
        }
    }
}
