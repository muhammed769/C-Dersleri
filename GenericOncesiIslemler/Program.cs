using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D1.GenericOncesiIslemler
{
    class Program
    {
        static void Main(string[] args)
       
        {

            /*
              ArrayList liste = new ArrayList();       object 'den değer taşıyon bir koleksiyondu yani her tipi(int,string.vb.)  buraya ekleyebiliyodum.Ama benim isteğim şuydu :

                liste.Add();                           oluşturmuş oldugum koleksiyona sadece int girilebilsin veya sadece string girilebilsin.İşte bu gibi işlemlerin çözümü için bizim bu ArrayList'i başka bir class içerisinde saklayıp  içerisine

                                                       datayı metotlar ile  giriyoduk.


            */


            sanalDatabase sdatabase = new sanalDatabase();
            sdatabase.yeniKayit(1);
            sdatabase.yeniKayit(2);

        }
    }
}
