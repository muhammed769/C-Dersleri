using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    class Program
    {
        static void Main(string[] args)

        {

            // Açıklama PartialClass'ı  şu gibi durumlarda kullanırız : Fields ve methods 'lar eger çok fazlaysa yani bir mimari proje gibi proje varsa elimizde bu fields ve methodsları birbirinden ayırt etme gibi durumlarda kullanılır.

            musteri M = new musteri();
            M.id = 1;
            M.Isim = "gamze";
            M.soyIsim = "kılınçcı";
            M.emailAdres = "gamzekılınccı@hotmail.com";

          int sonuc =  M.yeniKayit(M);

            if (sonuc > 0)
            {
                Console.WriteLine("database 'e yeni kayıt eklendi.");
            }

            ogrenci o = new ogrenci();
            o.id = 1; // f12 'ye BASTIGINDA SENİ  ogrenciField class'ına götürür.
            o.yeniKayit(o); // f12 'ye BASTIGINDA SENİ ogrenciField class'ına götürür.

        }


    }
}
