using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class ContaConfiguration : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {

            builder.ToTable("Conta", "astl");
            builder.HasKey("ContaID");
            builder.Property(f => f.ContaId).HasColumnName("ContaID");
            builder.Property(f => f.PessoaId).HasColumnName("Password");
            builder.Property(f => f.Usuario).HasColumnName("Usuario");
            builder.Property(f => f.Email).HasColumnName("Email");
            builder.Property(f => f.Password).HasColumnName("PessoaId");
            builder.Property(f => f.DataCriacao).HasColumnName("DataCriacao");
            builder.Property(f => f.DataAtualizacao).HasColumnName("DataAtualizacao");
        }
    }
}
