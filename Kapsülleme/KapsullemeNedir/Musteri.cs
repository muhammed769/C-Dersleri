using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D1.KapsüllemeNedir
{
   public class Musteri

   { 


        #region Kapsülleme konusu giriş -

        // Bu aşagıda 3 tane yazdığımız şey class'ların alanlarıdır.(Field'larıdır.)
        public int id;
        public string isim;
        public string soyisim;

        private string emailAdres;

        // Class içerisindeki Property'ler (Özellikler)

        public string BenEmailAdres
        {
            // get; // database(veritabanı) veya farklı bir veri kaynağı.. class'ı çagıran programcıya  datayı göstermeye yarar.
            // set; // dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atamaya yarar.

            set
            {
                this.emailAdres = value; // value = degerimizi saklar.
            }


            get
            {
                return this.emailAdres;  // içeride private olarak saklamış oldugumuz field'ın içindeki değeri property yardımıyla ...
                                         // ... onu çağıran kişiye gönder.
            }

        }

        #endregion

        
       







    }
}
