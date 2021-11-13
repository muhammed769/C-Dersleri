using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D4.Kapsülleme4üncüKullanim
{
     public class musteri
    {
        public string isim;
        private string _soyisim;

        public string SoyIsim
        {
            get { return this._soyisim; }

            set
            {
                this._soyisim = value;  // neyi set edicem  _soyisim 'mi set edicem value'yle
                this.emailadres = string.Format("{0} .{1}@gmail.com", isim, _soyisim);
            }
        }




            private string emailadres;
        public string EmailAdres
        {
            get { return this.emailadres; }
            private  set { this.emailadres = value; }
        }
        
        
        }
    }

