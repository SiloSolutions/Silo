namespace SiloWindowsFormsApp
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblFirstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAccountSettings = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_LastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLastName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblChangePassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_OldPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_NewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_ConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateProfile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_FirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsernameNotEditable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(75, 113);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(707, 113);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(186, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username (not editable)";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(76, 329);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Old Password";
            // 
            // txt_Username
            // 
            this.txt_Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Username.AutoSize = true;
            this.txt_Username.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Enabled = false;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.Silver;
            this.txt_Username.HintForeColor = System.Drawing.Color.Silver;
            this.txt_Username.HintText = "";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_Username.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_Username.LineThickness = 3;
            this.txt_Username.Location = new System.Drawing.Point(711, 146);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(220, 44);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSettings.ForeColor = System.Drawing.Color.White;
            this.lblAccountSettings.Location = new System.Drawing.Point(75, 45);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(174, 23);
            this.lblAccountSettings.TabIndex = 0;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // txt_LastName
            // 
            this.txt_LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_LastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_LastName.AutoSize = true;
            this.txt_LastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_LastName.ForeColor = System.Drawing.Color.Silver;
            this.txt_LastName.HintForeColor = System.Drawing.Color.Silver;
            this.txt_LastName.HintText = "";
            this.txt_LastName.isPassword = false;
            this.txt_LastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_LastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_LastName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_LastName.LineThickness = 3;
            this.txt_LastName.Location = new System.Drawing.Point(395, 146);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.MaxLength = 32767;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(220, 44);
            this.txt_LastName.TabIndex = 2;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(391, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.White;
            this.lblChangePassword.Location = new System.Drawing.Point(75, 263);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(189, 23);
            this.lblChangePassword.TabIndex = 0;
            this.lblChangePassword.Text = "Change Password";
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_OldPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_OldPassword.AutoSize = true;
            this.txt_OldPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_OldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OldPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_OldPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_OldPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txt_OldPassword.HintText = "";
            this.txt_OldPassword.isPassword = true;
            this.txt_OldPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_OldPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_OldPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_OldPassword.LineThickness = 3;
            this.txt_OldPassword.Location = new System.Drawing.Point(79, 364);
            this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OldPassword.MaxLength = 32767;
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(220, 44);
            this.txt_OldPassword.TabIndex = 4;
            this.txt_OldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_NewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_NewPassword.AutoSize = true;
            this.txt_NewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NewPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_NewPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txt_NewPassword.HintText = "";
            this.txt_NewPassword.isPassword = true;
            this.txt_NewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_NewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NewPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_NewPassword.LineThickness = 3;
            this.txt_NewPassword.Location = new System.Drawing.Point(395, 364);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPassword.MaxLength = 32767;
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(220, 44);
            this.txt_NewPassword.TabIndex = 5;
            this.txt_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(391, 329);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "New  Password";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ConfirmPassword.AutoSize = true;
            this.txt_ConfirmPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfirmPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_ConfirmPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txt_ConfirmPassword.HintText = "";
            this.txt_ConfirmPassword.isPassword = true;
            this.txt_ConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_ConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_ConfirmPassword.LineThickness = 3;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(711, 364);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmPassword.MaxLength = 32767;
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(220, 44);
            this.txt_ConfirmPassword.TabIndex = 6;
            this.txt_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(707, 329);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(140, 20);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Confirm Password";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.ActiveBorderThickness = 1;
            this.btnUpdateProfile.ActiveCornerRadius = 25;
            this.btnUpdateProfile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnUpdateProfile.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateProfile.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnUpdateProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateProfile.BackgroundImage")));
            this.btnUpdateProfile.ButtonText = "Update Profile";
            this.btnUpdateProfile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateProfile.IdleBorderThickness = 1;
            this.btnUpdateProfile.IdleCornerRadius = 25;
            this.btnUpdateProfile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnUpdateProfile.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdateProfile.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnUpdateProfile.Location = new System.Drawing.Point(79, 469);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(220, 47);
            this.btnUpdateProfile.TabIndex = 7;
            this.btnUpdateProfile.TabStop = false;
            this.btnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txt_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_FirstName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_FirstName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_FirstName.ForeColor = System.Drawing.Color.Silver;
            this.txt_FirstName.HintForeColor = System.Drawing.Color.Silver;
            this.txt_FirstName.HintText = "";
            this.txt_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FirstName.isPassword = false;
            this.txt_FirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_FirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_FirstName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_FirstName.LineThickness = 3;
            this.txt_FirstName.Location = new System.Drawing.Point(79, 146);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.MaxLength = 32767;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FirstName.Size = new System.Drawing.Size(220, 44);
            this.txt_FirstName.TabIndex = 1;
            this.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblResult.Location = new System.Drawing.Point(79, 427);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 8;
            // 
            // lblUsernameNotEditable
            // 
            this.lblUsernameNotEditable.AutoSize = true;
            this.lblUsernameNotEditable.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameNotEditable.ForeColor = System.Drawing.Color.Silver;
            this.lblUsernameNotEditable.Location = new System.Drawing.Point(716, 156);
            this.lblUsernameNotEditable.Name = "lblUsernameNotEditable";
            this.lblUsernameNotEditable.Size = new System.Drawing.Size(0, 21);
            this.lblUsernameNotEditable.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.lblUsernameNotEditable);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.lblAccountSettings);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblFirstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Username;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAccountSettings;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_LastName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblChangePassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_OldPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NewPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ConfirmPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateProfile;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_FirstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResult;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsernameNotEditable;
    }
}