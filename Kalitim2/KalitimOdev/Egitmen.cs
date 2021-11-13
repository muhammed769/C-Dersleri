using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalıtımOdev1
{
   public     class Egitmen:TemelTip
    
    {

        #region Field'ları

        public string brans  { get; set; }

        public int Bransseviye { get; set; }
        public DateTime ısbaslangıcTarih { get; set; }
        public DateTime isbitisTarih { get; set; }
        public int IzinGunSayisi { get; set; }

        #endregion

        #region Yapıcı metot(Değer giriliebilir Hale getiriyoruz.)

        public Egitmen()

        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metotu çalıştı.");

        }

        #endregion









    }
}
