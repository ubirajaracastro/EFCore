using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        #region Construtor
              
        public SwitchContext(DbContextOptions options) : base(options)
        {

        }
        #endregion

        #region DBSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }
        public DbSet<Identificacao> Identificao { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

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
            modelBuilder.ApplyConfiguration(new AmigoConfigurationSchema());
            modelBuilder.ApplyConfiguration(new ComentarioConfigurationSchema());
            modelBuilder.ApplyConfiguration(new ProcurandoPorConfigurationSchema());


            base.OnModelCreating(modelBuilder);
        }
        #endregion

    }

}
