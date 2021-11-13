using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerFramework.S12.D3.KalıtımOdev1tekrar
{
   public  class AnaTip
    
   {


        #region Fieldlar

        public int Id { get; set; }

        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string TcNo { get; set; }

        public int referanskod { get; set; }
        public int cinsiyet { get; set; }
        public DateTime KayitTarif { get; set; }


        public DateTime guncellemeTarih { get; set; }


        #endregion



        #region Yapıcı Metot

        public AnaTip()

        {
            Console.WriteLine("AnaTip nesnesinin yapıcı metotu çalıştı.");
            IdAtamaIslemi();

        }
        #endregion


        #region Standart Metot 1


        private void IdAtamaIslemi()
        
        {
            Random Rnd = new Random();
            this.Id = Rnd.Next(2500, 6000);

        }


        #endregion

        
        #region Standart Metot2

        public void anatiptestmetotu()
        {
            Console.WriteLine("Ana tip nesnemdeki  anatiptestmetotu çalıştı.");
             //anaTipMetot10();  Protected oldugu için program.cs içerisinde private gibi davranır.Yani Program.csde Protected ile oluşturdugun metotu ÇAGIRAMAZSIN.AMA BU CLASS İÇERİSİNDE ÇAGIRABİLİRSİN.
        }

        #endregion



        #region Protected Standart Metotu

        protected void anaTipMetot10()
        {
            Console.WriteLine("Protected Metot.");
        }


        #endregion





    }
}
