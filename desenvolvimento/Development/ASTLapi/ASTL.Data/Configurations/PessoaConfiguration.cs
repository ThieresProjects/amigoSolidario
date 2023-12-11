using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {

            builder.ToTable("Pessoa", "astl");
            builder.HasKey(f => f.PessoaId);
            builder.Property(f => f.PessoaId).HasColumnName("pessoaId");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.CPF).HasColumnName("CPF");
            builder.Property(f => f.Idade).HasColumnName("Idade");
        }
    }
}
