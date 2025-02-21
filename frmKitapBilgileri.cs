using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
        

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class frmKitapBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public frmKitapBilgileri()
        {
            InitializeComponent();
        }
        public string id, ad, yazar, yayinEvi, basimYili, kategori, dil, aciklama, eklenmeTarihi, sayfaSayisi, stokAdet, fiyat;


        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        public void kitaplarList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KITAPLAR_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            KitapBilgileri.DataSource = dt;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in KitapBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            KitapBilgileriTablo.BestFitColumns();
            KitapBilgileriTablo.Columns["ID"].Visible = false;
            

        }
        Font baslikFont = new Font("Tahoma", 8, FontStyle.Bold);
        void kitaplarListApperances()
        {
            
            KitapBilgileriTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            KitapBilgileriTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            KitapBilgileriTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            KitapBilgileriTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");
            KitapBilgileriTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");


            KitapBilgileriTablo.Columns["FİYAT"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            KitapBilgileriTablo.Columns["FİYAT"].DisplayFormat.FormatString = "c2";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in KitapBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            KitapBilgileriTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            KitapBilgileriTablo.OptionsBehavior.Editable = false;
            KitapBilgileriTablo.OptionsView.ShowIndicator = false;



        }
        public void txtSil()
        {
            idtxt.Clear();
            adtxt.Clear();
            yazartxt.Clear();
            yayınEvitxt.Clear();
            basımYılıtxt.Clear();
            kategoritxt.Clear();
            sayfaSayisitxt.Clear();
            diltxt.Clear();
            stokAdettxt.Clear();
            fiyattxt.Clear();
            eklenmeTarihitxt.Clear();
            aciklamatxt.Clear();
        }
        private void frmKitapBilgileri_Load(object sender, EventArgs e)
        {
            basımYılıtxt.Properties.DisplayFormat.FormatString = "yyyy";
            basımYılıtxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            basımYılıtxt.Properties.Mask.EditMask = "yyyy";
            basımYılıtxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            basımYılıtxt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            try
            {
                connection.Open();
                kitaplarList();
                txtSil();
                kategorilerLookUpEdit();
                kitaplarListApperances();
                DataRow dr = KitapBilgileriTablo.GetDataRow(KitapBilgileriTablo.FocusedRowHandle);
                kategoritxt.Text = dr[4].ToString();

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
        private void adtxt_EditValueChanged(object sender, EventArgs e)
        {
            ad = adtxt.Text;
        }

        private void yazartxt_EditValueChanged(object sender, EventArgs e)
        {
            yazar = yazartxt.Text;
        }

        private void yayınEvitxt_EditValueChanged(object sender, EventArgs e)
        {
            yayinEvi = yayınEvitxt.Text;
        }

        private void basımYılıtxt_EditValueChanged(object sender, EventArgs e)
        {
            basimYili = basımYılıtxt.Text;
        }

        private void fiyattxt_EditValueChanged(object sender, EventArgs e)
        {
            fiyat = fiyattxt.Text;
        }


        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            eklenmeTarihi = eklenmeTarihitxt.Text;
        }

        private void basımYılıtxt_EditValueChanged_1(object sender, EventArgs e)
        {
            basimYili = basımYılıtxt.Text;
        }

        private void idtxt_EditValueChanged(object sender, EventArgs e)
        {
            id = idtxt.Text;
        }

        private void kategoritxt_EditValueChanged(object sender, EventArgs e)
        {
            kategori = kategoritxt.Text;
        }

        private void sayfaSayisitxt_EditValueChanged(object sender, EventArgs e)
        {
            sayfaSayisi = sayfaSayisitxt.Text;
        }

        private void diltxt_EditValueChanged(object sender, EventArgs e)
        {
            dil = diltxt.Text;
        }

        private void stokAdettxt_EditValueChanged(object sender, EventArgs e)
        {
            stokAdet = stokAdettxt.Text;
        }

        private void aciklamatxt_TextChanged(object sender, EventArgs e)
        {
            aciklama = aciklamatxt.Text;
        }

        private void eklenmeTarihitxt_EditValueChanged(object sender, EventArgs e)
        {
            eklenmeTarihi = eklenmeTarihitxt.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kitaplarList();
        }
        void kategorilerLookUpEdit()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT KATEGORİ FROM KITAPLAR_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kategoritxt.Properties.DisplayMember = "KATEGORİ";
            kategoritxt.Properties.DataSource = dt;
        }

        private void KitapBilgileriTablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            kitaplarListApperances();
            DataRow dr = KitapBilgileriTablo.GetDataRow(KitapBilgileriTablo.FocusedRowHandle);

            if(dr != null)
            {
                idtxt.Text = dr[0].ToString();
                adtxt.Text = dr[1].ToString();
                yazartxt.Text = dr[2].ToString();
                yayınEvitxt.Text = dr[3].ToString();
                basımYılıtxt.Text = dr[4].ToString();
                kategoritxt.Text = dr[5].ToString();
                sayfaSayisitxt.Text = dr[6].ToString();
                diltxt.Text = dr[7].ToString();
                stokAdettxt.Text = dr[8].ToString();
                fiyattxt.Text = "₺" + dr[9].ToString();
                eklenmeTarihitxt.Text = dr[10].ToString();
                aciklamatxt.Text = dr[11].ToString();

            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSil();
        }
    }
}