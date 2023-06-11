using Microsoft.EntityFrameworkCore;
using PlatformeEntretien.Models;

namespace PlatformeEntretien
{
    public class Connexion:DbContext

    {
        public Connexion(DbContextOptions<Connexion> options) : base(options)
        {

        }

        public DbSet<Candidat>candidats { get; set; }
        public DbSet<Admin> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasKey(a => a.idadmin);
        }
    }

}

