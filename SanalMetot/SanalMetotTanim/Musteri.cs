using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotTanim
{
    public class Musteri // : object yazmayız ÇÜNKÜ FRAMEWORK STANDART OLARAK TÜM NESNELERİ OBJECT'TEN TÜRETİYOR.
    
    {
        public  int musteriId { get; set; }

        public   string isim { get; set; }
        public string Soyisim { get; set; }

        // NOT : Override anahtar kelimesi kullandıgımız metotun tüm SANAL METOTLARININI BİZE GÖSTERİR.


        /*           *********************************ÖNEMLİ*********************************

         overrride yazıp seçeneklerden Tostringi seçersem bu aşagıdaki kodun TAMAMI otomatik olarak gelir.
         bu kod'da return base.ToString() kısmını düzeltebiliriz. [base = objecti ifade eder.][normalde base kalıtılan kalıtılan class'ı gösterir.]

         public override string ToString() 
         {
             return base.ToString();
         }

         */


        public override string ToString()
        {

            return isim + " " + Soyisim;    /* *****************ÇOK AMA ÇOK ÖNEMLİ*********************

                                            * Ben ne zaman ToString() metotunu çağırsam  bana ilgili müşterinin...
                                            ... isim ve soy isim bilgilerini bu şekilde versin demiş olduk.

                                            */
        }
    }
}
