using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
      
        {

            // ArrayList'in Generic Versiyonu

            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Sen");


            /******************************************************** ÖNEMLİ ************************************************************** 


               * GENERİCLERİ <A> <B> GİBİ YAZARIZ.YANİ <A> DEDİGİMDE SEN BUNUN GENERİC BİR TİP OLDUGUNU ANLARSIN !!!

               * <T> tipi demek .net framework içerisinde olan veya bizim oluşturdugumuz herhangi bir tip demektir. 


            */

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            //  listeGeneric.Add("masa");  // Hata alırız çünkü benim koleksiyonum SADECCE İNT DEĞERLERİ KABUL EDER.

            for (int i = 0; i <listeGeneric.Count; i++)
            {

                Console.WriteLine(listeGeneric[i]);


            }


            List<string> isimler = new List<string>();
            isimler.Add("mika");
            isimler.Add("Fatih");
            //  isimler.Add(1);

            for (int i = 0; i < isimler.Count; i++)

            {
                Console.WriteLine(isimler[i]);


            }



            List<musteri> musterListe = new List<musteri>();

            musterListe.Add(new musteri()
            {
                id = 1,
                isim = "selin",
                soyisim = "şekerci"

            });
            foreach (musteri item in musterListe)
            {
                Console.WriteLine(item.isim);
            }






















        }
    }
}
