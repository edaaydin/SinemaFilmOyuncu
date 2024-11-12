using BeyazPerde.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyazPerde.Configrations
{
    public class OyuncuFilmConf : IEntityTypeConfiguration<OyuncuFilm>
    {
        public void Configure(EntityTypeBuilder<OyuncuFilm> builder)
        {
            // PK
            builder.HasKey(a => new { a.OyuncuID, a.FilmID });

            // Oyuncu icin
            builder.HasOne(a => a.Oyuncusu).WithMany(a => a.Filmleri).HasForeignKey(a => a.OyuncuID);

            // Film icin
            builder.HasOne(a => a.Filmi).WithMany(a => a.Oyunculari).HasForeignKey(a => a.FilmID);

        }
    }
}
