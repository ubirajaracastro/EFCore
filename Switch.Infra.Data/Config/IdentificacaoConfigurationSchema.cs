using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class IdentificacaoConfigurationSchema : IEntityTypeConfiguration<Identificacao>
    {
        public void Configure(EntityTypeBuilder<Identificacao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NumeroDocumento).IsRequired().HasMaxLength(18);
            builder.Property(p => p.TipoDocumento).IsRequired();
            builder.Property(p => p.UsuarioId).IsRequired();            
        }
    }
}
