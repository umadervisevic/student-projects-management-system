using Microsoft.EntityFrameworkCore;
using Studentska.Data.Added;
using Studentska.Data.Entiteti;

using System.Configuration;

namespace Studentska.Servis
{
    public class StudentskaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["StudentskaDb"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }

        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<Projekti> Projekti { get; set; }
        public DbSet<StudentiProjekti> StudentiProjekti { get; set; }

    }
}
