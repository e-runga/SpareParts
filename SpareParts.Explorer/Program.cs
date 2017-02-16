using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace SpareParts.Explorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.UserSkins.BonusSkins.Register();
                UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

                var loginForm = new Login();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new HomeControl());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}