using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    public enum musteriReturnValue // Numaralandırmalar (enumerations) kod içerisinde sayısal karşılaştırma veya işlem gerektiren yerlerde yazılımcı için daha okunabilirlik sunan, kod karmaşasını azaltan yardımcı bir yapıdır.

    {
        kayitBasarili,
        kayitBasarisiz,
        varolanMusteri,
        parametreHatasi,
        çalismaZamanHatasi

    }
}
