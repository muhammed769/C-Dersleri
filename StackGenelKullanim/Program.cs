using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D6.StackGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {

            // stack : içerisine almış oldugu dataları bır komut kullanarak sıralı bir şekilde kendi listesinden çıkarmayı saglıyor.

            Stack S1 = new Stack();

            S1.Push("Bir");
            S1.Push("iki");
            S1.Push("Üç");
            S1.Push("dört");

            // Koleksiyonumuzda  4 tane data eklemiş oldum.

             object o1 =S1.Pop(); //  datayı ize gönderip listeden çıkartır.
            object o2 = S1.Peek(); // sadece datayı gönderir silmez.


           


        }
    }
}
