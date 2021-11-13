using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerFramework.S12.D3.KalıtımOdev1tekrar
{
    class Program
    {
        static void Main(string[] args)
      
        {

            //AnaTip A = new AnaTip();


            //Egitmen2 E2 = new Egitmen2();

            //A = E2;

            //Personel2 P2 = new Personel2(); // ********* ÇOK ÇOK ÇOK ÖNEMLİ********* : Personel2 NESNEMİ BURAYA(YANİ PROGRAM.CS'E)  P2 adıyla KOPYALADIM.

            //A = P2;


            //Personel2 P2 = new Personel2();  /*  ****  ÇOK ÖNEMLİ****** BU kodu çalıştırıp F11 'e bastıgımda  personel2 sınıfının(yapıcı metotuna) gidecek ve orda TEKRAR F11 'e bastıgında Personel2 sınıfının ilk başta işlemlerini YAPMICAK,
            //                                                            ÇÜNKÜ PERSONEL2 NESNENDE MİRAS KALAN ANATİP NESNEN VAR VE ANATİP NESNENDEKİ İŞLEMLERİ ÖNCE YAPACAK SONRA  PERSONEL2 NESNENE GERİ GELECEK VE BURDAKİ İŞLEMLERİ YAPACAK!!!!!

            //                                 */


            //P2.anatiptestmetotu();

            //Ogrenci2 O2 = new Ogrenci2();
            //O2.anatiptestmetotu();


            #region Boxing-Unboxing işlemi


            //object Obj = O2;            // Boxıng işlemiydi bu kod ve  object nesnesi tüm nesnelerin anasıydı o yüzden O2 nesnemi object nesneme atadım.
            //O2 = (Ogrenci2)Obj;         // Unboxing işlemidir.

            //Obj = P2;
            //P2 = (Personel2)Obj;

            #endregion


            #region Ders Sonu(Bir sonraki ders için açıklama içerir, MUTLAKA OKU)

            /*
              NOT  : Bir sonraki videoda şunu işlicez : BEN İSTİYORUM Kİ TÜREMİŞ OLAN TİPLERİM TÜREYEMESİN...
                     OBJECT 'DEN ANATİP TÜREDİ, ANATİP' DEN EGİTMEN,PERSONEL,OGRENCİ TÜREDİ.YANİ BEN İSTİYORUM Kİ BUNLAR TÜREYEMESİN!!!            object >> AnaTip >>  Ogrenci  X
                                                                                                                                                                    >>  Personel 
                                                                                                                                                                    >>  Egitmen  X

             2.NOT : Ben bi sonraki videoda Personel TÜRESİN ama Ogrenci ve Egitmen TÜREYEMESİN İSTİCEM.Bİ SONRAKİ VİDEODA   BU DEDİGİMİZİ YAPMAK İÇİN GÖRÜŞMEK ÜZERE ...

             */

            #endregion


            #region 158.ders(Sealed anahtar kelimesi ile kalıtımı sonlandırmak)

            //Test T = new Test();  

            //T.                   // Biz böyle bir kullanım İSTEMEYİZ.ÇÜNKÜ bir nesneye miras bırakıyoruz miras bıraktıgımız nesnede başka bir nesneye miraz mırakıyor.Böyle bir kullanımı biz şuan da istemiyoruz diyelim :



            // Soru : Hangi nesnemizin kalıtılmasını istemiyoruz ?
            // Cevap: Egitmen2  nesnesinin kalıtılmasını istemiyorum.

            // Sealed Anahtar kelimesiyle YANİ en başa   public sealed class Egitmen2 :AnaTip   yazarak  biz sisteme Egitmen2 nesnesinin KALITIMININ OLMADIGI(MİRAS BIRAKAMADIGINI ) söylemiş oluyoruz.

            #endregion


            #region 159.ders(Kalıtılan nesne içerisinde kalıtım yapmak)


            //************************** ÇOK KRİTİK BİR NOKTA : ****************************

            //public sealed class Egitmen2 :Personel2  dediğimizde Egitmen2 nesnesinin SİSTEMİN TAMAMINA  MİRAS BIRAKMADIĞINI AMA PERSONEL2 NESNESİNİN  Egitmen2  NESNEME MİRAS BIRAKTIGINI SÖYLEMİŞ OLDUK.



            Egitmen2 E3 = new Egitmen2();

            // YANİ :  Gidiş : Egitmen2 ==> Personel2 ==> AnaTip ==> Object

            //         Dönüş : Object ==> AnaTip ==> Personel2 ==> Egitmen2

            #endregion


            #region 160.ders(Kalıtım ile Protected Kullanımı)

            /* Public = Uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır.
               Private = Sadece tanımlandıgı  class içerisinde ulaşılabilir anlamını taşır.
               Protected = Normal kullanımda Private olarak davranır.Kalıtım(Miras bırakma) yolu ile başka bir class içerisinde Public olarak kullanılır.


            */

            AnaTip A10 = new AnaTip();

            
                                             //  ******************************ÇOK ÖNEMLİ BİR NOKTA*****************************************

            //Ogrenci2 O2 = new Ogrenci2(); // Sen Ogrenci2 nesnende  AnaTip'de oluşturulan protected'a ulaşabildin(çünkü AnaTip ogrenci2 nesnesine kalıtılmıştı(miras bırakılmıştı) o yüzden kullanabildik) ..........
                                            // ...  AMA PROGRAM.CS DE SEN PROTECTED anaTipMetot10() METODUNA ULAŞAMAZSIN.
            //O2.

            #endregion




        }
    }
}
