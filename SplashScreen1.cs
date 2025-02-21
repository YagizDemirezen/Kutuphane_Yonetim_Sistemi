using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class SplashScreen1 : SplashScreen
    {
        private string[] sozler = new string[8];
        private string[] yazarlar = new string[8];
        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "© " + DateTime.Now.Year.ToString() + " YAAZSOFT. Tüm Hakları Saklıdır.";
            sozler[0] = "Kitaplar aklın çocuklarıdır.";
            yazarlar[0] = "Jonathan Swift";
            sozler[1] = "İyi bir kitap, iyi bir arkadaş gibidir.";
            yazarlar[1] = "Ernest Hemingway";
            sozler[2] = "Kitaplar, en sessiz ve en sadık dostlardır.";
            yazarlar[2] = "Charles W. Eliot";
            sozler[3] = "Kitap ruhun ilacıdır.";
            yazarlar[3] = "Japon Atasözü";
            sozler[4] = "Okumayı öğrenmek, en zor sanattır.";
            yazarlar[4] = "Friedrich Nietzsche";
            sozler[5] = "Bir kitap, bir dünya demektir.";
            yazarlar[5] = "Alphonse de Lamartine";
            sozler[6] = "Kitaplar uygarlığın yol göstericileridir.";
            yazarlar[6] = "Mustafa Kemal Atatürk";
            sozler[7] = "Kitapları sevmeyen, hayatı da sevmez.";
            yazarlar[7] = "Mehmet Murat İldan";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomWord = random.Next(0, 8);
            sozlbl.Text = sozler[randomWord];
            yazarlbl.Text = yazarlar[randomWord];
        }
    }
}