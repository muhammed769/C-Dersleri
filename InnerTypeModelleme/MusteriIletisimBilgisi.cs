using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
   
    {
        public  string iletisimTip { get; set; }   // 717770001 : Mobil  /  717770002 : Sabit Hat 
        public string alankodu{ get; set; }

        public string numara { get; set; }

        public bool aktifPasif { get; set; }

        public void musteriiletisimbilgisiTestMetotu()
        {
            Console.WriteLine("musteriiletisimbilgisiTestMetotu");
        }
    }
}
