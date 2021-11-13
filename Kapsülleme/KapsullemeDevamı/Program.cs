using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeDevamı
{
    class Program
    {
        static void Main(string[] args)
        {

          
            #region Kapsülleme Ara Odev Çok Onemli !!!!!!!!!!!!!

            /*
            Musteri1 M = new Musteri1();
            M.TcKimlikNumarası = "13456789101";

            string TC = M.TcKimlikNumarası;

            */
            #endregion



            #region Kapsülleme 1.kullanımı Tekrar : Field(alan) içerisine değer ataması yapılmasın ama değer okunabilsin.

            /*
            Musteri1 M = new Musteri1();

            Console.WriteLine("En sevdiğin rakam şu mu :" + M.EnSevRakam.ToString());
            */




            #endregion


            #region Kapsülleme 1.kullanımı : Field(alan) içerisine değer ataması yapılmasın ama değer okunabilsin.
            /*
             Musteri1 M2 = new Musteri1();



             M2.isim = "Özge";
             M2.soyIsim = "Bulak ";

             M2.EmailAdres = "özge3bulak@hotmail.com";
             Console.WriteLine(M2.EmailAdres);

             Console.WriteLine(" Müşteri Id değeri : " + M2.ID.ToString()); // ToString() = string dışındaki veri  tiplerini string'e çevirir.
            */
            #endregion




        }
    }
}
