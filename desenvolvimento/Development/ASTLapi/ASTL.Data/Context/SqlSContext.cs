using ASTL.Data.Configurations;
using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTL.Data.Context
{
    public class SqlSContext : DbContext
    {
        public SqlSContext(DbContextOptions<SqlSContext> options) : base(options)
        {

        }

        public DbSet<Conta> Conta { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<UserContext> UserContext { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Objeto> Objeto { get; set; }
        public DbSet<TipoObjeto> TipoObjeto { get; set; }
        public DbSet<LogDoacao> LogDoacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.107.176.41, 1434;database=RA044444;user id=RA044444;password=044444;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new UserContextConfiguration());
            modelBuilder.ApplyConfiguration(new ObjetoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoObjetoConfiguration());
            modelBuilder.ApplyConfiguration(new LogDoacaoConfiguration());
        }
    }
}
