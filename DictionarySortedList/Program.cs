using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D5.DictionarySortedList
{
    class Program
    {
        static void Main(string[] args)
        
        {

            #region Generic OLMAYAN KOLEKSİYON DAVRAŞI ŞU ŞEKİLDEYDİ :           

            Hashtable HTList = new Hashtable();

            HTList.Add(1, "Bir");
            HTList.Add(2, "İki");
            HTList.Add(3, true);
           // HTList.Add(1, "Test"); bu kısımda hata alırız ÇÜNKÜ key degerleri sadece ama sadece 1 kere kullanılır.

            #endregion


            #region Dictionary Koleksiyonu

            // Dictionary<Tkey,TValue>

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();

            DictionaryList.Add(1, "bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3,"Üç");
            // DictionaryList.Add(1, "Test");  // Bu kısımda hata alırız ÇÜNKÜ key degerleri sadece ama sadece 1 kere kullanılır.

            bool silmeSonuc = DictionaryList.Remove(5);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi.");
            }
            else
            {
                Console.WriteLine("Aranan deger liste içerisinde bulunamadı, Silme işlemi bşarısız.");
            }




           bool arananDegersonuc= DictionaryList.ContainsKey(1);

            if (arananDegersonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen Değer"; // Key 'i 10 olan değerin value degerini "bir" yerine "Yenilenen değer" yazdırmış olduk.
                DictionaryList[1] = gelenDeger;
            }


            else { Console.WriteLine("Aranan değer koleksiyon içinnde bulunamadı."); }

           

           bool sonuc= DictionaryList.ContainsValue("İki");

            if (sonuc)
            {
                Console.WriteLine("Aranan değer bulundu.");

            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }
            foreach (KeyValuePair<int,string> item in DictionaryList)  // var şu demektir : ne olarak dönücem sorusunu sormaya yarar.
            {
                Console.WriteLine(" Anahtar : {0}, Değer : {1}",item.Key,item.Value);  // item'ın içindeki key değerine ulaşabilirim.
            }


            DictionaryList.Clear();


            #endregion


            #region SortedList Koleksiyonu


            // SortedList DictionaryList'in yapmış oldugu her işlemi yapar.Ama aralarında ufak bir farklılık vardır.O fark şudur : 
            // SortedList key üzerinden küçükten büyüge dogru sıralama yapar.

            SortedList<int, string> sortedListKoleksiyon = new SortedList<int, string>();

            sortedListKoleksiyon.Add(100, "yüz");
            sortedListKoleksiyon.Add(40, "kırk");
            sortedListKoleksiyon.Add(6, "altı");




            #endregion





        }
    }
}
