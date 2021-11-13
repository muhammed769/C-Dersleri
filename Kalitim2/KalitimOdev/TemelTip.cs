using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D2.KalıtımOdev1
{
     public class TemelTip

    
     {

        #region Field'lar
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


        #region Yapıcı Metot(Deger girilebilir hale getiriyoruz)

        public TemelTip()
        {
            Console.WriteLine("temelTip nesnesinin yapıcı metotu çalıştı.");

            IdAtamaIslemi();
        }


        #endregion


        
        #region Standart Metot 1
        private void IdAtamaIslemi()

        {
            Random Rnd = new Random();
            this.id = Rnd.Next(1000, 9000);   //BUNU ÜSTTE YAPICI METOT'TA ÇAGIRMAM GEREKİR.

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
