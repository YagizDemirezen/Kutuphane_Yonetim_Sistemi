using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.Cryptography;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        FRMyonetici yoneticiForm;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");
        public static string kullaniciAdi;
        void gosterVeTemizle()
        {
            adlbl.Show();
            adtxt.Show();
            sifrelbl.Show();
            sifretxt.Show();
            bilgi2lbl.Show();
            hidepbx.Hide();
            showpbx.Show();
            adtxt.Clear();
            sifretxt.Clear();
            epostatxt.Clear();
            cizgilbl.Show();
            ilkisimtxt.Clear();
            soyadtxt.Clear();
            telnotxt.Clear();

        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void frmGiris_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            adlbl.Hide();
            adtxt.Hide();
            sifrelbl.Hide();
            sifretxt.Hide();
            adminGirisYapbtn.Hide();
            kullaniciGirisYapbtn.Hide();
            bilgi2lbl.Hide();
            showpbx.Hide();
            hidepbx.Hide();
            adminpbx.Hide();
            kullanicipbx.Hide();
            hesapAcbtn.Hide();
            hesapAcpbx.Hide();
            epostalbl.Hide();
            epostatxt.Hide();
            mailpbx.Hide();
            usernamepbx.Hide();
            passwordpbx.Hide();

            ilkisimpbx.Hide();
            ilkisimlbl.Hide();
            ilkisim2lbl.Hide();
            ilkisimtxt.Hide();

            telnopbx.Hide();
            telnotxt.Hide();
            telnolbl.Hide();
            soyadtxt.Hide();
            soyadlbl.Hide();

            cizgilbl.Hide();
            bilgilbl.Hide();

            SuperToolTip kullaniciAdiTooltip = new SuperToolTip();
            SuperToolTip sifreTooltip = new SuperToolTip();
            SuperToolTip epostaTooltip = new SuperToolTip();
            SuperToolTip adTooltip = new SuperToolTip();
            SuperToolTip soyadTooltip = new SuperToolTip();
            SuperToolTip telNoTooltip = new SuperToolTip();

            ToolTipItem kullaniciAdiItem = new ToolTipItem { Text = "Lütfen kullanıcı adınızı giriniz." };
            kullaniciAdiTooltip.Items.Add(kullaniciAdiItem);
            adtxt.SuperTip = kullaniciAdiTooltip;

            ToolTipItem sifreItem = new ToolTipItem { Text = "Lütfen şifrenizi giriniz." };
            sifreTooltip.Items.Add(sifreItem);
            sifretxt.SuperTip = sifreTooltip;

            ToolTipItem epostaItem = new ToolTipItem { Text = "Lütfen e-posta adresinizi giriniz." };
            epostaTooltip.Items.Add(epostaItem);
            epostatxt.SuperTip = epostaTooltip;

            ToolTipItem adItem = new ToolTipItem { Text = "Lütfen adınızı giriniz." };
            adTooltip.Items.Add(adItem);
            ilkisimtxt.SuperTip = adTooltip;

            ToolTipItem soyadItem = new ToolTipItem { Text = "Lütfen soyadınızı giriniz." };
            soyadTooltip.Items.Add(soyadItem);
            soyadtxt.SuperTip = soyadTooltip;

            ToolTipItem telNoItem = new ToolTipItem { Text = "Lütfen telefon numaranızı giriniz." };
            telNoTooltip.Items.Add(telNoItem);
            telnotxt.SuperTip = telNoTooltip;



            try
            {
                connection.Open();
                

            }
            catch
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Veritabanına bağlanmaya çalışırken bir hata ile karşılaşıldı.","Veritabanı Bağlantı Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            
            
        }

        private void yoneticiGirisbtn_Click(object sender, EventArgs e)
        {
            
            gosterVeTemizle();

            ilkisim2lbl.Hide();
            soyadlbl.Hide();
            telnotxt.Hide();
            bilgilbl.Show();
            adminGirisYapbtn.Show();
            kullaniciGirisYapbtn.Hide();
            hesapAcbtn.Hide();
            adminpbx.Show();
            kullanicipbx.Hide();
            hesapAcpbx.Hide();
            epostalbl.Hide();
            epostatxt.Hide();
            usernamepbx.Show();
            passwordpbx.Show();
            mailpbx.Hide();
            ilkisimpbx.Hide();
            ilkisimlbl.Hide();
            ilkisimtxt.Hide();

            telnopbx.Hide();
            telnolbl.Hide();
            soyadtxt.Hide();
            bilgi2lbl.Text = "Yönetici Girişi";
        }

        private void adminShowpbx_Click(object sender, EventArgs e)
        {
            sifretxt.Properties.UseSystemPasswordChar = false;
            showpbx.Hide();
            hidepbx.Show();
            hidepbx.BringToFront();
        }

        private void adminHidepbx_Click(object sender, EventArgs e)
        {
            sifretxt.Properties.UseSystemPasswordChar = true;
            showpbx.Show();
            hidepbx.Hide();
            showpbx.BringToFront();
        }

        private void k_girisbtn_Click(object sender, EventArgs e)
        {
            gosterVeTemizle();
            ilkisim2lbl.Hide();
            soyadlbl.Hide();
            telnotxt.Hide();
            bilgilbl.Show();
            kullaniciGirisYapbtn.Show();
            adminGirisYapbtn.Hide();
            hesapAcbtn.Hide();
            adminpbx.Hide();
            hesapAcpbx.Hide();
            kullanicipbx.Show();
            epostalbl.Hide();
            epostatxt.Hide();
            usernamepbx.Show();
            passwordpbx.Show();
            mailpbx.Hide();
            ilkisimpbx.Hide();
            ilkisimlbl.Hide();
            ilkisimtxt.Hide();

            telnopbx.Hide();
            telnolbl.Hide();
            soyadtxt.Hide();
            bilgi2lbl.Text = "Kullanıcı Girişi";
            
        }

        private void k_hesapAcbtn_Click(object sender, EventArgs e)
        {
            gosterVeTemizle();
            ilkisim2lbl.Show();
            soyadlbl.Show();
            telnotxt.Show();
            bilgilbl.Hide();
            kullaniciGirisYapbtn.Hide();
            adminGirisYapbtn.Hide();
            hesapAcbtn.Show();
            adminpbx.Hide();
            hesapAcpbx.Show();
            kullanicipbx.Hide();
            epostalbl.Show();
            epostatxt.Show();
            mailpbx.Show();
            usernamepbx.Show();
            passwordpbx.Show();
            ilkisimpbx.Show();
            ilkisimlbl.Show();
            ilkisimtxt.Show();

            telnopbx.Show();
            telnolbl.Show();
            soyadtxt.Show();
            bilgi2lbl.Text = "Hesap Oluştur";
        }
        void txtsil()
        {
            adtxt.Clear();
            sifretxt.Clear();
            epostatxt.Clear();
            ilkisimtxt.Clear();
            soyadtxt.Clear();
            telnotxt.Clear();
        }
        private void adminGirisYapbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if(adtxt.Text.Length < 5 || adtxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Kullanıcı Adı " + adtxt.Text.Length + " karakterden oluşamaz. Kullanıcı Adı 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adtxt.Focus();
                    adtxt.Clear();
                }
                else if(sifretxt.Text.Length < 5 || sifretxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Şifre " + sifretxt.Text.Length + " karakterden oluşamaz. Sifre 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sifretxt.Focus();
                    sifretxt.Clear();
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT ŞİFRE FROM YONETICILER_TBL WHERE [KULLANICI AD] = @k_ad", connection);
                    command.Parameters.AddWithValue("@k_ad", adtxt.Text);
                    var hashliSifreDB = command.ExecuteScalar();
                    if (hashliSifreDB != null)
                    {
                        string veritabaniHash = hashliSifreDB.ToString(); //Veritabanındaki hashli şifre
                        string girilenHash = HashPassword(sifretxt.Text); //Girilen şifreyi hashle

                        if (veritabaniHash == girilenHash) //hashler aynıysa
                        {
                            kullaniciAdi = adtxt.Text; // Giriş başarılı, kullanıcı adı saklanıyor
                            this.Hide();
                            if (yoneticiForm == null || yoneticiForm.IsDisposed)
                            {
                                yoneticiForm = new FRMyonetici();
                                yoneticiForm.Show();
                            }
                            else
                            {
                                yoneticiForm.BringToFront();
                            }
                            
                            
                        }
                        else
                        {
                            SystemSounds.Beep.Play();
                            XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Tekrar Deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtsil();
                        }
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                        XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Tekrar Deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsil();
                    }

                }


            }
            catch
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Veritabanına bağlanmaya çalışırken bir hata ile karşılaşıldı.", "Veritabanı Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void kullaniciGirisYapbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                if (adtxt.Text.Length < 5)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Kullanıcı Adı " + adtxt.Text.Length + " karakterden oluşamaz. Kullanıcı Adı 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adtxt.Focus();
                    adtxt.Clear();
                }
                else if (adtxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Kullanıcı Adı " + adtxt.Text.Length + " karakterden oluşamaz. Kullanıcı Adı 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adtxt.Focus();
                    adtxt.Clear();
                }
                else if (sifretxt.Text.Length < 5)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Şifre " + sifretxt.Text.Length + " karakterden oluşamaz. Sifre 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sifretxt.Focus();
                    sifretxt.Clear();
                }
                else if (sifretxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Şifre " + sifretxt.Text.Length + " karakterden oluşamaz. Sifre 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sifretxt.Focus();
                    sifretxt.Clear();
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT ŞİFRE FROM KULLANICILAR_TBL WHERE [KULLANICI AD] = @k_ad", connection);
                    command.Parameters.AddWithValue("@k_ad", adtxt.Text);
                    var hashliSifreDB = command.ExecuteScalar();
                    if(hashliSifreDB != null)
                    {
                        string veritabaniHash = hashliSifreDB.ToString(); //Veritabanındaki hashli şifre
                        string girilenHash = HashPassword(sifretxt.Text); //Girilen şifreyi hashle

                        if (veritabaniHash == girilenHash) //hashler aynıysa
                        {
                            kullaniciAdi = adtxt.Text; // Giriş başarılı, kullanıcı adı saklanıyor
                            XtraMessageBox.Show("Giriş başarılı.", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FRMkullanici kullaniciSayfasi = new FRMkullanici();
                            kullaniciSayfasi.Show();
                            this.Hide();
                            kullaniciSayfasi.BringToFront();
                        }
                        else
                        {
                            SystemSounds.Beep.Play();
                            XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Tekrar Deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtsil();
                        }
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                        XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Tekrar Deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsil();
                    }
                }
            }
            catch
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Veritabanına bağlanmaya çalışırken bir hata ile karşılaşıldı.", "Veritabanı Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void hesapAcbtn_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                


                if(ilkisimtxt.Text.Length < 2 || ilkisimtxt.Text.Length > 20)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Ad " + ilkisimtxt.Text.Length + " karakterden oluşamaz. Ad 2-20 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ilkisimtxt.Focus();
                    ilkisimtxt.Clear();
                }
                else if(soyadtxt.Text.Length < 2 || soyadtxt.Text.Length > 20)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Soyad " + soyadtxt.Text.Length + " karakterden oluşamaz. Soyad 2-20 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    soyadtxt.Focus();
                    soyadtxt.Clear();
                }
                else if(telnotxt.Text.Length != 17)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Lütfen telefon numaranızı eksiksiz giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    telnotxt.Focus();
                    telnotxt.Clear();
                }
                else if(epostatxt.Text.Length < 9 || epostatxt.Text.Length > 25)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("E-Posta " + epostatxt.Text.Length + " karakterden oluşamaz. E-Posta 9-25 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epostatxt.Focus();
                    epostatxt.Clear();
                }
                else if (adtxt.Text.Length < 5 || adtxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Kullanıcı Adı " + adtxt.Text.Length + " karakterden oluşamaz. Kullanıcı Adı 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adtxt.Focus();
                    adtxt.Clear();
                }
                else if (sifretxt.Text.Length < 5 || sifretxt.Text.Length > 15)
                {
                    SystemSounds.Beep.Play();
                    XtraMessageBox.Show("Şifre " + sifretxt.Text.Length + " karakterden oluşamaz. Sifre 5-15 karakterden oluşabilir.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sifretxt.Focus();
                    sifretxt.Clear();
                }
                else
                {

                    SqlCommand adKontrol = new SqlCommand("SELECT [KULLANICI AD] FROM KULLANICILAR_TBL WHERE [KULLANICI AD] = @k_ad", connection);
                    adKontrol.Parameters.AddWithValue("@k_ad", adtxt.Text);   
                    var kullaniciVarMi = adKontrol.ExecuteScalar();
                    SqlCommand epostaControl = new SqlCommand("SELECT [E-POSTA] FROM KULLANICILAR_TBL WHERE [E-POSTA] = @eposta", connection);
                    epostaControl.Parameters.AddWithValue("@eposta", epostatxt.Text);
                    var epostaVarMi = epostaControl.ExecuteScalar();

                    if (kullaniciVarMi != null)
                    {
                        SystemSounds.Beep.Play();
                        XtraMessageBox.Show("Kullanıcı Adı zaten kullanılıyor. Lütfen başka bir Kullanıcı Adı giriniz.", "Kullanıcı Adı Kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        adtxt.Focus();
                        txtsil();
                    }
                    if (epostaVarMi != null)
                    {
                        SystemSounds.Beep.Play();
                        XtraMessageBox.Show("E-Posta zaten kullanılıyor!", "EPOSTA Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        epostatxt.Focus();
                        txtsil();
                    }
                    if(kullaniciVarMi == null && epostaVarMi == null)
                    {
                        SqlCommand hesapac = new SqlCommand("INSERT INTO KULLANICILAR_TBL (AD,SOYAD,[TEL NO],[E-POSTA],[KULLANICI AD],ŞİFRE,[KAYIT TARİHİ]) VALUES (@ad,@soyad,@telno,@eposta,@k_ad,@sifre,@kayit)", connection);
                        hesapac.Parameters.AddWithValue("@ad", ilkisimtxt.Text);
                        hesapac.Parameters.AddWithValue("@soyad", soyadtxt.Text);
                        hesapac.Parameters.AddWithValue("@telno", telnotxt.Text);
                        hesapac.Parameters.AddWithValue("@eposta", epostatxt.Text);
                        hesapac.Parameters.AddWithValue("@k_ad", adtxt.Text);
                        string hashedPassword = HashPassword(sifretxt.Text);
                        hesapac.Parameters.AddWithValue("@sifre", hashedPassword);
                        DateTime suan = DateTime.Now;
                        string kayitTarihi = suan.ToString("dd.MM.yyyy HH:mm");
                        hesapac.Parameters.AddWithValue("@kayit", kayitTarihi);
                        hesapac.ExecuteNonQuery();

                        SystemSounds.Beep.Play();
                        XtraMessageBox.Show("Hesap oluşturma işlemi başarıyla tamamlanmıştır", "Hesap Başarıyla Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsil();
                    }
                }


            }
            catch
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Veritabanına bağlanmaya çalışırken bir hata ile karşılaşıldı.", "Veritabanı Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SagPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
