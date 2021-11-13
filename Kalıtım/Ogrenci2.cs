using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerFramework.S12.D3.KalıtımOdev1tekrar
{
     public sealed class Ogrenci2 :AnaTip

     {

        #region Fieldlar

        public string  bolum { get; set; }

        public int seviye { get; set; }


        #endregion



        #region Yapıcı Metot

        public Ogrenci2()
        {
            Console.WriteLine("Ogrenci2 nesnemin yapıcı metotu çalıştı.");

            // anaTipMetot10();  AnaTip nesnemi Ogrenci2'ye kalıttıgım için(miras bıraktıgım için yani)  AnaTip'de protected olarak tanımladıgım  anaTipMetot10() 'u burda ÇAĞIRABİLDİM YANİ PUBLİC OLDU.

        }



        #endregion
    }
}
