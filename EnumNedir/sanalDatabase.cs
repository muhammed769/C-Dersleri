﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S17.D1.EnumNedir
{
    public  class sanalDatabase
   
    {

        ArrayList sanalDB = new ArrayList();


        public musteriReturnValue musteriYeniKayit(Musteri M)

        {


            sanalDB.Add(M);
            return musteriReturnValue.kayitBasarili;  // parametre kontrol de yapabilirdim  , kayıt kontrölde yapabilirdim.
        }
    }
}
