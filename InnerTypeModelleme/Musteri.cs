using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
     public class Musteri
    
     {

        #region Tekil olarak kullanılan field'lar
        public int musteriID { get; set; }
        public string tcKimlikNumarası { get; set; }
        public string  Isim { get; set; }

        public string SoyIsim { get; set; }

       public DateTime olusturmaTarih { get; set; }    // Ben bu müşteri ne zaman oluşturuyorum ? 
        public int kullaniciId { get; set; }

        #endregion


        #region Inner Type Gerektiren Durumlar 

        // Benim müşterimin birden fazla adresi , iletisim bilgisi olabilir.O yüzden  yeni  sınıflar açtık.

        public MusteriAdres[] musteriAdresleri;                    // ***** ÇOK ÖNEMLİ ******* : Müsteri NESNEMİZİN(SINIFIMIZIN) İÇİNDE  MusteriAdres NESNEMİZİ BİR KOLEKSİYON OLARAK TANIMLAMIŞ OLDUK.

        

        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;  // ****** ÇOK ÖNEMLİ **** MusteriIletisimBilgisi SINIFIMI Musteri SINIFIM İÇERİSİNDE BİR KOLEKSİYON OLARAK KULLANACAĞIMIZI SÖYLEMİŞ OLDUK.

        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;   //  ****** ÇOK ÖNEMLİ **** MusteriSiparisBilgileri SINIFIMI Musteri SINIFIM İÇERİSİNDE BİR KOLEKSİYON OLARAK KULLANACAĞIMIZI SÖYLEMİŞ OLDUK.


        public Musteri()                                    //  !!!!!!!!!!! ÇOK ÖNEMLİ !!!!!!!!!!!! :  YAPICI METOTLA BERABER KOLEKSİYONLARA DEĞER GİRİLEBİLİR HALE GETİRDİK.
        {
            musteriAdresleri = new MusteriAdres[5];        // MusteriAdres  koleksiyonunun  4 indeksli yani 5 elemanlı olduğunu sisteme söylemiş oldun.

            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];

            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }




        #endregion

    }
}
