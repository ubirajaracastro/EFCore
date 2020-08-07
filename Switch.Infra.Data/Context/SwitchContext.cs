using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext:DbContext
    {
        #region Construtor
        public SwitchContext(DbContextOptions options):base(options)
        {
            
        }
        #endregion

        #region DBSets
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Postagem>Postagens { get; set; }
        DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        DbSet<Grupo> Grupos { get; set; }
        DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }
        DbSet<Identificacao> Identificao { get; set; }



        #endregion

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                              
                modelBuilder.ApplyConfiguration(new UsuarioConfigurationSchema());
                modelBuilder.ApplyConfiguration(new PostagemConfigurationSchema());
                modelBuilder.ApplyConfiguration(new StatusRelacionamentoConfigurationSchema());
                modelBuilder.ApplyConfiguration(new GrupoConfigurationSchema());
                modelBuilder.ApplyConfiguration(new UsuarioGrupoConfigurationSchema());
                modelBuilder.ApplyConfiguration(new IdentificacaoConfigurationSchema());           
                       

            base.OnModelCreating(modelBuilder); 
        }
        #endregion

    }
}
