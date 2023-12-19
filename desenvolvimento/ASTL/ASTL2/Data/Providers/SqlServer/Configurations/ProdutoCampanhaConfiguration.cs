using ASTL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class ProdutoCampanhaConfiguration : IEntityTypeConfiguration<ProdutoCampanha>
    {
        public void Configure(EntityTypeBuilder<ProdutoCampanha> builder)
        {
            builder.ToTable("ProdutoCampanha", "astl");
            builder.HasKey(f => f.ProdutoID);
            builder.Property(f => f.ProdutoID).HasColumnName("ProdutoID");
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Perecivel).HasColumnName("Perecivel");
            builder.Property(f => f.Validade).HasColumnName("Validade");
            builder.Property(f => f.Pontuacao).HasColumnName("Pontuacao");
        }
    }
}
