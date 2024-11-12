using BeyazPerde.Models.Concrete;

namespace BeyazPerde.Repositories
{
    public class FilmRepo : BaseRepo<Film>
    {
        public void FilmGuncelle(Film film)
        {
            // todo : kod bloklari
            db.SaveChanges();
        }
    }
}
