using IMCManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;

namespace IMCManager.Data
{

    public class DataContextEF : DbContext
    {

        private IConfiguration _config;
        public DataContextEF(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Paciente> Pacientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().ToTable("TPACIENTES").HasKey(p => p.PID);
        }


    }


}