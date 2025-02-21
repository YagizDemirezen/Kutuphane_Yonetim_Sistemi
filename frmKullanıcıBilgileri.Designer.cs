namespace Kütüphane_Yönetim_Sistemi
{
    partial class frmKullanıcıBilgileri
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
            this.bilgiPanel = new DevExpress.XtraEditors.PanelControl();
            this.kayitTarihtxt = new DevExpress.XtraEditors.TextEdit();
            this.kullaniciAdtxt = new DevExpress.XtraEditors.TextEdit();
            this.epostatxt = new DevExpress.XtraEditors.TextEdit();
            this.telnotxt = new DevExpress.XtraEditors.TextEdit();
            this.soyadtxt = new DevExpress.XtraEditors.TextEdit();
            this.adtxt = new DevExpress.XtraEditors.TextEdit();
            this.idtxt = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullaniciBilgileri = new DevExpress.XtraGrid.GridControl();
            this.kullaniciBilgileriTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).BeginInit();
            this.bilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTarihtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epostatxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telnotxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileriTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.Controls.Add(this.kayitTarihtxt);
            this.bilgiPanel.Controls.Add(this.kullaniciAdtxt);
            this.bilgiPanel.Controls.Add(this.epostatxt);
            this.bilgiPanel.Controls.Add(this.telnotxt);
            this.bilgiPanel.Controls.Add(this.soyadtxt);
            this.bilgiPanel.Controls.Add(this.adtxt);
            this.bilgiPanel.Controls.Add(this.idtxt);
            this.bilgiPanel.Controls.Add(this.pictureBox2);
            this.bilgiPanel.Controls.Add(this.labelControl7);
            this.bilgiPanel.Controls.Add(this.labelControl6);
            this.bilgiPanel.Controls.Add(this.labelControl5);
            this.bilgiPanel.Controls.Add(this.labelControl4);
            this.bilgiPanel.Controls.Add(this.labelControl3);
            this.bilgiPanel.Controls.Add(this.labelControl2);
            this.bilgiPanel.Controls.Add(this.labelControl1);
            this.bilgiPanel.Controls.Add(this.pictureBox1);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bilgiPanel.Enabled = false;
            this.bilgiPanel.Location = new System.Drawing.Point(1564, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(376, 1040);
            this.bilgiPanel.TabIndex = 2;
            // 
            // kayitTarihtxt
            // 
            this.kayitTarihtxt.Enabled = false;
            this.kayitTarihtxt.Location = new System.Drawing.Point(146, 360);
            this.kayitTarihtxt.Name = "kayitTarihtxt";
            this.kayitTarihtxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.kayitTarihtxt.Properties.MaskSettings.Set("mask", "d");
            this.kayitTarihtxt.Size = new System.Drawing.Size(218, 22);
            this.kayitTarihtxt.TabIndex = 32;
            this.kayitTarihtxt.EditValueChanged += new System.EventHandler(this.kayitTarihtxt_EditValueChanged);
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Enabled = false;
            this.kullaniciAdtxt.Location = new System.Drawing.Point(146, 314);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(218, 22);
            this.kullaniciAdtxt.TabIndex = 31;
            this.kullaniciAdtxt.EditValueChanged += new System.EventHandler(this.kullaniciAdtxt_EditValueChanged);
            // 
            // epostatxt
            // 
            this.epostatxt.Enabled = false;
            this.epostatxt.Location = new System.Drawing.Point(146, 260);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(218, 22);
            this.epostatxt.TabIndex = 30;
            this.epostatxt.EditValueChanged += new System.EventHandler(this.epostatxt_EditValueChanged);
            // 
            // telnotxt
            // 
            this.telnotxt.Enabled = false;
            this.telnotxt.Location = new System.Drawing.Point(146, 214);
            this.telnotxt.Name = "telnotxt";
            this.telnotxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.telnotxt.Properties.MaskSettings.Set("mask", "(\\+90) [0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
            this.telnotxt.Size = new System.Drawing.Size(218, 22);
            this.telnotxt.TabIndex = 29;
            this.telnotxt.EditValueChanged += new System.EventHandler(this.telnotxt_EditValueChanged);
            // 
            // soyadtxt
            // 
            this.soyadtxt.Enabled = false;
            this.soyadtxt.Location = new System.Drawing.Point(146, 164);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.soyadtxt.Properties.MaskSettings.Set("mask", "\\p{Lu}[a-zA-ZıİçÇğĞııöÖşŞüÜ]{1,}");
            this.soyadtxt.Size = new System.Drawing.Size(218, 22);
            this.soyadtxt.TabIndex = 28;
            this.soyadtxt.EditValueChanged += new System.EventHandler(this.soyadtxt_EditValueChanged);
            // 
            // adtxt
            // 
            this.adtxt.Enabled = false;
            this.adtxt.Location = new System.Drawing.Point(146, 110);
            this.adtxt.Name = "adtxt";
            this.adtxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.adtxt.Properties.MaskSettings.Set("mask", "\\p{Lu}[a-zA-ZıİçÇğĞııöÖşŞüÜ]{1,}");
            this.adtxt.Size = new System.Drawing.Size(218, 22);
            this.adtxt.TabIndex = 27;
            this.adtxt.EditValueChanged += new System.EventHandler(this.adtxt_EditValueChanged);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(189, 60);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(125, 22);
            this.idtxt.TabIndex = 26;
            this.idtxt.Visible = false;
            this.idtxt.EditValueChanged += new System.EventHandler(this.idtxt_EditValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.recurrence_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 363);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 21);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Kayıt Tarihi:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 313);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(112, 21);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Kullanıcı Adı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 263);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 21);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "E-Posta:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 21);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Telefon No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 21);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Soyad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 21);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Ad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(179, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BİLGİLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.info_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(133, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // kullaniciBilgileri
            // 
            this.kullaniciBilgileri.Dock = System.Windows.Forms.DockStyle.Left;
            this.kullaniciBilgileri.Location = new System.Drawing.Point(0, 0);
            this.kullaniciBilgileri.MainView = this.kullaniciBilgileriTablo;
            this.kullaniciBilgileri.Name = "kullaniciBilgileri";
            this.kullaniciBilgileri.Size = new System.Drawing.Size(1539, 1040);
            this.kullaniciBilgileri.TabIndex = 3;
            this.kullaniciBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kullaniciBilgileriTablo});
            // 
            // kullaniciBilgileriTablo
            // 
            this.kullaniciBilgileriTablo.GridControl = this.kullaniciBilgileri;
            this.kullaniciBilgileriTablo.Name = "kullaniciBilgileriTablo";
            this.kullaniciBilgileriTablo.OptionsView.ShowGroupPanel = false;
            this.kullaniciBilgileriTablo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.kullaniciBilgileriTablo_FocusedRowChanged);
            // 
            // frmKullanıcıBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1040);
            this.Controls.Add(this.kullaniciBilgileri);
            this.Controls.Add(this.bilgiPanel);
            this.Name = "frmKullanıcıBilgileri";
            this.Text = "kullanıcıBilgileri";
            this.Load += new System.EventHandler(this.frmKullanıcıBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).EndInit();
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayitTarihtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epostatxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telnotxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBilgileriTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bilgiPanel;
        private DevExpress.XtraEditors.TextEdit idtxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl kullaniciBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView kullaniciBilgileriTablo;
        private DevExpress.XtraEditors.TextEdit adtxt;
        private DevExpress.XtraEditors.TextEdit kayitTarihtxt;
        private DevExpress.XtraEditors.TextEdit kullaniciAdtxt;
        private DevExpress.XtraEditors.TextEdit epostatxt;
        private DevExpress.XtraEditors.TextEdit telnotxt;
        private DevExpress.XtraEditors.TextEdit soyadtxt;
    }
}