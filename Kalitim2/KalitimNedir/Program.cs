using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    class Program
    {
        static void Main(string[] args)

        {

            #region Kalıtım Nedir ? (Açıklamalar)

            /*
          + Kalıtım yolu ile oluşturmuş oldugumuz nesnelerimiz birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir.
            
          + Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için(tüm nesneler object nesnesinden katıldığı için) türetilen tip kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.

          +  Uygulama içersinde gördügünüz gibi ögrenci nesnesi aslında bizim oluşturduğumuz özel bir tip ama içeride bizim ona yazmadığımız metotların olduğunu ve bunların object nesnesinden KALITILARAK(MİRAS BIRAKILARAK) gelmiştir.

          +   C# programlama dilinde oluşturmuş olduğumuz tüm nesnelerimiz default olarak türetilmeye açık olarak gelmektedir.İstersek oluşturmuş olduğumuz nesnelerimizin türetilmesini engelleyebiliriz.

          -  Uygulamalarımız veri tabanlarını oluşturacağımız zaman bazen uygulama seviyesindeki bazı ayarların kayıt bazında tutulmasının istenmesinden veya uygulamamızın içerisindeki tanımların birbirinin bazı alanlarının aynı olması nedeni ile
             tablolar aynı kolonları içerebilirler.

          -  Yazmış olduğumuz kodlarımız ise veri tabanlarımızdan data alma veya data gönderme temel görevlerini yerine getirebilmek için şemasal olarak database tiplerinin modelleri olarak oluşurlar.

          -  OOP ' da kalıtım tam bu noktada bize yardımcı olur ve sınıflarımızı tanımlarken merkezi bir mimari ile daha az ve daha merkezli kod yazmamızı sağlar.



            */
            #endregion


            temelTip T1 = new temelTip();
            T1.TemelTipMetot2();


            Egitmen E1 = new Egitmen();
            Console.WriteLine("Egitmen nesnesi örneklendi"); // YANİ DEĞER GİRİLEBİLİR HALE GELDİ.BUNUDA EGİTMEN SINIFINDAKİ YAPICI METOTLA YAPMIŞ OLDUK. 
            E1.TemelTipMetot2();


            Personel P1 = new Personel();
            Ogrenci O1 = new Ogrenci();

            #region Boxing - Unboxing işlemi (kutulama - kutudan çıkarma)

            //  object O1 = E1;             // BOXING İŞLEMİ (KUTULAMA)

            // Object kendi  veri tipinden bir değer isteyebilirdi Kİ İSTER. AMA EGİTMEN NESNESİNİ ALMASINI İSTEDİK.
            //  YANİ  ANA TİP(OBJECT) KENDİSİNDEN TÜREYEN TİPİ TANIR, KENDİ İÇİNE PARAMETRE OLARAK KABUL EDER.BİZ BUNA ''''BOXING(KUTULAMA) ''' DERİZ.

            //  E1 = (Egitmen)O1;        //   UNBOXING İŞLEMİ(KUTUDAN ÇIKARMA)

            #endregion


            #region Özel Tiplerde Boxing ve Unboxing


            #region Özel Tiplerde Boxing

            // ******ÖNEMLİ******* Bizim object nesnemiz(YANİ EN TEMEL NESNEMİZ) nedir ?  CEVAP = temelTip object nesnemizdir.(YANİ EN TEMEL NESNEMİZ temelTip'tir.)

            temelTip T2;          // SORU :  Hangi nesnelerde temelTip object görevi görür ?  CEVAP = Personel, Egitmen, Ogrenci

                                  // temelTip nesnesinden türedikleri için temelTip nesnesi bu nesnelerde object gibi davranır.


            T2 = E1;              // temelTip nesnesine Egitmen nesnesini atadık.
            T2 = P1;             //  temelTip nesnesine Personel nesnesini atadık.
            T2 = O1;            //   temelTip nesnesine Ogrenci nesnesini atadık.


            #endregion         



            #region Özel Tiplerde Unboxing

            E1 = (Egitmen)T2;      // Egitmen nesnemizi temelTip nesnesinden çıkardık.
            P1 = (Personel)T2;     // Personel nesnemizi temelTip nesnesinden çıkardık.
            O1 = (Ogrenci)T2;      // Ogrenci nesnemizi temelTip nesnesinden çıkardık.


            #endregion


            #endregion



        }
    }
}
