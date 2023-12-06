using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class TipoObjetoConfiguration : IEntityTypeConfiguration<TipoObjeto>
    {
        public void Configure(EntityTypeBuilder<TipoObjeto> builder)
        {
            builder.ToTable("TipoObjeto", "astl");
            builder.HasKey("TipoObjetoId");
            builder.Property(f => f.TipoObjetoId).HasColumnName("TipoObjetoId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
        }
    }
}
