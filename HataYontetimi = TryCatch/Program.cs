using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.HataYönetimi.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //  MerhabaHataYönetimi();
            HataYonetimiInceleme();
        }
       static  void MerhabaHataYönetimi()

       {
            Console.WriteLine("Bir sayı girişi yapınız : ");
            int sayi1 = int.Parse(Console.ReadLine());
       }


        static void HataYonetimiInceleme()
        {
            try
            {
                //  Standart uygulama için yazmış oldugumuz kod blokları buraya yazılır.

                Console.WriteLine("Bir sayı girişi yapınız : ");
                int sayi1 = int.Parse(Console.ReadLine());

                if(sayi1==10)
                {
                    throw new OzelHataSinifi();   // throw anahtar kelimesiyle benim belirledigim bir hatayı fırlatıyorum.
                }

            }
      catch (OzelHataSinifi ft) // Eger bunu OzelHataSinifi bu catch blogunda yazmasaydık ne olurdu ? catch(Expection ex) ' e yani EN BASE 'E GİDER.
            {
                Console.WriteLine(" Özel hata sınıfı catch içerisinde yakalandı. ");
            }

             catch(FormatException ft)
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir.");
                Console.WriteLine(ft.Message);
            }

            catch (Exception ex)  // HATA YÖNETİMİNDE EXCEPTİON CLASS'I BASE CLASS'DIR.(YANİ HER HATA EXPECTİON SINIFINDA TÜREMİŞTİR.)
            {
                /* Sistem içerisinde çalışma zamanında alınan hataların loglanmasına ve kullanıcıya daha açıklayıcı  hata mesajları
                   vermemize yarayan kodları buraya yazarız.                 
                */

                Console.WriteLine("Herhangi bir hata oluştu.");

                Console.WriteLine(ex.Message); // Hatayı Console ekranımızda yazdırır.

            }

            finally
            {
                /* * Try kısmında bizim kodlarımız çalışır,
                   * Kodumuz hata alır ve Catch bloguna düşer. Catch blogunda  aldıgımız hatalarda yapmamız gerekenleri buraya yazarız.
                   * Daha sonra bizim FINALLY blogumuz çalışır ve  Try Catch mekanizmasından çıkarız.
                   
                   ++ Finally blogu = Kod tarafında herhangi bir hata almasakta bizim finally blogumuz çalışmaya devam eder.
                   * 
                */

                Console.WriteLine(" Finally blogu çalıştı.");
            }

            Console.WriteLine("Uygulama bitti");

            Console.ReadLine();
        }
    
       
    }
}
