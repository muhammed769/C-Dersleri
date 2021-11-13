using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir_1
{
    public class Musteri
   
    {

        public int id { get; set; }
        public Guid musteriNumara { get; set; }

        public string isim { get; set; }
        public string soyIsim { get; set; }

        public DateTime dogumTarihi { get; set; }


        // Class ' a Generic bir Field eklemedik, Generic bir kullanım gerçekleştirmedik  ÇÜNKÜ ZATEN BUNLAR SQL TABLOMUN BİR KOPYASIDIR.

    }
}
