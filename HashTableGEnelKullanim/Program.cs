using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D3.HashTableGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();


            #region Yeni Deger Ekleme

            // H1.Add(object key, object value)  key=key degerleri Liste içinde dataya ulaşmak için kullandıgımız anahtar kelimelerdir ve 1 defa kullanılır.

            H1.Add("Car", "Araba");
            H1.Add("Home", "Ev");

            H1.Add("Cars", "Araba");
          //   H1.Add("Cars", "Araba"); // BU kısımda hata alırız çünkü KEY Anahtar kelimesi(Yani burda Cars olan kelime) 2 kere kullanılmaz.
                                     //SADECE VE SADECE KEY ANAHTAR KELİMESİ 1 DEFA KULLANILIR.


            #endregion


            #region Yardımcı Metotlar
            bool kontrol1 = H1.Contains("Car"); // Car anahtar kelimesi(YANİ key) H1 listesinde mi  demektir bu kod. 
            bool kontrol2 = H1.Contains("Pencil");

            bool kontrol3 = H1.ContainsKey("Cars"); // ContainsKey Contain ile birebir  aynı işlevi görür.
            bool kontrol4 = H1.ContainsValue("Araba");  // Value degeri H1 listemizde mevcut mu demektir bu kod.



            //Peki ben koleksiyon içinde bir düzenleme yani bir degeri degiştirmek istersem şunu yapmam gerekir :
            H1["Home"] = "Yazlık";




            H1.Clear();  //Koleksiyon içindeki tüm datayı siler.

            int koleksiyonicindekiToplamDeger = H1.Count;

            H1.Remove("Cars"); // H1 koleksiyonumuz içindeki Cars keyini siler.

            #endregion


        }
    }
}
