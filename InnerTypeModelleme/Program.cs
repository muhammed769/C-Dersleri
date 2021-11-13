using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        
        {

            Musteri M1 = new Musteri();  // Musteri sınıfını sen buraya kopyaladın  M1 adında kopyaladın ve musteri sınıfındaki field'lara aşağıdaki degerleri girmiş oldun.

            M1.musteriID = 3;
            M1.tcKimlikNumarası = "5236974133581232";
            M1.Isim = "Müzeyyen";
            M1.SoyIsim = "Senar";
            M1.olusturmaTarih = DateTime.Now;  // oluşturma tarihimin  şimdi olduğunu söylemiş olduk.

           //   M1.musteriAdresleri = new MusteriAdres[5];    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!BU TİP BİR KULLANIMI ASLA AMA ASLA YAPMA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

           //   *********** ÖNEMLİ***********  : Şöyle yap : Musteri nesnesine(sınıfına) git Musteri  nesnesinin YAPICI METOT'UNU(constructur'ını) oluştur.


            M1.musteriAdresleri[0] = new MusteriAdres() // MusteriAdres sınıfını buraya kopyaladın ve [0]'ıncı indeksine girilecegini söylemiş oldun.
            {
                Il="izmir",
                Ilce="çiğli",
                Adres="Adres....",
                adresTip="Iş Yeri"


            };

            M1.musteriAdresleri[0].musteriadresTestMetotu();  // M1 sınıfımdaki musteriadresleri koleksiyonuma

        }
    }
}
