using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    public  class Ogrenci // internal olarakta ayarlayabilirdik.

    {

        public string Isim { get; set; }  // Prop yazıp 2 kere TAB'a basarsan bu kullanım otomatik olarak gelir.

        public string SoyIsim { get; set; }
        public  string EmailAdres { get; set; }


        public void Test1()
        {
            Console.WriteLine("Bu metot Nesne örneği alındıktan sonra çalışan metottur.");

            Test2();   //  ÖNEMLİ 1 : Static olmayan bir metotun içinde static olan bir başka metodu ÇAĞRILABİLİR ve  işlem yapabilirim.
        }

        public static void Test2()
        {
            Console.WriteLine("Bu metot Nesne örneği ALINMADAN kullanılabilir.");

            // ÖNEMLİ 2 : Static olan bir metotta ise static olmayan bir başka metot ÇAĞRILAMAZ.Yani static bir metotta SADECE static metotlar çağrılır.





        }


    }
}
