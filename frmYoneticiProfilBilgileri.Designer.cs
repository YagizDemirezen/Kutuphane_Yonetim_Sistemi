namespace Kütüphane_Yönetim_Sistemi
{
    partial class frmYoneticiProfilBilgileri
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
            this.sifretxt = new DevExpress.XtraEditors.TextEdit();
            this.kullaniciAdtxt = new DevExpress.XtraEditors.TextEdit();
            this.idtxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yoneticiBilgileri = new DevExpress.XtraGrid.GridControl();
            this.yoneticiBilgileriTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).BeginInit();
            this.bilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifretxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBilgileriTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.Controls.Add(this.sifretxt);
            this.bilgiPanel.Controls.Add(this.kullaniciAdtxt);
            this.bilgiPanel.Controls.Add(this.idtxt);
            this.bilgiPanel.Controls.Add(this.labelControl3);
            this.bilgiPanel.Controls.Add(this.labelControl2);
            this.bilgiPanel.Controls.Add(this.labelControl1);
            this.bilgiPanel.Controls.Add(this.pictureBox1);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bilgiPanel.Location = new System.Drawing.Point(1462, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(462, 1033);
            this.bilgiPanel.TabIndex = 3;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(190, 164);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(218, 22);
            this.sifretxt.TabIndex = 28;
            this.sifretxt.EditValueChanged += new System.EventHandler(this.sifretxt_EditValueChanged_1);
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(190, 114);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(218, 22);
            this.kullaniciAdtxt.TabIndex = 27;
            this.kullaniciAdtxt.EditValueChanged += new System.EventHandler(this.kullaniciAdtxt_EditValueChanged);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(229, 60);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(125, 22);
            this.idtxt.TabIndex = 26;
            this.idtxt.Visible = false;
            this.idtxt.EditValueChanged += new System.EventHandler(this.idtxt_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 21);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Şifre:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 21);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(219, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BİLGİLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.info_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(173, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // yoneticiBilgileri
            // 
            this.yoneticiBilgileri.Dock = System.Windows.Forms.DockStyle.Left;
            this.yoneticiBilgileri.Location = new System.Drawing.Point(0, 0);
            this.yoneticiBilgileri.MainView = this.yoneticiBilgileriTablo;
            this.yoneticiBilgileri.Name = "yoneticiBilgileri";
            this.yoneticiBilgileri.Size = new System.Drawing.Size(1456, 1033);
            this.yoneticiBilgileri.TabIndex = 4;
            this.yoneticiBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.yoneticiBilgileriTablo});
            // 
            // yoneticiBilgileriTablo
            // 
            this.yoneticiBilgileriTablo.GridControl = this.yoneticiBilgileri;
            this.yoneticiBilgileriTablo.Name = "yoneticiBilgileriTablo";
            this.yoneticiBilgileriTablo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.yoneticiBilgileriTablo_FocusedRowChanged);
            // 
            // frmYoneticiProfilBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.yoneticiBilgileri);
            this.Controls.Add(this.bilgiPanel);
            this.Name = "frmYoneticiProfilBilgileri";
            this.Text = "frmYoneticiProfilBilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYoneticiProfilBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).EndInit();
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifretxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBilgileriTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bilgiPanel;
        private DevExpress.XtraEditors.TextEdit idtxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl yoneticiBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView yoneticiBilgileriTablo;
        private DevExpress.XtraEditors.TextEdit sifretxt;
        private DevExpress.XtraEditors.TextEdit kullaniciAdtxt;
    }
}