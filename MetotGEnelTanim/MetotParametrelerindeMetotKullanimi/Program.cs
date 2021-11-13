using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D6.MetotParemetrelerindeMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine(true);

            // decimal toplam = topla(12M, 45M);
            // EkrandaGoster(toplam);

                                                                                 //  ÇOK ÖNEMLİ  : 
            EkrandaGoster(topla(12, 33));                                        // ben bir sayıyı ekranda göstermek istiyorum : o zaman ekrandagöster metodunu kullanmak gerekir
                                                                                 // ekrandagoster metodunun neye ihtiyacı var bu metotda bir deger istiyo.bana herhangi bir deger ver ekranda gösteriyim diyo.Parametre kısmına metodu yazdık.
                                                                                 // parametre kısmına yazdıgım topla metodunu çagır  topla metodu içerisine 12 ve 33 degerlerini ata.
                                                                                 // Önce topla metodu çalışır.static int topla metoduna ilk önce gider sonra tekrar buraya gelir ve en son static void EkrandaGoster metoduyla 45'i console'a yazmış olur.
                                                                                 //İÇ İÇE METOT KULLANIMI  BU ŞEKİLDEDİR.


        }

        static  void EkrandaGoster(object o)


        {
            Console.WriteLine(o.ToString());
        }
        static int topla(int sayi1, int sayi2)

        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1 , decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;

        }

        static void topla(string metin1, string metin2)
        {
            Console.WriteLine(metin1 + "" + metin2);
            
        }
    }
}
