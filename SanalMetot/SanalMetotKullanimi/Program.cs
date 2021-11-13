using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {


            televizyon T = new televizyon();
            T.ekranaYaz("Hangisi ? ");          // **************************************** ÇOK ÖNEMLİ ***************************************************************
                                               // Bu sanal metodumu çalıştırdıgımda baseClass'daki  ekranaYaz sanal metodu çalıştı yoksa Urun'deki ekranaYaz sanal metodu çalıştı HANGİSİ ÇALIŞTI ???
                                               // URUN CLASS'I ÇALIŞIR ÇÜNKÜ URUN CLASS'I SANAL METODU OVERRİDE ETMİŞTİ YANİ SANAL METODLARI GÖSTEREN CLASS URUN CLASS'IDIR.
                                                
                                               


            //Urun U = new Urun();
            //U.ekranaYaz("Urun nesnesi içerisinde bu metot çalıştı.");

            //baseClass B1 = new baseClass();
            //B1.ekranaYaz("baseClass nesnesi üzerinden bu metot çağrıldı.");

            Urun U = new Urun();
            U.ekranaYaz("Merhaba");  // sanal metot yapılmış haliyle kodu çagırdık.

            baseClass B1 = new baseClass();
            B1.ekranaYaz("Merhaba");


        }
    }
}
