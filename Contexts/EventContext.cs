using Microsoft.EntityFrameworkCore;
using webApi.Event_.Lucas.Domains;

namespace webApi.Event_.Lucas.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TiposEvento> TiposEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<ComentariosEvento> ComentariosEvento { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PresencaEvento> PresencaEvento { get; set; }

        //Define as ações de construção do banco (string Conexão)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE06-S15; DataBase=webApi.Event+.Lucas; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
