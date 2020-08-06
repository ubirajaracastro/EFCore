using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext:DbContext
    {
        public SwitchContext(DbContextOptions options):base(options)
        {
            
        }

        #region DBSets
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Postagem>Postagens { get; set; }
        DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Usuario>(entity =>
            {              
                modelBuilder.ApplyConfiguration(new UsuarioConfigurationSchema());
                modelBuilder.ApplyConfiguration(new IdentificacaoConfigurationSchema());
                modelBuilder.ApplyConfiguration(new PostagemConfigurationSchema());                
            });
                       

            base.OnModelCreating(modelBuilder); 
        }


    }
}
