using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerFramework.S12.D3.KalıtımOdev1tekrar
{
   public   sealed class Egitmen2 :Personel2  

   {

        #region Fieldlar

        public string brans{ get; set; }
        public string bransSeviye { get; set; }


        public Egitmen2()
        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metotu çalıştı.");
        }
        



        #endregion






   }
}
