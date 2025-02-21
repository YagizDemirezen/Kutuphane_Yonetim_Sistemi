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
using DevExpress.XtraEditors;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class frmKullanıcıBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public frmKullanıcıBilgileri()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, telno, eposta, kullaniciad, kayitTarihi;

        private void idtxt_EditValueChanged(object sender, EventArgs e)
        {
            id = idtxt.Text;
        }

        private void adtxt_EditValueChanged(object sender, EventArgs e)
        {
            ad = adtxt.Text;
        }

        private void telnotxt_EditValueChanged(object sender, EventArgs e)
        {
            telno = telnotxt.Text;  
        }

        private void soyadtxt_EditValueChanged(object sender, EventArgs e)
        {
            soyad = soyadtxt.Text;
        }

        private void epostatxt_EditValueChanged(object sender, EventArgs e)
        {
            eposta = epostatxt.Text;
        }

        private void kullaniciAdtxt_EditValueChanged(object sender, EventArgs e)
        {
            kullaniciad = kullaniciAdtxt.Text;
        }

        private void kayitTarihtxt_EditValueChanged(object sender, EventArgs e)
        {
            kayitTarihi = kayitTarihtxt.Text;
        }

        private void kullaniciBilgileriTablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            kullanicilarListApperances();
            DataRow dr = kullaniciBilgileriTablo.GetDataRow(kullaniciBilgileriTablo.FocusedRowHandle);

            if (dr != null)
            {
                idtxt.Text = dr[0].ToString();
                adtxt.Text = dr[1].ToString();
                soyadtxt.Text = dr[2].ToString();
                telnotxt.Text = dr[3].ToString();
                epostatxt.Text = dr[4].ToString();
                kullaniciAdtxt.Text = dr[5].ToString();
                kayitTarihtxt.Text = dr[6].ToString();

            }
        }

        private void frmKullanıcıBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                kullanicilarList();
                txtSil();

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

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");

        public void kullanicilarList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,AD,SOYAD,[TEL NO],[E-POSTA],[KULLANICI AD],[KAYIT TARİHİ] FROM KULLANICILAR_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kullaniciBilgileri.DataSource = dt;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in kullaniciBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            kullaniciBilgileriTablo.BestFitColumns();
            kullaniciBilgileriTablo.Columns["ID"].Visible = false;


        }
        Font baslikFont = new Font("Tahoma", 8, FontStyle.Bold);
        void kullanicilarListApperances()
        {

            kullaniciBilgileriTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            kullaniciBilgileriTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            kullaniciBilgileriTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            kullaniciBilgileriTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");
            kullaniciBilgileriTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in kullaniciBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            kullaniciBilgileriTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            kullaniciBilgileriTablo.OptionsBehavior.Editable = false;
            kullaniciBilgileriTablo.OptionsView.ShowIndicator = false;



        }
        public void txtSil()
        {
            idtxt.Clear();
            adtxt.Clear();
            soyadtxt.Clear();
            telnotxt.Clear();
            epostatxt.Clear();
            kullaniciAdtxt.Clear();
            kayitTarihtxt.Clear();
        
        }



    }
}