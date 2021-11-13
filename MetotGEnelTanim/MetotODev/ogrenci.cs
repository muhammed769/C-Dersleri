using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D3.MetotOdev
{
     public class ogrenci
    {
        public void ogrenciNothesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3)
        {
            Console.WriteLine("Ögrencini bilgileri aşagıdaki gibidr :");
            Console.WriteLine("Ad soyad : {0} {1}", ad, soyad);

            decimal ortalama = ortalamaHesapla(not1, not2, not3); // içerideki başka bir metodu çagırmış olduk.  // decimal ortalama = (not1 + not2 + not3) / 3; tam bu satırda ilk kod buydu. 

            if (ortalama<45)
            {
                Console.WriteLine(" Ortalama degeriniz : {0} - Kaldınız", ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama degeriniz : {0} - Geçtiniz", ortalama);

            }
}

        // Sadece bu class içerisinde erişilmesini istersem ve dış dünyaya kapalı olmasını istersem PUBLİC YERİNE PRİVATE KULLANIRIM.
        // Her metod kendi degişken isimlerine göre metotları çagırır.
        // Paremetre isimleri aynı olmayabilir.Yani bir metoda verdigimiz paremetre isimlerini başka bir metoda aynı paremetre degerlerini verebilirimde vermeyebilirimde bu tamamen bana kalmıştır.
        
        private decimal ortalamaHesapla(decimal ogrencinot1, decimal ogrencinot2, decimal ogrencinot3)
        {
            //decimal ortalama = (ogrencinot1 + ogrencinot2 + ogrencinot3) / 3;
            //return ortalama;                                                    //ortalama degerini Program.cs'e göndercek.

            return (ogrencinot1 + ogrencinot2 + ogrencinot3) / 3;


        }

        // eger metotun public mi private mı oldugunu yazmazsak c# OTAMATİK OLARAK PRİVATE OLARAK ALGILIR (ÇOK ÖNEMLİ)

        // parametreler ilgili metodun içerigini baglar.

        // İç İçe kullanımlarda iç metot önce çalışır. Sonra deger gönderir ve en son dış metot çalışır.







    }
}
