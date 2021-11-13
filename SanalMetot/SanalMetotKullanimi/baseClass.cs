using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S13.D2.SanalMetotKullanimi
{
  public   class baseClass
    {



        public baseClass()
        {
            Console.WriteLine("BaseClass");
        }
        public virtual void ekranaYaz(string data)  // public virtual void ekranaYaz(string data)

        {

            Console.WriteLine(data);

        }

        // Not(ÖNEMLİ) : // public virtual void ekranaYaz(string data) dersen dikkat et burda VİRTUAL anahtar kelimesini kullandık. Bu metot artık SANAL BİR METOT OLMUŞ OLUR.


    }
}
