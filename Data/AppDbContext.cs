using Microsoft.EntityFrameworkCore;
using ZCK.OrdensProducao.Api.Models;

namespace ZCK.OrdensProducao.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<OrdemProducao> Ordens { get; set; }
        public DbSet<ItemReceita> ItensReceita { get; set; }
        public DbSet<Insumo> Insumos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Insumo>()
                .Property(i => i.Custo)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ItemReceita>()
                .Property(i => i.Quantidade)
                .HasPrecision(18, 4);
        }
    }
}