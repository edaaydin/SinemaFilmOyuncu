using BeyazPerde.Configrations;
using BeyazPerde.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BeyazPerde.Models.Context
{
    public class SinemaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Sinema5101;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        public DbSet<Yonetmen> Yonetmens { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Oyuncu> Oyuncus { get; set; }
        public DbSet<OyuncuFilm> OyuncuFilms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConf());
            modelBuilder.ApplyConfiguration(new OyuncuFilmConf());
        }

    }
}
