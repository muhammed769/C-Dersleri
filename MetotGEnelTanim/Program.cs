   using System; // bir  Kütüphane dosyasını uygulamamızın  içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.MetotGenelTanım
{
    class Program
    {
        static void Main(string[] args)
        {

            // uzun bir şekilde yazalım :

            // System.Console.Write("merhaba");
            // using kısmında kütüphane eklenmiş hali ile yazımı şu şekıldedir : 
            // Console.Write("merhaba");

            // Selamla();  // bu kodu yazarak ben bu metodu cagırmıs oldum.

            // not :sistemi çalıştırırken once F11 SONRA F10 'LA TEST ET.



            ogrenci o1 = new ogrenci();                // ogrencı class program cs'deki ogrenci'yi buraya çagırmış oldum ve örneklemiş oldum.
                                                       //Bu örnekleme'yi ŞUAN İÇİN  ilgili metota ulaşmak için yapılan bir işlem olarak düşün.Aslında arka tarafta stack ,heap , poıntler ,ram yapıları degişiyo bunları sonraki bölümlerde anlatıcaz.


            //ŞU SEVİYEDE  bu kodla bir nesne oluşturdugumuzu bilmemiz  şuan bizim için yeterli.Yani şuan bunu bilmen bizim yeterli.

            // o1.selamlaOgrenci();        // o1 nesnemin uygulama içinde selamlaOgrenci metoduna parantez() açtıgımda selamlaOgrenci metodunun herhangi bir  parametre ALMADIGINI  ve geriye bir şey göndermedigini görebiliyoruz demektir bu kodun anlamı.


            o1.ogrenciMetot1("Mika ", "DURSUN");


        }

        static void Selamla()  // void = metot çalışcak ama  geriye herhangı bır parametre donmucek.

        {

            Console.Write("Merhaba");

        }


        // NOT : ARTIK KENDİSİNİ TEKRAR EDEN İŞLEMLERİMİZİ YADA TEKRAR ETMEYEN OPERASYONEL İŞLEMLERİMİZİ KENDİ CLASS TANIMLARINDA KÜÇÜK KÜÇÜK METOTLARA BÖLÜP İSTEDİGİMİZ ZAMAN ULAŞABİLİR DURUMDA OLUCAZ.İŞTE  O YÜZDEN METOTLAR ÇOK ÖNEMLİDİR.
    }
}
