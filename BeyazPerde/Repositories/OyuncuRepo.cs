using BeyazPerde.Models.Concrete;
using BeyazPerde.Models.Context;

namespace BeyazPerde.Repositories // metot kutuphanesi
{
    public class OyuncuRepo : BaseRepo<Oyuncu>
    {
        // Amacım oyuncu nesnesine ait CRUD opereasyonları (Create(Ekle),Read(Oku), update(Guncelle), delete(Sil))
        // Repository : Metot Kutuphanesi

        public void OyuncuGuncelle(Oyuncu oyuncu)
        {
            // todo : kod bloklari dikkat!
            db.SaveChanges();
        }

     
    }
}
