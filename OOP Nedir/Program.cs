using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
    class Program  // class 'lar referans tiplidir.
    {
        static void Main(string[] args)   // Nesne yönelimli programlamayı ögrenirken gerçek hayattan örnekleri bolca kullanmalıyız.Çünkü biz gerçek hayatta nesne yönelimli bir dünyada yaşıyoruz.
        {

            //  Musteri M1 = new Musteri();   // burdaki ()  şu anlama gelir : default degerleri al demektir.Musteri nesnesi oluşturmuş oldum.M1 = Musteri class'ına M1 REFERANSIYLA ULAŞMAK İSTİYORUM. new ile Musteri class'ımın kopyasını buraya alıyorum.
            // ()  bu metot'u gösterir.
            // eger bu bir metot'u gösteriyorsa var olan bir şeyi  tekrardan üzerinden geçiyorsak programlama dünyasında biz buna ''EZMEK'' diyoruz.

            // Musteri.cs'de yapıcı metotları yazdıktan sonra şu kodu  yeniden yazıyorum : (BURASI ÇOK ÖNEMLİ İYİ ANLA !!!!!!!!!)

            Musteri M1 = new Musteri("56231582168", "Nesrin");    // burda 4 tane overland acılıyor ve  içlerinden 1.ci overland da örnegin tc kimlik nosunu ben vereyim gerisini sen doldur veya tc isim soyisimini ben vereyim gerisini sen doldur.
                                                       //burda 3'üncü overlandı sectik ve bu overland string tckimlikno ve string isim 'di o yüzden buraya tckimlik no ile isimi girip geriye kalan degerleri doldurmamızı sonraki aşamada ister.)
            M1.TCkimliknumara = "22222555566622";
            M1.isim = "Mika";
            M1.soyisim = "Dursun";
            M1.cinsiyet = 717770001;
            


            // Şimdi buraya kadarki nesnelerimiz Ram üzerinde nasıl şekillencek  kendisini nereye attıgını, davranışlarının nasıl oldugunu inceleyelim.Çünkü bu ayrıntıları ögrenmen ilerdeki projeleride ögrenmene yardımcı olucak  o yüzden bu detaylar ÇOK ÖNEMLİ!!

            Musteri M2 = M1; // M2 nesnem M1'in RAM 'deki degeri neyse M2 nesnemde aynı degerleri alsın.

            M2.isim = "Çagla"; // Hem M2 nesnemdeki isim degeri Çagla olmuş oldu hemde M1 nesnemdeki isim degeri Çagla oldu çünkü M1 ve M2 ikiside aynı yere bakıyor.baktıgı yeri degiştirirsen 2 side degişmiş olur o yüzden.
            M1.TCkimliknumara = "548999999";


            bool musteriKontrol = M1.MusteriKontrol();
            


            //M2 = null;  // M2 nesnemle işimizin bittigini söylemiş olduk veya sen artık oraya gösterme. null demek hiç bir şey görmemek demektir.M2=null; desende M2'ye M1 üzerinden HALA ulaşabilirsin.
            //M1 = null;  //Ama ben M1 ide null yaparsam HEM M2 HEM M1  null yani hiç bir deger görmemiş olur.


            // stack bölge : M1 ve M2 vardı heap bölge : tckimlikno,isim ... vardı ben stack bölgede pointer'ları kaldırmış oldum ve bu degerler Ram'den düşer yani silinir.

            string isim = M2.isim; // tam bu kısımda hata alırsın çünkü sen M2 yi tanımlarken = new DEMEDİN BURASI ÇOK ÖNEMLİ.


            // Ekstra bilgi : public private yerine internal yazarsak internal şu anlama gelir namespace(uzay) içerisinde müsteri metodumu kim çagırabiliyosa  erişimi açık hale getiriyor.



        }
    }


    //class Musteri   // böylede bir class tanımlayabilirim ama böyle bir kullanım kodun okunaklıgı açısından pek önerilmez.
    //{

    //   }
    




}
