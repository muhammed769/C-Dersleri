using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
     public class Personel:temelTip
    
     {
        // Personel ' ait olan 3 farklı Field aynı zamanda egitmeninde Field'ı AMA Ogrencinin FİELD'I DEĞİL !!!

        #region Field'lar


        public DateTime IsBaslangıcTarih { get; set; }

        public DateTime IsBitisTarih { get; set; }

        public int IzinGunSayisi { get; set; }


        // Bu field'ları egitmen class'ınada ekledim.
        #endregion




    }
}
