using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
     public class Egitmen:temelTip
   
     {


        #region Sadece Eğitmene ait olan FİELD'LAR

        public string Brans { get; set; }
        public int BransSeviye  { get; set; }

        public DateTime IsBaslangıcTarih { get; set; }

        public DateTime IsBitisTarih { get; set; }

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
