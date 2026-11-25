using Microsoft.EntityFrameworkCore;
using NexoApi.Models;

namespace NexoApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options ) : base  (options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<ClienteDetalhe> ClienteDetalhes { get; set;}

}
}