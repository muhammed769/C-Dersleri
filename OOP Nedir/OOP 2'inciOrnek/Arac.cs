using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.OOP2inciOrnek
{
    public class Arac
    {
        public string  marka;
        public  string model;
        public int modelYil;
        public decimal km;
        public int YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxİndirimTutar;
        public decimal Fiyat;

        public Arac(string _marka, string _model)  // Bu yapıcı metottur.
        {
            marka = _marka;
            model = _model;

        }

        public Arac(string _marka, string _model, int _modelYil)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
        }

        public Arac(string _marka, string _model, int _modelYil, decimal _km)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            km = _km;

        }


        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} , Model {1} , Model Yılı {2}", marka, model, modelYil);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal FiyatHesap = SatisFiyat - MaxİndirimTutar;
            if (_fiyat<FiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi");
            }
            else
            {
                Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }






    }
}
