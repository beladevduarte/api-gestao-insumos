using Microsoft.EntityFrameworkCore;
using ZCK.OrdensProducao.Api.Models;

namespace ZCK.OrdensProducao.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<OrdemProducao> Ordens { get; set; }
        public DbSet<ItemReceita> ItensReceita { get; set; }
    }
}