using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfigurationSchema : IEntityTypeConfiguration<UsuarioGrupo>
    {    

        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)

        {
            builder.HasKey(o => new { o.UsuarioId, o.GrupoId });
            
            builder.Property(o => o.DataCriacao).IsRequired();
            builder.Property(o => o.Admin);



        }

    }
        

}
