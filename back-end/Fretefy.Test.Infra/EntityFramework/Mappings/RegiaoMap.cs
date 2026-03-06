using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(1024).IsRequired();

            builder.HasMany(p => p.Cidades)
               .WithMany(p => p.Regioes)
               .UsingEntity(j =>
               {
                   j.ToTable("RegiaoCidade");
                   j.Property("CidadesId").HasColumnName("CidadeId");
                   j.Property("RegioesId").HasColumnName("RegiaoId");
               });
        }
    }
}
