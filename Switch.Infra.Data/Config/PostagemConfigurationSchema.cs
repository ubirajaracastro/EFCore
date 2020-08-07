using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfigurationSchema : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(prop => prop.Texto).IsRequired().HasMaxLength(400);

            //relacionamento um para muito invertido. Mas ja foi definido no um para muitos no lado usuario - usuario/postagem na 
            //classe de config UsuarioCOnfigEsquema

           // builder.HasOne(o => o.Usuario).WithMany(o => o.Postagens);
        }
    }
}
