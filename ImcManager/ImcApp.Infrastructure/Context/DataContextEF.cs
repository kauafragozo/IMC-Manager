using ImcProgram.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ImcProgram.Context
{

    public class DataContextEF : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=IMCMANAGERDB;TrustServerCertificate=true;Trusted_Connection=true;",
                options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().ToTable("TPACIENTES");
        }


    }


}