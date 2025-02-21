using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;

namespace Kütüphane_Yönetim_Sistemi
{
    internal static class Program
    {
        private static bool isSplashShown = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!isSplashShown)
            {
                SplashScreenManager.ShowForm(typeof(SplashScreen1));  // SplashScreenForm burada kendi formunuz olmalı
                System.Threading.Thread.Sleep(6000); // 6 saniye beklet
                SplashScreenManager.CloseForm();
                isSplashShown = true;  // SplashScreen bir kez gösterildiğini işaret et
            }

            Application.Run(new frmGiris());
        }
    }
}
