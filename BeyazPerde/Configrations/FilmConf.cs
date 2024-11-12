using BeyazPerde.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyazPerde.Configrations
{
    // configurasyon sınıfının gorev ve yeteneklerini bilmesi icin IentityTpeConfiguration yada onun sınıfından turetilmis hali EntityTypeConfiguration sınıfından kalıtım almalıdır.
    public class FilmConf : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(a => a.Ad).HasMaxLength(100).IsRequired().HasColumnName("FirstName"); // isrequired : not null

            // Pk ?
            builder.HasKey(a => a.ID);

            // film ile yonetmen iliskisi
            // a = film, b = yonetmen' den almıs oluyoruz.

            builder.HasOne(a => a.Yonetmen).WithMany(b=> b.YonetmeninFilmleri).HasForeignKey(a=> a.YonetmenID);
        }
    }
}
