using ASTL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class CampanhaScoreConfiguration : IEntityTypeConfiguration<CampanhaScore>
    {
        public void Configure(EntityTypeBuilder<CampanhaScore> builder) 
        {
            builder.ToTable("CampanhaScore", "astl");
            builder.HasKey(f => f.CampanhaID);
            builder.Property(f => f.ProdutoID).HasColumnName("produtoId");
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.ScoreID).HasColumnName("scoreId");
            builder.Property(f => f.Pontuacao).HasColumnName("Pontuacao");
        }
    }
}
