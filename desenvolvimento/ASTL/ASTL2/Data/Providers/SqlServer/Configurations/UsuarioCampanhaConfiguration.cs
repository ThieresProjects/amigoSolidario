using ASTL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class UsuarioCampanhaConfiguration : IEntityTypeConfiguration<UsuarioCampanha>
    {
        public void Configure(EntityTypeBuilder<UsuarioCampanha> builder) 
        {
            builder.ToTable("UsuarioCampanha", "astl");
            builder.HasKey(f => f.ContaID);
            builder.HasKey(f => f.CampanhaID);
            builder.Property(f => f.ContaID).HasColumnName("contaId");
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.Score).HasColumnName("Pontuacao");
        }
    }
}
