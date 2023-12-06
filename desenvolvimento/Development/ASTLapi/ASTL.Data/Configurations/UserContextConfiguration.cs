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
            builder.HasKey("PessoaID");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            //builder.Property(f => f.idGrupo).HasColumnName("idGrupo");
            //builder.Property(f => f.idMarca).HasColumnName("idMarca");
            builder.Property(f => f.CPF).HasColumnName("CPF");
            builder.Property(f => f.Endereco).HasColumnName("Endereco");
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
            //builder.Property(f => f.DataCadastro).HasColumnName("DataCadastro");

            //builder.Property(f => f.Descricao).HasColumnName("Descricao")
            //    .IsRequired()
            //    .HasMaxLength(200);

            //builder
            //    .HasOne(d => d.Marca)
            //    .WithMany()
            //    .HasForeignKey(f => f.idMarca);

            //builder
            //   .HasOne(d => d.Grupo)
            //   .WithMany()
            //   .HasForeignKey(f => f.idGrupo);

        }
    }
}
