using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfigurationSchema : IEntityTypeConfiguration<Usuario>
    {      
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
           
            builder.HasKey(p => p.Id);           


            builder.Property(p => p.Nome).IsRequired()
                                             .HasMaxLength(40);                                                                                       
                            

            builder.Property(p => p.SobreNome).IsRequired()
                                             .HasMaxLength(40);

            builder.Property(p => p.Email).IsRequired()
                                            .HasMaxLength(40);

            builder.Property(p => p.UrlFoto).HasMaxLength(40);                                        
            builder.Property(p => p.DataNascimento).IsRequired();
            builder.Property(p => p.Sexo).IsRequired();

            builder.Property(p => p.Senha).IsRequired()
                                           .HasMaxLength(40);
            //relation one to one
            builder.HasOne(o => o.Identificacao)
                           .WithOne(o => o.Usuario)
                           .HasForeignKey<Identificacao>(o => o.UsuarioId);

            //relation one to many
            builder.HasMany(o => o.Postagens).WithOne(o => o.Usuario);
            builder.HasMany(u => u.Comentarios).WithOne(c => c.Usuario);
            builder.HasMany(u => u.Amigos).WithOne(a => a.Usuario);
            builder.HasMany(u => u.Postagens).WithOne(p => p.Usuario);
            builder.HasMany(u => u.UsuarioGrupos).WithOne(p => p.Usuario);
            builder.HasOne(u => u.StatusRelacionamento);
            builder.HasOne(u => u.ProcurandoPor);


        }
    }
}
