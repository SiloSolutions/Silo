using System;
using System.Drawing;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{
    //86 ore

    //Splash screen finito
    //Login/Registrazione finiti
    //SiloPage finito
    ////Data finito
    ////Settings finito
    ////SignOut finito
    ////Dashboard finito

    public partial class SiloPage : Form
    {
        public static int sideWidth = 202;
        public SiloPage()
        {
            InitializeComponent();

            var firstname = LoginPage.currentUser.FirstName.Substring(0, 1).ToUpper();
            firstname += LoginPage.currentUser.FirstName.Substring(1, LoginPage.currentUser.FirstName.Length - 1);

            var lastname = LoginPage.currentUser.LastName.Substring(0, 1).ToUpper();
            lastname += LoginPage.currentUser.LastName.Substring(1, LoginPage.currentUser.LastName.Length - 1);

            lblWelcome.Text = "Welcome";
            lblUser.Text = firstname + " " + lastname;
            openForm(new Dashboard());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openForm(object form)
        {
            if (pnlCenter.Controls.Count > 0)
            {
                pnlCenter.Controls.RemoveAt(0);
            }
            Form fr = form as Form;
            fr.TopLevel = false;
            pnlCenter.Controls.Add(fr);
            pnlCenter.Tag = fr;
            fr.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnData.Normalcolor = Color.Transparent;
            btnSettings.Normalcolor = Color.Transparent;
            btnSignOut.Normalcolor = Color.Transparent;
            btnDashboard.Normalcolor = Color.FromArgb(67, 81, 89);

            btnDashboard.selected = true;
            btnData.selected = false;
            btnSettings.selected = false;
            btnSignOut.selected = false;

            btnDashboard.Active = true;
            btnData.Active = false;
            btnSettings.Active = false;
            btnSignOut.Active = false;

            openForm(new Dashboard());

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            btnDashboard.Normalcolor = Color.Transparent;
            btnSettings.Normalcolor = Color.Transparent;
            btnSignOut.Normalcolor = Color.Transparent;
            btnData.Normalcolor = Color.FromArgb(67, 81, 89);

            btnData.Active = true;
            btnDashboard.Active = false;
            btnSettings.Active = false;
            btnSignOut.Active = false;

            btnData.selected = true;

            btnDashboard.selected = false;
            btnSettings.selected = false;
            btnSignOut.selected = false;

            openForm(new Data());

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnDashboard.Normalcolor = Color.Transparent;
            btnData.Normalcolor = Color.Transparent;
            btnSignOut.Normalcolor = Color.Transparent;
            btnSettings.Normalcolor = Color.FromArgb(67, 81, 89);

            btnSettings.Active = true;
            btnDashboard.Active = false;
            btnData.Active = false;
            btnSignOut.Active = false;

            btnSettings.selected = true;
            btnDashboard.selected = false;
            btnData.selected = false;
            btnSignOut.selected = false;

            openForm(new Settings());

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            btnDashboard.Normalcolor = Color.Transparent;
            btnData.Normalcolor = Color.Transparent;
            btnSettings.Normalcolor = Color.Transparent;
            btnSignOut.Normalcolor = Color.FromArgb(67, 81, 89);

            btnSignOut.Active = true;
            btnDashboard.Active = false;
            btnData.Active = false;
            btnSettings.Active = false;

            btnSignOut.selected = true;
            btnDashboard.selected = false;
            btnData.selected = false;
            btnSettings.selected = false;

            openForm(new SignOut());


        }

        private void pictureUser_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                openFileDialog.InitialDirectory = desktopPath;
                var filter = @"All Image Files(*.bmp, *.jpg, *.jpeg, *.png, *.gif, *.tif, *.tiff, *.ico)|*.BMP;*.bmp;*.JPG;*.JPEG*.jpg;*.jpeg;*.PNG;*.png;*.GIF;*.gif;*.tif;*.tiff;*.ico;*.ICO
                                | PNG(*.png)|*.PNG;*.png
                                |JPEG(*.jpg, *.jpeg)|*.JPG;*.JPEG;*.jpg;*.jpeg
                                |Bitmap(*.bmp)|*.BMP;*.bmp                                    
                                |GIF(*.gif)|*.GIF;*.gif
                                |TIF(*.tif, *.tiff)|*.tif;*.tiff
                                |ICO(*.ico)|*.ico;*.ICO
                                |All files (*.*)|*.*";


                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;


                DialogResult action = openFileDialog.ShowDialog();

                if (action == DialogResult.OK)
                {
                    this.pictureUser.Load(openFileDialog.FileName);
                    if (pnlSide.Width == 202)
                    {
                        this.pictureUser.BorderRadius = 40;

                    }
                    else
                    {
                        this.pictureUser.BorderRadius = 25;
                    }
                    this.pictureUser.SizeMode = PictureBoxSizeMode.Zoom;

                }

            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlSide.Width == 202)
            {
                pnlSide.Visible = false;
                pnlCenter.Visible = false;
                btnMenu.Visible = false;
                pictureUser.Visible = false;
                lblWelcome.Visible = false;
                lblUser.Visible = false;

                btnDashboard.Visible = false;
                btnData.Visible = false;
                btnSettings.Visible = false;
                btnSignOut.Visible = false;

                pnlSide.Width = 50;
                pnlCenter.Width = 1000;

                sideWidth = 50;

                pnlCenter.Location = new Point(50, 41);

                if (btnDashboard.selected == true)
                {
                    openForm(new Dashboard());
                }
                else
                {
                    if (btnData.selected == true)
                    {
                        openForm(new Data());
                    }
                    else
                    {
                        if (btnSettings.selected == true)
                        {
                            openForm(new Settings());
                        }
                        else
                        {
                            if (btnSignOut.selected == true)
                            {
                                openForm(new SignOut());
                            }
                        }
                    }
                }

                btnMenu.Left = 10;

                btnDashboard.Width = 51;
                btnData.Width = 51;
                btnSettings.Width = 51;
                btnSignOut.Width = 51;

                btnDashboard.IconMarginLeft = 11;
                btnData.IconMarginLeft = 11;
                btnSettings.IconMarginLeft = 11;
                btnSignOut.IconMarginLeft = 11;

                btnDashboard.Text = "";
                btnData.Text = "";
                btnSettings.Text = "";
                btnSignOut.Text = "";

                pictureUser.Location = new Point(0, 70);
                pictureUser.Size = new Size(50, 50);
                pictureUser.BorderRadius = 25;

                btnMenu.Visible = true;

                btnDashboard.Visible = true;
                btnData.Visible = true;
                btnSettings.Visible = true;
                btnSignOut.Visible = true;

                pictureUser.Visible = true;

                pnlAnimator.ShowSync(pnlCenter);
                pnlAnimator.ShowSync(pnlSide);


            }
            else
            {

                pnlSide.Visible = false;
                pnlCenter.Visible = false;
                btnMenu.Visible = false;

                btnDashboard.Visible = false;
                btnData.Visible = false;
                btnSettings.Visible = false;
                btnSignOut.Visible = false;

                pictureUser.Visible = false;

                pnlSide.Width = 202;
                pnlCenter.Width = 758;

                sideWidth = 202;

                pnlCenter.Location = new Point(202, 41);

                if (btnDashboard.selected == true)
                {
                    openForm(new Dashboard());
                }
                else
                {
                    if (btnData.selected == true)
                    {
                        openForm(new Data());
                    }
                    else
                    {
                        if (btnSettings.selected == true)
                        {
                            openForm(new Settings());
                        }
                        else
                        {
                            if (btnSignOut.selected == true)
                            {
                                openForm(new SignOut());
                            }
                        }
                    }
                }

                btnMenu.Left = 165;

                btnDashboard.Width = 203;
                btnData.Width = 203;
                btnSettings.Width = 203;
                btnSignOut.Width = 203;

                btnDashboard.IconMarginLeft = 50;
                btnData.IconMarginLeft = 50;
                btnSettings.IconMarginLeft = 50;
                btnSignOut.IconMarginLeft = 50;

                btnDashboard.Text = "Dashboard";
                btnData.Text = "Data";
                btnSettings.Text = "Settings";
                btnSignOut.Text = "Sign Out";

                pictureUser.Width = 75;
                pictureUser.Height = 75;
                pictureUser.BorderRadius = 40;
                pictureUser.Location = new Point(67, 6);

                btnMenu.Visible = true;
                pictureUser.Visible = true;
                lblWelcome.Visible = true;
                lblUser.Visible = true;

                btnDashboard.Visible = true;
                btnData.Visible = true;
                btnSettings.Visible = true;
                btnSignOut.Visible = true;

                pnlAnimator.ShowSync(pnlCenter);
                pnlAnimator.ShowSync(pnlSide);

            }
        }
    }
}
