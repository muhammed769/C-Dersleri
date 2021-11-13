using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.LinqTeknolojisi
{
    class Program
    {
        
        static bool funcDelegateKullanimi1(Musteri m) // Linq sorgularında Delegate KULLANIMI  Func Delegate konu başlıgı  için bir metot oluşturduk : 
        {
            if (m.isim[0] == 'A')
                return true;

            else
                return false;
        }  


        static bool predicateDelegateMetot(Musteri m )
        {
            if (m.dogumTarih.Year > 1990)
                return true;
            else
                return false;
        } // Linq sorgularında Delegate KULLANIMI  Predicate  Delegate konu başlıgı  için bir metot oluşturduk : 

        

        static void  musteriActionListe(Musteri m) // Linq sorgularında Delegate KULLANIMI  Action  Delegate konu başlıgı  için bir metot oluşturduk :
        {
            Console.WriteLine(m.isim+ ""+ m.soyisim);
        }



        static void Main(string[] args)
        {

            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();


          #region Ödevler 

            // Müşteri listesi içerisinde bulunan kayıtlardan ismi a ile başlayan soyisim değerinin içinde e olan ve doğum yılı 1985 'den büyük olan kayıtları getirin.


            var odevAlistirma1 = from I in musteriListe
                                 where
                                 I.isim.StartsWith("A") &&
                                 I.soyisim.Contains("e") &&
                                 I.dogumTarih.Year > 1985
                                 select I;

            Console.WriteLine(odevAlistirma1.Count());


            var odevAlistirma2 = musteriListe.Where(x => x.isim.StartsWith("A") && x.soyisim.Contains("e") && x.dogumTarih.Year > 1985);

            Console.WriteLine( odevAlistirma2.Count());

           #endregion


          #region Linq sorgularında Delegate kullanımı = Action Delegate(ForEach)

            // ForEach = ilgili Data içerisinde dönmemizi sağlar.

            // En uzun yol : ------------------------------------------------------------------------------------------------------

            Action < Musteri > actionMusteri = new Action<Musteri>(musteriActionListe);

            musteriListe.ForEach(actionMusteri);

            // ---------------------------------------------------------------------------------------------------------------------

            musteriListe.ForEach(new Action<Musteri>(musteriActionListe));

            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine(m.isim + "" + m.soyisim); } );

            musteriListe.ForEach((Musteri m) => { Console.WriteLine( m.isim + "" + m.soyisim); });



         // En kısa yol : ------------------------------------------------------------------------------------------------------

                          // Diger delegate'lerden farkı : Bunun en kısa yolu  EN FAZLA BU KADAR KISALABİLİR.

            musteriListe.ForEach((m) => { Console.WriteLine(m.isim + "" + m.soyisim); });



            #endregion


          #region Linq sorgularında Delegate kullanımı = Predicate Delegate(Find All)

            // Burdada aynı şekilde ilerleyeceğiz EN UZUN OLDAN EN KISA YOLA DOĞRU : ---------------------------------------------------

            // Func delegate geriye Sadece bool DÖNMEZ ama Predicate delegate geriye SADECE bool DÖNER.ARALARINDAKİ TEK FARK BUDUR ! 

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);

            var DelegateKullanimiPredicate1 = musteriListe.FindAll(predicate);

            //---------------------------------------------------------------------------------------------------------------------------------

            var DelegateKullanimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegateMetot));

            var DelegateKullanimiPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.dogumTarih.Year > 1990; } );

            var DelegateKullanimiPredicate4 = musteriListe.FindAll((Musteri m) => { return m.dogumTarih.Year > 1990; } );

            var DelegateKullanimiPredicate5 = musteriListe.FindAll((M) => { return M.dogumTarih.Year > 1990; });

            // En son ve En kısa kullanımı bu şekildedir : 

            var DelegateKullanimiPredicate6 = musteriListe.FindAll(M => M.dogumTarih.Year > 1990);


            #endregion


          #region Linq sorgularında Delegate kullanımı = Func Delegate ( Where)

            var DelegateKullanimi1 = musteriListe.Where(i => i.isim.StartsWith("A")).Count();

                        // Bu => (Lamda) operatörüyle yazdıgımız kısa kullanışlı kod blogudur.Şimdi ise uzun bir şekilde YANİ =>(Lamda) operatörünü KULLANMADAN  kod yazıcaz : 

             // En uzun yol : --------------------------------------------------------------------------------------------------

            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);
            var DelegateKullanimi2 = musteriListe.Where(funcDelegate1);
            DelegateKullanimi2 = musteriListe.Where(funcDelegateKullanimi1);


            // ------------------------------------------------------------------------------------------------------------------

            var DelegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));

            var DelegateKullanimi4 = musteriListe.Where( delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; } );

            var DelegateKullanimi5 = musteriListe.Where((Musteri M) => { return M.isim[0] == 'A' ? true : false; });

            var DelegateKullanimi6 = musteriListe.Where((m) => { return m.isim[0] == 'A' ? true : false; });

            //  Son Kullandıgımız yöntem ise ŞUYDU : 

            var DelegateKullanimi7 = musteriListe.Where(x => x.isim[0] == 'A');


            #endregion


          #region Alistirmalar

            //-------------------------------- 1 : musteriler içerisinde ülke degeri A ile başlayan Linq  to metot kullanarak bulalım. ------------------------------------------------------------------------

            int alistirma = musteriListe.Where(b => b.ulke.StartsWith("A")).Count();
            Console.WriteLine(alistirma);
            
            // Hocanın Yaptıgı  :         IEnumerable<Musteri> guzelAlıstırmalar  =  musteriListe.Where(b => b.ulke.StartsWith("A")).Count();  ( IEnumerable<Musteri> = geldigi gibi karşıladık.)
            // Console.WriteLine(guzelAlıstırmalar.Count());

            var alistirma1 =           (from Y in musteriListe
                                       where Y.ulke.StartsWith("A")
                                       select Y).Count();


            // ------------------------------  2 : musteriler listesi içerisindeki kayıtlardan isminin içinde b harfi geçen VE(&&) ulke değeri içinde A harfi geçen müşterilerin listesini getirin.------------------------

            // Hocanın yaptıgı  :

            var musteriListealistirma2 = musteriListe.Where(i => i.isim.Contains("B") && i.ulke.Contains("A")).ToList();

            // Benim yaptıklarım : 

                              int alistirma2 = musteriListe.Where(i => i.isim.Contains("B") && i.ulke.Contains("A")).Count();
                              Console.WriteLine(alistirma2);

                              var alistirma2I = (from x in musteriListe
                              where
                              x.isim.Contains("B")
                              && x.ulke.Contains("A")
                              select x).Count();

                              Console.WriteLine(alistirma2I);


            // 3 : musteriler listesi içerisindeki kayıtlardan  doğum yılı 1990 dan büyük olan ve isminin içerisinde a harfi geçen müşterileri II.YOL OLAN LİNQ TO QUERY İLE BULALIM...


                         // HATIRLATMA :  Ben bu II.YOL OLAN LİNQ TO QUERY 'i üstteki 2' inci örnekte KENDİM UYGULAMIŞTIM.

            var alistirma3 = (from h in musteriListe
                              where
                              h.dogumTarih.Year > 1990 
                              &&
                              h.isim.Contains("A")
                              select h).Count();

            Console.WriteLine(alistirma3);



            // 4 : musteriler listesi içerisindeki kayıtlardan  doğum yılı 1990 dan büyük olan VEYA isminin içerisinde a harfi geçen müşterileri II.YOL OLAN LİNQ TO QUERY İLE BULALIM...

            var alistirma4 =
                            (from i in musteriListe
                             where i.dogumTarih.Year > 1990 || i.isim.Contains("A")
                             select i).Count();

            Console.WriteLine(alistirma4);                            

            #endregion


          #region Linq Sorgulama Çeşitleri

            // ******************************************************************************* I.YOL: METOTLAR İLE SORGULAMA ********************************************************************************************

            int toplamMusteriAdet1 = musteriListe.Where(I => I.isim.StartsWith("A")).Count();

            /* I yazarak musteriliste içerisinde bir arama gerçekleştirmek istedigimi söyledim. Ve her bir elemanımı ben I adında isimlendirdim.      
             * => İçerisinde ARA anlamındadır.
             * İkinci I : Neyin içerisinde ARA ? Musteri içerisinde ARA, Peki kriterim NE ?
             * I.isim.StartsWith("A") : Müşterinin adı başlıyorsa ? Neyle başlıyorsa ?  "A"  ile başlıyorsa  sen bu müşterileri bul.
             * Bu şarta uyan toplam  adedine yani Count'una ihtiyaç duyuyorum.

            */

         // ******************************************************************************* II.YOL: QUERY İLE SORGULAMA **********************************************************************************************

            var toplamMusteriAdet2 = (from I in musteriListe
                                      where I.isim.StartsWith("A")
                                      select I).Count();

                                     /* (from I in musteriListe : musteriListe içerisinde elemanların hepsi I olsun
                                      *  where I.isim.StartsWith("A") : isim değerlerim A ile başlıyorsa 
                                      *  select I).Count(); : Sen bu şarta uyan I degerlerini bana getir.
                                      */

                                     #endregion


          #region Linq GELMEDEN ÖNCE

                                     // A ile başlayan müşterilen adedini verin.

                                     //int bulunanToplam = 0;
                                     //for (int i = 0; i < musteriListe.Count; i++)
                                     //{
                                     //    if(musteriListe[i].isim[0]=='A')
                                     //    {
                                     //        bulunanToplam++;
                                     //    }

                                     //}
                                     //Console.WriteLine(" Liste içerisinde isim değeri A ile başlayan kayıt sayısı şudur : {0} ", bulunanToplam);

                                     //Console.WriteLine(musteriListe.Count);
                                     //Console.ReadLine();


                                     #endregion


          #region Linq GELDİKTEN SONRA

                                     //int bulunanToplam = 0;
                                     //bulunanToplam = 0;

                                     //bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count();

                                     //Console.WriteLine(" Liste içerisinde isim değeri A ile başlayan kayıt sayısı şudur  {0} ", bulunanToplam);
                                     //Console.ReadLine();


                                     #endregion


        }
    }
}
