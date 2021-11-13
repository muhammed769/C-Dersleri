using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S18.D4.ListGenericTodoUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlIslemListesi_Paint(object sender , PaintEventArgs e)
        {

        }

        private void ButonAcKapa(bool kontrol)
        {

            foreach (Control item in grpBoxIslemListe.Controls)

            {

                if (item is Button)                                                 // Eger item Butonsa , YANİ İTEM BUTON NESNESİNE ÇEVRİLEBİLİYORSA  ...

                {
                    ((Button)item).Enabled = kontrol;                               // ... SEN GİT İTEM 'I BUTTON'A ÇEVİR. YANİ ENABLED'INI(AKTİFLEŞTİRMESİNİ) AÇ.SONUC OLARAK  group box'daki buttonları istedigimiz bu seviyede  AÇ
                }

            }
        }





private void Form1_Load(object sender, EventArgs e)
        {

            tm_zamanla.Interval = 15000;          // benim zamanlayıcım her 15 saniyede bir çalışıp benim vermiş oldugum işlemi yapmaya çalışcak.(Interval = Aralık demektir.) 

            tm_zamanla.Tick += Tm_zamanla_Tick;   // tm.zamanla.Tcik += yazıp 2 kere taba basarsan aşagıdaki kod otomatik olarak gelir.
                                                    
                                                  // Tick adında bir event'ım var.Tick'ıtı kullanarak her işlem tetiklendiginde  oluşmasını istedigim, çalışmasını istedigim kod bloklarını aşagıdaki kısma yazarız.

           tm_zamanla.Start();


            ButonAcKapa(false);                    // Kullanıcı adı ve şifre kısmı dogru girilmeden group box'daki butonları kapatmış olduk böylece.
                                                   // FOREACH döngüsüde eger kullanıcı adı ve şifre kısmı dogru girilirse buttonları AKTİF(ENABLED) ETMİŞ OLACAK.



            sistemGiriş kullaniciKontrol = new sistemGiriş();

            kullaniciKontrol.MdiParent = this;                                               // kullaniciKontrol MdiParent'ımızın bu form olarak belirttik.YANİ sistemGiriş SINIFIMIZIN BU FORMA AİT OLDUGUNU BELİRTTİK.

            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;                 // İLGİLİ FORMUMUZUN EKRANDA TAM ORTADA OLMASI GEREKTİGİNİ SÖYLEDİK. 

            kullaniciKontrol.Show();                                                         // İLGİLİ FORMUMUZU EKRANDA GÖSTEREBİLDİK.



                                      


        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }
    }
}
