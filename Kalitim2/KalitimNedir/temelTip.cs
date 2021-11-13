using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D1.KalitimNedir
{
    public class temelTip

    {

        #region Field'lar

        // *************** 3 tablodada ortak olan Field'larımızı buraya yazalım : ***********************
        public int id { get; set; }
        
        public string referansKod { get; set; }

        public string tcKimlikNumarası { get; set; }

        public string isim { get; set; }

        public string soyIsim { get; set; }

        public int cinsiyet { get; set; }

        public DateTime KayitTarih { get; set; }

        public int kayitKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }

        public int guncellemeKullanici { get; set; }

        public bool silindi { get; set; }

        #endregion



        #region Önemli Açıklama

        /* Şimdi benim 3 tablodada ortak olan bu field'ları diger tablolara ENTEGRE  etmem lazım.Şöyle yapıcaz : 

        ***************ÇOK ÖNEMLİ*************** :   Egitmen class'ına gidilip public class Egitmen yazan yerin yanına :temelTip yazarsak KALITIM YANİ MİRAS BIRAKMAYI YAPMIŞ OLURUZ.
        
        YANİ ARTIK temelTip İÇERİSİNDE VAR OLAN FİELD'LAR VE METOTLAR  TAMAMİYLE Egitmen CLASS'I TARAFINDAN  MİRAS ALINABİLSİN VE KULLANILABİLSİN.

        */
        #endregion



        #region Yapıcı Metot(Deger girilebilir hale getiriyoruz)

        public temelTip()
        {
            Console.WriteLine("temelTip nesnesinin yapıcı metotu çalıştı.");

            IdAtamaIslemi();
        }


        #endregion



        #region Standart Metot 1
        private void IdAtamaIslemi()
        
        {
            Random Rnd = new Random();
           this.id= Rnd.Next(1000, 9000);   //BUNU ÜSTTE YAPICI METOT'TA ÇAGIRMAM GEREKİR.
             
        }
        #endregion



        #region Standart Metot 2 

        public void TemelTipMetot2()
        {
            Console.WriteLine("Temel Tipin içerisindeki TemelTipMetot2 çalıştı.");
        }

        #endregion





    }
}
