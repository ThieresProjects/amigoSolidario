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
        //public SqlSContext(DbContextOptions<SqlSContext> options) : base(options)
        //{

        //}

        public DbSet<Conta> Conta { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93, 1434; Database = BD044444; User ID = RA044444; Password = 044444; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
        }
    }
}
