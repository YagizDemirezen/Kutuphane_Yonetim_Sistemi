using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System.IO;
using DevExpress.Utils.Extensions;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FRMyonetici : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRMyonetici()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                return; // Başlık çubuğundan sürüklemeyi engeller
            }

            base.WndProc(ref m);
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        private void acilisEkran()
        {
            ribbon.Minimized = true;
            this.Refresh();
            sagUst_k_adItem.Caption = frmGiris.kullaniciAdi;
            Font sagUstFont = new Font("Times New Roman", 14, FontStyle.Bold);
            sagUst_k_adItem.ItemAppearance.SetFont(sagUstFont);

            anasayfabtnClick();
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowToolbarCustomizeItem = false;

        }
        private void FRMyonetici_Load(object sender, EventArgs e)
        {
            acilisEkran();
            


        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        frmAnasayfa anasayfa;
        void anasayfabtnClick()
        {
            anasayfa = new frmAnasayfa();
            anasayfa.MdiParent = this;
            anasayfa.Show();
        }
        private void anasayfabtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfabtnClick();

            }
            else
            {
                anasayfa.Show();
                anasayfa.BringToFront();
            }
        }

        private void FRMyonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        frmGiris girisForm;
        private void cikisYapbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();

            if (girisForm == null || girisForm.IsDisposed)
            {
                girisForm = new frmGiris();
                girisForm.Show();
            }
            else
            {
                girisForm.BringToFront();
            }
        }

        frmKitapBilgileri kitapBilgileri;
        private void kitapBilgileribtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (kitapBilgileri == null || kitapBilgileri.IsDisposed)
            {
                kitapBilgileri = new frmKitapBilgileri();
                kitapBilgileri.MdiParent = this;
                kitapBilgileri.Show();

            }
            else
            {
                kitapBilgileri.MdiParent = this;
                kitapBilgileri.Show();
                kitapBilgileri.BringToFront();
            }
        }
        void kitapEkle()
        {
            if (string.IsNullOrEmpty(kitapBilgileri.ad) ||
                string.IsNullOrEmpty(kitapBilgileri.yazar) ||
                string.IsNullOrEmpty(kitapBilgileri.yayinEvi) ||
                string.IsNullOrEmpty(kitapBilgileri.basimYili) ||
                string.IsNullOrEmpty(kitapBilgileri.kategori) ||
                string.IsNullOrEmpty(kitapBilgileri.dil) ||
                string.IsNullOrEmpty(kitapBilgileri.aciklama) ||
                string.IsNullOrEmpty(kitapBilgileri.stokAdet) ||
                string.IsNullOrEmpty(kitapBilgileri.fiyat) ||
                string.IsNullOrEmpty(kitapBilgileri.eklenmeTarihi))
            {
                
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen kitabın tüm bilgileri giriniz.", "Kitap Bilgileri Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fiyatStr = kitapBilgileri.fiyat.Replace("₺", "").Trim();

                SqlCommand ekle = new SqlCommand("INSERT INTO KITAPLAR_TBL (AD, YAZAR, [YAYIN EVİ], [BASIM YILI], KATEGORİ, [SAYFA SAYISI], DİL, [STOK ADET], FİYAT, [EKLENME TARİHİ], AÇIKLAMA) VALUES (@ad, @yazar, @yayinEv, @basimYil, @kategori, @sayfaSayisi, @dil, @stokAdet, @fiyat, @eklenmeTarihi, @aciklama)", connection);
                ekle.Parameters.AddWithValue("@ad", kitapBilgileri.ad);
                ekle.Parameters.AddWithValue("@yazar", kitapBilgileri.yazar);
                ekle.Parameters.AddWithValue("@yayinEv", kitapBilgileri.yayinEvi);
                ekle.Parameters.AddWithValue("@basimYil", kitapBilgileri.basimYili);
                ekle.Parameters.AddWithValue("@kategori", kitapBilgileri.kategori);
                ekle.Parameters.AddWithValue("@dil", kitapBilgileri.dil);
                ekle.Parameters.AddWithValue("@stokAdet", int.Parse(kitapBilgileri.stokAdet));
                ekle.Parameters.AddWithValue("@fiyat", float.Parse(fiyatStr));
                ekle.Parameters.AddWithValue("@eklenmeTarihi", kitapBilgileri.eklenmeTarihi);
                ekle.Parameters.AddWithValue("@aciklama", kitapBilgileri.aciklama);
                ekle.Parameters.AddWithValue("@sayfaSayisi", int.Parse(kitapBilgileri.sayfaSayisi));

                connection.Open();
                ekle.ExecuteNonQuery();
                connection.Close();
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Kitap ekleme işlemi başarıyla tamamlandı.", "Kitap Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa.kitaplarList();
                anasayfa.chartControlDoldurKitap();
                kitapBilgileri.kitaplarList();
                kitapBilgileri.txtSil();
            }
        }
        void kitapSilMethod()
        {
            if (string.IsNullOrEmpty(kitapBilgileri.id))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen bir kitap seçiniz.", "Kitap Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            else
            {
                string fiyatStr = kitapBilgileri.fiyat.Replace("₺", "").Trim();

                SqlCommand sil = new SqlCommand("DELETE FROM KITAPLAR_TBL WHERE ID = @id", connection);
                sil.Parameters.AddWithValue("@id", kitapBilgileri.id);
                SystemSounds.Hand.Play();
                DialogResult silmeKarari = XtraMessageBox.Show(kitapBilgileri.ad + " adlı kitabı silmek istediğine emin misiniz?", "Kitap Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silmeKarari == DialogResult.Yes)
                {
                    connection.Open();
                    sil.ExecuteNonQuery();
                    connection.Close();
                    SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Kitap silme işlemi başarıyla tamamlandı.", "Kitap Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa.kitaplarList();
                    anasayfa.chartControlDoldurKitap();
                    kitapBilgileri.kitaplarList();
                    kitapBilgileri.txtSil();
                }
            }
        }
        void kitapGuncelleMethod()
        {
            if (string.IsNullOrEmpty(kitapBilgileri.id))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen bir kitap seçiniz.", "Kitap Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(kitapBilgileri.ad) ||
                string.IsNullOrEmpty(kitapBilgileri.yazar) ||
                string.IsNullOrEmpty(kitapBilgileri.yayinEvi) ||
                string.IsNullOrEmpty(kitapBilgileri.basimYili) ||
                string.IsNullOrEmpty(kitapBilgileri.kategori) ||
                string.IsNullOrEmpty(kitapBilgileri.dil) ||
                string.IsNullOrEmpty(kitapBilgileri.aciklama) ||
                string.IsNullOrEmpty(kitapBilgileri.stokAdet) ||
                string.IsNullOrEmpty(kitapBilgileri.fiyat) ||
                string.IsNullOrEmpty(kitapBilgileri.eklenmeTarihi))
                {
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Lütfen kitabın tüm bilgileri giriniz.", "Kitap Bilgileri Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string fiyatStr = kitapBilgileri.fiyat.Replace("₺", "").Trim();

                    SqlCommand guncelle = new SqlCommand("UPDATE KITAPLAR_TBL SET AD = @ad, YAZAR = @yazar, [YAYIN EVİ] = @yayinEv, [BASIM YILI] = @basimYil, KATEGORİ = @kategori, [SAYFA SAYISI] = @sayfaSayisi, DİL = @dil, [STOK ADET] = @stokAdet, FİYAT = @fiyat, [EKLENME TARİHİ] = @eklenmeTarihi, AÇIKLAMA = @aciklama WHERE ID = @id", connection);
                    guncelle.Parameters.AddWithValue("@ad", kitapBilgileri.ad);
                    guncelle.Parameters.AddWithValue("@yazar", kitapBilgileri.yazar);
                    guncelle.Parameters.AddWithValue("@yayinEv", kitapBilgileri.yayinEvi);
                    guncelle.Parameters.AddWithValue("@basimYil", kitapBilgileri.basimYili);
                    guncelle.Parameters.AddWithValue("@kategori", kitapBilgileri.kategori);
                    guncelle.Parameters.AddWithValue("@dil", kitapBilgileri.dil);
                    guncelle.Parameters.AddWithValue("@stokAdet", int.Parse(kitapBilgileri.stokAdet));
                    guncelle.Parameters.AddWithValue("@fiyat", float.Parse(fiyatStr));
                    guncelle.Parameters.AddWithValue("@eklenmeTarihi", kitapBilgileri.eklenmeTarihi);
                    guncelle.Parameters.AddWithValue("@aciklama", kitapBilgileri.aciklama);
                    guncelle.Parameters.AddWithValue("@sayfaSayisi", int.Parse(kitapBilgileri.sayfaSayisi));
                    guncelle.Parameters.AddWithValue("@id", kitapBilgileri.id);

                    connection.Open();
                    guncelle.ExecuteNonQuery();
                    connection.Close();
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Kitap güncelleme işlemi başarıyla tamamlandı.", "Kitap Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa.kitaplarList();
                    anasayfa.chartControlDoldurKitap();
                    kitapBilgileri.kitaplarList();
                    kitapBilgileri.txtSil();
                }
            }
        }
        void formKontrolEkle()
        {
            if (kitapBilgileri == null || kitapBilgileri.IsDisposed)
            {
                kitapBilgileri = new frmKitapBilgileri();
                kitapEkle();
            }
            else
            {
                kitapEkle();
            }

        }
        void formKontrolGuncelle()
        {
            if (kitapBilgileri == null || kitapBilgileri.IsDisposed)
            {
                kitapBilgileri = new frmKitapBilgileri();
                kitapGuncelleMethod();
            }
            else
            {
                kitapGuncelleMethod();
            }

        }
        void formKontrolSil()
        {
            if (kitapBilgileri == null || kitapBilgileri.IsDisposed)
            {
                kitapBilgileri = new frmKitapBilgileri();
                kitapSilMethod();
            }
            else
            {
                kitapSilMethod();
            }

        }

        private void kitapEklebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolEkle();
        }

        private void kitapGuncellebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolGuncelle();
        }

        private void kitapSilbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolSil();
        }
        KitaplarRapor kitaplarrpr = new KitaplarRapor();
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            kitapDocuments kitapRapor1 = new kitapDocuments(new KitaplarRapor());
            kitapRapor1.Show();
            kitapRapor1.BringToFront();
        }

        frmKullanıcıBilgileri kullaniciBilgileri;
        private void kullaniciListesibtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (kullaniciBilgileri == null || kullaniciBilgileri.IsDisposed)
            {
                kullaniciBilgileri = new frmKullanıcıBilgileri();
                kullaniciBilgileri.MdiParent = this;
                kullaniciBilgileri.Show();

            }
            else
            {
                kullaniciBilgileri.MdiParent = this;
                kullaniciBilgileri.Show();
                kullaniciBilgileri.BringToFront();
            }
        }


        void formKontrolSilKullanici()
        {
            if (kullaniciBilgileri == null || kullaniciBilgileri.IsDisposed)
            {
                kullaniciBilgileri = new frmKullanıcıBilgileri();
                kullaniciSilMethod();
            }
            else
            {
                kullaniciSilMethod();
            }
        }
        void kullaniciSilMethod()
        {
            if (string.IsNullOrEmpty(kullaniciBilgileri.id))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen bir kullanıcı seçiniz.", "Kullanıcı Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand sil = new SqlCommand("DELETE FROM KULLANICILAR_TBL WHERE ID = @id", connection);
                sil.Parameters.AddWithValue("@id", kullaniciBilgileri.id);
                SystemSounds.Hand.Play();
                DialogResult silmeKarari = XtraMessageBox.Show(kullaniciBilgileri.kullaniciad + " adlı kullanıcıyı silmek istediğine emin misiniz?", "Kullanıcı Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silmeKarari == DialogResult.Yes)
                {
                    connection.Open();
                    sil.ExecuteNonQuery();
                    connection.Close();
                    SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Kullanıcı silme işlemi başarıyla tamamlandı.", "Kullanıcı Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa.kullanicilarList();
                    kullaniciBilgileri.kullanicilarList();
                    kullaniciBilgileri.txtSil();
                }
            }
        }


        private void kullaniciSilbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolSilKullanici();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullanıcılarDocuments kullanıcıRapor1 = new KullanıcılarDocuments(new KullanıcılarRapor());
            kullanıcıRapor1.Show();
            kullanıcıRapor1.BringToFront();
        }

        personelBilgileri personelbilgileri;
        private void personelListesibtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (personelbilgileri == null || personelbilgileri.IsDisposed)
            {
                personelbilgileri = new personelBilgileri();
                personelbilgileri.MdiParent = this;
                personelbilgileri.Show();

            }
            else
            {
                personelbilgileri.MdiParent = this;
                personelbilgileri.Show();
                personelbilgileri.BringToFront();
            }
        }
        void formKontrolPersonelEkle()
        {
            if (personelbilgileri == null || personelbilgileri.IsDisposed)
            {
                personelbilgileri = new personelBilgileri();
                personelEkle();
            }
            else
            {
                personelEkle();
            }
        }
        void formKontrolPersonelSil()
        {
            if (personelbilgileri == null || personelbilgileri.IsDisposed)
            {
                personelbilgileri = new personelBilgileri();
                personelSil();
            }
            else
            {
                personelSil();
            }
        }
        void formKontrolPersonelGuncelle()
        {
            if (personelbilgileri == null || personelbilgileri.IsDisposed)
            {
                personelbilgileri = new personelBilgileri();
                personelGuncelle();
            }
            else
            {
                personelGuncelle();
            }
        }
        void personelEkle()
        {
            if (string.IsNullOrEmpty(personelbilgileri.ad) ||
                string.IsNullOrEmpty(personelbilgileri.soyad) ||
                string.IsNullOrEmpty(personelbilgileri.telno) ||
                string.IsNullOrEmpty(personelbilgileri.eposta) ||
                string.IsNullOrEmpty(personelbilgileri.departman) ||
                string.IsNullOrEmpty(personelbilgileri.maas) ||
                string.IsNullOrEmpty(personelbilgileri.girisTarihi) ||
                string.IsNullOrEmpty(personelbilgileri.durum))
            {

                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen personelin tüm bilgileri giriniz.", "Personel Bilgileri Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maasstr = personelbilgileri.maas.Replace("₺", "").Trim();

                SqlCommand ekle = new SqlCommand("INSERT INTO PERSONELLER_TBL (AD, SOYAD, [TEL NO], [E-POSTA], DEPARTMAN, MAAŞ, [İŞE GİRİŞ TARİHİ], DURUM) VALUES (@ad, @soyad, @telno, @eposta, @departman, @maas,@girisTarihi, @durum)", connection);
                
                ekle.Parameters.AddWithValue("@ad", personelbilgileri.ad);
                ekle.Parameters.AddWithValue("@soyad", personelbilgileri.soyad);
                ekle.Parameters.AddWithValue("@telno", personelbilgileri.telno);
                ekle.Parameters.AddWithValue("@eposta", personelbilgileri.eposta);
                ekle.Parameters.AddWithValue("@departman", personelbilgileri.departman);
                ekle.Parameters.AddWithValue("@maas", float.Parse(maasstr));
                ekle.Parameters.AddWithValue("@girisTarihi", personelbilgileri.girisTarihi);
                ekle.Parameters.AddWithValue("@durum", personelbilgileri.durum);


                connection.Open();
                ekle.ExecuteNonQuery();
                connection.Close();
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Personel ekleme işlemi başarıyla tamamlandı.", "Personel Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa.personellerList();
                personelbilgileri.personelList();
                personelbilgileri.txtSil();//
            }
        }
        void personelGuncelle()
        {
            if (string.IsNullOrEmpty(personelbilgileri.id))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen bir personel seçiniz.", "Personel Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(personelbilgileri.ad) ||
                    string.IsNullOrEmpty(personelbilgileri.soyad) ||
                    string.IsNullOrEmpty(personelbilgileri.telno) ||
                    string.IsNullOrEmpty(personelbilgileri.eposta) ||
                    string.IsNullOrEmpty(personelbilgileri.departman) ||
                    string.IsNullOrEmpty(personelbilgileri.maas) ||
                    string.IsNullOrEmpty(personelbilgileri.girisTarihi) ||
                    string.IsNullOrEmpty(personelbilgileri.durum))
                {
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Lütfen personelin tüm bilgileri giriniz.", "Personel Bilgileri Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string maasstr = personelbilgileri.maas.Replace("₺", "").Trim();

                    SqlCommand guncelle = new SqlCommand("UPDATE PERSONELLER_TBL SET AD = @ad, SOYAD = @soyad, [TEL NO] = @telno, [E-POSTA] = @eposta, DEPARTMAN = @departman, MAAŞ = @maas, [İŞE GİRİŞ TARİHİ] = @girisTarihi, DURUM = @durum WHERE ID = @id", connection);
                    guncelle.Parameters.AddWithValue("@id",personelbilgileri.id);
                    guncelle.Parameters.AddWithValue("@ad", personelbilgileri.ad);
                    guncelle.Parameters.AddWithValue("@soyad", personelbilgileri.soyad);
                    guncelle.Parameters.AddWithValue("@telno", personelbilgileri.telno);
                    guncelle.Parameters.AddWithValue("@eposta", personelbilgileri.eposta);
                    guncelle.Parameters.AddWithValue("@departman", personelbilgileri.departman);
                    guncelle.Parameters.AddWithValue("@maas", float.Parse(maasstr));
                    guncelle.Parameters.AddWithValue("@girisTarihi", personelbilgileri.girisTarihi);
                    guncelle.Parameters.AddWithValue("@durum", personelbilgileri.durum);

                    connection.Open();
                    guncelle.ExecuteNonQuery();
                    connection.Close();
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Personel güncelleme işlemi başarıyla tamamlandı.", "Personel Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa.personellerList();
                    personelbilgileri.personelList();
                    personelbilgileri.txtSil();
                }
            }
        }
        void personelSil()
        {
            if (string.IsNullOrEmpty(personelbilgileri.id))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen bir personel seçiniz.", "Personel Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fiyatStr = personelbilgileri.maas.Replace("₺", "").Trim();

                SqlCommand sil = new SqlCommand("DELETE FROM PERSONELLER_TBL WHERE ID = @id", connection);
                sil.Parameters.AddWithValue("@id", personelbilgileri.id);
                SystemSounds.Hand.Play();
                DialogResult silmeKarari = XtraMessageBox.Show(personelbilgileri.ad + " " + personelbilgileri.soyad + " personelini silmek istediğine emin misiniz?", "Personel Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silmeKarari == DialogResult.Yes)
                {
                    connection.Open();
                    sil.ExecuteNonQuery();
                    connection.Close();
                    SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Personel silme işlemi başarıyla tamamlandı.", "Personel Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anasayfa.personellerList();
                    personelbilgileri.personelList();
                    personelbilgileri.txtSil();
                }
            }
        }
        private void personelEklebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolPersonelEkle();
            
        }

        private void personelSilbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolPersonelSil();
        }

        private void personelGuncellebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolPersonelGuncelle();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            personelBilgileriDocuments personelRapor1 = new personelBilgileriDocuments(new personelRapor());
            personelRapor1.Show();
            personelRapor1.BringToFront();
        }

        public string klasorKonum = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Veritabanı Yedekleri");
        void klasorOlustur()
        {

            string txtmesaj = "Yedek dosyasını açmak için C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup klasörüne taşıyınız";
            string txtDosyaYolu = Path.Combine(klasorKonum,"Bilgilendirme Mesajı.txt");
            if (!Directory.Exists(klasorKonum))
            {
                Directory.CreateDirectory(klasorKonum);
                
            }
            File.WriteAllText(txtDosyaYolu, txtmesaj);
        }

        public string yedeklemeKonumu;
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            klasorOlustur();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Veritabanı Yedekleme Konumu Seçiniz.",
                Filter = "SQL Server Dosyaları (*.bak)|*.bak",
                InitialDirectory = klasorKonum,
                FileName = "Kutuphane_Yonetim_SistemiDB_" + DateTime.Now.ToString("dd.MM.yyyy-HH_mm") + ".bak"
            };
           
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                yedeklemeKonumu = saveFileDialog.FileName;
                try
                {
                    connection.Open();
                    SqlCommand yedekle = new SqlCommand($"BACKUP DATABASE Kutuphane_Yonetim_SistemiDB TO DISK = '{yedeklemeKonumu}' WITH INIT, STATS = 10", connection); yedekle.ExecuteNonQuery();
                    SystemSounds.Asterisk.Play();
                    XtraMessageBox.Show("Veritabanına yedekleme işlemi başarıyla tamamlandı.", "Veritabanı Yedeklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Veritabanına bağlanmaya çalışırken bir hata ile karşılaşıldı." + ex.Message, "Veritabanı Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        frmYoneticiProfilBilgileri yoneticiProfilBilgileri;
        private void profilDuzenlebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(yoneticiProfilBilgileri == null || yoneticiProfilBilgileri.IsDisposed)
            {
                yoneticiProfilBilgileri = new frmYoneticiProfilBilgileri();
                yoneticiProfilBilgileri.MdiParent = this;
                yoneticiProfilBilgileri.Show();
                yoneticiProfilBilgileri.BringToFront();
            }
            else
            {
                yoneticiProfilBilgileri.Show();
                yoneticiProfilBilgileri.BringToFront();
            }
        }
        private void sifreGuncellebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            formKontrolSifreGuncelle();
        }

        void sifreGuncelle()
        {
            if (string.IsNullOrEmpty(yoneticiProfilBilgileri.sifre))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen yönetici şifresini  giriniz.", "Yönetici Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT ŞİFRE FROM YONETICILER_TBL WHERE [KULLANICI AD] = @k_ad", connection);
                command.Parameters.AddWithValue("@k_ad", yoneticiProfilBilgileri.kullaniciAdi);
                var hashliSifreDB = command.ExecuteScalar();
                if (hashliSifreDB != null)
                {
                    string veritabaniHash = hashliSifreDB.ToString(); //Veritabanındaki hashli şifre
                    string girilenHash = frmGiris.HashPassword(yoneticiProfilBilgileri.sifre); //Girilen şifreyi hashle

                    if (veritabaniHash == girilenHash) //hashler aynıysa
                    {
                        SystemSounds.Hand.Play();
                        XtraMessageBox.Show("Yönetici şifresi aynı olamaz.", "Yönetici Şifresi Güncellenmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        SqlCommand sifreGuncelle = new SqlCommand("UPDATE YONETICILER_TBL SET ŞİFRE = @sifre WHERE ID = @id", connection);
                        sifreGuncelle.Parameters.AddWithValue("@id", yoneticiProfilBilgileri.id);
                        sifreGuncelle.Parameters.AddWithValue("@sifre", frmGiris.HashPassword(yoneticiProfilBilgileri.sifre));
                        sifreGuncelle.ExecuteNonQuery();
                        SystemSounds.Asterisk.Play();
                        XtraMessageBox.Show("Yönetici şifresi güncelleme işlemi başarılı.", "Yönetici Şifresi Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Yönetici şifresi güncelleme işlemi başarısız.", "Yönetici Şifresi Güncellenemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }


        void kullaniciAdiGuncelle()
        {
            if (string.IsNullOrEmpty(yoneticiProfilBilgileri.kullaniciAdi))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen yönetici kullanıcı adınızı  giriniz.", "Yönetici Bilgisi Eksik", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                connection.Open();

                SqlCommand kullaniciAdiGuncelle = new SqlCommand("UPDATE YONETICILER_TBL SET [KULLANICI AD] = @k_ad WHERE ID = @id", connection);
                kullaniciAdiGuncelle.Parameters.AddWithValue("@id", yoneticiProfilBilgileri.id);
                kullaniciAdiGuncelle.Parameters.AddWithValue("@k_ad",yoneticiProfilBilgileri.kullaniciAdi);
                kullaniciAdiGuncelle.ExecuteNonQuery();
                SystemSounds.Asterisk.Play();
                XtraMessageBox.Show("Yönetici kullanıcı adı güncelleme işlemi başarılı.", "Yönetici Kullanıcı Adı Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }
        void yoneticiSil()
        {

            SqlCommand sil = new SqlCommand("DELETE FROM YONETICILER_TBL WHERE ID = @id", connection);
            sil.Parameters.AddWithValue("@id", yoneticiProfilBilgileri.id);
            SystemSounds.Hand.Play();
            DialogResult silmeKarari = XtraMessageBox.Show("Hesabı silmek istediğine emin misiniz?", "Hesap Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeKarari == DialogResult.Yes)
            {
                connection.Open();
                sil.ExecuteNonQuery();
                connection.Close();
                SystemSounds.Asterisk.Play();
                XtraMessageBox.Show("Hesap silme işlemi başarıyla tamamlandı.", "Hesap Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if(girisForm == null || girisForm.IsDisposed)
                {
                    frmGiris girisForm = new frmGiris();
                    girisForm.Show();
                    girisForm.BringToFront();
                }
                else
                {
                    girisForm.Show();
                    girisForm.BringToFront();
                }

            }
        }
        void yoneticiEkle()
        {
            if(string.IsNullOrEmpty(yoneticiProfilBilgileri.kullaniciAdi) || string.IsNullOrEmpty(yoneticiProfilBilgileri.sifre))
            {
                SystemSounds.Hand.Play();
                XtraMessageBox.Show("Lütfen tüm bilgileri giriniz.", "Yönetici Bilgileri Eksik.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                connection.Open();

                SqlCommand adKontrol = new SqlCommand("SELECT [KULLANICI AD] FROM YONETICILER_TBL WHERE [KULLANICI AD] = @k_ad", connection);
                adKontrol.Parameters.AddWithValue("@k_ad", yoneticiProfilBilgileri.kullaniciAdi);
                var kullaniciVarMi = adKontrol.ExecuteScalar();

                if (kullaniciVarMi != null)
                {
                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Kullanıcı Adı zaten bulunuyor.", "Kullanıcı Adı Kullanılıyor.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string hashliSifre = frmGiris.HashPassword(yoneticiProfilBilgileri.sifre);

                    SqlCommand ekle = new SqlCommand("INSERT INTO YONETICILER_TBL ([KULLANICI AD],ŞİFRE) VALUES (@k_ad,@sifre)", connection);
                    ekle.Parameters.AddWithValue("@k_ad", yoneticiProfilBilgileri.kullaniciAdi);
                    ekle.Parameters.AddWithValue("@sifre", hashliSifre);
                    ekle.ExecuteNonQuery();

                    SystemSounds.Hand.Play();
                    XtraMessageBox.Show("Yönetici hesabu başarıyla eklendi.", "Hesap Eklendi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }




        
        void formKontrolSifreGuncelle()
        {
            if (yoneticiProfilBilgileri == null || yoneticiProfilBilgileri.IsDisposed)
            {
                yoneticiProfilBilgileri = new frmYoneticiProfilBilgileri();
                sifreGuncelle();
            }
            else
            {
                sifreGuncelle();
            }
        }
        void formKontrolKullaniciAdGuncelle()
        {
            if (yoneticiProfilBilgileri == null || yoneticiProfilBilgileri.IsDisposed)
            {
                yoneticiProfilBilgileri = new frmYoneticiProfilBilgileri();
                kullaniciAdiGuncelle();
            }
            else
            {
                kullaniciAdiGuncelle();
            }
        }
        void formKontrolYoneticiSil()
        {
            if (yoneticiProfilBilgileri == null || yoneticiProfilBilgileri.IsDisposed)
            {
                yoneticiProfilBilgileri = new frmYoneticiProfilBilgileri();
                yoneticiSil();
            }
            else
            {
                yoneticiSil();
            }
        }
        void formKontrolYoneticiEkle()
        {
            if (yoneticiProfilBilgileri == null || yoneticiProfilBilgileri.IsDisposed)
            {
                yoneticiProfilBilgileri = new frmYoneticiProfilBilgileri();
                yoneticiEkle();
            }
            else
            {
                yoneticiEkle();
            }
        }

        private void kullaniciAdGuncellebtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            formKontrolKullaniciAdGuncelle();
            yoneticiProfilBilgileri.yoneticiList();
        }

        private void profiliSilbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolYoneticiSil();
            yoneticiProfilBilgileri.yoneticiList();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKontrolYoneticiEkle();
            yoneticiProfilBilgileri.yoneticiList();
        }
        private void temalarbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Point p = new Point(2400,104);
            ribbon.Minimized = false;
            radialMenu1.ShowPopup(p);
         
        }
       
        private void FRMyonetici_Click(object sender, EventArgs e)
        {
            ribbon.Minimized = true;
        }

        private void tabletoffice_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.RibbonStyle = RibbonControlStyle.TabletOffice;   
        }

        private void defaultbtnn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.RibbonStyle = RibbonControlStyle.Default;
        }
    }
}