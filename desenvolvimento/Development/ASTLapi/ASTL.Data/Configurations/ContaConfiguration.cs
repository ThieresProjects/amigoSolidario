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
            builder.HasKey(f => f.ContaID);
            builder.Property(f => f.ContaID).HasColumnName("contaId");
            builder.Property(f => f.PessoaID).HasColumnName("pessoaId");
            builder.Property(f => f.Usuario).HasColumnName("Usuario");
            builder.Property(f => f.Email).HasColumnName("Email");
            builder.Property(f => f.Senha).HasColumnName("Senha");
            builder.Property(f => f.CriadoEm).HasColumnName("DataCriacao");
            builder.Property(f => f.AtualizadoEm).HasColumnName("DataAtualizacao");
        }
    }
}
