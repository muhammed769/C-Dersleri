using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D4.GenelOdevHocanınYaptıgı
{
    /* Ödev açıklaması : 
     1- Müşteri adında bir nesne oluşturalım ve oluşturmuş oldugumuz nesnenın içeriside static olarak ArrayList oluşturalım.

     2-Oluşturmuş olduğumuz ArrayList koleksiyonumuzu sanal bir database(veritabanı) mantığında kullanacagız.[İpucu : Static olarak oluşturdugumuz ArrayList'i Static yapıcı metodunda new ile örnekleyip ilgili koleksiyonu açmamız gerekir.]

     3-Müşteri sınıfımızın içerisine :
         +++ ID, Isim, SoyIsim, EmailAdres, KullaniciAdi, Sifre isimleri ile field'lar oluşturalım.
         +++ Oluşturmuş oldugumuz bu field listesinden bazılarının kapsülleme filtreleri aşağıdaki gibi olmalıdır:

    4-Kullanıcı adı değeri sanal olarak oluşturmuş oldugumuz  database'imiz içerisinde aransın, Eğer kullanıcı adı sanal database içerisinde bulunuyorsa field içerisine eklenmek istenen değer eklenemesin.[Kapsülleme]

    5-Müşteri Ekle adında bir static metot oluşturalım, parametre olarak müşteri tipi alsın.Metot içerisinde :
         +++ Musteri nesnesinin null olup olmadığını ve müşteri nesnesi içersindeki kullanıcı adının dolu olması şartına baksın.
         +++ Yukarıdaki kriterlerden geçerse müşterimizi sanal olarak oluşturdugumuz database'imize eklemeden önce email adresinden bir kontrol sağlasın eğer sistemde aynı email adresi ile bir müşteri değeri 
             var ise eklemesin yok ise sanal database içerisine ilgili nesneyi eklesin.

     */

     public class Musteri1
     
     {

        #region Sanal Database

            static ArrayList musteriDatabase; // NOT: musteriDatabase adındaki koleksiyonumu static yapıcı metotta new ile örneklemezsem koleksiyonum default olarak null(boş) değerini alır.

        //  ÖNEMLİ : Benim istediğim şu müşteriyi ilk çagırdıgım noktada static yapıcı metotum çalışsın ;  musteriDatabase isimli koleksiyonum  new ile örneklensin ve  YENİ KAYIT ALMAYA HAZIR BEKLESİN.Çünkü benim asıl isteğim buydu.

        /*   Soru : PEKİ NEDEN STATİC YAPICI METOT ?  Cevap : Çünkü static yapıcı metot  uygulama içerisinde ilgili nesne çağrıldığında SADECE 1  kere çalışıyordu.Bu yüzden  static yapıcı metotumu koleksiyonuma örnekliyorum.

             Eğer ben standart yapıcı  metotta örneklemiş olsaydım  her nesneyi örneklediğimde  koleksiyonum yeniden örneklenecekti ve içerisinde datayı KAYBEDECEKTİ.Bu yüzden STATİC YAPICI METOT KULLANDIK.

        */


        #endregion


        #region Static Yapıcı Metot 

        static Musteri1()
        {
            musteriDatabase = new ArrayList();  //  *******ÇOK ÖNEMLİ****** : Koleksiyonumu static yapıcı metot'uma örneklemiş oldum ve artık KOLEKSİYONUM  İÇİNDEKİ DEĞERİ KAYBETMEDEN YENİ KAYIT ALMAYA HAZIR BEKLEMİŞ OLDU.
                                                // VE artık musteriDatabase isimli koleksiyonumun default değeri null yerine Count=0 oldu yani Artık değer girilebilir hale geldi.
                                                // HATIRLATICI BİLGİ : Count : Koleksiyonumuzun içerisindeki var olan değer sayısını ifade eder.
        }

        #endregion



        #region Field'larımız (alanlarımız)

        public int Id { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string EmailAdres { get; set; }
        public  string Sifre { get; set; }

        #endregion



        #region Kapsülleme

        private string _kullaniciadi;

        public string KullaniciAdi
        {

            get
            {
                return this._kullaniciadi;
            }
            
            set    // set 'le kullanici adındaki şartımı yerine getirmem için Static Metotlar oluşturcam.
            {

                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);   // value=değer

                if (kullaniciAdiKontrol)

                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
                    this._kullaniciadi = string.Empty;  //empty = boş  ( bu kodu yazmasakta olur ama işimizi garantiye aldık.)

                }

                else
                {
                    this._kullaniciadi = value;
                }
            }
        }

        #endregion


        // Eger  metotları oluştururken erişim belirleyici yazmazsan c# bunu PRİVATE OLARAK ALGILAR.

        #region  Static Metotlar  

      static bool musteriKullaniciAdiKontrol(string _kullaniciAdi)       // bool = dogru yada yanlış bir değer döndürmeye yarar. Parametre olarak (_kullaniciAdi) yazdık çünkü _kullaniciAdi'nı kontrol etmek istiyorum.

        {

            // kullanıcı adını koleksiyonda var mı yok mu kontrol etmem gerekiyor eger koleksiyonda aynı değeri bulduysam bunu söylemem gerekiyor.Bunu şöyle yapıcaz :

            bool Kontrol = false;

            for (int i = 0; i <musteriDatabase.Count; i++)     // ArrayList obje olarak değerleri alıyodu hatırlarsan ; benim Musteri nesnem bu ArrayList içerisinde  obje olarak saklı.
                                                               // Yani burası boxing olarak duruyor benim bunu unboxing etmem gerekiyor.YANİ benim bunu musteri nesneme çevirmem gerekiyor...
            {
                // ... Bu yüzden şu kodu yazmam gerekiyor : 

                Musteri1 Temp = (Musteri1)musteriDatabase[i];  // musteriDatabase 'in  i'inci değerini  unboxing işlemiyle  çevirmiş olduk.

                if (Temp.KullaniciAdi==_kullaniciAdi) 
                {
                    Kontrol = true; // eger böyle bir kullanıcı adı varsa  ben bunu buldum diyorum.
                    break;
                }

            }


            return Kontrol;

        }

        public static void MusteriEkle(Musteri1 M1)
        {
            // Bu kısma geldiyse yeni bir müşteri tanımlandıgını biliyoruz biz.

            #region Parametre Kontrol

            if (M1!=null && ! string.IsNullOrEmpty(M1.KullaniciAdi) && ! string.IsNullOrEmpty(M1.EmailAdres))//Parametre olarak gelen değer yani M !=null (parametre olarak gelen değer eşit degilse null 'a)  VE KullaniciAdi null yada boş degilse şu işlemleri yap : 

            {

                bool EmailadresKontrol= MusteriEmailAdresKontrol(M1.EmailAdres);

                if (EmailadresKontrol)
                {

                    Console.WriteLine("Eklemek istediğiniz kullanıcı  sistemde kayıtlı.");
                }
                else
                {
                    musteriDatabase.Add(M1);
                    Console.WriteLine("Yeni kayıt işlemi başarılı.");
                }


            }
                 
            #endregion
        }


        static bool MusteriEmailAdresKontrol(string _emailAdres)
        
        
        {

            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri1 Temp = (Musteri1)musteriDatabase[i];

                if (Temp.EmailAdres==_emailAdres)
                {
                    Kontrol = true; //datayı buldum bunu ekleme diyorum.
                    break;
                }
            }
            return Kontrol;

        }

        #endregion





    }
}
