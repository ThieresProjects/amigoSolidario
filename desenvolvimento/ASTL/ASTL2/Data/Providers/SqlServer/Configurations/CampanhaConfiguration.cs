using ASTL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Providers.SqlServer.Configurations
{
    public class CampanhaConfiguration : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder) 
        {
            builder.ToTable("Campanha", "astl");
            builder.HasKey(f => f.CampanhaID);
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.CriadoEm).HasColumnName("DataCriacao");
            builder.Property(f => f.AtualizadoEm).HasColumnName("DataAtualizacao");
        }
    }
}
