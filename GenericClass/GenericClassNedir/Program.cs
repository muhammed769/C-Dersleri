using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir_1
{
    class Program
    {
        static void Main(string[] args)
        
        {

            /*
             * 
             * 
             * Bizim ilk önce datayı okudugumuz bir Database'imiz var VE  müşteriye vermiş oldugumuz Uygulamamız var.Bu Uygulamadanda Database'imizi yönetiyoruz.
             
               YANİ, müşteri buraya bir veri getiriyor, bir değer girişi yapıyor, bir değer sorguluyor, ya da operasyonel bir süreç başlatıyor, BİZDE BUNLARI C# İLE YAZIYORUZ.

             * Database'imiz MSSQL'DİR.Biz burda datalarımızı saklıyoruz.
              
             * MSSQL içerisinde  var olan tablo üzerinden gidelim.Mesela bir önceki derste örnegimiz müşteriydi.Yani
               
               Bizim tblMusteri adında bir tablomuz olsun.Tablo içerisindeki bazı field'ların isimleri ve veriTipleri şöyleydi :

              - id int,
              -musteriNumara uniqueidentitfy(Neye karşılık gelir ? Guid'e karşılık gelir.)
              -isim nvarchar(50)(string) (Yani nvarchar(50) string'e karşılık gelir.)
              -Soyisim nvarchar(50)   (string) 
              -dogumTarih datetime    (datetime)


             * PEKİ ben bu nesnemi c# tarafında nesne örneğini almaya çalışırken bir önceki derste yaptıgımız gibi T tipi K tipi  diye bunları ayrıştırıp  daha sonra ilgili nesnenin içerisinde  field'ları aktarmam MANTIKSIZ ZATEN örnegin  id int 
               zaten ilerde void olamaz yada dogumTarihi Datetime 'dır ben bunu string tutamam.

             * BİZİM BURDAKİ SÜRECİMİZ ASLINDA  GENERİC MİMARİYİ KULLANMA SÜRECİNİ VE ASLINDA  UYGULAMAMIZIN TASARIM DESENLERİ ANLATMAK.
              
         BİZ EĞER TASARIM DESENİ OLARAK UnitOfWorks'ü kullanıyosak : || Generic Class || Generic Interface ||Entity Framework|| DatabaseFirst || yaklasımlarından bir tanesini kullanıcaz.İŞTE GENERİC CLASS'LAR BUNLARI KULLANIRKEN BİZE YARDIM EDECEK.

               Bizim REPOSİTORY( İŞ KATMANI) ' LERİMİZİ  DAHA DİNAMİK YAZABİLMEMİZ İÇİN, BİR KERE YAZDIGIMIZ REPOSİTORY'İMİZİ  BİRDEN FAZLA KERE  FARKLI FARKLI EMPTY 'LER İÇİN  KULLANMAMIZI SAĞLAYAN  YAPILARDA, GENERİC CLASS ' LARI KULLANIRIZ.

             * Şimdi  size Generic bir Repository  örnegi vericem.Generic Repository örneginde  Generic Class 'ı anlatmaya çalışcam.
                                                    
             */

         genericRepository<Musteri> repositoryMusteri = new genericRepository<Musteri>();             // Oluşturmuş oldugum Musteri Class'ımı GenericRepository'ime  veri tipi olarak verdim.Bu ne demek ? Git database'e  Musteri'leri getir bana.

         List<Musteri> musterilerim = repositoryMusteri.Getir(); /* Dedigimde  tool type ' i oku ve orda şunu diyo : ben herhangi parametre almam ama sana List Generic koleksiyonundan Musteri nesnesi dönerim diyo...
                                                                  Görevi ne : database' e gidicek  Musteri tablosundaki kayıtları Entitiy Framework, DatabaseFirst yaklaşımlarından herhangi birini alarak  getiricek List Generic Musteri'ye çeviricek.
                                                                  VE bana ileticek.

                                                                  *  Biz demekki ne yapmıyomuşuz ? Özel olarak oluşturduğumuz TABLO CLASS'LARIMIZ YANİ BİZ BUNLARA ENTİTY (VARLIK)  DİYORUZ GENERİC OLARAK OLUŞTURMUYORUZ !!!
                                                                  
                                                                  *  Uygulama içerisinde yazmış olduğumuz  operasyonel süreçlerimizi  1 kere yazabilmek için GENERİC KOLEKSİYONLAR oluşturup ekranda gördügümüz şekilde kullanıyoruz.
                                                                   
                                                                  *  GenericRepository'imizi oluşturduk içine Musteri nesnemizi attık ve kullanacagımız bütün metotlar ne oldu ? Musteri Class'ını gören ve Musteri Class'ı üzerinde işlem yapabilen 
                                                                     bir METOT HALİNE GELDİ.

                                                                  */

            repositoryMusteri.yeniKayitEkle(null);


            genericRepository<Urun> repositoryUrun = new genericRepository<Urun>();
            repositoryUrun.Getir();                                                     // git database' e urun tablosundan  kayıtları bana List Generic Koleksiyonu olarak getir.Ben ne yapmış oldum Şimdi :
                                                                                        // genericRepository'imi 1 kere yazdım ve oluşturmuş oldugum Entitiy'leri(Varlıkları) kullanarak  database'den kayıt okumuş oldum.
                                                                                        // Getir adlı metodum ne yapıyo ?  Geriye T tipi  dönücek şekilde  bana datayı getiriyor.

            repositoryUrun.yeniKayitEkle(null);



            /* Generic Class Bilgiler :

            where ile <T> tipimizin tipini belirleyebiliriz. MESELA where T : class dedigimde  benim T tipim  bir class olmak zorunda 



            */
        }
    }
}
