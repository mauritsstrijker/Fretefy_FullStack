using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RefreshTokenMap : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Token).HasMaxLength(256).IsRequired();
            builder.Property(p => p.Username).HasMaxLength(256).IsRequired();
            builder.Property(p => p.CriadoEm).IsRequired();
            builder.Property(p => p.ExpiraEm).IsRequired();
            builder.Property(p => p.RevogadoEm);

            builder.HasIndex(p => p.Token).IsUnique();
            builder.HasIndex(p => p.Username);

            builder.Ignore(p => p.Expirado);
            builder.Ignore(p => p.Revogado);
            builder.Ignore(p => p.Ativo);
        }
    }
}
