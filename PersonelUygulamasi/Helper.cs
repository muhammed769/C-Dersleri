using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public static class Helper

    {
        // Helper H = new Helper(); ÖNEMLİ = static olarak işaretlenmiş class'lar ÖRNEKLENEMEZ.
        // Static olan class 'lar içerisinde  static olmayan standart metotlar kullanılamaz.
        // public string Tanim { get; set; }  ÖNEMLİ =  Static olan class'lar içerisinde static olmayan field tanımları yapılamaz.



        //public Helper() // Static olarak belirlediğin class içerisinde  bu yapıcı metodu KULLANAMAZSIN.
        //       {
                         // Her nesne ÖRNEĞİ alındığında uygulama , standart yapıcı metotu çalıştırır.  
        //      } 




        static Helper ()  // Bu yapıcı metodu kullanabilirsin.
                          // ÖNEMLİ : STATİC YAPICI METOTLAR UYGULAMA BOYUNCA SADECE 1 KERE ÇALIŞIR.

        
        {

            Console.WriteLine("Helper => Static class =>Static CTOR");

        }








        public static void emailGonder (string aliciEmailAdres, string konu, string icerik)
        
        {
            // Email gönderme işlemleri devam edecek... Egitimin ilerleyen seviyelerde bahsedicek.
            Console.WriteLine("Mail Gönderim işlemi başarılı");
        }

    }
}
