using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D4.HashTableOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashTable ÖDEV

            // HashTable içerisine ENG-TR olarak data ekle.

            // Yeni kayıt eklemek istiyor musunuz E/H
            // E: Yeni kayıt ekleme işlemi devam etsin.
            // H: Tüm listeyi yazdırın.
            // Var olan bir key degeri ekliyor ise kullanıcıya bu deger daha önceden sistemimizde bulunmaktadır yazsın.

            Hashtable Dil = new Hashtable();

            do
            {
                Console.Clear();

                Console.WriteLine("Eklemek istediginiz dil koleksiyonumuz için  deger  giriniz :");

                Console.Write("EN :");
                string eng = Console.ReadLine();


                bool kontrol = Dil.Contains(eng);

                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediginiz deger {0} dil içerisinde bulunmaktadır.{1} degerin Türkçe karşılıgıdır.", eng, Dil[eng].ToString());

                }
                else
                {
                    Console.WriteLine("{0}  ingilizce degerinin türkçe karşılıgını yazınız: ",eng);
                    string tr = Console.ReadLine();
                    Dil.Add(eng, tr);
                    Console.WriteLine("Deger ekleme işlemi başarılı.");
                }
                Console.WriteLine("Yeni Deger eklemek istiyor musunuz : (E/H)");

                
 } while (Console.ReadLine().ToUpper() !="H");

             // 1.YÖNTEM :

            foreach (var item in Dil.Keys)

            {
                Console.WriteLine(" ENG : {0} = TR :{1} ", item, Dil[item]);

            }

            // 2.YÖNTEM :

            foreach (DictionaryEntry item in Dil)
            

           {
                //Console.WriteLine(item.GetType().Name);
                Console.WriteLine(" ENG : {0} = TR :{1} ", item.Key, item.Value);
            }
            




            #endregion




        }
    }
}
