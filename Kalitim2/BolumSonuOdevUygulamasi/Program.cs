using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D4.BolumSonuOdevUygulaması
{
    class Program
    {
        static void Main(string[] args)
        
        {
            bilgisayar B1 = new bilgisayar();


           //  B1.id = 1;                        // id girmek istemiyorum,  uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum.AÇIKLAMA kod ilk başta B1.id=1; ŞEKLİNDEYDİ AMA BİZ BaseClass'da id kısmına KAPSÜLLEME EKLEDİK
                                                 // VE KULLANICIYA DEĞER GİRİŞİ YASAKLAMIŞ OLDUK.DOLAYISIYLA BU KODU YORUM SATIRI HALİNE GETİRİYORUM.


            B1.Marka = "Lenovo";
            B1.Model = "z50";
            B1.islemci = "İ5";
            B1.alısFiyat = 1200;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1200M;
            B1.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B1);



            bilgisayar B2 = new bilgisayar();
             
            B2.Marka = "Lenovo";
            B2.Model = "z50";
            B2.islemci = "İ5";
            B2.alısFiyat = 1200;
            B2.satisFiyat = 1500;
            B2.kampanyaFiyat = 1200M;
            B2.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B2);
        }
    }
}
