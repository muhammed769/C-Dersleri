using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D5.AsırıYuklenmek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine(true);

            topla(22, 10);

        }


        static void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        // return 'ile geri deger döndürürüz.

        static void topla(decimal sayi1, decimal sayi2)                              // static int topla(int sayi1i int sayi2)   //  2 farklı static  le başlayan  nu 2 kod sistemi 1'i deger döndermez biri return ile geri deger gönderir.
                                                                                      //{
                                                                                           //  int toplam = sayi1 + sayi2;
                                                                                           //   return toplam;
                                                                                      // }
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(string metin1, string metin2)
        {
            Console.WriteLine(metin1 + "" + metin2);
        }
    }
}
