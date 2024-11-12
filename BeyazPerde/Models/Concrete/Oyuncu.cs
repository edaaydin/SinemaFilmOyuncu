using BeyazPerde.Models.Abstract;

namespace BeyazPerde.Models.Concrete
{
    public class Oyuncu : BaseClass
    {
        public Oyuncu()
        {
            Filmleri = new List<OyuncuFilm>();
        }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad; ;
        }

        // navigation prop

        // 1 oyuncu cokca filmde oynadı

        public virtual List<OyuncuFilm> Filmleri { get; set; }

    }
}
