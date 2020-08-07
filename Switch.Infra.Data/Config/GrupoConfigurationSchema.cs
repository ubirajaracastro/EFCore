using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfigurationSchema : IEntityTypeConfiguration<Grupo>
    {    

        public void Configure(EntityTypeBuilder<Grupo> builder)

        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired()
                                         .HasMaxLength(100);

            builder.Property(p => p.Descricao).IsRequired()
                                        .HasMaxLength(100);

            builder.Property(p => p.UrlFoto).IsRequired()
                                        .HasMaxLength(200);

            builder.HasMany(o => o.Postagens).WithOne(o => o.Grupo);

        }

    }
        

}
