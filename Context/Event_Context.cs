using Event_Plus.Domains;
using Microsoft.EntityFrameworkCore;

namespace Event_Plus.Context
{
    public class Event_Context : DbContext
    {

        public Event_Context()
        { 
        }

        public Event_Context(DbContextOptions<Event_Context> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Evento> Evento{ get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Presenca> Presenca { get; set; }
        public DbSet<Instituicao> Instituicao{ get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<TipoUsuario> TipoUsuario{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE32-S28\\SQLEXPRESS; Database=Filmes ; User Id =sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
