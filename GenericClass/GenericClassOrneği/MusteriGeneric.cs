using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D6.GenericClass
{
    public  class MusteriGeneric<T>     /* Şimdi biz aslında MüşteriGeneric class'ına şunu söyledik : Sen MüşteriGeneric class'ı olarak örneklenirken  karşı tarafa bir soru soracaksın :
    
                                           Beni örneklemek istiyosun ama  içeride bir T tipi var , bu tipi doldur ÇÜNKÜ benim bu tipi kendi class'ım içerisinde kullanma ihtimalim var. 
                                            
                                           YANİ  BENİ(CLASS 'I)  ÖRNEKLEMEK İSTİYOSAN T TİPİNİ BELİRTMEK ZORUNDASIN.


                                      */



    {

        public T id { get; set; }
        public T musteriNumara { get; set; }

        public string TcKimlikNo { get; set; }
        public string isim { get; set; }
        public string  Soyisim { get; set; }
        public DateTime dogumTarih { get; set; }


        public T musteriNumarasiAl() 

        {

            return musteriNumara; // musteri numarası T tipinden geri gelecek.

        }

    }
}
