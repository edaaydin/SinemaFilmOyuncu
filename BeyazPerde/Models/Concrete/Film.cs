using BeyazPerde.Models.Abstract;

namespace BeyazPerde.Models.Concrete
{
    public class Film : BaseClass
    {
        public Film()
        {
            Oyunculari = new List<OyuncuFilm>();
        }
        public string Ad { get; set; }
        public DateTime YayinlanmaTarihi { get; set; }

        // navigation prop

        // 1 filmin 1 yonetmeni var

        public int YonetmenID { get; set; } // FK
        public Yonetmen Yonetmen { get; set; }

        // 1 FİMİN COKCA OYUNCUSU VAR
        public virtual List<OyuncuFilm> Oyunculari { get; set; }



    }
}