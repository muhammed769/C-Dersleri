using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D7.GenericClassNedir_1
{
    class genericRepository <T>    // Burda genericRepository class'ı olarak  bir T tipi alacaksın demiş olduk   VE  Genel olarak  benim datamı  SQL'E  taşımasını istiyorum.
   
    {

        public genericRepository()
        {
            // context ( Baglam ) : EF ( Entity Framework ) yaklaşımımda  mesela  DBFirst 'ün context'ini örneklicek.Yani napıcak gidicek , ben bu nesneyi  örnekledigimde  yapıcı metot Database ( SQl ) 'le baglantı kuracak...

            // ... Kurmuş oldugu baglantıda Database'ile ( SQl 'le ) haberleşir bir halde beklicek.
        }


        public virtual  List<T> Getir()                     // Genericten   data dönen T dön bana  ve bu metotun adı Getir olsun. EK BİLGİ : IEnumerable<T>  interface'in Generic 'İDİR.
        {

            // Benim asıl amacım Şu : Gelen T tipini database üzerinden sorgulamak ve elde etmiş oldugum kayıtları koleksiyon olarak bir üst katmana dönmek...

            return null;
        }


        public virtual void yeniKayitEkle(T data)
        
        {

             // Bize gelen T tipi içerisindeki  bilgiyi  T tipinin işaret etmiş oldugu  tabloya ekliyoruz.



        }



    }
}
