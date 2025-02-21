using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraRichEdit.Import.Html;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        public void kitaplarList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 AD, YAZAR, [YAYIN EVİ], KATEGORİ, [STOK ADET], FİYAT, [EKLENME TARİHİ] FROM KITAPLAR_TBL  ORDER BY ID DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Sonkitap.DataSource = dt;
            

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonkitapTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonkitapTablo.BestFitColumns();
        }
        public void kullanicilarList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 AD, SOYAD, [TEL NO], [E-POSTA], [KULLANICI AD], [KAYIT TARİHİ] FROM KULLANICILAR_TBL ORDER BY ID DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SonKullanici.DataSource = dt;


            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonkitapTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonkitapTablo.BestFitColumns();
        }
        public void personellerList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 AD, SOYAD,DEPARTMAN, MAAŞ,DURUM FROM PERSONELLER_TBL ORDER BY ID DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sonPersonel.DataSource = dt;


            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonkitapTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonpersonelTablo.BestFitColumns();
        }


        Font baslikFont = new Font("Tahoma", 8, FontStyle.Bold);
        void kitaplarListApperances()
        {

            SonkitapTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonkitapTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            SonkitapTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            SonkitapTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonkitapTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");


            SonkitapTablo.Columns["FİYAT"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            SonkitapTablo.Columns["FİYAT"].DisplayFormat.FormatString = "c2";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonkitapTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonkitapTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            SonkitapTablo.OptionsBehavior.Editable = false;
            SonkitapTablo.OptionsView.ShowIndicator = false;
        }

        void kullanicilarListApperances()
        {

            SonkullaniciTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonkullaniciTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            SonkullaniciTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            SonkullaniciTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonkullaniciTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonkullaniciTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonkullaniciTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            SonkullaniciTablo.OptionsBehavior.Editable = false;
            SonkullaniciTablo.OptionsView.ShowIndicator = false;
        }
        void personellerListApperances()
        {

            SonpersonelTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonpersonelTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            SonpersonelTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            SonpersonelTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            SonpersonelTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");

            SonpersonelTablo.Columns["MAAŞ"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            SonpersonelTablo.Columns["MAAŞ"].DisplayFormat.FormatString = "c2";

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in SonpersonelTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            SonpersonelTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            SonpersonelTablo.OptionsBehavior.Editable = false;
            SonpersonelTablo.OptionsView.ShowIndicator = false;
        }
        public void chartControlDoldurKitap()
        {
            connection.Open();
            SqlCommand fillChart = new SqlCommand("SELECT TOP 25 KATEGORİ, COUNT(*) AS [KİTAP SAYISI] FROM KITAPLAR_TBL GROUP BY KATEGORi", connection);
            SqlDataReader dr = fillChart.ExecuteReader();
            while (dr.Read())
            {
                KitapTurleri_ilk25.Series["Kitap Türleri ve Sayıları"].Points.AddPoint(
                    dr[0].ToString(), // Kategori ismi
                    int.Parse(dr[1].ToString()) // Kitap sayısı
                );
            }
            dr.Close();
            connection.Close();
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            chartControlDoldurKitap();
            try
            {
                connection.Open();
                
                kitaplarList();
                kullanicilarList();
                personellerList();
                kitaplarListApperances();
                kullanicilarListApperances();
                personellerListApperances();
                
                

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

    }
}
