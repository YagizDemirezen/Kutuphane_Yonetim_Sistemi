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
using System.Security.Cryptography;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class frmYoneticiProfilBilgileri : Form
    {
        public frmYoneticiProfilBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        public void yoneticiList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YONETICILER_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            yoneticiBilgileri.DataSource = dt;
            yoneticiBilgileriTablo.BestFitColumns();
            yoneticiBilgileriTablo.Columns["ID"].Visible = false;
            yoneticiBilgileriTablo.Columns["ŞİFRE"].Visible = false;
        }
        Font baslikFont = new Font("Tahoma", 8, FontStyle.Bold);
        void yoneticilerlistApperances()
        {

            yoneticiBilgileriTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            yoneticiBilgileriTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            yoneticiBilgileriTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            yoneticiBilgileriTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");
            yoneticiBilgileriTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in yoneticiBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            yoneticiBilgileriTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            yoneticiBilgileriTablo.OptionsBehavior.Editable = false;
            yoneticiBilgileriTablo.OptionsView.ShowIndicator = false;
            yoneticiBilgileriTablo.OptionsView.ShowGroupPanel = false;


        }
        private void yoneticiBilgileriTablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = yoneticiBilgileriTablo.GetDataRow(yoneticiBilgileriTablo.FocusedRowHandle);
            
            if (dr != null)
            {
                idtxt.Text = dr[0].ToString();
                kullaniciAdtxt.Text = dr[1].ToString();

            }
        }
        public string kullaniciAdi, sifre, id;

        private void frmYoneticiProfilBilgileri_Load(object sender, EventArgs e)
        {
            yoneticiList();
            yoneticilerlistApperances();
        }


        private void kullaniciAdtxt_EditValueChanged(object sender, EventArgs e)
        {
            kullaniciAdi = kullaniciAdtxt.Text;
            
        }

        private void sifretxt_EditValueChanged_1(object sender, EventArgs e)
        {
            sifre = sifretxt.Text;
        }

        private void idtxt_EditValueChanged(object sender, EventArgs e)
        {
            id = idtxt.Text;
        }
    }
}
