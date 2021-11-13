using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S14.D2.AbstractKullanimi
{
    public  class musteri:temelSinif  // musteri sınıfıma(nesneme) temelSinif şablonumdaki kuralları miras bıraktım.
   
    {

        public int musteriID { get; set; }

        public musteri()
        {

            musteriID = 1;
        }

        public override void testAbstract() // ******************ÇOK ÖNEMLİ ÇOKKKKKKKKK *********************** : temelSinif şablonuna ait olan testAbstract metotununun body YANİ { }  İÇERİSİNE BURDA DEGER GİREBİLİRİM ARTIK.
                                            // bu kodun biz buraya otomatik olarak nasıl aldık ?  = EN ÜSTTE public class musteri : temelSinif  yazan yerin musteri yazısı olan kısımdaki işarete tıklayıp seçeneklerden İMLEPEMENTE SECENEGINE TIKLADIK!!!
        
        
        {

            Console.WriteLine(" Müşteri sınıfının içindeki testAbract metotudur.");

        }
    }


}
