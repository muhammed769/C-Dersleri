using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MatematikselIslemler
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematik M = new Matematik();         // Matematik M  şu demek : Matematik class'ını M ile örnekledik.
                                           
            YenidenIslemYap:                        // go to metodunu kullandık.


            M.menuHazirla();                                         // M.menuHazirla() : M olarak isimlendirdigim matematik class'ı içerisindeki menuHazirla metodu İÇİN ŞU İŞLEMLERİ YAP.

            int kullaniciSecim = int.Parse(Console.ReadLine());      //Console.ReadLine 'dan gelen string degerini int.Parse komutuyla int 'a çevir ve  kullaniciSecim'in içerisine at.
                                                                     //Console.ReadLine() 'in üzerine mausu götürdügümüzde  ordaki yazan yazı şu anlama gelir : Kullanıcının girmiş oldugu degerleri sana string olarak veririm demek oluyor. 



            Console.WriteLine("Lütfen 1.sayı degerini giriniz : ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayı degerini giriniz : ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch ( kullaniciSecim)
            {
                case 1 :

                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);                   //  M. şu demek : M  olarak isimlendirdigim matematik  class'ı İÇERİSİNDEKİ(NOKTA(.) İÇERİSİNDEKİ DEMEKTİR.) 
                                                                                               // YANİ M  olarak isimlendirdigim class içerisindeki metotları bana listele demektir bu kodun anlamı.

                    M.sonucEkranayaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");              //M.sonucEkranayaz : M olarak isimlendirdigim matematik class'ı içerisindeki sonucEkranaYaz metodumu çagırdım.              
                    
                    break;

                case 2 :

                   sonuc= M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);

                    M.sonucEkranayaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                   
                    break;


                case 3 :

                   sonuc=  M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);

                    M.sonucEkranayaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                                

                   break;

                case 4 :

                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);

                    M.sonucEkranayaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");

                    break;

                default:                                 // default = Varsayılan demektir.


                    Console.WriteLine("Belirtmiş oldugunuz deger liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen yeniden deneyiniz :");

                    System.Threading.Thread.Sleep(2000); // 2 saniye sistemi bekletiyo.

                    goto YenidenIslemYap;

                    // yani default degeri yani kullanıcı 1-4 haricinde bir deger girerse  ekranda deger bulunamadı yeniden deneyin yazıcak sistem 2 saniye beklicez ve goto metoduyla yenidenişlem yapıcak o yüzden burdaki break'i kaldırdık.
            }


            Console.WriteLine(" Yeni işlem yapmak istiyor musunuz : [E/H]"); // [E/H] kullanımı yeni yaptı bu kodu UNUTMA.
            string tepki = Console.ReadLine();

            if (tepki=="E")
            {
                goto YenidenIslemYap;

            }

            // altına bir şey yazmıyoruz çünkü diger cevap H olacagı için uygulama otomatik olarak sonlanacaktır.

        }
    }
}
