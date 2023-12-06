using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class ObjetoConfiguration : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.ToTable("Objeto", "astl");
            builder.HasKey("ObjetoId");
            builder.Property(f => f.ObjetoId).HasColumnName("ContaId");
            builder.Property(f => f.TipoObjetoId).HasColumnName("TipoObjetoId");
            builder.Property(f => f.EnderecoId).HasColumnName("EnderecoId");
            builder.Property(f => f.Quantidade).HasColumnName("Quantidade");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Ativo).HasColumnName("Ativo");
            builder.Property(f => f.Imagem).HasColumnName("Imagen");
        }
    }
}
