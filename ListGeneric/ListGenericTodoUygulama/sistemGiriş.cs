using NetFramework.S18.D4.ListGenericTodoUygulama.BusinessService;
using NetFramework.S18.D4.ListGenericTodoUygulama.entites;
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
    public partial class sistemGiriş : Form
    {
        public sistemGiriş()
        {
            InitializeComponent();
        }

        

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {

            TextBox T = (TextBox)sender;   /* Unboxing işlemi yaptık.
                                            
                                            * object'ten gelen SENDER PARAMETRESİ, ÜZERİNE TIKLANILAN TEXTBOX'I temsil eder.

                                            * Gelen tipin Textbox olduğunu biliyorum.Sonuc olarak yani sender'ımı TextBox'a çevirdik.


                                           */

            T.BackColor = Color.Yellow;


        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;     

            //Kullanıcı Adı textbox 'ından giriş yaptıktan sonra YANİ aşagısındaki text box' a geçtiginde Kullanıcı Adı textbox'ı BEYAZ GÖZÜKSÜN DEMİŞ OLDUM.
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))  // EĞER  kullanıcı boş veya null degilse VEYA  sifre kısmı boş veya null degilse sen bir şeyler yap.

            {
                 kullaniciService kullaniciService = new kullaniciService();  // kullaniciService 'imi bellege kullaniciService adında ekledim.(kopyaladım.)
                 kullanici kontrolKullanici=kullaniciService.kullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);

                if (kontrolKullanici != null) // yani içeride bir kullanıcı var demektir.
                {

                    /* Eğer dogru bir kullanıcıysa yani : 

                      * Açık olan formun içerisinde  group box'ın içerisinde  olan butonlara erişip  o butonların durumunu  true 'ya çeviricez ve daha sonra açık olan o küçük sistem giriş  formunu kapatmamız gerekiyor.
                        Bunuda aslında Ram'de bulunan openForms'ın içerisinde  işlemler yapıcaz ve yapmış oldugumuz işlemlerde  arka tarafta bulunan kontrollerimize erişmiş olucaz.

                      *Şimdi bir Form nesnesi oluşturalım.

                    */

                    Form anaForm = Application.OpenForms["Form1"];    // Açık olan Form'ların name 'inde yada sistemsel indeks'inde arama yapabilirim.Ben burda name 'den giderek arama yapmak istiyorum.
                                                                      // Uygulama(application) içinde OpenForms metodunu kullanarak Form1'i arattım ve Form1 'i buldugumu biliyorum artık ve bu bildigimi yazdım buraya.


                    Panel solPanel = (Panel)anaForm.Controls["pnlIslemListesi "];                 // Peki anaForm'un control'lerinde bir panelimiz vardı.Şimdi Panel'e ulaşcaz. YANİ anaForm'un control ' lerini(ELEMANLARINI) Panel'e çeviriyorum.
                                                                                                  // Form'un hangi control'lerini Panel çeviriyorum : Panelin properties'indeki name : pnlIslemListesi 'sini buraya yazdık.
                    

                    GroupBox gbIslemListe = (GroupBox)solPanel.Controls["grpBoxIslemListe"];    // solPanel 'in control ' lerini Group box'a çeviriyorum.solPanel'in Hangi control'lerini group box'a çeviriyorum :
                                                                                                  //  solPanel'in Hangi control'lerini(ELEMANLARINI) group box'a çeviriyorum : GroupBox'ın properties'indeki name :grpBoxIslemListe 'ini buraya yazdık.


                    foreach (Control item in gbIslemListe.Controls)             // Şimdi GroupBox'ın içindeki kontrollerde dönücem.(foreach kullandık çünkü tip olarak döneriz.)
                   
                    {
                        if (item is Button)  // Eger döndügüm CONTROL(ELEMAN) bir buton İSE  ONUN BUTONUNUN ENABLED'INI(AKTİFLEŞTİRME) TRUE'YA ÇEVİRİYORUM VE BUTTTON ARTIK AKTİFTİR.

                        {
                            item.Enabled = true;
                        }


                    }                                                                                      










                }


                else // içeride kullanıcı yok bulunamadı demektir.
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz olarak giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); // eksiksin olarak girin dedikten sonra bir okey butonu ve bir bilgilendirme simgesi göstermiş olduk.
            }
        }
    }
}
