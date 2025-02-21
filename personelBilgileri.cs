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
    public partial class personelBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public personelBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1I3DF0\SQLEXPRESS;Initial Catalog=Kutuphane_Yonetim_SistemiDB;Integrated Security=True;");
        public string id, ad, soyad, telno, eposta, departman, maas, girisTarihi, durum;

        private void adtxt_EditValueChanged(object sender, EventArgs e)
        {
            ad = adtxt.Text;
        }

        private void idtxt_EditValueChanged(object sender, EventArgs e)
        {
            id = idtxt.Text;
        }

        private void soyadtxt_EditValueChanged(object sender, EventArgs e)
        {
            soyad = soyadtxt.Text;
        }

        private void epostatxt_EditValueChanged(object sender, EventArgs e)
        {
            eposta = epostatxt.Text;
        }

        private void departmantxt_EditValueChanged(object sender, EventArgs e)
        {
            departman = departmantxt.Text;
        }

        private void maastxt_EditValueChanged(object sender, EventArgs e)
        {
            maas = maastxt.Text;
        }


        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            durum = durumtxt.Text;
            if(durum == "Aktif")
            {
                durumSwitch.IsOn = true;
            }
            else
            {
                durumSwitch.IsOn = false;
            }
        }

        private void durumSwitch_Toggled(object sender, EventArgs e)
        {
            if(durumSwitch.IsOn)
            {
                durumtxt.Text = "Aktif";
            }
            else
            {
                durumtxt.Text = "Pasif";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSil();
        }

        private void telnotxt_EditValueChanged_1(object sender, EventArgs e)
        {
            telno = telnotxt.Text;
        }

        private void giristarihitxt_EditValueChanged(object sender, EventArgs e)
        {
            girisTarihi = giristarihitxt.Text;
        }


        private void PersonelBilgileriTablo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            personellerListApperances();
            DataRow dr = PersonelBilgileriTablo.GetDataRow(PersonelBilgileriTablo.FocusedRowHandle);

            if (dr != null)
            {
                idtxt.Text = dr[0].ToString();
                adtxt.Text = dr[1].ToString();
                soyadtxt.Text = dr[2].ToString();
                telnotxt.Text = dr[3].ToString();
                epostatxt.Text = dr[4].ToString();
                departmantxt.Text = dr[5].ToString();
                maastxt.Text = "₺" + dr[6].ToString();
                giristarihitxt.Text = dr[7].ToString();
                durumtxt.Text = dr[8].ToString();


            }
        }

        private void personelBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                personelList();
                txtSil();
                personellerLookUpEdit();
                personellerListApperances();
                DataRow dr = PersonelBilgileriTablo.GetDataRow(PersonelBilgileriTablo.FocusedRowHandle);
                departmantxt.Text = dr[4].ToString();

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

       
        void personellerLookUpEdit()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT DEPARTMAN FROM PERSONELLER_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            departmantxt.Properties.DisplayMember = "DEPARTMAN";
            departmantxt.Properties.DataSource = dt;
        }

        public void personelList()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PERSONELLER_TBL", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PersonelBilgiler.DataSource = dt;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in PersonelBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            PersonelBilgileriTablo.BestFitColumns();
            PersonelBilgileriTablo.Columns["ID"].Visible = false;


        }
        Font baslikFont = new Font("Tahoma", 8, FontStyle.Bold);
        void personellerListApperances()
        {

            PersonelBilgileriTablo.Appearance.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#ADD8E6");
            PersonelBilgileriTablo.Appearance.Row.BackColor2 = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
            PersonelBilgileriTablo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            PersonelBilgileriTablo.Appearance.FocusedRow.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");
            PersonelBilgileriTablo.Appearance.FocusedCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#21afde");


            PersonelBilgileriTablo.Columns["MAAŞ"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            PersonelBilgileriTablo.Columns["MAAŞ"].DisplayFormat.FormatString = "c2";
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in PersonelBilgileriTablo.Columns)
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceHeader.ForeColor = Color.Black;
                column.AppearanceHeader.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ac7e6");
                column.AppearanceHeader.Font = baslikFont;
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            PersonelBilgileriTablo.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll | DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            PersonelBilgileriTablo.OptionsBehavior.Editable = false;
            PersonelBilgileriTablo.OptionsView.ShowIndicator = false;



        }
        public void txtSil()
        {
            idtxt.Clear();
            adtxt.Clear();
            soyadtxt.Clear();
            telnotxt.Clear();
            epostatxt.Clear();
            departmantxt.Clear();
            maastxt.Clear();
            giristarihitxt.Clear();
        }

    }
}