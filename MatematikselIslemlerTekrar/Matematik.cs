using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.MatematikselIslemler    //   Metot=Yöntem 
{
    public class Matematik // public 'i yazarak dış dünyaya erişimi açmış oldum.
    {

        // Toplama işlemi

        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)      //geridönüşdegeri olsun istedim o yüzden decimal(ondalık) yazdım.
        
        {
            decimal sonuc = sayi1 + sayi2;           // Metodumuza bir işlem yaptırdık.Metodumuz sayi1 le sayi2 'yi topladı sonuc'un üzerine attı ama sonuç degerini Metodun dışarısına göndermem gerekiyor.Bunun için şu kodu yazmam gerekir :
            return sonuc;                           // return(geri gönder) anahtar kelimesi kullanırız.Yani return sonuc; sonucu gönder Program.cs'e demektir bu kodun anlamı.
        }


        // Çıkartma işlemi 

        public decimal cikartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        // Bölme işlemi

        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }


        // Çarpma İşlemi

        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazirla()  // bu kodun anlamı : void 'i yazdık çünkü geri dönüş yapmıcak  yani burdaki yazdıklarımız hep ekranda kalacak. () parantezi boş bıraktık çünkü parametre almıcak.Sonuç olarak menuHazirla metodunu oluşturmuş olduk.

        {
            Console.Clear();
            Console.WriteLine("*********MENÜ**********");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkartma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Lütfen deger seçiniz : " );



        }


        public void sonucEkranayaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc,string operators)
        {

            Console.WriteLine("{0} {1} {2} ={3}", kullaniciSayi1,operators,kullaniciSayi2,sonuc);



        }








    }
}
