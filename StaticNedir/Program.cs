using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)

        {
            Ogrenci O1;  // Stack bölgede pointer'ımız (İşaretimiz) oluştu.

                        // Stack bölgede pointer(İşaret) oluştuğu zaman  static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field,metot static dediğimiz bölgede oluşturuldu.


            O1 = new Ogrenci();  // Stack bölgede oluşan pointer kendisini heap bölgede static OLMAYAN tanımlarını tamamladı.

            O1.Test1();          // Nesne örneği ALINDIKTAN SONRA Test1 adındaki metoduma ulaşabildim.

            Ogrenci.Test2();     // Nesne örneği ALMADAN Test2 adındaki metoda ulaştım.


            
            /* Static Kavranu gerçek hayatta kullanıldığı yerler : 
            
             
             * 1 - Helper.cs => Kontroller 
             
             
             * 2 - Oluşturmuş olduğumuz nesnemizin bağımlılığı farklı class'lara bağlı olduğu için (Yani proje içinde özel olduğu için) nesne içerisinde static metot tanımları yapılır.


             * 3 - Class içerisinde bir field (static) tanımı yapar, ilgili field içerisine bir değer ataması yaparız.Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field'ımıza ulasir değerimizi okuruz.

            * 4 -  [ Uygulama ] = > [ozelHelper] = > [DLL]

            */

        }
    }
}
