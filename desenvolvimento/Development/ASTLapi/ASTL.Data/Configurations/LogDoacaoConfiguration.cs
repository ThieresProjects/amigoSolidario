using ASTL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASTL.Data.Configurations
{
    public class LogDoacaoConfiguration : IEntityTypeConfiguration<LogDoacao>
    {
        public void Configure(EntityTypeBuilder<LogDoacao> builder)
        {

            builder.ToTable("Log_Doacao", "astl");
            builder.HasKey("DoacaoId");
            builder.Property(f => f.DoacaoId).HasColumnName("DoacaoId");
            builder.Property(f => f.TipoDoacao).HasColumnName("TipoDaocao");
            builder.Property(f => f.RemetenteId).HasColumnName("Remetente");
            builder.Property(f => f.DestinatarioId).HasColumnName("Destinatario");
            builder.Property(f => f.ObjetoId).HasColumnName("ObjetoId");
            builder.Property(f => f.Enviado).HasColumnName("Enviado");
            builder.Property(f => f.Data).HasColumnName("DataHora");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
        }
    }
}
