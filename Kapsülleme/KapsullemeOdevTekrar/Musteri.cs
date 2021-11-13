using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D3.KapsullemeOdevTekrar
{
     public class Musteri

     {


        #region Kapsulleme Odevi Tekrar 

        private string tckimlikno;

        public string TcKimlikNo
        
        {

            get { return  tckimlikno.Substring(0, 3); }


            set
            {
                if(value.Length==11)

                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);  // Tckimlik numaramı her girdiğim değer sayısal mı kontrol et demektir bu kodun anlamı.

                        if (karakterKontrol)
                        {
                            this.tckimlikno = value;
                        }

                        else
                        {
                            Console.WriteLine("11 haneli girdiğiniz Tc kimlik numaranızın tamamı sayısal bir değer olmalıdır !!! ");
                            break;
                        }
                    }


                }

                else
                {
                    Console.WriteLine("Tc kimlik numaranızı eksik girdiniz.");
                }


            }

        
        }

        #endregion


     }




}

     

