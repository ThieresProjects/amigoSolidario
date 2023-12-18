using ASTL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class CampanhaPremioConfiguration : IEntityTypeConfiguration<CampanhaPremio>
    {
        public void Configure(EntityTypeBuilder<CampanhaPremio> builder)
        {
            builder.ToTable("CampanhaPremio", "astl");
            builder.HasKey(f => f.PremioID);
            builder.Property(f => f.PremioID).HasColumnName("premioId");
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Ordem).HasColumnName("Ordem");
        }
    }
}
