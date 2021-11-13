using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
     public class Musteri
    {

        // Ben müşterimin şu bilgilerini tutmak istiyorum :

        // TcKimlik Numarası
        //İsim
        //Soyisim
        //Cinsiyet

        // peki ben bir bilgiyi neyin içerisinde tutuyorum ? cevab : degişkenlerin içerisinde tutuyorum.


        // Yapıcı Metot kullanımı (ctor) : Nesnelerimizi örneklerken  içerisinde bulunan field'ların(alanların) bir deger alması gerekiyor.Bu deger alma zorunlulugu .NetFramework 'da Yapıcı metotlarla saglanıyor.
        //ctor yazıp 2 kere Tab'a basarsan aşagıdaki public Musteri() yazan yer otomatik olarak gelir.
        // Eger biz yapıcı metotlara müdahale etmezsek arka tarafta kodumuz çalışırken  bu metotlar bizim için  oluşuyo ve boş bir şekilde  duruyo.Ne yapıyo ?
        //class'ın içerisinde varlıgını koruyan field'ların(alanların) veritiplerine göre default degerler veriyor.
        //Şimdi biz eger yapıcı metotlara müdahale edebilirsek sistemin default degerlerini degiştirebiliriz.Örnek olarak şunu yapabiliriz :
        //
        public Musteri()
        {
           // TCkimliknumara = "1234567890";  // Tckimliknumara'mın artık default degeri null yerine 1234567890 gözükecek.
        }

        // Şimdi birden fazla yapıcı metot yapıcaz : 

        public Musteri(string _tckimlikno)
        {
            TCkimliknumara = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }



         public string TCkimliknumara;
        public  string isim;
         public string soyisim;
        public int cinsiyet;  // 717770001 : Bay olsun ; 717770002 : Bayan olsun


        public bool  MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumara); // metot içerisinde metot'a eriştim ve bir deger aldım ve bu degeri artık dış dünyaya gönderiyorum.
            return kontrol ;  
        }


        private bool  MusteriKontrolDatabase(string tckimlikNumarası)
        {
            // database 'e gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmedigi bilgisi sorgulanır.(kurgusal olarak müşterimizi sistemde bulundugunu varsaydık.)
            return true;
        }




    }
}