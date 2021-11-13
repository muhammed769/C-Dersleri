using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public  class musteri
    {

        // Field'larımız yazalım :

        public int id { get; set; }
        public string Isim { get; set; }
        public string soyIsim { get; set; }
        public string emailAdres { get; set; }


        // Metotlarımızı yazalım :

        public int yeniKayit(musteri M)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(musteri M)
        {
            Console.WriteLine("Müşteri kaydı güncellendi.");
            return 1;
        }
        public int kayitSil(int id)
        {
            Console.WriteLine("Müşteri kaydı silindi.");
            return 1;
        }
    }
}
