using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerFramework.S12.D3.KalıtımOdev1tekrar
{
    public  class Personel2 :AnaTip
   
    {

        #region Fieldlar

        public DateTime ısBaslangıcTarih { get; set; }

        public DateTime ısbitisTarih { get; set; }

        public int izinGunSayisi { get; set; }

        #endregion


        #region Yapıcı metot

        public Personel2()
        {
            Console.WriteLine(" Personel2 nesnemin yapıcı metotu çalıştı.");
        }

        #endregion

    }
}
