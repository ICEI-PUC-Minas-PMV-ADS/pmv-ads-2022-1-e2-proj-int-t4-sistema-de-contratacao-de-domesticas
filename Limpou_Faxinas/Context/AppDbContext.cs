using Microsoft.EntityFrameworkCore;

namespace Limpou_Faxinas.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Servico> Servicos { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }
    }
}
