using System;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    public partial class SignOut : Form
    {
        public SignOut()
        {
            InitializeComponent();
            if (SiloPage.sideWidth == 202)
            {
                this.Width = 758;
            }
            else
            {
                this.Width = 800;
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
