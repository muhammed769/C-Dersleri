using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D4.GenelOdevHocanınYaptıgı
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri1 M1 = new Musteri1();
            M1.Id = 1;
            M1.Isim = "Mika";
            M1.SoyIsim = "DESEN";
           
            M1.EmailAdres = "mikadesen@hotmail.com";
            M1.KullaniciAdi = "mikadesen";
            M1.Sifre = "123456";

            Musteri1.MusteriEkle(M1);



            Musteri1 M2 = new Musteri1()
            {
                Id = 2,
                Isim = "nejo",
                SoyIsim = "kral",
                KullaniciAdi = "nejo.kral",
                EmailAdres = "nejo.kral@gmail.com",
                Sifre = "2"

                      
            };

            Musteri1.MusteriEkle(M2);

            Musteri1 M3 = new Musteri1();
            M3.Id = 1;
            M3.Isim = "Mika";
            M3.SoyIsim = "DESEN";
            M3.KullaniciAdi = "mikadesen";
            M3.EmailAdres = "mikadesen@hotmail.com";
            M3.Sifre = "123456";

            Musteri1.MusteriEkle(M3);





        }
    }
}
