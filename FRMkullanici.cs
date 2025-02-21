using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FRMkullanici : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRMkullanici()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        private void acilisEkran()
        {
            ribbon.Minimized = true;
            this.Refresh();
            k_adlabel.Caption = frmGiris.kullaniciAdi;
            Font sagUstFont = new Font("Times New Roman", 14, FontStyle.Bold);
            k_adlabel.ItemAppearance.SetFont(sagUstFont);
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowToolbarCustomizeItem = false;

        }

        private void FRMkullanici_Load(object sender, EventArgs e)
        {
            acilisEkran();
            kitaplarList();
            kitaplarListApperances();
        }
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
        frmGiris girisForm;
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
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
    }
}