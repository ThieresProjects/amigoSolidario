using ASTL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class UsuarioScoreConfiguration : IEntityTypeConfiguration<UsuarioScore>
    {
        public void Configure(EntityTypeBuilder<UsuarioScore> builder) 
        {
            builder.ToTable("UsuarioScore", "astl");
            builder.HasKey(f => f.CampanhaID);
            builder.Property(f => f.ScoreID).HasColumnName("scoreId");
            builder.Property(f => f.ProdutoID).HasColumnName("produtoId");
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.ContaID).HasColumnName("contaId");
        }
    }
}
