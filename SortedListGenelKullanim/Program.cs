using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D5.SortedListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList = key'leri sıralama yapar ve bu sıralamayı yaparken  key degerleri AYNI VERİ TİPİNDE OLMAK ZORUNDADIR.

            SortedList sıra = new SortedList();
            sıra.Add(100, "yüz");
            sıra.Add(50, "elli");
            sıra.Add(150, "yüz elli");
            //  sıra.Add("B", "BE");  NESNE AYNI VERİ TİPİNDE OLMAK ZORUNDADIR !!



        }
    }
}
