using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.HataYönetimi.TryCatch
{
    public  class OzelHataSinifi : Exception // Exception nesnesinden kalıttık. (Exception = Beklenmedik Durum)
   
    {
        public OzelHataSinifi()
        {
            Console.WriteLine(" Özel hata sınıfı oluştu.");
        }
    }
}
