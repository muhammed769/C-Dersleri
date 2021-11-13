using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();

            // P1 dedigimde Static olmayan property'lerim karşıma gelir.

            P1.Isim = "Mika";
            P1.SoyIsim = " Desen ";
            P1.Emailadres = " mika.desen";
            P1.Cinsiyet = 717770001;  // Bay  717770002=Bayan


            Personel P2 = new Personel();
            P2.Isim = "Mika";
            P2.SoyIsim = " Desen ";
            P2.Emailadres = " mika.desen";
            P2.Cinsiyet = 717770001;  // Bay  717770002=Bayan


            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.SoyIsim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.SoyIsim);

        }
    }
}
