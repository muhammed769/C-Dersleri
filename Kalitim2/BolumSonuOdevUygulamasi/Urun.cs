using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S12.D4.BolumSonuOdevUygulaması
{
    public class Urun : baseClass   // base = Türkçe anlamı temel demektir.

    {

        #region Ürüne ait olan Fieldlar

        public string Marka { get; set; }               // BİR LİSTE İÇERİSİNDE MARKA KONTROLÜNÜ YAPICAZ.BİZİM BELİRTTÜGİMİZ MARKALAR DIŞINDAKİ BİR ÜRÜN SATAMICAK.
        public string Model { get; set; }


        private decimal _alisfiyat;

        public decimal alısFiyat                       // 0'DAN KÜÇÜK OLAMAZ
        {
            get { return this._alisfiyat; }

            set

            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0 'dan küçük olamaz.");

                }

                else { this._alisfiyat = value; }



            }

        }


        private decimal _satisfiyat;
        public decimal satisFiyat     // ALIS FİYATINDAN KÜÇÜK OLAMAZ.
        {
            get { return this._satisfiyat; }

            set
            {

                if (value < _alisfiyat)
                {
                    Console.WriteLine(" Ürünün Satış fiyatı alış fiyatından küçük olamaz.");

                }

                else { this._satisfiyat = value; }

            }
        }


        private decimal _kampanyafiyat;
        public decimal kampanyaFiyat  // KAMPANYA FİYAT DEGERİ 0'DAN KÜÇÜK OLAMAZ.
        {
            get { return this._kampanyafiyat; }
            set 
            {
                if (value<=0)
                {
                    Console.WriteLine("Kampanya Fiyatı 0'dan  küçük  veya eşit olamaz.");
                }

                else { this._kampanyafiyat = value; }
                
            } 
        }

        // NOT : YANİ 4 FARKLI KAPSÜLLEME İŞLEMİ YAPICAZ.



        #endregion



    }
}
