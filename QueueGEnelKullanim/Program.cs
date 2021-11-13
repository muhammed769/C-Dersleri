using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D7.QueueGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue Q1 = new Queue();

            Q1.Enqueue("Bir");         //Koleksiyona objeyi ekler. EKLEDİGİMİZ sırada çıktı verir.
            Q1.Enqueue("iki");
            Q1.Enqueue("üç");
            Q1.Enqueue("dört");


            object O1 = Q1.Peek();   //Degerleri yansıtır.
            object O2 = Q1.Dequeue(); // İLK degerden silmeye başlar.













        }
        
    }
}
