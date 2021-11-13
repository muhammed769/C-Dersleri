using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsüllemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Kapsülleme konusu giriş
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.isim = "mika";
            M1.soyisim = "ders";

            // Kapsülleme nedir ?
            // Müşteri class'ı içerisinde tanımlamış olduğumuz alanları özelleştirebilmek için Kapsüllemeyi kullanırız.

            // field(alan) içerisine değer ataması yapılmasın ama değer okunabilsin (Kapsüllemenin  1.örnek kullanımı)

            // field(alan) içerisine değer ataması yapılsın ama değer okunmasın.(Kapsüllemenin 2.örnek kullanımı)

            // field(alan) içerisine değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.(Kapsüllemenin 3.örnek kullanımı)(kızlık soyadı 2 ve 4.harf)

            // field içerisine değer ataması ve işlemleri yapılsın ama bu iki işlemde bizim belirdigimiz süreçten ...
            // ... geçsin veri daha sonra gösterilsin.(Kapsüllemenin 4.örnek kullanımı)


            // Class
            // Field
            //Property =Özellikler
            // Get & Set 


            // M1.emailAdres = "mamisedef.@hotmail.com"; (Fİeld)  //Kapsülleme 1.örnek kullanımı şimdi yapıcaz :

            // bu kod Musteri class'ımda başında public varken HATA ALMADIK ama private yazınca bu kısımda bir hata aldık.
            // Musteri class'ında emailadres kodunun başına prıvate yazdıktan sonra ben buraya deger ataması yapamıyorum ?
            // PEKİ benım buraya değer ataması yapabilecegim bir mekanizma lazım. Property'leri kullanıcaz.

            M1.BenEmailAdres = "mamisedef.@hotmail.com";  // Musteri class'ındaki private emailAdres koduna değer atamış olduk.

            Console.Write(M1.BenEmailAdres);

            #endregion

            

        }
    }
}
