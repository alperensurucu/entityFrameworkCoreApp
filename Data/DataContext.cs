using Microsoft.EntityFrameworkCore;

namespace entityFrameworkCoreApp.Data
{
    public class DataContext : DbContext        
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {

        } 
        //options bilgisini dışarıdan alamadığı için burda bunu yazdık .
        // Mesela yeni bir kurs ekleyecek isek
        // DataContext ten üretilen nesle ile Aşağıdaki datalara erişeceğiz ve
        // üzerlerine ekleyeceğiz.

        public DbSet<Kurs> Kurslar => Set<Kurs>(); //nullable olabilir kısmı hata vermesin diye initialize ettik.
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();
    }
}
