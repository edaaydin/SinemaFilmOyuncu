using BeyazPerde.Models.Abstract;
using BeyazPerde.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace BeyazPerde.Repositories
{
    public class BaseRepo<T> where T : BaseClass // Where t bunun bir class oldugunu soyluyor
    {
        // T yi baseclass gibi gor baska yerde t tipine ne verirsen oyle gor

        protected readonly SinemaDbContext db;
        protected readonly DbSet<T> set;

        public BaseRepo()
        {
            db = new SinemaDbContext();
            set = db.Set<T>();
        }

        // Create - Ekleme
        public void Ekle(T nesne) // oyuncu - yonetmen - film olabilir
        {
            set.Add(nesne);
            db.SaveChanges();
        }

        // Read - id'sine gore biri gelebilir / herkes gelsin - Okuma

        public T IdBilgisiIleGetir(int id)
        {
            return set.Find(id);
        }

        public List<T> ButunAktifleriGetir() // Aktif olanlar gelsin ?
        {
            return set.Where(a => a.IsActive == true).ToList();
        }

        // Delete - Silme ---> Aktifligi pasife cekeriz

        public void Sil(int id)
        {
            T nesne = IdBilgisiIleGetir(id);
            nesne.IsActive = false;
            db.SaveChanges();
        }
    }
}
