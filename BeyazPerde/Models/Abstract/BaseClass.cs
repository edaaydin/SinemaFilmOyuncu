namespace BeyazPerde.Models.Abstract
{
    // dotnet add package Microsoft.EntityFrameworkCore.Proxies ile lazy loading kullanmamızı saglar.

    public class BaseClass // Ata class ve miras verir id ve activ icin
    {
        public int ID { get; set; }
        public bool IsActive { get; set; } = true;



    }
}
