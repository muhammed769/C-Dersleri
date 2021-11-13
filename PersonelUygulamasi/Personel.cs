using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public  class Personel


    {

        // Bir static field  tanımı yapalım :

        // public static string domainAdres = "firmam.com";

         public static string domainAdres ;

        public string Isim { get; set; }
        public  string SoyIsim { get; set; }

        private string _emailadres;
        public string Emailadres
        {
            get
            {
                return this._emailadres; // İçeride saklamış olduğum _emailadresi gönder.
            }

            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainAdres;  // _emailadresde yazan yazıyı ToLower ile küçük harfe çevir ; @ işaretini ekle ; static olarak  belirttigimiz domainAdres metotundaki değeri ekle. 

            }
        }


        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her Örneklemede çalışan metottur.");
        }
       
                                                                               // NOT : Standart yapıcı metot mu önce çalışır Static yapıcı metot mu önce çalışır ?  CEVAP = Static yapıcı metot önce çalışır.
        static Personel()
        {
            domainAdres = "firmam.com";   
        }



    }


}
