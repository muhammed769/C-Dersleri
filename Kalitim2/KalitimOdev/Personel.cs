using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalıtımOdev1
{
     public class Personel:TemelTip
    
     {

        #region Field'lar

        public int izinGunSayisi { get; set; }
        public DateTime IsBaslangıcTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
       

        #endregion


        public Personel()
        {
            Console.WriteLine("Personel nesnesinin yapıcı metotu çalıştı.");

        }

    }
}
