using NetFramework.S18.D6.GenericClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
       
        {
            // Generic OLMAYAN BİR CLASS TANIMI YAPTIK.

            Musteri M1 = new Musteri();

            M1.id = 1;
            M1.TcKimlikNo = "123456789";
            M1.musteriNumara = "SL654";
            M1.isim = "selin";
            M1.Soyisim = "çakmak";
            M1.dogumTarih = DateTime.Parse("02.10.2001");


            MusteriGeneric<int> musteriGeneric2 = new MusteriGeneric<int>();  // T tipim int demiş olduk.
            musteriGeneric2.id = 1;
            musteriGeneric2.musteriNumarasiAl(); // herhangi bir parametre degeri almaz geriye int döner.


            MusteriGeneric<Guid> musteriGeneric3 = new MusteriGeneric<Guid>();
            musteriGeneric3.musteriNumarasiAl();          // herhangi bir parametre degeri almaz geriye Guid döner

           

        }
    }
}
