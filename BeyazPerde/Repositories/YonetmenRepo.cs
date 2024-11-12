using BeyazPerde.Models.Concrete;

namespace BeyazPerde.Repositories
{
    public class YonetmenRepo : BaseRepo<Yonetmen>
    {
        public void YonetmenGuncelle(Yonetmen yonetmen)
        {
            // todo : kod bloklari
            db.SaveChanges();
        }
    }
}
