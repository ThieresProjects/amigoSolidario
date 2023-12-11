using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class CampanhaGrupoConfiguration : IEntityTypeConfiguration<CampanhaGrupo>
    {
        public void Configure(EntityTypeBuilder<CampanhaGrupo> builder) 
        {
            builder.ToTable("CampanhaGrupo", "astl");
            builder.HasKey(f => f.CampanhaID);
            builder.Property(f => f.CampanhaID).HasColumnName("campanhaId");
            builder.Property(f => f.GrupoID).HasColumnName("grupoId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.ScoreGroup).HasColumnName("ScoreGroup");
        }
    }
}
