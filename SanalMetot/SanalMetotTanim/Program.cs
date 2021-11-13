using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D1.SanalMetotTanim
{
    class Program
    {
        static void Main(string[] args)
        {

            /* BaseClass içerisinde ekrana yaz adında bir metot olsa urun sınıfı içerisinde ekrana yaz
               metodu çagrıldıgı zaman baseClass içerisinde bulunan şekli ile çalışıp metot işlemini tamamlıyodu.

            İŞTE SANAL METOT ŞU İŞE YARAR :
            
            Urun sınıfında baseClass'a ait olan bir metotu degiştirebilme kabiliyetidir.

            *Şimdi sanal metot anlatımına object içerisinde bize standart olarak gelen toString metotunu inceleyerek
            başlıcaz.

            */

            #region object nesnesinden gelen ToString metodunun incelenmesi

            /* ToString metodunun kendine özgü bir çalışma prensibi var

                  ToString metodunu çagırdıgımız zaman çagrılan class'ın Namespace ve class'ın adını bize geriye döner.
                   YANİ : 

                           Musteri M1=new Musteri();
                           object => Musteri


                  M1.Tostring(); dedigimde namespace.Musteri (YANİ  NAMESPACE VE CLASS ADI(Musteri) GELİYOR .)

            * object nesnesi içerisine gelen ToString  metotu sanal bir metottur.Yani ben metotun body'sini(İÇERİGİNİ) DEĞİŞTİREBİLİRİM.


            */

            #endregion

            Musteri M1 = new Musteri();
            M1.isim = "MİKA";
            M1.Soyisim = "DERİM";


             string toStringMesaj= M1.ToString();

            Console.WriteLine(toStringMesaj);  // NetFramework.S13.D1.SanalMetotTanim.Musteri ' yazısını ekrana görürüm.


        }
    }
}
