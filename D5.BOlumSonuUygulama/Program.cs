using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameowork.S12.D5.BolumSonuOdevUygulamTekrar
{
    class Program
    {
        static void Main(string[] args)
       
        
        {

            bilgisayar2 B2 = new bilgisayar2();


            B2.Marka = "Casper";
            B2.Model = "96SVp";
            B2.Ekrankartı = "Amd";
            B2.Islemci = "intel";
            B2.alisFiyati = 1000;
            B2.SatisFiyati = 900;
            B2.KampanyaFiyati = 0;


            sanalDatabase.YeniUrunEkle(B2);


        }
    }
}
