using BeyazPerde.Models.Abstract;

namespace BeyazPerde.Models.Concrete
{
    public class Yonetmen : BaseClass // id ve isactive gelecek
    {
        public Yonetmen()
        {
            YonetmeninFilmleri = new List<Film>();
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

        // navigation prop

        // 1 yönetmenin cokca filmi olabilir

        public virtual List<Film> YonetmeninFilmleri { get; set; } // Lazy yapıcaz filmler tum datasıyla birlikte geliyor id vs o yuzden moviden ıd istemeye gerek yok
        // Eager Loading
        // lazy Loading
    }
}
