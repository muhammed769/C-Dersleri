using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D4.BolumSonuOdevUygulaması
{
    public  class baseClass
    
    {


        #region Fieldlar


        public static int sayac = 1; // ilk oluştugun zaman sayac özelligi 1 degerini otomatik olarak alsın demiş olduk.

        public baseClass()
        {
            _id = sayac;          
            sayac = sayac + 1;
        }

        private int _id;
        
        public int id // id girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum.Yani öyle bir işlem yapmak istiyorum ki örnegin B1.id=1; yazdıgımda hata versin
                      // ama hiçbirşey yapmadıgımdada içeride bir id değerini takip edip bir sonraki id değerini alabilsin. Cevap = KAPSÜLLEME YAPICAZ.

        {
            get // degeri içeriden dışarıya gönderir.
            {
                return _id;
            }

             private set //  private set yazarak kullanıcıya   değer girişi İMKANINI KALDIRMIŞ OLDUK.

             {

                /* ***************************************** ÇOK ÖNEMLİİİİİİİ ÇOKKKKKKKKKKKKKK ****************************************************************
                
                * bir sayaç içerisindeki değerden faydalanmak istiyoruz.
                *  SORU = Bir nesne örneklendiginde SADECE 1 KERE ÇALIŞAN YAPININ ADI NEYDİ ? CEVAP : STATİC
                *  DOLAYISIYLA BEN İNT STATİC BİR  SAYAC PROPERTY'SİNİ  EKLERSEM İLGİLİ PROPERTY ÜZERİNDE  İŞLEM YAPIP  SAYAC DEĞERİMİ KONTROL EDEBİLİRİM.

                */
                                          
                                         // ***********************************ÇOK  AMA ÇOKKKKK KRİTİK BİR NOKTA********************************************************

                //_id = sayac;          //_id degerime aslında 1 degerini atamak istedigimi söyledim.AMA..
                //sayac = sayac + 1;    // AMA SİSTEMİ ÇALIŞTIRDIGIMIZ İD DEGERİM 2 OLMADI YANİ BİR DEĞER ATAYAMADIM ÇÜNKÜÜÜ SET ALANI PRİVATE OLARAK İŞARETLENDİ.BUNUN İÇİN STATİC YAPICI METOTUYLA id ALANIMI DEĞER GİRİLEBİLİR HALE GETİRMEM LAZIM.


             }

                }


        private string _barkod;

        public string barkod   //Buraya girmiş oldugum değer  benim sanal database'imde  olmaması gerekiyor.eger girdigim barkod sanaldatabase'imde varsa  bir uyarı cıksın yoksa barkodu kabul et.
        {
            get { return _barkod; }

            set
            {
                bool kontrol2 = sanalDatabase.dbBarkodKontrol(value);

                if (kontrol2)
                {
                    Console.WriteLine("Girilen barkod degeri  sistemde kayıtlıdır.Lütfen başka bir barkod değeri giriniz.");
                }

                else
                {
                    this._barkod = value;
                }
            }
        
        
        } 

        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici{ get; set; }
        public bool silindi { get; set; }


        #endregion







    }
}
