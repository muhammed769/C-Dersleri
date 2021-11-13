using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D1.GenericOncesiIslemler
{
    public class sanalDatabase
   
    {

        private ArrayList listem;
        public sanalDatabase()
        {
            listem = new ArrayList();
        }

        public void yeniKayit(int data)
        {
            listem.Add(data);
                               /* İçeride saklamış oldugum ArrayList'ime(koleksiyonuma) istemiş olduugum  zorunlu koşmuş oldugum veri tipini (int 'ı aldık.) alabildim.

                               * Artık ArrayList'im yeniKayıt metodunu kullanarak  int veri tiplerini  alabilir hale gelmiş oldu.

                                 İşte bu kullanımı yapıyoduk AMA GENERİC GELMEDEN ÖNCE ÇÜNKÜ GENERİC MİMARİ GELDİGİNDE  GENERİC MİMARİYLE BERABER GENERİC KOLEKSİYONLAR GELDİ.

                               * Class'ın , Metodun, interface'in  GENERİC DAVRANIŞLARI GELİŞTİ.YANİ BİR DAVRANIŞ ŞEKLİ GELDİ GENERİC DAVRANIŞ DİYE.

                                  VE BUNLAR BİZE Class'ta , Metotta, interface'de,, listelerde ESNEKLİK SUNDU, İŞTE BU BÖLÜMDE BUNLARDAN DETAYLI OLARAK BAHSEDİCEZ...

           */

        }


    }
}
