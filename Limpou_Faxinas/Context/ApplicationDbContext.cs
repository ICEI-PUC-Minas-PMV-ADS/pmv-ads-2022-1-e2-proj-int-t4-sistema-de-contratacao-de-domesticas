using Limpou_Faxinas.Models;
using Microsoft.EntityFrameworkCore;

namespace Limpou_Faxinas.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //public DbSet<Models.Servico> Servicos { get; set; }
        //public DbSet<Models.Usuario> Usuarios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
    }
}
