using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameowork.S12.D5.BolumSonuOdevUygulamTekrar
{
    public  class Urun2:baseClass2

    {

        #region Fieldlarımız

        public string Marka { get; set; }
        public string Model { get; set; }


        #endregion


        #region AlisFiyati ,SatisFiyati ve KampanyaFiyat için KAPSÜLLEMELER


        private decimal _alisfiyati;
        public decimal alisFiyati 
        {
            get { return _alisfiyati; }

            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Alış Fiyati 0'dan küçük olamaz.");
                    
                }
                else { this._alisfiyati = value; }
                

                
            }
        }

        private decimal _satisfiyati;

        public decimal SatisFiyati 
        {
            get { return this._satisfiyati;}


            set
            {
                if (value<_satisfiyati)
                {
                    Console.WriteLine("Satış Fiyatı Alış Fiyatından küçük olamaz.");

                }
                else { this._satisfiyati = value; }
            }
        }


        private decimal _kampanyafiyati;

        public decimal KampanyaFiyati
        {
            get { return this._kampanyafiyati; }

            set
            {
                if (value<0)
                {
                    Console.WriteLine("Kampanya Fiyatı 0'dan küçük olamaz");
                }
                else { this._kampanyafiyati = value; }

            }
        }


        #endregion

        




    }
}
