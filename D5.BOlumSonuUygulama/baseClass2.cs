using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameowork.S12.D5.BolumSonuOdevUygulamTekrar
{
     public class baseClass2
   
     {


        #region Fieldlarımız

        public DateTime Olusturmatarihi { get; set; }

        public DateTime Guncellemematarihi { get; set; }

        public int olusturanKullanici{ get; set; }

        public int guncelleyenKullanici { get; set; }

        public bool Silindi{ get; set; }


        #endregion


        #region id için KAPSÜLLEME

       public static int sayac = 1;
        public baseClass2()
        {
            id = sayac;
            sayac = sayac + 1;
        }

        private int _id;

        public int id
        {
            get { return _id; }

           private set
            {
                //
            }

        }


        #endregion


        #region

        private string _barkod;

        public string barkod
        {
            get { return this._barkod; }

            set
            {
                bool kontrol2 = sanalDatabase.ArBarkodKontrol(value); // sanalDatabase nesnemdeki ArBarkodKontrol metotundan gelen değeri  kontrol2 ile kontrol et.

                if (kontrol2)

                {
                    Console.WriteLine("Girilen barkod değeri sistemde kayıtlıdır.Lütfen başka bir barkod değeri giriniz.");
                }

                else { this._barkod = value; }
                

                
            }
        }

        #endregion



    }
}
