using System;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    public partial class BootPage : Form
    {
        public BootPage()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loadingBar.Width += 3;
            if (loadingBar.Width >= 350)
            {
                string await = string.Empty;
                for (int i = 0; i < 6200; i++)
                {
                    await += i.ToString();
                }
            }
            if (loadingBar.Width >= 700)
            {
                loadingTimer.Stop();
                this.Close();
            }
        }
    }
}
