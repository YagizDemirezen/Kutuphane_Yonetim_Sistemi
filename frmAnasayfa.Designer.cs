namespace Kütüphane_Yönetim_Sistemi
{
    partial class frmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.SonKullanici = new DevExpress.XtraGrid.GridControl();
            this.SonkullaniciTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sonKayitlbl = new DevExpress.XtraEditors.LabelControl();
            this.SonkitapTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sonkitap = new DevExpress.XtraGrid.GridControl();
            this.sonKitaplar = new DevExpress.XtraEditors.LabelControl();
            this.KitapTurleri_ilk25 = new DevExpress.XtraCharts.ChartControl();
            this.sonPersonel = new DevExpress.XtraGrid.GridControl();
            this.SonpersonelTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.SonKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonkullaniciTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonkitapTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sonkitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapTurleri_ilk25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonpersonelTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // SonKullanici
            // 
            this.SonKullanici.Location = new System.Drawing.Point(1096, 43);
            this.SonKullanici.MainView = this.SonkullaniciTablo;
            this.SonKullanici.Name = "SonKullanici";
            this.SonKullanici.Size = new System.Drawing.Size(535, 280);
            this.SonKullanici.TabIndex = 1;
            this.SonKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SonkullaniciTablo});
            // 
            // SonkullaniciTablo
            // 
            this.SonkullaniciTablo.GridControl = this.SonKullanici;
            this.SonkullaniciTablo.Name = "SonkullaniciTablo";
            this.SonkullaniciTablo.OptionsView.ShowGroupPanel = false;
            // 
            // sonKayitlbl
            // 
            this.sonKayitlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sonKayitlbl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sonKayitlbl.Appearance.Options.UseFont = true;
            this.sonKayitlbl.Appearance.Options.UseForeColor = true;
            this.sonKayitlbl.Location = new System.Drawing.Point(1228, 12);
            this.sonKayitlbl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sonKayitlbl.Name = "sonKayitlbl";
            this.sonKayitlbl.Size = new System.Drawing.Size(281, 24);
            this.sonKayitlbl.TabIndex = 4;
            this.sonKayitlbl.Text = "SON KULLANICI KAYITLARI";
            // 
            // SonkitapTablo
            // 
            this.SonkitapTablo.GridControl = this.Sonkitap;
            this.SonkitapTablo.Name = "SonkitapTablo";
            this.SonkitapTablo.OptionsView.ShowGroupPanel = false;
            // 
            // Sonkitap
            // 
            this.Sonkitap.Location = new System.Drawing.Point(30, 43);
            this.Sonkitap.MainView = this.SonkitapTablo;
            this.Sonkitap.Name = "Sonkitap";
            this.Sonkitap.Size = new System.Drawing.Size(1050, 280);
            this.Sonkitap.TabIndex = 0;
            this.Sonkitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SonkitapTablo});
            // 
            // sonKitaplar
            // 
            this.sonKitaplar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonKitaplar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sonKitaplar.Appearance.Options.UseFont = true;
            this.sonKitaplar.Appearance.Options.UseForeColor = true;
            this.sonKitaplar.Location = new System.Drawing.Point(444, 14);
            this.sonKitaplar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sonKitaplar.Name = "sonKitaplar";
            this.sonKitaplar.Size = new System.Drawing.Size(250, 24);
            this.sonKitaplar.TabIndex = 6;
            this.sonKitaplar.Text = "SON EKLENEN KİTAPLAR";
            // 
            // KitapTurleri_ilk25
            // 
            xyDiagram2.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram2.AxisX.MinorCount = 1;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.WholeRange.Auto = false;
            xyDiagram2.AxisX.WholeRange.MaxValueSerializable = "24";
            xyDiagram2.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.KitapTurleri_ilk25.Diagram = xyDiagram2;
            this.KitapTurleri_ilk25.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.KitapTurleri_ilk25.Legend.Title.Text = "Tür ve Adet";
            this.KitapTurleri_ilk25.Legend.Title.Visible = true;
            this.KitapTurleri_ilk25.Location = new System.Drawing.Point(0, 462);
            this.KitapTurleri_ilk25.Name = "KitapTurleri_ilk25";
            series2.Name = "Kitap Türleri ve Sayıları";
            sideBySideBarSeriesView2.BarWidth = 0.1D;
            sideBySideBarSeriesView2.ColorEach = true;
            series2.View = sideBySideBarSeriesView2;
            this.KitapTurleri_ilk25.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.KitapTurleri_ilk25.Size = new System.Drawing.Size(2194, 456);
            this.KitapTurleri_ilk25.TabIndex = 7;
            // 
            // sonPersonel
            // 
            this.sonPersonel.Location = new System.Drawing.Point(1637, 43);
            this.sonPersonel.MainView = this.SonpersonelTablo;
            this.sonPersonel.Name = "sonPersonel";
            this.sonPersonel.Size = new System.Drawing.Size(535, 280);
            this.sonPersonel.TabIndex = 8;
            this.sonPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SonpersonelTablo});
            // 
            // SonpersonelTablo
            // 
            this.SonpersonelTablo.GridControl = this.sonPersonel;
            this.SonpersonelTablo.Name = "SonpersonelTablo";
            this.SonpersonelTablo.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1772, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 24);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "SON PERSONEL KAYITLARI";
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 789);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sonPersonel);
            this.Controls.Add(this.KitapTurleri_ilk25);
            this.Controls.Add(this.sonKitaplar);
            this.Controls.Add(this.sonKayitlbl);
            this.Controls.Add(this.SonKullanici);
            this.Controls.Add(this.Sonkitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnasayfa";
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SonKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonkullaniciTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonkitapTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sonkitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapTurleri_ilk25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonpersonelTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl SonKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView SonkullaniciTablo;
        private DevExpress.XtraEditors.LabelControl sonKayitlbl;
        private DevExpress.XtraGrid.Views.Grid.GridView SonkitapTablo;
        private DevExpress.XtraGrid.GridControl Sonkitap;
        private DevExpress.XtraEditors.LabelControl sonKitaplar;
        private DevExpress.XtraCharts.ChartControl KitapTurleri_ilk25;
        private DevExpress.XtraGrid.GridControl sonPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView SonpersonelTablo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}