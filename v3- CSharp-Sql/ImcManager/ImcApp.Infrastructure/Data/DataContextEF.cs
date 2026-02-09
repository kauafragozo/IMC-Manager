using ImcProgram.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ImcProgram.Data
{

    public class DataContextEF : DbContext
    {
        public DbSet<Pacientes> Pacientes { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=IMCMANAGERDB;TrustServerCertificate=true;Trusted_Connection=true;",
                options => options.EnableRetryOnFailure());
            }
        }
    }


}