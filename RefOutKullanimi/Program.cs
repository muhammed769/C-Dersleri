using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D4.RefOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ref ve Out anahtar sözcüklerinde eski .Net Framework versiyonlarında 1 fark vardı:
            // Mevcut FrameWork versiyonu 7.0 olanlar  bu farktan etkilenmiyecekler.

            // Ref ve out anahtar sözcükleri  deger tipli davranıştan referans tipli davranışa gecmemize yarıyor.

            //Ref ve out  parametre degeri almaksızın kullanılabiliyor.

            //int sayi1 = 0;
            //degerAta(ref sayi1); // sayi1 de 10 degeri almış oldu.


            // Başlık : Degişken sayıda Parametre almak(Params Kullanımı)
            //Metot 2 parametre verilerek de çagıralibilir 4 parametre verilerek de.Çalışma mantıgı ise gayet basittir; PARAMS anahtar sözcügü ile dinamik bir dizi oluşturulur ve parametre olarak gönderilen degerler  bu diziye eklenir.
            //Metot içerisindede dizi içerisindeki parametreler kullanılarak istenilen işlemler yapılabilir.

           topla(5, 9, 66, 22, 66, 22);  // istedigim kadar degeri parametre olarak ekleyebilirim.

            // NOT : Params ifadesi girilen degerleri  belirtmiş oldugumuz veri tipinden diziye çevirir.Ama bunu parametre olarak isterken bizden dizi istemez.Belirtmiş oldugunuz veritipinden sıralı data ister..
            //.. istemiş oldugu sıralı datayıda  içeride bir dizinin içine otamatik olarak aktarır ve işlem yapmamıza olanak saglar.
            
            //

         }

        static void degerAta(ref int gelenDeger)  // parametre olarak ref anahtar sözcügünü kullanarak int bir deger istiyorum bununda adına gelenDeger diyelim

        {

            gelenDeger = 10;



        }
        static void topla(params int[] sayilar)
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            Console.WriteLine("Toplam : {0}", toplam);
        }

    }
}
