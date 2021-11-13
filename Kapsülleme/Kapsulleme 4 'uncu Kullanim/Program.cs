using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D4.Kapsülleme4üncüKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m = new musteri();
            m.isim = "Musa";
            m.SoyIsim = " Çağıran";
            Console.WriteLine(m.EmailAdres);


        }
    }
}
