using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco", "astl");
            builder.HasKey("EnderecoID");
            builder.Property(f => f.CEP).HasColumnName("CEP");
            builder.Property(f => f.Pais).HasColumnName("Pais");
            builder.Property(f => f.Numero).HasColumnName("Numero");
            builder.Property(f => f.Estado).HasColumnName("Estado");
            builder.Property(f => f.Cidade).HasColumnName("Cidade");
            builder.Property(f => f.Complemento).HasColumnName("Complemento");
        }
    }
}
