using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BootPage());
            LoginPage loginPage = new LoginPage();
            Application.Run(loginPage);
            if (loginPage.DialogResult == DialogResult.OK)
            {
                loginPage.Close();

                Application.Run(new SiloPage());

            }
        }
    }
}
