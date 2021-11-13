using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public class Musteri : Imusteri   // Imusteri yazan yerde çıkan işarete tıkla implement interface dersen  interface ' deki field ve metotarı OTOMATİK OLARAK bu kod kısmına GELİR.
    {


        int _id;
        string _isim;
        string _soyisim;




        public int Id { get { return _id; }  set{ _id = value; } }
        public string isim { get { return _isim; }  set{ _isim = value; } }
        public string soyisim { get { return _soyisim; }  set {_soyisim = value; } }

        public int kayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("Kayit düzenlendi");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Kayit silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("  Kayit eklendi");
            return 1;
        }
    }
}
