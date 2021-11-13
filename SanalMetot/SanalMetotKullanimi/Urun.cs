using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
     public class Urun:baseClass
     {

        public Urun()
        {
            Console.WriteLine("ürün");
        }
        public override void ekranaYaz(string data)
        {
            //  base.ekranaYaz(data); ana kullanımı böyle geldi ama biz bunu değiştirebiliriz.Şöyle :

            Console.WriteLine("urun => " + data);
        }
    }
}
