using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D4.BolumSonuOdevUygulaması
{
   public static  class sanalDatabase
    
   {

        #region Barkod alanı için sanalDatabase

        private static ArrayList db;


        #endregion



        #region SanalDatabase 'i deger girilebilir hale getircez:

        static sanalDatabase()
        {
            db = new ArrayList();  // 2.BİR YOL =  ÜSTTE private static ArrayList db= new ArrayList(); DİYEREKTE SANALDATABASE'İMİZİ DEĞER GİRİLEBİLİR HALE GETİREBİLİRDİK.HANGİ YOLU İSTERSEN ONU YAPABİLİRSİN !!!
        }

        #endregion


        
        #region Standart Metot(yeniUrunEkle) metodu
        public static void yeniUrunEkle(baseClass data )       /* ************************************ÇOK ÖNEMLİ BİR NOKTA***************************************
                                                                   yeniUrunEkle(baseClass) yazarak baseClass sınıfından türeyen ne varsa erişim saglayabilirim ---- yeniurunEkle(Urun) yazsaydım Urun sınıfından türeyen ne varsa erişim sağlardım.
                                                                   YANİ BEN baseClass NESNEMİ  BURAYA data İSMİYLE ÇAGIRDIM.

                                                               */
            
         {

            if (data !=null && ! string.IsNullOrEmpty(data.barkod))

            {
                db.Add(data);
            }


         }
        #endregion


        #region Barkod Kontrolü için Yaptıgımız Metot

        public static bool dbBarkodKontrol(string barkod)

        {
            bool kontrol2 = false;

            if (db!=null && db.Count>0)

            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseClass bc = (baseClass)db[i];

                    if (bc.barkod==barkod)
                    {
                        kontrol2 = true;
                        break;
                    }

                }

            }


            return kontrol2;
        }

        #endregion


    }


}

