using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D3.MetotOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            // WriteLine  string degerleri yazarız.

            string ogrenciad = string.Empty; // ogrenciad 'ı degişkenine boş bir deger atadım.
            string ogrencisoyad = string.Empty;

            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;


            Console.WriteLine("Ögrenci adı :");
            ogrenciad = Console.ReadLine();

            Console.WriteLine("Ögrenci soyadı : ");
            ogrencisoyad = Console.ReadLine();

            Console.WriteLine("1.Notunuzu giriniz :");
            not1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("2.Notunuzu giriniz :");
            not2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("3.Notunuzu giriniz : ");
            not3 = decimal.Parse(Console.ReadLine());

            ogrenci N = new ogrenci();
            N.ogrenciNothesapla(ogrenciad, ogrencisoyad, not1, not2, not3);

// Hatırlatma :Şimdi ben ogrenci cs.de ogrenciNotHesapla metotunda örnegin  public voıd ogrenciNotHesapla(not3 =20) dersem not3 default bir deger atamış olurum ve tam bu kısımda SADECE not3 yazıp bırakırsam kullanıcı not 3 degerine hangi degeri girerse....
            //... not3' ün degeri o olmuş olur.
            
            // Opsiyonel parametre kullandıgın zaman (Yani not3 degerine 20 girmek gibi bu not3=20 den sonra girdigin her parametre opsiyonel olmak zorunda yani not3'den sonra girdigin her parametre opsiyonel olmak zorunda.




























        }
    }
}
