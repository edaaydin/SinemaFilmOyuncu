namespace BeyazPerde.Models.Concrete
{
    // id dısında baska prop'larda tutabiliriz.
    // her ikisinin id'si de PK olmalı ki cagırdıgımız zaman kod karmasıklıgını onlesin ve tek gelsin.
    // burdakiler tek pk degil fk de olabilir.
    public class OyuncuFilm // ara tablo coka cok iliski icin
    {
        // 1 filmi

        public int FilmID { get; set; }
        public virtual Film Filmi { get; set; }

        // 1 oyuncu

        public int OyuncuID { get; set; }
        public virtual Oyuncu Oyuncusu { get; set; }
    }
}
