using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework
{
    public class TestDbContext : DbContext
    {
        public TestDbContext()
        {

        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RefreshTokenMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new RegiaoMap());
        }
    }
}
