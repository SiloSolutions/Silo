using SiloData;
using SiloModel;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace SiloWindowsFormsApp
{

    public partial class LoginPage : Form
    {
        public static User currentUser;

        private readonly string _configuration;
        public LoginPage()
        {
            InitializeComponent();


            _configuration = Properties.Settings.Default.Silo_Data;

            btnSignInPasswordHide.Visible = false;
            btnSignUpPasswordHide.Visible = false;
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signIn.Visible = false;
            bunifuTransition1.HideSync(signIn);
            signIn.Left = 574;

            signUp.Visible = false;
            signUp.Left = 40;
            signUp.Visible = true;
            bunifuTransition1.ShowSync(signUp);
            signUp.Refresh();

            bunifuSeparator.Left = btnSignUp.Left;
            bunifuSeparator.Width = btnSignUp.Width;

            txt_SignInPassword.Text = "";
            txt_SignInUsername.Text = "";

            lblRegisterControl.Text = "";
            lblRegisterResult.Text = "";
            lblResult.Text = "";

            lblRegisterControl.ForeColor = Color.FromArgb(26, 177, 136);
            lblRegisterResult.ForeColor = Color.FromArgb(26, 177, 136);
            lblResult.ForeColor = Color.FromArgb(26, 177, 136);


            txt_SignInUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_SignInPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

            if (txt_SignInPassword.isPassword == false)
            {
                txt_SignInPassword.isPassword = true;

                btnSignInPasswordHide.Visible = false;
                btnSignInPasswordShow.Visible = true;
            }

        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {

            signUp.Visible = false;
            bunifuTransition1.HideSync(signUp);
            signUp.Left = 574;

            signIn.Visible = false;
            signIn.Left = 40;
            signIn.Visible = true;
            bunifuTransition1.ShowSync(signIn);
            signIn.Refresh();

            bunifuSeparator.Left = btnSignIn.Left;
            bunifuSeparator.Width = btnSignIn.Width;

            txt_SignUpFirstName.Text = "";
            txt_SignUpLastName.Text = "";
            txt_SignUpUsername.Text = "";
            txt_SignUpPassword.Text = "";

            lblRegisterControl.Text = "";
            lblRegisterResult.Text = "";
            lblResult.Text = "";

            lblRegisterControl.ForeColor = Color.FromArgb(26, 177, 136);
            lblRegisterResult.ForeColor = Color.FromArgb(26, 177, 136);
            lblResult.ForeColor = Color.FromArgb(26, 177, 136);

            txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);


            if (txt_SignUpPassword.isPassword == false)
            {
                txt_SignUpPassword.isPassword = true;

                btnSignUpPasswordHide.Visible = false;
                btnSignUpPasswordShow.Visible = true;
            }

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SignInSend_Click(object sender, EventArgs e)
        {


            lblRegisterControl.Text = "";
            lblRegisterResult.Text = "";
            lblResult.Text = "";

            lblRegisterControl.ForeColor = Color.FromArgb(26, 177, 136);
            lblRegisterResult.ForeColor = Color.FromArgb(26, 177, 136);
            lblResult.ForeColor = Color.FromArgb(26, 177, 136);

            if (txt_SignInUsername.Text != "" && txt_SignInPassword.Text != "")
            {
                txt_SignInUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
                txt_SignInPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                IUserRepository data = new UserRepository(_configuration);
                try
                {
                    var user = data.GetUser(txt_SignInUsername.Text, txt_SignInPassword.Text);

                    if (user != null)
                    {
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                        currentUser = new User
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Username = user.Username,
                            Password = user.Password
                        };
                    }
                    else
                    {
                        txt_SignInUsername.LineFocusedColor = Color.Red;
                        txt_SignInUsername.Focus();

                        txt_SignInPassword.LineFocusedColor = Color.Red;

                        lblResult.Text = "Wrong Username or Password";
                        lblResult.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex);
                }
            }
            else
            {
                if (txt_SignInUsername.Text == "" && txt_SignInPassword.Text == "")
                {
                    txt_SignInUsername.LineFocusedColor = Color.Red;
                    txt_SignInUsername.Focus();

                    txt_SignInPassword.LineFocusedColor = Color.Red;

                    lblResult.Text = "Enter username and password";
                    lblResult.ForeColor = Color.Red;
                }
                else
                {
                    if (txt_SignInUsername.Text == "")
                    {
                        txt_SignInPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                        txt_SignInUsername.LineFocusedColor = Color.Red;
                        txt_SignInUsername.Focus();

                        lblResult.Text = "Enter username";
                        lblResult.ForeColor = Color.Red;

                    }
                    else
                    {
                        txt_SignInUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);

                        txt_SignInPassword.LineFocusedColor = Color.Red;
                        txt_SignInPassword.Focus();

                        lblResult.Text = "Enter password";
                        lblResult.ForeColor = Color.Red;

                    }
                }
            }
        }

        private void btn_SignUpSend_Click(object sender, EventArgs e)
        {

            lblRegisterControl.Text = "";
            lblRegisterResult.Text = "";
            lblResult.Text = "";

            lblRegisterControl.ForeColor = Color.FromArgb(26, 177, 136);
            lblRegisterResult.ForeColor = Color.FromArgb(26, 177, 136);
            lblResult.ForeColor = Color.FromArgb(26, 177, 136);

            if (txt_SignUpFirstName.Text != "" && txt_SignUpLastName.Text != "" &&
                txt_SignUpUsername.Text != "" && txt_SignUpPassword.Text != "")
            {

                IUserRepository data = new UserRepository(_configuration);

                var user = new User
                {
                    Username = txt_SignUpUsername.Text,
                    FirstName = txt_SignUpFirstName.Text,
                    LastName = txt_SignUpLastName.Text,
                    Password = txt_SignUpPassword.Text
                };

                var result = data.Insert(user);
                if (result != null)
                {
                    if (result.Username == txt_SignUpUsername.Text)
                    {
                        lblRegisterResult.Text = "Registration was successful";
                        lblRegisterResult.ForeColor = Color.FromArgb(26, 177, 136);

                        signUp.Visible = false;
                        bunifuTransition1.HideSync(signUp);
                        signUp.Left = 574;

                        signIn.Visible = false;
                        signIn.Left = 40;
                        signIn.Visible = true;
                        bunifuTransition1.ShowSync(signIn);
                        signIn.Refresh();

                        bunifuSeparator.Left = btnSignIn.Left;
                        bunifuSeparator.Width = btnSignIn.Width;

                        txt_SignUpFirstName.Text = "";
                        txt_SignUpLastName.Text = "";
                        txt_SignUpUsername.Text = "";
                        txt_SignUpPassword.Text = "";
                    }
                    else
                    {

                        lblRegisterControl.Text = "Ops... Something went wrong, try again";
                        lblRegisterControl.ForeColor = Color.Red;

                        txt_SignUpUsername.LineFocusedColor = Color.Red;
                        txt_SignUpUsername.Focus();
                    }

                }
                else
                {
                    lblRegisterControl.Text = "Username alredy used, try again";
                    lblRegisterControl.ForeColor = Color.Red;

                    txt_SignUpUsername.LineFocusedColor = Color.Red;
                    txt_SignUpUsername.Focus();
                }

            }
            else
            {
                if (txt_SignUpFirstName.Text == "" && txt_SignUpLastName.Text == "" &&
                    txt_SignUpUsername.Text == "" && txt_SignUpPassword.Text == "")
                {
                    txt_SignUpFirstName.LineFocusedColor = Color.Red;
                    txt_SignUpFirstName.Focus();

                    txt_SignUpLastName.LineFocusedColor = Color.Red;
                    txt_SignUpUsername.LineFocusedColor = Color.Red;
                    txt_SignUpPassword.LineFocusedColor = Color.Red;

                    lblRegisterControl.Text = "The fields are mandatory";
                    lblRegisterControl.ForeColor = Color.Red;

                }
                else
                {
                    if (txt_SignUpFirstName.Text == "" && txt_SignUpLastName.Text == "" &&
                        txt_SignUpUsername.Text == "")
                    {
                        txt_SignUpFirstName.LineFocusedColor = Color.Red;
                        txt_SignUpFirstName.Focus();

                        txt_SignUpLastName.LineFocusedColor = Color.Red;
                        txt_SignUpUsername.LineFocusedColor = Color.Red;

                        txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                        lblRegisterControl.Text = "The fields are mandatory";
                        lblRegisterControl.ForeColor = Color.Red;


                    }
                    else
                    {
                        if (txt_SignUpFirstName.Text == "" && txt_SignUpLastName.Text == "" &&
                            txt_SignUpPassword.Text == "")
                        {
                            txt_SignUpFirstName.LineFocusedColor = Color.Red;
                            txt_SignUpFirstName.Focus();

                            txt_SignUpLastName.LineFocusedColor = Color.Red;
                            txt_SignUpPassword.LineFocusedColor = Color.Red;

                            txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);

                            lblRegisterControl.Text = "The fields are mandatory";
                            lblRegisterControl.ForeColor = Color.Red;


                        }
                        else
                        {
                            if (txt_SignUpFirstName.Text == "" && txt_SignUpUsername.Text == "" &&
                                txt_SignUpPassword.Text == "")
                            {
                                txt_SignUpFirstName.LineFocusedColor = Color.Red;
                                txt_SignUpFirstName.Focus();

                                txt_SignUpUsername.LineFocusedColor = Color.Red;
                                txt_SignUpPassword.LineFocusedColor = Color.Red;

                                txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                lblRegisterControl.Text = "The fields are mandatory";
                                lblRegisterControl.ForeColor = Color.Red;


                            }
                            else
                            {
                                if (txt_SignUpLastName.Text == "" && txt_SignUpUsername.Text == "" &&
                                    txt_SignUpPassword.Text == "")
                                {
                                    txt_SignUpLastName.LineFocusedColor = Color.Red;
                                    txt_SignUpLastName.Focus();

                                    txt_SignUpUsername.LineFocusedColor = Color.Red;
                                    txt_SignUpPassword.LineFocusedColor = Color.Red;

                                    txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                    lblRegisterControl.Text = "The fields are mandatory";
                                    lblRegisterControl.ForeColor = Color.Red;


                                }
                                else
                                {
                                    if (txt_SignUpFirstName.Text == "" && txt_SignUpLastName.Text == "")
                                    {
                                        txt_SignUpFirstName.LineFocusedColor = Color.Red;
                                        txt_SignUpFirstName.Focus();

                                        txt_SignUpLastName.LineFocusedColor = Color.Red;

                                        txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                        txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                        lblRegisterControl.Text = "The fields are mandatory";
                                        lblRegisterControl.ForeColor = Color.Red;


                                    }
                                    else
                                    {
                                        if (txt_SignUpFirstName.Text == "" && txt_SignUpUsername.Text == "")
                                        {
                                            txt_SignUpFirstName.LineFocusedColor = Color.Red;
                                            txt_SignUpFirstName.Focus();

                                            txt_SignUpUsername.LineFocusedColor = Color.Red;

                                            txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                            txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                            lblRegisterControl.Text = "The fields are mandatory";
                                            lblRegisterControl.ForeColor = Color.Red;


                                        }
                                        else
                                        {
                                            if (txt_SignUpFirstName.Text == "" && txt_SignUpPassword.Text == "")
                                            {
                                                txt_SignUpFirstName.LineFocusedColor = Color.Red;
                                                txt_SignUpFirstName.Focus();

                                                txt_SignUpPassword.LineFocusedColor = Color.Red;

                                                txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                lblRegisterControl.Text = "The fields are mandatory";
                                                lblRegisterControl.ForeColor = Color.Red;


                                            }
                                            else
                                            {
                                                if (txt_SignUpLastName.Text == "" && txt_SignUpUsername.Text == "")
                                                {
                                                    txt_SignUpLastName.LineFocusedColor = Color.Red;
                                                    txt_SignUpLastName.Focus();

                                                    txt_SignUpUsername.LineFocusedColor = Color.Red;

                                                    txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                    txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                    lblRegisterControl.Text = "The fields are mandatory";
                                                    lblRegisterControl.ForeColor = Color.Red;


                                                }
                                                else
                                                {
                                                    if (txt_SignUpLastName.Text == "" && txt_SignUpPassword.Text == "")
                                                    {
                                                        txt_SignUpLastName.LineFocusedColor = Color.Red;
                                                        txt_SignUpLastName.Focus();

                                                        txt_SignUpPassword.LineFocusedColor = Color.Red;

                                                        txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                        txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                        lblRegisterControl.Text = "The fields are mandatory";
                                                        lblRegisterControl.ForeColor = Color.Red;


                                                    }
                                                    else
                                                    {
                                                        if (txt_SignUpUsername.Text == "" && txt_SignUpPassword.Text == "")
                                                        {
                                                            txt_SignUpUsername.LineFocusedColor = Color.Red;
                                                            txt_SignUpUsername.Focus();

                                                            txt_SignUpPassword.LineFocusedColor = Color.Red;

                                                            txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                            txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                            lblRegisterControl.Text = "The fields are mandatory";
                                                            lblRegisterControl.ForeColor = Color.Red;


                                                        }
                                                        else
                                                        {
                                                            if (txt_SignUpFirstName.Text == "")
                                                            {
                                                                txt_SignUpFirstName.LineFocusedColor = Color.Red;
                                                                txt_SignUpFirstName.Focus();


                                                                txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                                lblRegisterControl.Text = "The fields are mandatory";
                                                                lblRegisterControl.ForeColor = Color.Red;


                                                            }
                                                            else
                                                            {
                                                                if (txt_SignUpLastName.Text == "")
                                                                {
                                                                    txt_SignUpLastName.LineFocusedColor = Color.Red;
                                                                    txt_SignUpLastName.Focus();


                                                                    txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                    txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                    txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                                    lblRegisterControl.Text = "The fields are mandatory";
                                                                    lblRegisterControl.ForeColor = Color.Red;


                                                                }
                                                                else
                                                                {
                                                                    if (txt_SignUpUsername.Text == "")
                                                                    {
                                                                        txt_SignUpUsername.LineFocusedColor = Color.Red;
                                                                        txt_SignUpUsername.Focus();


                                                                        txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                        txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                        txt_SignUpPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                                        lblRegisterControl.Text = "The fields are mandatory";
                                                                        lblRegisterControl.ForeColor = Color.Red;


                                                                    }
                                                                    else
                                                                    {
                                                                        if (txt_SignUpPassword.Text == "")
                                                                        {
                                                                            txt_SignUpPassword.LineFocusedColor = Color.Red;
                                                                            txt_SignUpPassword.Focus();


                                                                            txt_SignUpFirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                            txt_SignUpLastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
                                                                            txt_SignUpUsername.LineFocusedColor = Color.FromArgb(26, 177, 136);

                                                                            lblRegisterControl.Text = "The fields are mandatory";
                                                                            lblRegisterControl.ForeColor = Color.Red;


                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSignInPasswordShow_Click(object sender, EventArgs e)
        {
            if (txt_SignInPassword.isPassword == true)
            {
                txt_SignInPassword.isPassword = false;

                btnSignInPasswordShow.Visible = false;
                btnSignInPasswordHide.Visible = true;
            }
        }

        private void btnSignInPasswordHide_Click(object sender, EventArgs e)
        {
            if (txt_SignInPassword.isPassword == false)
            {
                txt_SignInPassword.isPassword = true;

                btnSignInPasswordHide.Visible = false;
                btnSignInPasswordShow.Visible = true;
            }
        }


        private void btnSignUpPasswordShow_Click(object sender, EventArgs e)
        {
            if (txt_SignUpPassword.isPassword == true)
            {
                txt_SignUpPassword.isPassword = false;

                btnSignUpPasswordShow.Visible = false;
                btnSignUpPasswordHide.Visible = true;
            }
        }

        private void btnSignUpPasswordHide_Click(object sender, EventArgs e)
        {
            if (txt_SignUpPassword.isPassword == false)
            {
                txt_SignUpPassword.isPassword = true;

                btnSignUpPasswordHide.Visible = false;
                btnSignUpPasswordShow.Visible = true;
            }
        }
    }
}
