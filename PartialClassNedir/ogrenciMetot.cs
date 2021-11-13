using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S16.D1.PartialClassNedir
{
    public partial  class ogrenci // class ismi ogrenciMetot 'tu yani burda class ogrenciMetot yazıyordu biz burdaki Metot YAZISINI SİLDİK.
                                  // public partial class ogrenci  şu demek = ogrenci class'ı 2 farklı cs'de bulunan  bir partial class'dır.

    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("Kayıt işlemi başarılı");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine(" Ögrenci kayıdı güncellendi");
            return 1;
        }
        public int kayitSil(int id)
        {
            Console.WriteLine("Ogrenci kaydı silindi");
            return 1;
        }



    }
}
