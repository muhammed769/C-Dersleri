using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeDevamı
{
     public class Musteri1


     {

        #region Kapsulleme Ara Odev TEKRAR  ÇOK ÖNEMLİ !!!!!!!!!!!!!!!
        private string _tcklimliknumarası;

        public string TcKimlikNumarası
        {
            get { return _tcklimliknumarası.Substring(0, 3); }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;

                    for (int i = 0; i < value.Length; i++)
                    
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);

                        if (karakterKontrol)
                        {

                            // karakterlerin hepsi sayısalmış.

                        }
                        


                        else
                        {
                            bayrak = true;
                            break;
                        }

                    }

                    if(bayrak)
                    {
                        Console.WriteLine("Tc kimlik numarası degerler sayısal olmalıdır.");
                    }

                    else
                    {
                        this._tcklimliknumarası = value;
                    }


                }
                else
                {
                    Console.WriteLine("tckimlik numarası 11 haneli olmalıdır.");
                }





            }
        }


        #endregion

        #region Kapsulleme Ara Odev ÇOK ÖNEMLİ !!!!!!!!!!!!!!!

        /*

        private string  _tckimliknumarası;

        public string TcKimlikNumarası
        {
           
            get {  return _tckimliknumarası.Substring(0,3) ; }  // Tckimlik numarasının ilk 3 hanesini bu komutla göstermiş olduk.
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;  // Bayragın default değeri false dedim  ona göre.
                    for (int i = 0; i <value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);  // value degerlerinin her bir elemanını kontrol et sayısal mı diye &&  string'in içindeki her bir karakter  char veri tipidir.
                        if (karakterKontrol)
                        {
                            // Demekki karakterlerin  hepsi sayısal değermiş.
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if(bayrak)  // Yani bayrak doğru ise
                    {
                        Console.WriteLine("Tckimlik numarası içindeki değerler sayısal olmalıdır.");
                    }
                    else
                    {
                        this._tckimliknumarası = value;
                    }
                }
                else
                {
                    Console.WriteLine("Tc Kimlik numarası 11 hane olmalıdır.");
                }
            }
        }
        */

        #endregion



        #region Kapsülleme 1.kullanımı  Tekrar: Field(alan) içerisine değer ataması yapılmasın ama değer okunabilsin.

        /*
        private int ensevrakam;

        public Musteri1()
        {
            this.ensevrakam = Bul();
        }
        public int EnSevRakam
        {
            get { return this.ensevrakam; }
            private set { this.ensevrakam = value; }
        }

        private int Bul()
        {
            Random Rnd = new Random();
             return Rnd.Next(1, 20);
        }

        */

        #endregion


        #region Kapsülleme 1.kullanımı : Field(alan) içerisine değer ataması yapılmasın ama değer okunabilsin.

        /*

        //   NOT : Burda amacım set edilemesin get edilsin.YANİ deger ataması yapılmasın ama değer okunabilsin.

        public Musteri1()  // Yapıcı metot oluşturduk.Çünkü set blogunda bir değer ataması yapılmayacagını söylemek istiyorum ve bu yüzden Yapıcı Metot'la degeri EZİCEM.
        {
            this.id = IDUret();
        }

        int id; // Eğer kodun başına public, private gibi erişim belirleyicilerini eklemezsen c# bunu PRİVATE olarak algılar.

        public int ID
        {
             get { return this.id;  }
             private set { this.id = value; } // private set yazarak kullanıcı dışarıdan bir değer atamayacak hale geldi.
        }


        public string isim;
        public string soyIsim;

        private string emailAdres;
        public string EmailAdres
        {
            set { this.emailAdres = value; }
            get { return this.emailAdres; }
        }

        private int IDUret()  // Yapıcı metot'un yanında şimdide bir metot oluşurduk.
        {
            Random Rnd = new Random();
           return Rnd.Next(100000, 900000);

        }

        */


        #endregion



    }



}
