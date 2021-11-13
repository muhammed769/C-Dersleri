using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameowork.S12.D5.BolumSonuOdevUygulamTekrar
{
    public static class sanalDatabase
    {

        #region Sanal Database

        static ArrayList Ar;

        #endregion


        #region Static yapıcı metotla Sanal Database'imi(koleksiyonumu) değer girilebilir hale getiriyorum.


        static sanalDatabase()
        {
            Ar = new ArrayList();

        }
        #endregion


        #region Barkod field'ım için yapılan işlemler 1 = YeniurunEkle adında bir  static standart metot oluştur.

       public static void YeniUrunEkle(baseClass2 data)   //Şimdi ben koleksiyonuma yeni bir ürün eklemek için bir static standart metot oluşturdum ve parametre olarak baseClass2 nesnemi girdim , baseClass2 nesnemin adı data olsun dedim.
        
       {
            if (data!=null && !string.IsNullOrEmpty(data.barkod) )  // data nesnem(yani baseClass2 nesnem) null degilse ve içinde barkod degeri boş ve null degilse :
            {
                Ar.Add(data);                                       // Ar koleksiyonuma datayı ekle demiş oldum.
            }


       }

        #endregion

        #region Barkod field'im için yapılan işlemler 2 = Barkod kontrolu için static standart metot oluştur

         public static bool ArBarkodKontrol(string barkod)

         {

           bool kontrol2 = false;

            if (Ar!=null && Ar.Count>0)

            {
                for (int i = 0; i < Ar.Count; i++)

                {
                    baseClass2 Bc = (baseClass2)Ar[i];

                    if (Bc.barkod==barkod)
                    {
                        kontrol2 = true;
                        break;

                    }

                }

            }
            return kontrol2;


        }
            

        #endregion











    }

}
