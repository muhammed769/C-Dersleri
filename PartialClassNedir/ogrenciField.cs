using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public partial class ogrenci    // Dosya adı ogrenciFields 'tı burada ilk başta class ognreciFields yazıyordu AMA BİZ Fields  YAZAN YERİ SİLDİK.
                                    // public partial class ogrenci  şu demek = ogrenci class'ı 2 farklı cs'de bulunan  bir partial class'dır.

    {
        public int id{ get; set; }

        public string isim{ get; set; }

        public string soyisim { get; set; }
        public string ogrenciNumarasi { get; set; }

    }
}
