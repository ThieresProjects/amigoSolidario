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
        public SqlSContext(DbContextOptions<NameOftheDBContextClass> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
