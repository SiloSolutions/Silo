using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SiloData;
using SiloModel;

namespace SiloWindowsFormsApp
{
    public partial class Settings : Form
    {
        private readonly string _configuration;

        public Settings()
        {
            InitializeComponent();
            if (SiloPage.sideWidth == 202)
            {
                this.Width = 758;
            }
            else
            {
                this.Width = 800;
                this.Location = new Point(70, 0);
            }

            _configuration = Properties.Settings.Default.Silo_Data;


            var firstname = LoginPage.currentUser.FirstName.Substring(0, 1).ToUpper();
            firstname += LoginPage.currentUser.FirstName.Substring(1, LoginPage.currentUser.FirstName.Length - 1);

            var lastname = LoginPage.currentUser.LastName.Substring(0, 1).ToUpper();
            lastname += LoginPage.currentUser.LastName.Substring(1, LoginPage.currentUser.LastName.Length - 1);

            txt_FirstName.Text = firstname;
            txt_LastName.Text = lastname;
            lblUsernameNotEditable.Text = LoginPage.currentUser.Username;

            lblResult.Text = "";
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.ForeColor = Color.FromArgb(26, 177, 136);

            txt_FirstName.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_LastName.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_OldPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_NewPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);
            txt_ConfirmPassword.LineFocusedColor = Color.FromArgb(26, 177, 136);


            IUserRepository data = new UserRepository(_configuration);

            try
            {
                var currentUser = data.SelectUser(LoginPage.currentUser.Username);

                if (txt_FirstName.Text != "" && txt_LastName.Text != "")
                {
                    if (txt_FirstName.Text != currentUser.FirstName &&
                        txt_LastName.Text != currentUser.LastName)
                    {
                        if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                            txt_ConfirmPassword.Text != "")
                        {
                            if (txt_OldPassword.Text == currentUser.Password &&
                                txt_NewPassword.Text != currentUser.Password &&
                                txt_NewPassword.Text == txt_ConfirmPassword.Text)
                            {
                                var updateUser = new User
                                {
                                    FirstName = txt_FirstName.Text,
                                    LastName = txt_LastName.Text,
                                    Username = currentUser.Username,
                                    Password = txt_NewPassword.Text
                                };

                                var result = data.Update(updateUser);

                                if (result == 1)
                                {
                                    lblResult.Text = "Successful update";
                                }
                                else
                                {
                                    lblResult.Text = "Ops... Something went wrong, try again";
                                    lblResult.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                if (txt_OldPassword.Text != currentUser.Password)
                                {
                                    lblResult.Text = "Wrong password";
                                    lblResult.ForeColor = Color.Red;

                                    txt_OldPassword.Focus();
                                    txt_OldPassword.LineFocusedColor = Color.Red;
                                }
                                else
                                {
                                    if (txt_NewPassword.Text == currentUser.Password)
                                    {
                                        lblResult.Text = "The password cannot be the same as the previous one";
                                        lblResult.ForeColor = Color.Red;

                                        txt_NewPassword.Focus();
                                        txt_NewPassword.LineFocusedColor = Color.Red;
                                    }
                                    else
                                    {
                                        if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                        {
                                            lblResult.Text = "The passwords must be the same";
                                            lblResult.ForeColor = Color.Red;

                                            txt_NewPassword.Focus();
                                            txt_NewPassword.LineFocusedColor = Color.Red;
                                            txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            var updateUser = new User
                            {
                                FirstName = txt_FirstName.Text,
                                LastName = txt_LastName.Text,
                                Username = currentUser.Username,
                                Password = currentUser.Password
                            };

                            var result = data.Update(updateUser);

                            if (result == 1)
                            {
                                lblResult.Text = "Successful update";
                            }
                            else
                            {
                                lblResult.Text = "Ops... Something went wrong, try again";
                                lblResult.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        if (txt_FirstName.Text != currentUser.FirstName &&
                            txt_LastName.Text == currentUser.LastName)
                        {
                            if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                txt_ConfirmPassword.Text != "")
                            {
                                if (txt_OldPassword.Text == currentUser.Password &&
                                    txt_NewPassword.Text != currentUser.Password &&
                                    txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                {
                                    var user = new User
                                    {
                                        FirstName = txt_FirstName.Text,
                                        LastName = currentUser.LastName,
                                        Username = currentUser.Username,
                                        Password = txt_NewPassword.Text
                                    };

                                    data.Update(user);

                                    lblResult.Text = "Successful update";
                                }
                                else
                                {
                                    if (txt_OldPassword.Text != currentUser.Password)
                                    {
                                        lblResult.Text = "Wrong password";
                                        lblResult.ForeColor = Color.Red;

                                        txt_OldPassword.Focus();
                                        txt_OldPassword.LineFocusedColor = Color.Red;
                                    }
                                    else
                                    {
                                        if (txt_NewPassword.Text == currentUser.Password)
                                        {
                                            lblResult.Text = "The password cannot be the same as the previous one";
                                            lblResult.ForeColor = Color.Red;

                                            txt_NewPassword.Focus();
                                            txt_NewPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                            {
                                                lblResult.Text = "The passwords must be the same";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                                txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                            }
                                        }
                                    }
                                }
                            }
                            var updateUser = new User
                            {
                                FirstName = txt_FirstName.Text,
                                LastName = currentUser.LastName,
                                Username = currentUser.Username,
                                Password = currentUser.Password
                            };

                            var result = data.Update(updateUser);

                            if (result == 1)
                            {
                                lblResult.Text = "Successful update";
                            }
                            else
                            {
                                lblResult.Text = "Ops... Something went wrong, try again";
                                lblResult.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (txt_LastName.Text != currentUser.LastName &&
                                txt_FirstName.Text == currentUser.FirstName)
                            {
                                if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                txt_ConfirmPassword.Text != "")
                                {
                                    if (txt_OldPassword.Text == currentUser.Password &&
                                        txt_NewPassword.Text != currentUser.Password &&
                                        txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                    {
                                        var user = new User
                                        {
                                            FirstName = currentUser.FirstName,
                                            LastName = txt_LastName.Text,
                                            Username = currentUser.Username,
                                            Password = txt_NewPassword.Text
                                        };

                                        data.Update(user);

                                        lblResult.Text = "Successful update";
                                    }
                                    else
                                    {
                                        if (txt_OldPassword.Text != currentUser.Password)
                                        {
                                            lblResult.Text = "Wrong password";
                                            lblResult.ForeColor = Color.Red;

                                            txt_OldPassword.Focus();
                                            txt_OldPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text == currentUser.Password)
                                            {
                                                lblResult.Text = "The password cannot be the same as the previous one";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                            }
                                            else
                                            {
                                                if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                                {
                                                    lblResult.Text = "The passwords must be the same";
                                                    lblResult.ForeColor = Color.Red;

                                                    txt_NewPassword.Focus();
                                                    txt_NewPassword.LineFocusedColor = Color.Red;
                                                    txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                                }
                                            }
                                        }
                                    }
                                }
                                var updateUser = new User
                                {
                                    FirstName = currentUser.FirstName,
                                    LastName = txt_LastName.Text,
                                    Username = currentUser.Username,
                                    Password = currentUser.Password
                                };

                                var result = data.Update(updateUser);

                                if (result == 1)
                                {
                                    lblResult.Text = "Successful update";
                                }
                                else
                                {
                                    lblResult.Text = "Ops... Something went wrong, try again";
                                    lblResult.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                    txt_ConfirmPassword.Text != "")
                                {
                                    if (txt_OldPassword.Text == currentUser.Password &&
                                        txt_NewPassword.Text != currentUser.Password &&
                                        txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                    {
                                        var updateUser = new User
                                        {
                                            FirstName = currentUser.FirstName,
                                            LastName = currentUser.LastName,
                                            Username = currentUser.Username,
                                            Password = txt_NewPassword.Text
                                        };

                                        var result = data.Update(updateUser);

                                        if (result == 1)
                                        {
                                            lblResult.Text = "Successful update";
                                        }
                                        else
                                        {
                                            lblResult.Text = "Ops... Something went wrong, try again";
                                            lblResult.ForeColor = Color.Red;
                                        }
                                    }
                                    else
                                    {
                                        if (txt_OldPassword.Text != currentUser.Password)
                                        {
                                            lblResult.Text = "Wrong password";
                                            lblResult.ForeColor = Color.Red;

                                            txt_OldPassword.Focus();
                                            txt_OldPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text == currentUser.Password)
                                            {
                                                lblResult.Text = "The password cannot be the same as the previous one";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                            }
                                            else
                                            {
                                                if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                                {
                                                    lblResult.Text = "The passwords must be the same";
                                                    lblResult.ForeColor = Color.Red;

                                                    txt_NewPassword.Focus();
                                                    txt_NewPassword.LineFocusedColor = Color.Red;
                                                    txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (txt_OldPassword.Text == "" && txt_NewPassword.Text == "" &&
                                    txt_ConfirmPassword.Text == "")
                                    {
                                        lblResult.Text = "The fields are mandatory";
                                        lblResult.ForeColor = Color.Red;

                                        txt_OldPassword.Focus();

                                        txt_OldPassword.LineFocusedColor = Color.Red;
                                        txt_NewPassword.LineFocusedColor = Color.Red;
                                        txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                    }
                                    else
                                    {
                                        if (txt_OldPassword.Text != currentUser.Password &&
                                            txt_NewPassword.Text == "" && txt_ConfirmPassword.Text == "")
                                        {
                                            lblResult.Text = "Wrong password and the fields are mandatory";
                                            lblResult.ForeColor = Color.Red;

                                            txt_OldPassword.Focus();

                                            txt_OldPassword.LineFocusedColor = Color.Red;
                                            txt_NewPassword.LineFocusedColor = Color.Red;
                                            txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_OldPassword.Text == currentUser.Password &&
                                                txt_NewPassword.Text == "" && txt_ConfirmPassword.Text == "")
                                            {
                                                lblResult.Text = "The fields are mandatory";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();

                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                                txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                            }
                                            else
                                            {
                                                if (txt_OldPassword.Text != currentUser.Password &&
                                                    txt_NewPassword.Text == "")
                                                {
                                                    lblResult.Text = "Wrong password and the field are mandatory";
                                                    lblResult.ForeColor = Color.Red;

                                                    txt_OldPassword.Focus();

                                                    txt_OldPassword.LineFocusedColor = Color.Red;
                                                    txt_NewPassword.LineFocusedColor = Color.Red;
                                                }
                                                else
                                                {
                                                    if (txt_OldPassword.Text == currentUser.Password &&
                                                        txt_NewPassword.Text == "")
                                                    {
                                                        lblResult.Text = "The field are mandatory";
                                                        lblResult.ForeColor = Color.Red;

                                                        txt_NewPassword.Focus();

                                                        txt_NewPassword.LineFocusedColor = Color.Red;
                                                    }
                                                    else
                                                    {
                                                        if (txt_OldPassword.Text != currentUser.Password &&
                                                            txt_ConfirmPassword.Text == "")
                                                        {
                                                            lblResult.Text = "Wrong password and the field are mandatory";
                                                            lblResult.ForeColor = Color.Red;

                                                            txt_OldPassword.Focus();

                                                            txt_OldPassword.LineFocusedColor = Color.Red;
                                                            txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                                        }
                                                        else
                                                        {
                                                            if (txt_OldPassword.Text == currentUser.Password &&
                                                                txt_ConfirmPassword.Text == "")
                                                            {
                                                                lblResult.Text = "The field are mandatory";
                                                                lblResult.ForeColor = Color.Red;

                                                                txt_ConfirmPassword.Focus();

                                                                txt_ConfirmPassword.LineFocusedColor = Color.Red;
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
                else
                {
                    if (txt_FirstName.Text != "")
                    {
                        if (txt_FirstName.Text != currentUser.FirstName)
                        {
                            if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                txt_ConfirmPassword.Text != "")
                            {
                                if (txt_OldPassword.Text == currentUser.Password &&
                                    txt_NewPassword.Text != currentUser.Password &&
                                    txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                {
                                    var user = new User
                                    {
                                        FirstName = txt_FirstName.Text,
                                        LastName = currentUser.LastName,
                                        Username = currentUser.Username,
                                        Password = txt_NewPassword.Text
                                    };

                                    data.Update(user);

                                    lblResult.Text = "Successful update";
                                }
                                else
                                {
                                    if (txt_OldPassword.Text != currentUser.Password)
                                    {
                                        lblResult.Text = "Wrong password";
                                        lblResult.ForeColor = Color.Red;

                                        txt_OldPassword.Focus();
                                        txt_OldPassword.LineFocusedColor = Color.Red;
                                    }
                                    else
                                    {
                                        if (txt_NewPassword.Text == currentUser.Password)
                                        {
                                            lblResult.Text = "The password cannot be the same as the previous one";
                                            lblResult.ForeColor = Color.Red;

                                            txt_NewPassword.Focus();
                                            txt_NewPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                            {
                                                lblResult.Text = "The passwords must be the same";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                                txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                            }
                                        }
                                    }
                                }
                            }

                            var updateUser = new User
                            {
                                FirstName = txt_FirstName.Text,
                                LastName = currentUser.LastName,
                                Username = currentUser.Username,
                                Password = currentUser.Password
                            };

                            var result = data.Update(updateUser);

                            if (result == 1)
                            {
                                lblResult.Text = "Successful update";
                            }
                            else
                            {
                                lblResult.Text = "Ops... Something went wrong, try again";
                                lblResult.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        if (txt_LastName.Text != "")
                        {
                            if (txt_LastName.Text != currentUser.LastName)
                            {
                                if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                txt_ConfirmPassword.Text != "")
                                {
                                    if (txt_OldPassword.Text == currentUser.Password &&
                                        txt_NewPassword.Text != currentUser.Password &&
                                        txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                    {
                                        var user = new User
                                        {
                                            FirstName = currentUser.FirstName,
                                            LastName = txt_LastName.Text,
                                            Username = currentUser.Username,
                                            Password = txt_NewPassword.Text
                                        };

                                        data.Update(user);

                                        lblResult.Text = "Successful update";
                                    }
                                    else
                                    {
                                        if (txt_OldPassword.Text != currentUser.Password)
                                        {
                                            lblResult.Text = "Wrong password";
                                            lblResult.ForeColor = Color.Red;

                                            txt_OldPassword.Focus();
                                            txt_OldPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text == currentUser.Password)
                                            {
                                                lblResult.Text = "The password cannot be the same as the previous one";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                            }
                                            else
                                            {
                                                if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                                {
                                                    lblResult.Text = "The passwords must be the same";
                                                    lblResult.ForeColor = Color.Red;

                                                    txt_NewPassword.Focus();
                                                    txt_NewPassword.LineFocusedColor = Color.Red;
                                                    txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                                }
                                            }
                                        }
                                    }
                                }

                                var updateUser = new User
                                {
                                    FirstName = currentUser.FirstName,
                                    LastName = txt_LastName.Text,
                                    Username = currentUser.Username,
                                    Password = currentUser.Password
                                };

                                var result = data.Update(updateUser);

                                if (result == 1)
                                {
                                    lblResult.Text = "Successful update";
                                }
                                else
                                {
                                    lblResult.Text = "Ops... Something went wrong, try again";
                                    lblResult.ForeColor = Color.Red;
                                }
                            }
                        }
                        else
                        {
                            if (txt_OldPassword.Text != "" && txt_NewPassword.Text != "" &&
                                    txt_ConfirmPassword.Text != "")
                            {
                                if (txt_OldPassword.Text == currentUser.Password &&
                                    txt_NewPassword.Text != currentUser.Password &&
                                    txt_NewPassword.Text == txt_ConfirmPassword.Text)
                                {
                                    var updateUser = new User
                                    {
                                        FirstName = currentUser.FirstName,
                                        LastName = currentUser.LastName,
                                        Username = currentUser.Username,
                                        Password = txt_NewPassword.Text
                                    };

                                    var result = data.Update(updateUser);

                                    if (result == 1)
                                    {
                                        lblResult.Text = "Successful update";
                                    }
                                    else
                                    {
                                        lblResult.Text = "Ops... Something went wrong, try again";
                                        lblResult.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    if (txt_OldPassword.Text != currentUser.Password)
                                    {
                                        lblResult.Text = "Wrong password";
                                        lblResult.ForeColor = Color.Red;

                                        txt_OldPassword.Focus();
                                        txt_OldPassword.LineFocusedColor = Color.Red;
                                    }
                                    else
                                    {
                                        if (txt_NewPassword.Text == currentUser.Password)
                                        {
                                            lblResult.Text = "The password cannot be the same as the previous one";
                                            lblResult.ForeColor = Color.Red;

                                            txt_NewPassword.Focus();
                                            txt_NewPassword.LineFocusedColor = Color.Red;
                                        }
                                        else
                                        {
                                            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
                                            {
                                                lblResult.Text = "The passwords must be the same";
                                                lblResult.ForeColor = Color.Red;

                                                txt_NewPassword.Focus();
                                                txt_NewPassword.LineFocusedColor = Color.Red;
                                                txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (txt_OldPassword.Text == "" && txt_NewPassword.Text == "" &&
                                txt_ConfirmPassword.Text == "" && txt_FirstName.Text == "" &&
                                txt_LastName.Text == "")
                                {
                                    lblResult.Text = "The fields are mandatory";
                                    lblResult.ForeColor = Color.Red;

                                    txt_FirstName.Focus();

                                    txt_FirstName.LineFocusedColor = Color.Red;
                                    txt_LastName.LineFocusedColor = Color.Red;
                                    txt_OldPassword.LineFocusedColor = Color.Red;
                                    txt_NewPassword.LineFocusedColor = Color.Red;
                                    txt_ConfirmPassword.LineFocusedColor = Color.Red;
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error " + ex);
            }
        }
    }
}
