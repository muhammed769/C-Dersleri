using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{

    #region  Delegate Açıklama

    /*  Delegate metot tutuculardır.Bir başka deyişle , bir veya birden fazla metodu tetikleyen yapılara Delegate diyoruz.
        *  Aynı metot imzasına sahip olan metotları saklayan ve sırası ile çalıştıran yapılardır.
        *  Delegate'leri LINQ 'da sık sık kullanıcaz.

       GENEL KULLANIMI : 

           Delegate int MatematikselIslemler(int A, int B)

           Yukarıdaki örnek kullanımda parametre olarak iki adet int değer alan ve geriye int değer dönen 
           metotları oluşturduğumuz delegate içerisinde tutabiliriz.

        */
    #endregion

    // Metot İmzası = Bizim  metodumuz hangi parametreleri alıyo ve  geriye ne dönüyo 
    class Program
    {

        delegate void MatematikselIslemler(int sayi1, int sayi2);

        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplama işleminin sonucu : {0} ", sonuc);
        }
        static void cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkarma işleminin sonucu : {0} ", sonuc);
        }
        static void carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu : {0} ", sonuc);
        }
      

        static void Main(string[] args)
        {

            #region Delegate kullanmadan önce
            // Delegate kullanmadan önce böyle yazıyorduk.

            //Topla(10, 20);
            //cikart(35, 2);
            //carpma(800 , 2);
            #endregion


            #region Delegate kullandıktan sonra 

            MatematikselIslemler M = new MatematikselIslemler(Topla);

            M += carpma; // delegate metodumun içerisinde carpma metodunu ekledik.
            M += cikart; // delegate metodumun içerisinde cikart metodunu ekledik.
            M.Invoke(30, 2);

            // Sonuç olarak ilk başta Topla metodu,sonra carpma metodu en sonda cikart metodu bu 2 sayıyı baz alarak çalışacak.

            Delegate[] isaretEdilenMetotlar = M.GetInvocationList();

            foreach (var item in isaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name); // Delegate olarak İŞLEM YAPILMIŞ metotların isimlerini sırasıyla ekranda yazdırır.
                                                     // Topla,carpma,cikart metotları bu sıra halinde ekranda gözükür.
            }

            // ******************************* Çalışma zamanında metot çıkartma , metot ekleme işlemleri **********************************

            M -= carpma;

            foreach (var item in M.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M -= cikart;

            foreach (var item in M.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M += carpma;

            foreach (var item in M.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            Console.ReadLine();

            #endregion

        }
    }
}
