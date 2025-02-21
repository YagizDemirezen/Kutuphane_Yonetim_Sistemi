namespace Kütüphane_Yönetim_Sistemi
{
    partial class FRMkullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMkullanici));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.k_adlabel = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.KitapBilgileri = new DevExpress.XtraGrid.GridControl();
            this.KitapBilgileriTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileriTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barButtonItem4);
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.k_adlabel,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.k_adlabel);
            this.ribbon.Size = new System.Drawing.Size(1922, 71);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Çıkış Yap";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.close_32x32;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "KİTAP BİLGİLERİ";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.about_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // k_adlabel
            // 
            this.k_adlabel.Caption = "barStaticItem1";
            this.k_adlabel.Id = 3;
            this.k_adlabel.ImageOptions.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.customer_32x32;
            this.k_adlabel.Name = "k_adlabel";
            this.k_adlabel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // KitapBilgileri
            // 
            this.KitapBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KitapBilgileri.Location = new System.Drawing.Point(0, 71);
            this.KitapBilgileri.MainView = this.KitapBilgileriTablo;
            this.KitapBilgileri.Name = "KitapBilgileri";
            this.KitapBilgileri.Size = new System.Drawing.Size(1922, 1008);
            this.KitapBilgileri.TabIndex = 2;
            this.KitapBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KitapBilgileriTablo});
            // 
            // KitapBilgileriTablo
            // 
            this.KitapBilgileriTablo.GridControl = this.KitapBilgileri;
            this.KitapBilgileriTablo.Name = "KitapBilgileriTablo";
            this.KitapBilgileriTablo.OptionsView.ShowGroupPanel = false;
            // 
            // FRMkullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1079);
            this.Controls.Add(this.KitapBilgileri);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FRMkullanici.IconOptions.Image")));
            this.Name = "FRMkullanici";
            this.Ribbon = this.ribbon;
            this.Text = "Kullanıcı Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMkullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileriTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem k_adlabel;
        private DevExpress.XtraGrid.GridControl KitapBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView KitapBilgileriTablo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}