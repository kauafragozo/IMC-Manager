using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PessoaManager.Models;

namespace PessoaManager.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TesteDB;Trusted_Connection=true;TrustServerCertificate=True;",
                options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("TPESSOA").HasKey(c => c.Id);
        }


    }
}