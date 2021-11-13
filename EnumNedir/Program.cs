using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        
        {

            // SORU : Enum neden kullanılır ? CEVAP : Numaralandırmalar (enumerations) kod içerisinde sayısal karşılaştırma veya işlem gerektiren yerlerde yazılımcı için daha okunabilirlik sunan, kod karmaşasını azaltan yardımcı bir yapıdır.

            // Kod yazarken sade ve temiz bir şekilde yazmalıyız.Dolayısıyla bir kurgumuzun olması lazım.



            Musteri M1 = new Musteri();

            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "MİKA";
            M1.Soyisim = "cevizli";
            M1.emailAdres = "mikacevizli.com";

            
          
              sanalDatabase SB = new sanalDatabase();
              musteriReturnValue musteriKayitSonuc= SB.musteriYeniKayit(M1);
                                                   
                                                            
                if (musteriKayitSonuc==musteriReturnValue.kayitBasarili)

                { 

                }
            

                
        }
    }
}
