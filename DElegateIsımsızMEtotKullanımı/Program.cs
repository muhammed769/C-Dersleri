using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIsimsizMetotKullanimi
{
    class Program
    {

        delegate void EkranaYaz(string isim, string soyisim);
        static  void Main(string[] args)
        {

         //********************************************************************************************************************

                             // Var olan bir metotu kullanarak delegate içine ekleme

            EkranaYaz Test1 = new EkranaYaz(TestMetot);

         //********************************************************************************************************************

                            // İSİMSİZ METOT KULLANIMI(Var olan bir metotu kullanarak delegate tanımlı metot  içine delegate metot ekleme)

            EkranaYaz Test2 = new EkranaYaz(delegate (string isim, string soyisim)
            {
                Console.WriteLine(isim + "" + soyisim);

            });

         //********************************************************************************************************************

                            // Lambda Exp Kullanımı

            EkranaYaz Test3 = (isim, soyisim) =>
            {
                Console.WriteLine(isim + "" + soyisim);
            };

         //********************************************************************************************************************

            Test1(" Mika", " Desen");
            Test2(" Nejat ", " Boy");
            Test3(" İrem ", " Çelik");

        }
       
        static void TestMetot(string isim, string soyisim)
        {
            Console.WriteLine (isim+""+soyisim);
        }
    }
}
