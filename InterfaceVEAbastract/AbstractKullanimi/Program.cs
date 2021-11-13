using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.AbstractKullanimi
{
    class Program
    {
        static void Main(string[] args)
        
        {

            #region OKU

            /* Hatırlarsanız  nesne yönelimli programda biz her seyin başında  nesne oluşturduk.Daha sonra bu nesnenin içerisine field metotlar atadık.Daha sonra kalıttık, static 'leri gördük, işlemler yaptık.

            İşte TAM BU İŞLEMLERİN ORTASINDA , İŞLEMLERİMİZİ PROFESYONELLEŞTİRMEK İÇİN  ABSTRACT VE INTERFACE OLUŞTURMUŞ OLDUGUMUZ CLASS'LAR İÇERİSİNDE KULLANICAZ.

            Şimdi bir sınıf oluşturalım  oluşturdugumuz sınıfı  önce bildigimiz şekilde inceleyelim  daha sonra  bu sınıfın hayatına ABSTRACT  gelirse ne olur, bunu inceleyelim.

            */
            #endregion

            // ****************************************************   ÇOK  AMA ÇOK ÖNEMLİ     *********************************************************************
            // temelSinif T1 = new temelSinif();  // temelSinif'a ABSTRACT YAZDIGIN ZAMAN UYGULAMAYA ŞUNU DEMEK İSTİYOSUN : TEMEL SINIF ARTIK BİR ŞABLONDUR(KURAL KÜTÜPHANESİDİR.). BU YÜZDEN SEN BU temelSinif'ı ARTIK ÖRNEKLEYEMEZSİN!!!(KOPYALAMAZSIN!) 

            // SORU :  OLUŞTURMUŞ OLDUGUMUZ  temelSinif ŞABLONUMU BEN NERDE KULLANABİLİCEM ?   CEVAP = temelSinif şablonumu BAŞKA SINIFA MİRAS BIRAKARAK(KALITARAK) KULLANİBİLİRİM.

            // ABSTRACT 'TA NESNE ÖRNEGİ KALITIM YOLUYLA ALINABİLİR.


            musteri M1 = new musteri(); // BEN ARTIK temelSinif ADINI VERDİGİM ŞABLONUMU PROGRAM.CS'DE KULLANABİLİRİM.

            M1.test();



            M1.testAbstract();


            // Şimdi musteri nesneside başka bir nesneye miras bıraksın  o zaman temelSinif adındaki şablonumun içerisinde bulunan testAbract metetodu ÇALIŞCAK MI  ?  BUNU İNCELİCEZ...

            superMusteri S = new superMusteri();

            




        }
    }
}
