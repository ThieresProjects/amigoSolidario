using ASTL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto", "astl");
            builder.HasKey(f => f.ProdutoID);
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.ProdutoID).HasColumnName("ProdutoId");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Validade).HasColumnName("Validade");
            builder.Property(f => f.Perecivel).HasColumnName("Perecivel");
        }
    }
}
