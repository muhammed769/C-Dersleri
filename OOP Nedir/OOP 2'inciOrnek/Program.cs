using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.OOP2inciOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            Arac A = new Arac("opel", "Astra", 2005, 36000);

            A.AlisFiyat = 28000;
            A.SatisFiyat = 30000;
            A.MaxİndirimTutar = 1000;
            // A.Fiyat= Kapsülleme konusuna dahil 

            A.FiyatAta(29500);
            A.BilgileriGoruntule();
        }
    }
}
