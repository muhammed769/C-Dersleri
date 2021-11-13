using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelTanım
{
     public class ogrenci
    {
        // Hatırlatma : Artık kendisini tekrar eden işlemlerimizi ya da tekrar etmeyen operasyonel işlemlerimizi kendi class tanımlarında küçük küçük metotlara bölüp istedigimiz zaman ulaşabilir durumda olucaz.İşte o yüzden metotlar çok önemlidir.

        // Uygulamamıza yeni bir sınıf nasıl ekleyebiliriz şimdi bunu ögrenicez :

        // ogrenci adında bir class(sınıf) açmış olduk.

        // Şimdi açmış oldugumuz bu class 'ı Main metodu içerisinde nasıl bulabiliriz ? Şöyle yapıcaz : 

        // class ogrenci yazan yere 'public' eklicez.Public uygulamanın her noktasında bu class 'ı(sınıfı) kullanabilmemizi saglar.

        // Not : Metotlarla bir deger ataması yapmak istemezsek void yazısını ekleriz.

                   public void  selamlaOgrenci()  // Herhangi bir deger ataması yapmadık.

                              {

                                       Console.WriteLine("Merhaba Ogrenci");     // Sistem kütüphanesinin Console class'ındaki(sınıfındaki) WriteLine metodunu kullanmış olduk.

                              }


        /* öncelikle Metotların [ErişimBelirleyicilerinin] olması gerekiyor. Daha sonra <GeriDonusDegeri> olabilir. VE bir metotodun ÇAGRILMASI için metotun ismi olması gerekiyor yani = MetotAdi(Parametreler)
         * 
        // yani :  Metotların yazılım aşaması şu şekildedir :   [ErişimBelirleyici] <GeriDonusDeger> MetotAdi(Parametreler) 

         * {
         *   Metot 'un çalışması için gereken kodlarda bu alana yazılır.
         * }
         * 
         * Erişim Belirleyicileri : 5 farklı Erişim belirleyici bulunmaktadır. Bunlar : 
         * 
         *      Public : Ben bu  metodu class' ın içerisinden DEGİL,  class'ıma ulaşan herkesin bu metodada ulaşması istiyorum deriz.
         *      Private : İçerisinde bulunmuş oldugu class düzeyinde çagrılabilir.Benim ogrenci nesneme ulaşan bir insan bu metoda ULAŞAMASIN, Özel olarak class'ın içerisinden ulaşılsın.
         *      Protected : Kalıtım konusunda yogun olarak kullanıcaz.Birbirinden nesneler kalıtıldıgında  protected olarak kullanılabiliyor.
         *      Internal : İlgili uygulama içerisinde(kutuphane)  metota ulaşabilirsin.
         *      Internal Protected : İlgili uygulama içerisinde metota ulaşabilirsin veya bir yerden kalıtıldıysa metota  ulaşabilirsin.
         * 
         */




        // Şimdi şunu yapıcaz : Şimdi metot tanımı yapıcam  class dışından erişilmesini istiyorum.Benım class'ıma ulaşan herkesin görmesini istiyorum.


             public void ogrenciMetot1( string ogrenciAdi, string ogrencıSoyadi)    // Erişim belirleyici kısmına public yazdım.
                                                                                    //Geri Dönüş Degerime sahip olmasını İSTEMİYORUM  yani bir işlemi yapıp sonuclanmasını istedigim için VOİD  yazdım.
                                                                                    //Metodumun adınada '' ogrenciMetot1 '' dedik.
                                                                                    // Parametre olmasını istiyorum.Yani parametreler kısmına (Benden ögrencinin adı ve soyadı bilgilerini istesin istiyorum.)

               {
                         Console.WriteLine("Ögrenci Bilgileri : {0} {1}", ogrenciAdi, ogrencıSoyadi);
               }

        // Şimdi program cs 'e geri dönücez.

        


    }
}
