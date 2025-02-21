namespace Kütüphane_Yönetim_Sistemi
{
    partial class frmKitapBilgileri
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
            this.KitapBilgileri = new DevExpress.XtraGrid.GridControl();
            this.KitapBilgileriTablo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bilgiPanel = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.basımYılıtxt = new DevExpress.XtraEditors.DateEdit();
            this.eklenmeTarihitxt = new DevExpress.XtraEditors.DateEdit();
            this.idtxt = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.aciklamatxt = new System.Windows.Forms.RichTextBox();
            this.fiyattxt = new DevExpress.XtraEditors.TextEdit();
            this.stokAdettxt = new DevExpress.XtraEditors.TextEdit();
            this.diltxt = new DevExpress.XtraEditors.TextEdit();
            this.sayfaSayisitxt = new DevExpress.XtraEditors.TextEdit();
            this.yayınEvitxt = new DevExpress.XtraEditors.TextEdit();
            this.yazartxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.adtxt = new DevExpress.XtraEditors.TextEdit();
            this.kategoritxt = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileriTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).BeginInit();
            this.bilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basımYılıtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basımYılıtxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklenmeTarihitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklenmeTarihitxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiyattxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokAdettxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diltxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayınEvitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazartxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoritxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapBilgileri
            // 
            this.KitapBilgileri.Dock = System.Windows.Forms.DockStyle.Left;
            this.KitapBilgileri.Location = new System.Drawing.Point(0, 0);
            this.KitapBilgileri.MainView = this.KitapBilgileriTablo;
            this.KitapBilgileri.Name = "KitapBilgileri";
            this.KitapBilgileri.Size = new System.Drawing.Size(1539, 749);
            this.KitapBilgileri.TabIndex = 0;
            this.KitapBilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KitapBilgileriTablo});
            // 
            // KitapBilgileriTablo
            // 
            this.KitapBilgileriTablo.GridControl = this.KitapBilgileri;
            this.KitapBilgileriTablo.Name = "KitapBilgileriTablo";
            this.KitapBilgileriTablo.OptionsView.ShowGroupPanel = false;
            this.KitapBilgileriTablo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.KitapBilgileriTablo_FocusedRowChanged);
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.Controls.Add(this.simpleButton1);
            this.bilgiPanel.Controls.Add(this.basımYılıtxt);
            this.bilgiPanel.Controls.Add(this.eklenmeTarihitxt);
            this.bilgiPanel.Controls.Add(this.idtxt);
            this.bilgiPanel.Controls.Add(this.pictureBox2);
            this.bilgiPanel.Controls.Add(this.labelControl12);
            this.bilgiPanel.Controls.Add(this.labelControl11);
            this.bilgiPanel.Controls.Add(this.labelControl10);
            this.bilgiPanel.Controls.Add(this.labelControl9);
            this.bilgiPanel.Controls.Add(this.labelControl8);
            this.bilgiPanel.Controls.Add(this.labelControl7);
            this.bilgiPanel.Controls.Add(this.labelControl6);
            this.bilgiPanel.Controls.Add(this.labelControl5);
            this.bilgiPanel.Controls.Add(this.labelControl4);
            this.bilgiPanel.Controls.Add(this.labelControl3);
            this.bilgiPanel.Controls.Add(this.labelControl2);
            this.bilgiPanel.Controls.Add(this.panelControl2);
            this.bilgiPanel.Controls.Add(this.fiyattxt);
            this.bilgiPanel.Controls.Add(this.stokAdettxt);
            this.bilgiPanel.Controls.Add(this.diltxt);
            this.bilgiPanel.Controls.Add(this.sayfaSayisitxt);
            this.bilgiPanel.Controls.Add(this.yayınEvitxt);
            this.bilgiPanel.Controls.Add(this.yazartxt);
            this.bilgiPanel.Controls.Add(this.labelControl1);
            this.bilgiPanel.Controls.Add(this.adtxt);
            this.bilgiPanel.Controls.Add(this.kategoritxt);
            this.bilgiPanel.Controls.Add(this.pictureBox1);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bilgiPanel.Location = new System.Drawing.Point(1564, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(376, 749);
            this.bilgiPanel.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Kütüphane_Yönetim_Sistemi.Properties.Resources.clear_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(162, 756);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(132, 44);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Temizle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // basımYılıtxt
            // 
            this.basımYılıtxt.EditValue = null;
            this.basımYılıtxt.Location = new System.Drawing.Point(146, 262);
            this.basımYılıtxt.Name = "basımYılıtxt";
            this.basımYılıtxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basımYılıtxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basımYılıtxt.Properties.MaskSettings.Set("mask", "yyyy");
            this.basımYılıtxt.Size = new System.Drawing.Size(218, 22);
            this.basımYılıtxt.TabIndex = 29;
            this.basımYılıtxt.EditValueChanged += new System.EventHandler(this.basımYılıtxt_EditValueChanged_1);
            // 
            // eklenmeTarihitxt
            // 
            this.eklenmeTarihitxt.EditValue = null;
            this.eklenmeTarihitxt.Location = new System.Drawing.Point(146, 560);
            this.eklenmeTarihitxt.Name = "eklenmeTarihitxt";
            this.eklenmeTarihitxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.eklenmeTarihitxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.eklenmeTarihitxt.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.eklenmeTarihitxt.Size = new System.Drawing.Size(218, 22);
            this.eklenmeTarihitxt.TabIndex = 28;
            this.eklenmeTarihitxt.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(5, 660);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(83, 21);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "Açıklama:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 559);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(131, 21);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Eklenme Tarihi:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(5, 513);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 21);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Fiyat:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 463);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 21);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Stok Adet:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 413);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(29, 21);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Dil:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 363);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(109, 21);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Sayfa: Sayısı";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 313);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 21);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Kategori:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 263);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 21);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Basım Yılı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 21);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Yayın Evi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 21);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Yazar:";
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.aciklamatxt);
            this.panelControl2.Location = new System.Drawing.Point(146, 601);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(218, 136);
            this.panelControl2.TabIndex = 12;
            // 
            // aciklamatxt
            // 
            this.aciklamatxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aciklamatxt.Location = new System.Drawing.Point(2, 2);
            this.aciklamatxt.Name = "aciklamatxt";
            this.aciklamatxt.Size = new System.Drawing.Size(214, 132);
            this.aciklamatxt.TabIndex = 0;
            this.aciklamatxt.Text = "";
            this.aciklamatxt.TextChanged += new System.EventHandler(this.aciklamatxt_TextChanged);
            // 
            // fiyattxt
            // 
            this.fiyattxt.Location = new System.Drawing.Point(146, 510);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fiyattxt.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.fiyattxt.Properties.MaskSettings.Set("mask", "c");
            this.fiyattxt.Size = new System.Drawing.Size(218, 22);
            this.fiyattxt.TabIndex = 10;
            this.fiyattxt.EditValueChanged += new System.EventHandler(this.fiyattxt_EditValueChanged);
            // 
            // stokAdettxt
            // 
            this.stokAdettxt.Location = new System.Drawing.Point(146, 460);
            this.stokAdettxt.Name = "stokAdettxt";
            this.stokAdettxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.stokAdettxt.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.stokAdettxt.Properties.MaskSettings.Set("mask", "d");
            this.stokAdettxt.Size = new System.Drawing.Size(218, 22);
            this.stokAdettxt.TabIndex = 9;
            this.stokAdettxt.EditValueChanged += new System.EventHandler(this.stokAdettxt_EditValueChanged);
            // 
            // diltxt
            // 
            this.diltxt.Location = new System.Drawing.Point(146, 410);
            this.diltxt.Name = "diltxt";
            this.diltxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.diltxt.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.diltxt.Properties.MaskSettings.Set("mask", "\\p{Lu}[a-zA-ZıİçÇğĞııöÖşŞüÜ]{2,}");
            this.diltxt.Size = new System.Drawing.Size(218, 22);
            this.diltxt.TabIndex = 8;
            this.diltxt.EditValueChanged += new System.EventHandler(this.diltxt_EditValueChanged);
            // 
            // sayfaSayisitxt
            // 
            this.sayfaSayisitxt.Location = new System.Drawing.Point(146, 360);
            this.sayfaSayisitxt.Name = "sayfaSayisitxt";
            this.sayfaSayisitxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.sayfaSayisitxt.Properties.MaskSettings.Set("mask", "d");
            this.sayfaSayisitxt.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.sayfaSayisitxt.Size = new System.Drawing.Size(218, 22);
            this.sayfaSayisitxt.TabIndex = 7;
            this.sayfaSayisitxt.EditValueChanged += new System.EventHandler(this.sayfaSayisitxt_EditValueChanged);
            // 
            // yayınEvitxt
            // 
            this.yayınEvitxt.Location = new System.Drawing.Point(146, 210);
            this.yayınEvitxt.Name = "yayınEvitxt";
            this.yayınEvitxt.Size = new System.Drawing.Size(218, 22);
            this.yayınEvitxt.TabIndex = 4;
            this.yayınEvitxt.EditValueChanged += new System.EventHandler(this.yayınEvitxt_EditValueChanged);
            // 
            // yazartxt
            // 
            this.yazartxt.Location = new System.Drawing.Point(146, 160);
            this.yazartxt.Name = "yazartxt";
            this.yazartxt.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.yazartxt.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.yazartxt.Properties.MaskSettings.Set("mask", "\\p{Lu}[a-zA-ZıİçÇdDeEfFgGhHıİjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ]{1,}\\s\\p{Lu}[a-zA" +
        "-ZıİçÇdDeEfFgGhHıİjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ]{1,}");
            this.yazartxt.Size = new System.Drawing.Size(218, 22);
            this.yazartxt.TabIndex = 3;
            this.yazartxt.EditValueChanged += new System.EventHandler(this.yazartxt_EditValueChanged);
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
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(146, 110);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(218, 22);
            this.adtxt.TabIndex = 0;
            this.adtxt.EditValueChanged += new System.EventHandler(this.adtxt_EditValueChanged);
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(146, 310);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kategoritxt.Properties.DropDownRows = 10;
            this.kategoritxt.Properties.NullText = "";
            this.kategoritxt.Size = new System.Drawing.Size(218, 22);
            this.kategoritxt.TabIndex = 6;
            this.kategoritxt.EditValueChanged += new System.EventHandler(this.kategoritxt_EditValueChanged);
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
            // frmKitapBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 749);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.KitapBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKitapBilgileri";
            this.Text = "frmKitapBilgileri";
            this.Load += new System.EventHandler(this.frmKitapBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBilgileriTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiPanel)).EndInit();
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basımYılıtxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basımYılıtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklenmeTarihitxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklenmeTarihitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fiyattxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokAdettxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diltxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayınEvitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazartxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoritxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl KitapBilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView KitapBilgileriTablo;
        private DevExpress.XtraEditors.PanelControl bilgiPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit adtxt;
        private DevExpress.XtraEditors.TextEdit fiyattxt;
        private DevExpress.XtraEditors.TextEdit stokAdettxt;
        private DevExpress.XtraEditors.TextEdit diltxt;
        private DevExpress.XtraEditors.TextEdit sayfaSayisitxt;
        private DevExpress.XtraEditors.TextEdit yayınEvitxt;
        private DevExpress.XtraEditors.TextEdit yazartxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RichTextBox aciklamatxt;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LookUpEdit kategoritxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit idtxt;
        private DevExpress.XtraEditors.DateEdit eklenmeTarihitxt;
        private DevExpress.XtraEditors.DateEdit basımYılıtxt;
    }
}