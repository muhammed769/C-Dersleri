using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Yenilikler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dynamic anahtar kelimesi
            
            // dynmaic anahtar kelimesi var anahtar kelimesinden farklıdır.
            // dynamic tipinde bir değişken tanımladıgında bunu diyelim string bir değer atadın.Hemen altında bu degişkene int bir değer atayabilirsin.
            
            dynamic deger1 = 3;
            deger1 = "Mika";

            deger1 = new // Ayrıca hatırlayalım diye burdada isimsiz bir tip tanımlaması yapmış olduk.
            {
                isim = "İrem"
            };

            #endregion


            #region Tuple Kullanımı

            var selamlaDegerlerII = SelamlaII();
            Console.WriteLine(selamlaDegerlerII.isim);
            Console.WriteLine(selamlaDegerlerII.soyisim);


            Tuple<string, string, int, bool, Araba, string, string> tupleKullanimiI =
            new Tuple<string, string, int, bool, Araba, string, string>("Mika", "Desen", 69, true, new Araba() { }, "İzmir", "Azerbaycan");

            Console.WriteLine(tupleKullanimiI.Item6); // Ekranada İzmir yazar.

            #endregion


            #region Try Catch de  When Kullanimi ( When : Hataları kategorize edebilmemize yarar.)

            try
            {
                //  .. Kodlarımız var.
                throw new FormatException("Format Hatası");
                throw new FormatException("Format "); // 1'inci FormatException 'a girmez 2'inci FormatException'a girer.çünkü Format Hatası yerine SADECE Format Yazılmış ! ! !
            }

            catch (FormatException fe) when (fe.Message == "Format Hatası") // Format Exception içerisinde hatada Eger " Format Hatası " yazıyorsa 
                                                                            // GEL BURDAKİ FormatException 'u çalıştır.
            {
                Console.WriteLine(fe);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            #endregion


            #region String Interpolition(Verileri Ekrana yazdırmak)

            // ****************************** String Interpolition NEDİR ? *******************************************************

            string isim = "Mika";
            string soyisim = "Desen";

            Console.WriteLine(" Merhaba" + isim + " " + soyisim);  // bu şekilde Console'e yazdıklarımızı birleştirebiliriz.
                                                                   // YA DA 

            string karsilamaMetin = string.Format("Merhaba {0} {1}", isim, soyisim);  // bu şekilde de Console'e yazdıklarımızı birleştirebiliriz.
            Console.WriteLine(karsilamaMetin);

            // YA DA 

            Console.WriteLine(string.Format("Merhaba {0} {1}", isim, soyisim));

            // **********************Eski konularımızda böyle yapıyoduk.Şimdi String Interpolition' la nasıl yaparız bunu görücez . **********************************

            Console.WriteLine($"Merhaba {isim } - {soyisim} ");  //  ÖNEMLİ  :  $ işaretini String Interpolition kullanacagımızı belirtir.

            #endregion


            #region Var anahtar kelimesi ( LINQ bölümüne hazırlık )

            var meslek = " Bilgisayar Programcısı ";

            meslek.ToString();   // meslek degişkenin karşısına yazdıgımız datanın string oldugunu C# anladı ve biz artık meslek degişkenini kullanarak 
                                 // string veri tipinin bütün özelliklerini kullanabiliriz.BUNU VAR ANAHTAR KELİMESİNİ KULLANARAK YAPARIZ !

            var kategori = 12;
            kategori = 3;   // Burdada aynı mantık vardır.

            #endregion


            #region Var anahtar kelimesi ile İsimsiz Tip Kullanımı

            Musteri m = new Musteri();
            m.isim = "Mika";
            m.soyisim = "Desen";

            // Bu yaptıgımız kullanılım İSİMLİ TİP KULLANIMI



            var v = new
            {
                numara = 1,
                isim = "Mika",
                soyisim = "Desen"

            };

            Console.WriteLine(v.soyisim);


            #endregion


            #region Local Function(Metot içerisinde Metot tanıyabilme kabiliyetidir)

            // Local Function : Metot içerisinde Metot tanıyabilme kabiliyetidir.


            int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            int CarpimSonucu = Carp(20, 5);
            Console.WriteLine(CarpimSonucu);

            // ÖNEMLİ : Gördügün gibi metot içerisinde metot tanımlayıp işlemlerimizi yapabiliriz.( BUNADA İŞTE LOCAL FUNCTİON DİYORUZ.)

            #endregion


            #region Metot parametrelerinde  Default değer ataması 

            int sonuc = CarpCarp(13, 10);
            Console.WriteLine(sonuc);

            #endregion        

        }
        static int CarpCarp(int sayi1, int sayi2 = 1) // Burayı İyi ANLA.sayi2 'ye herhangi bir değer GİRİLMEZSE değeri 1 'dir demiş olduk ve aşagıdaki if'li kısmı sildik.

        {                                           // ÖNEMLİ : Default değer atamasını KESİNLİKLE AMA KESİNLİKLE EN SON'A YAZMAK ZORUNDASIN YOKSA HATA ALIRSIN ! ! !
            //if (sayi2 == 0)
            //    sayi2 = 1;
            return sayi1 * sayi2;
        }

        static (string isim, string soyisim) SelamlaII() // Buda aslında bir Tuple'dır.
        {
            return ("Nejat" , "Boy");
        }
    }
}
