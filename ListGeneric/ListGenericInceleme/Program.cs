using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D3.ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilarim = new List<int>();


         sayilarim.Add(1);

            // koleksiyona  aynı anda birden fazla değer eklemek istediğimizde şunu yapmamız gerekir :

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            // 1.yol ama uzun bir yol...

            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);

            //}

            // 2.yol

            sayilarim.AddRange(eklenecekData1);


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;


            sayilarim.TrimExcess();  //  ÖNEMLİ : TrimExcess() komutu count ve capacity degerlerini eşit hale getirir.

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;



            // Soru : sayilarim koleksiyonu içerisinde bulunan datayı ekrana yazdırmak, bunu nasıl yaparsınız ?


            sayilarim.ForEach(a => Console.WriteLine(a));           //  ForEach METODU 'NU yazdıgımda tool type'inde  bir action delege istiyor.delege konusunu bilmiyosun ama şu seviyede delegenin İŞ YAPAN BİR PARÇA OLDUGUNNU BİLMEN YETERLİ.

                                                                    //  burdaki a şunu ifade eder : sayilarim koleksiyonundaki her bir değere a adını verdigim isim ile ulaşıyorum.

                                                                    //  => şunu ifade eder :  ilgili koleksiyon içerisinde arama yap anlamına gelir.

                                                                    //  => linq konusu list<T> (yani listGeneric içerisinde) daha sonra detaylı görücez.



            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            int bulunanDeger=sayilarim[3];   //sayilarim koleksiyonun 3'üncü indekse karşılık gelen değeri bulunanDeger degişkenime ata diyorum.
            Console.WriteLine(" List<T> koleksiyonu içerisinde 3'üncü indekste karşılık gelen değer : {0} ", bulunanDeger );


            sayilarim.Insert(2, 260);                            //  Insert : burdaki 2 sayilarim koleksiyonumdaki 2.indeksi ifade eder 260 ise 2'inci indekse 260 değerini atadı ve 2indeksteki değer bir alta kaydı. +1 indeks eklenmiş oldu sonuc olarak.


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            bool kontrol1 = sayilarim.Any();                                       //  Any : Koleksiyon içerisinde bir değer var mı varsa true döner yoksa false döner.

            bool kontrol2 = sayilarim.Any(i => i > 5);                            // sayilarim koleksiyonumda her bir değeri  i olarak VARSAY ve bunların içinde bir araştırma yap,  i 'nin o anki degeri 5 ten büyükse yani koleksiyonda 5 ten büyük deger varsa true döndür yoksa false döndür.5 ten buyuk deger oldugu true döner.

            bool kontrol3 = sayilarim.Any(i => i > 3000);




            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            sayilarim.Sort();                                                // Sort : Koleksiyon içindeki elemanları  ya A-Z 'YE YA DA 1-N ' KADAR SIRALAR.Yani KÜÇÜKTEN BÜYÜGE DOGRU SIRALAMA YAPAR.

            sayilarim.Reverse();                                            // Reverse : Koleksiyon içindeki elemanları Z - A 'ya sıralar.Yani BÜYÜKTEN KÜÇÜGE DOGRU SIRALAMA YAPAR.


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            int enYuksekDeger = sayilarim.Max();                //  Max : İlgili koleksiyon içindeki en yüksek sayıyı bize gösterir.

            int enDusukDeger = sayilarim.Min();                //  Min : İlgili koleksiyon içindeki en düşük sayıyı bize gösterir.

            int toplamDeger = sayilarim.Sum();                // Som   :  İlgili koleksiyon içindeki tüm degerleri toplar.


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            sayilarim.Remove(260) ;                                      // Remove  : İlgili koleksiyon içindeki belirttigin değeri SİLMEYE YARAR.

            int silinenAdet=sayilarim.RemoveAll(i => i > 3);           // RemoveAll : Koleksiyon içindeki her bir değer i olarak VARSAY ve i 'nin içinde araştırma yap eger HERHANGİ BİR İ DEGERİ 3 DEN BÜYÜKSE O DEGERLERİ SİL.

            sayilarim.RemoveAt(2);                                    // RemoveAt   : Koleksiyon içindeki belirtmiş olduğumuz İNDEKSTEKİ DEĞERİ SİLER.

            sayilarim.Clear();                                      // Clear        :  Koleksiyon içindeki bütün datayı siler.



            // NOT : UYGULAMA ALANI BÖLÜMÜNE GİT , List<T> Uygulama içerisinde WİNDOWS FORMU İZLE. ( ÇÜNKÜ İLERİDE GİRECEGİMİZ MİMARİ PROJELERİN HABERCİSİ, KULLANICIMIZA NASIL BİR EKRAN TASARIMI VEREBİLİYORUZ GİBİ NEDENLERDEN DOLAYI  MUTLAKA İZLE.)
           

        }
    }
}
