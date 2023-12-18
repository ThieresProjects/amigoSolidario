using ASTL.Data.Providers.SqlServer.Configurations;
using ASTL.Models;
using Microsoft.EntityFrameworkCore;

namespace ASTL.Data.Providers.SqlServer
{
    public class Context : DbContext
    {
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<CampanhaGrupo> CampanhaGrupo { get; set; }
        public DbSet<CampanhaScore> CampanhaScore { get; set; }
        public DbSet<UsuarioCampanha> UsuarioCampanha { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data source = 201.62.57.93, 1434; 
                Database = BD044444; 
                User ID = RA044444; 
                Password = 044444; 
                TrustServerCertificate = True");

            //optionsBuilder.UseSqlServer(@"
            //    Data source = 10.107.176.41, 1434; 
            //    Database = BD044444; 
            //    User ID = RA044444; 
            //    Password = 044444; 
            //    TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaScoreConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioCampanhaConfiguration());
        }
    }
}
