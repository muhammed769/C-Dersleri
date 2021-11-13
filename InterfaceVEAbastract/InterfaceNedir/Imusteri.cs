using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S15.D1.InterfaceNedir
{
    public interface Imusteri
    
    
    {



        /* ************************************************************************************ÇOK AMA ÇOK ÖNEMLİ AÇIKLAMALAR *****************************************************************************************************
       
        * interface ' de YAPICI METOT(ctor) KULLANAMAZSIN.(YANİ NESNE ÖRNEĞİ ALINMADIGINI BURDA GARANTİ ETMİŞ OLUYORUZ.)
        
        * Abstract ile interface arasındaki fark interface'in TAMAMEN ŞABLON İÇERİGE SAHİP OLMASIDIR.
         
        * Abstract içerisinde ben standart bir  metot oluşturabiliyorum AMA interface 'de STANDART METOT YADA YAPICI METOT  OLUŞTURAMAM !!!!!!!!!!!!!!

        * interface'in bütün tanımları şablondur bir başka deyişle interface'in bütün tanımları kuraldır.
        
        * interface'de nesne örnegi KALITIM YOLUYLA BİLE OLSA HİÇBİR ŞEKİLDE  ALINAMAZ !!!!!!  [ ABSTRACTA NESNE ÖRNEGİ KALITIM YOLUYLA ALINABİLİYORDU.]
        
        * interface'in içerisinde  şunlar vardır : 
              
             1- Fieldlar 

             2- Metotlar

             3- Delegate
        
                    vb.. daha görmediğimiz bir çok şey interface içerisinde yer alır !!!

        * Biz şuan interface'in içerisindeki Fieldları ve Metotları anlatıcaz.Digerlerini ilerleyen seviyelerde anlatıcaz. 

        */



        #region  1 - Fieldlar

        /*  ******************************************************************  ÇOK ÖNEMLİ  *********************************************************************

         * public int Id { get; set; }    Bu kodu yazdıgımızda hata alırız ÇÜNKÜ burası bir infterface dolayısıyl PUBLİC 'İ YAZMAYA GEREK YOKTUR.
      
        * int Id;  Bu kodu yazdığımızdada hata alırız ÇÜNKÜ interface bu haliyle bu degişkeni tanımaz  ama { get ; set; } ekledigimizde yani property ekledigimizde interface o zaman bu property 'ler üzerinden degişkeni tanımlar.

        */


        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }


        #endregion


        #region 2 - Metotlar

        int yeniKayit(string isim, string soyisim);      /* ***************************************  ÖNEMLİ **************************************************

                                                         * ınterface'in metotlarının bodyleri yani bunlar { }  OLMAZ !!!!!!!! Body'ler yani bunları { }   bir sınıf içerisinde doldururuz.
                                                         * 
                                                         *  YANİ BİZ SADECE METOTLARIN İMZALARINI OLUŞTURDUK BODY'LERİNİ İSE BİR SINIF İÇERİSİNDE DOLDURURUZ.

                                                         */
        int kayitDuzenle(int id, string isim, string soyisim);

        int kayitSil(int id);

        #endregion








    }
}
