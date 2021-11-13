using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.AbstractKullanimi
{
  public  abstract class temelSinif // buraya astract yazdıgında şunu demek oluyosun uygulamaya : Bu temelSinif  aslında  benim şablan olarak kullanacağım bir sınıf dedim veya ben bu sınıfı bir kural kütüphanesi olarak görmek istiyorum demiş oldum.
                                   // abstract yazmanla beraber temelSinif ŞABLONUNU sen MİRAS BIRAKMAK ZORUNDASIN(KALITMAK ZORUNDASIN) ARTIK VE MİRAS BIRAKILAN SINIFLAR (KALITILAN SINIFLAR)  BU ŞABLONDA YAZILAN KURALLARA HARFİYEN UYMAK ZORUNDADIR.
    {
        public DateTime kayitTarih{ get; set; }

        public DateTime guncellemeTarih { get; set; }

        public temelSinif() // Yapıcı metotla üstte oluşturduğumuz field'larımıza bir değer girişi yaptık.
        {

            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;

        }


        public void test()

        {
            Console.WriteLine("Temel sınıfın içindeki test metotudur.");
        }




        public abstract void testAbstract(); // abstract metotların metot bodyleri YANİ { } OLMAZ. SADECE METOT İMZASI DEDİGİMİZ BÖLÜM YAZILIR VE BIRAKILIR. METOT İMZASI ŞU DEMEK : metotun public mi private mı oldugu void mi yoksa degilmi, adı testAbstract olucak, parametre almıcak.
        //{
        //}
    }
}
