using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D7.LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 22);   // ben buraya LocalFunction metodunu çagırabilirim topla metodunu çagıramam çünkü topla metodu  SADECE LocalFunction metodu içindedir.
         }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {

            


            int topla(int gelensayi1, int gelensayi2)  // metot içinde yeni metot oluşturduk.

            {
                return gelensayi1 + gelensayi2;
            }

            int ToplamDegerSu = topla(sayi1, sayi2);
            Console.WriteLine(ToplamDegerSu);
        }


    }
}
