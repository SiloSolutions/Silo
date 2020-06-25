using System;

namespace SiloWindowsFormsApp
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_SignUpSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signUp = new System.Windows.Forms.Panel();
            this.lblRegisterControl = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignUpPasswordShow = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_SignUpUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SignUpFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SignUpLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignUpPasswordHide = new System.Windows.Forms.PictureBox();
            this.txt_SignUpPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signIn = new System.Windows.Forms.Panel();
            this.lblRegisterResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_SignInSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_SignInUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignInPasswordShow = new System.Windows.Forms.PictureBox();
            this.btnSignInPasswordHide = new System.Windows.Forms.PictureBox();
            this.txt_SignInPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.btnShutdown = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.signUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpPasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpPasswordHide)).BeginInit();
            this.signIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInPasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInPasswordHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutdown)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSignIn
            // 
            this.btnSignIn.ActiveBorderThickness = 1;
            this.btnSignIn.ActiveCornerRadius = 1;
            this.btnSignIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignIn.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSignIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.IdleBorderThickness = 1;
            this.btnSignIn.IdleCornerRadius = 1;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignIn.IdleForecolor = System.Drawing.Color.White;
            this.btnSignIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignIn.Location = new System.Drawing.Point(111, 43);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(163, 64);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.ActiveBorderThickness = 1;
            this.btnSignUp.ActiveCornerRadius = 1;
            this.btnSignUp.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignUp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSignUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.IdleBorderThickness = 1;
            this.btnSignUp.IdleCornerRadius = 1;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignUp.IdleForecolor = System.Drawing.Color.White;
            this.btnSignUp.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignUp.Location = new System.Drawing.Point(277, 43);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(163, 64);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btn_SignUpSend
            // 
            this.btn_SignUpSend.ActiveBorderThickness = 1;
            this.btn_SignUpSend.ActiveCornerRadius = 40;
            this.btn_SignUpSend.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btn_SignUpSend.ActiveForecolor = System.Drawing.Color.White;
            this.btn_SignUpSend.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btn_SignUpSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_SignUpSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SignUpSend.BackgroundImage")));
            this.btn_SignUpSend.ButtonText = "Sign Up";
            this.btn_SignUpSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_SignUpSend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_SignUpSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUpSend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_SignUpSend.IdleBorderThickness = 1;
            this.btn_SignUpSend.IdleCornerRadius = 40;
            this.btn_SignUpSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btn_SignUpSend.IdleForecolor = System.Drawing.Color.White;
            this.btn_SignUpSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btn_SignUpSend.Location = new System.Drawing.Point(28, 379);
            this.btn_SignUpSend.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SignUpSend.Name = "btn_SignUpSend";
            this.btn_SignUpSend.Size = new System.Drawing.Size(419, 64);
            this.btn_SignUpSend.TabIndex = 16;
            this.btn_SignUpSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SignUpSend.Click += new System.EventHandler(this.btn_SignUpSend_Click);
            // 
            // signUp
            // 
            this.signUp.Controls.Add(this.lblRegisterControl);
            this.signUp.Controls.Add(this.bunifuCustomLabel5);
            this.signUp.Controls.Add(this.btn_SignUpSend);
            this.signUp.Controls.Add(this.bunifuCustomLabel4);
            this.signUp.Controls.Add(this.bunifuCustomLabel3);
            this.signUp.Controls.Add(this.bunifuCustomLabel2);
            this.signUp.Controls.Add(this.btnSignUpPasswordShow);
            this.signUp.Controls.Add(this.bunifuCustomLabel1);
            this.signUp.Controls.Add(this.txt_SignUpUsername);
            this.signUp.Controls.Add(this.txt_SignUpFirstName);
            this.signUp.Controls.Add(this.txt_SignUpLastName);
            this.signUp.Controls.Add(this.btnSignUpPasswordHide);
            this.signUp.Controls.Add(this.txt_SignUpPassword);
            this.bunifuTransition1.SetDecoration(this.signUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.signUp.Location = new System.Drawing.Point(574, 115);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(466, 482);
            this.signUp.TabIndex = 4;
            // 
            // lblRegisterControl
            // 
            this.lblRegisterControl.AllowParentOverrides = false;
            this.lblRegisterControl.AutoEllipsis = false;
            this.lblRegisterControl.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.lblRegisterControl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblRegisterControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblRegisterControl.Location = new System.Drawing.Point(28, 351);
            this.lblRegisterControl.Name = "lblRegisterControl";
            this.lblRegisterControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRegisterControl.Size = new System.Drawing.Size(0, 0);
            this.lblRegisterControl.TabIndex = 15;
            this.lblRegisterControl.Text = null;
            this.lblRegisterControl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRegisterControl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 276);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(25, 193);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(83, 20);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Username";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(238, 106);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Last Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 106);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "First Name";
            // 
            // btnSignUpPasswordShow
            // 
            this.bunifuTransition1.SetDecoration(this.btnSignUpPasswordShow, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignUpPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpPasswordShow.Image")));
            this.btnSignUpPasswordShow.Location = new System.Drawing.Point(420, 304);
            this.btnSignUpPasswordShow.Name = "btnSignUpPasswordShow";
            this.btnSignUpPasswordShow.Size = new System.Drawing.Size(24, 24);
            this.btnSignUpPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSignUpPasswordShow.TabIndex = 18;
            this.btnSignUpPasswordShow.TabStop = false;
            this.btnSignUpPasswordShow.Click += new System.EventHandler(this.btnSignUpPasswordShow_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(112, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(220, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Sign Up For Free";
            // 
            // txt_SignUpUsername
            // 
            this.txt_SignUpUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignUpUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignUpUsername.AutoScroll = true;
            this.txt_SignUpUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignUpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignUpUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignUpUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignUpUsername.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpUsername.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpUsername.HintText = "";
            this.txt_SignUpUsername.isPassword = false;
            this.txt_SignUpUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignUpUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignUpUsername.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignUpUsername.LineThickness = 3;
            this.txt_SignUpUsername.Location = new System.Drawing.Point(28, 214);
            this.txt_SignUpUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignUpUsername.MaxLength = 32767;
            this.txt_SignUpUsername.Name = "txt_SignUpUsername";
            this.txt_SignUpUsername.Size = new System.Drawing.Size(416, 44);
            this.txt_SignUpUsername.TabIndex = 13;
            this.txt_SignUpUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SignUpFirstName
            // 
            this.txt_SignUpFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignUpFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignUpFirstName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignUpFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignUpFirstName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignUpFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignUpFirstName.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpFirstName.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpFirstName.HintText = "";
            this.txt_SignUpFirstName.isPassword = false;
            this.txt_SignUpFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignUpFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignUpFirstName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignUpFirstName.LineThickness = 3;
            this.txt_SignUpFirstName.Location = new System.Drawing.Point(25, 129);
            this.txt_SignUpFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignUpFirstName.MaxLength = 32767;
            this.txt_SignUpFirstName.Name = "txt_SignUpFirstName";
            this.txt_SignUpFirstName.Size = new System.Drawing.Size(205, 44);
            this.txt_SignUpFirstName.TabIndex = 9;
            this.txt_SignUpFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SignUpLastName
            // 
            this.txt_SignUpLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignUpLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignUpLastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignUpLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignUpLastName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignUpLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignUpLastName.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpLastName.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpLastName.HintText = "";
            this.txt_SignUpLastName.isPassword = false;
            this.txt_SignUpLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignUpLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignUpLastName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignUpLastName.LineThickness = 3;
            this.txt_SignUpLastName.Location = new System.Drawing.Point(239, 129);
            this.txt_SignUpLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignUpLastName.MaxLength = 32767;
            this.txt_SignUpLastName.Name = "txt_SignUpLastName";
            this.txt_SignUpLastName.Size = new System.Drawing.Size(205, 44);
            this.txt_SignUpLastName.TabIndex = 11;
            this.txt_SignUpLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSignUpPasswordHide
            // 
            this.bunifuTransition1.SetDecoration(this.btnSignUpPasswordHide, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignUpPasswordHide.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpPasswordHide.Image")));
            this.btnSignUpPasswordHide.Location = new System.Drawing.Point(420, 304);
            this.btnSignUpPasswordHide.Name = "btnSignUpPasswordHide";
            this.btnSignUpPasswordHide.Size = new System.Drawing.Size(24, 24);
            this.btnSignUpPasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSignUpPasswordHide.TabIndex = 18;
            this.btnSignUpPasswordHide.TabStop = false;
            this.btnSignUpPasswordHide.Click += new System.EventHandler(this.btnSignUpPasswordHide_Click);
            // 
            // txt_SignUpPassword
            // 
            this.txt_SignUpPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignUpPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignUpPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignUpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignUpPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignUpPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignUpPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignUpPassword.HintText = "";
            this.txt_SignUpPassword.isPassword = true;
            this.txt_SignUpPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignUpPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignUpPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignUpPassword.LineThickness = 3;
            this.txt_SignUpPassword.Location = new System.Drawing.Point(28, 297);
            this.txt_SignUpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignUpPassword.MaxLength = 32767;
            this.txt_SignUpPassword.Name = "txt_SignUpPassword";
            this.txt_SignUpPassword.Size = new System.Drawing.Size(416, 44);
            this.txt_SignUpPassword.TabIndex = 15;
            this.txt_SignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signIn
            // 
            this.signIn.Controls.Add(this.lblRegisterResult);
            this.signIn.Controls.Add(this.lblResult);
            this.signIn.Controls.Add(this.bunifuCustomLabel6);
            this.signIn.Controls.Add(this.btn_SignInSend);
            this.signIn.Controls.Add(this.bunifuCustomLabel7);
            this.signIn.Controls.Add(this.bunifuCustomLabel10);
            this.signIn.Controls.Add(this.txt_SignInUsername);
            this.signIn.Controls.Add(this.btnSignInPasswordShow);
            this.signIn.Controls.Add(this.btnSignInPasswordHide);
            this.signIn.Controls.Add(this.txt_SignInPassword);
            this.bunifuTransition1.SetDecoration(this.signIn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.signIn.Location = new System.Drawing.Point(53, 115);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(466, 482);
            this.signIn.TabIndex = 9;
            // 
            // lblRegisterResult
            // 
            this.lblRegisterResult.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblRegisterResult, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblRegisterResult.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblRegisterResult.Location = new System.Drawing.Point(60, 20);
            this.lblRegisterResult.Name = "lblRegisterResult";
            this.lblRegisterResult.Size = new System.Drawing.Size(0, 21);
            this.lblRegisterResult.TabIndex = 14;
            // 
            // lblResult
            // 
            this.lblResult.AllowParentOverrides = false;
            this.lblResult.AutoEllipsis = false;
            this.lblResult.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.lblResult, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblResult.Location = new System.Drawing.Point(32, 322);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = null;
            this.lblResult.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblResult.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(28, 228);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Password";
            // 
            // btn_SignInSend
            // 
            this.btn_SignInSend.ActiveBorderThickness = 1;
            this.btn_SignInSend.ActiveCornerRadius = 40;
            this.btn_SignInSend.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btn_SignInSend.ActiveForecolor = System.Drawing.Color.White;
            this.btn_SignInSend.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btn_SignInSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_SignInSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SignInSend.BackgroundImage")));
            this.btn_SignInSend.ButtonText = "Sign In";
            this.btn_SignInSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_SignInSend, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_SignInSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignInSend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_SignInSend.IdleBorderThickness = 1;
            this.btn_SignInSend.IdleCornerRadius = 40;
            this.btn_SignInSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btn_SignInSend.IdleForecolor = System.Drawing.Color.White;
            this.btn_SignInSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btn_SignInSend.Location = new System.Drawing.Point(28, 379);
            this.btn_SignInSend.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SignInSend.Name = "btn_SignInSend";
            this.btn_SignInSend.Size = new System.Drawing.Size(419, 64);
            this.btn_SignInSend.TabIndex = 7;
            this.btn_SignInSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SignInSend.Click += new System.EventHandler(this.btn_SignInSend_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(28, 145);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(83, 20);
            this.bunifuCustomLabel7.TabIndex = 3;
            this.bunifuCustomLabel7.Text = "Username";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(177, 53);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(97, 33);
            this.bunifuCustomLabel10.TabIndex = 0;
            this.bunifuCustomLabel10.Text = "Sign In";
            // 
            // txt_SignInUsername
            // 
            this.txt_SignInUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txt_SignInUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignInUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignInUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_SignInUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignInUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignInUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignInUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignInUsername.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignInUsername.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignInUsername.HintText = "";
            this.txt_SignInUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SignInUsername.isPassword = false;
            this.txt_SignInUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignInUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignInUsername.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignInUsername.LineThickness = 3;
            this.txt_SignInUsername.Location = new System.Drawing.Point(31, 166);
            this.txt_SignInUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignInUsername.MaxLength = 32767;
            this.txt_SignInUsername.Name = "txt_SignInUsername";
            this.txt_SignInUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_SignInUsername.Size = new System.Drawing.Size(416, 44);
            this.txt_SignInUsername.TabIndex = 4;
            this.txt_SignInUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSignInPasswordShow
            // 
            this.bunifuTransition1.SetDecoration(this.btnSignInPasswordShow, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignInPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("btnSignInPasswordShow.Image")));
            this.btnSignInPasswordShow.Location = new System.Drawing.Point(423, 257);
            this.btnSignInPasswordShow.Name = "btnSignInPasswordShow";
            this.btnSignInPasswordShow.Size = new System.Drawing.Size(24, 24);
            this.btnSignInPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSignInPasswordShow.TabIndex = 16;
            this.btnSignInPasswordShow.TabStop = false;
            this.btnSignInPasswordShow.Click += new System.EventHandler(this.btnSignInPasswordShow_Click);
            // 
            // btnSignInPasswordHide
            // 
            this.bunifuTransition1.SetDecoration(this.btnSignInPasswordHide, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignInPasswordHide.Image = ((System.Drawing.Image)(resources.GetObject("btnSignInPasswordHide.Image")));
            this.btnSignInPasswordHide.Location = new System.Drawing.Point(423, 257);
            this.btnSignInPasswordHide.Name = "btnSignInPasswordHide";
            this.btnSignInPasswordHide.Size = new System.Drawing.Size(24, 24);
            this.btnSignInPasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSignInPasswordHide.TabIndex = 17;
            this.btnSignInPasswordHide.TabStop = false;
            this.btnSignInPasswordHide.Click += new System.EventHandler(this.btnSignInPasswordHide_Click);
            // 
            // txt_SignInPassword
            // 
            this.txt_SignInPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_SignInPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_SignInPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SignInPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_SignInPassword, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txt_SignInPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SignInPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_SignInPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txt_SignInPassword.HintText = "";
            this.txt_SignInPassword.isPassword = true;
            this.txt_SignInPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.txt_SignInPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SignInPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_SignInPassword.LineThickness = 3;
            this.txt_SignInPassword.Location = new System.Drawing.Point(31, 249);
            this.txt_SignInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SignInPassword.MaxLength = 32767;
            this.txt_SignInPassword.Name = "txt_SignInPassword";
            this.txt_SignInPassword.Size = new System.Drawing.Size(416, 44);
            this.txt_SignInPassword.TabIndex = 6;
            this.txt_SignInPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnShutdown, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.Location = new System.Drawing.Point(12, 12);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(32, 32);
            this.btnShutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShutdown.TabIndex = 13;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator.BackgroundImage")));
            this.bunifuSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator.LineThickness = 5;
            this.bunifuSeparator.Location = new System.Drawing.Point(111, 98);
            this.bunifuSeparator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator.Size = new System.Drawing.Size(163, 10);
            this.bunifuSeparator.TabIndex = 13;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(573, 640);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuSeparator);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.signIn);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.signUp.ResumeLayout(false);
            this.signUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpPasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpPasswordHide)).EndInit();
            this.signIn.ResumeLayout(false);
            this.signIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInPasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInPasswordHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignIn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignUp;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_SignUpSend;
        private System.Windows.Forms.Panel signUp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignUpUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignUpFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignUpLastName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignUpPassword;
        private System.Windows.Forms.Panel signIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_SignInSend;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignInPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SignInUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox btnShutdown;
        private Bunifu.UI.WinForms.BunifuLabel lblResult;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRegisterResult;
        private Bunifu.UI.WinForms.BunifuLabel lblRegisterControl;
        private System.Windows.Forms.PictureBox btnSignInPasswordShow;
        private System.Windows.Forms.PictureBox btnSignInPasswordHide;
        private System.Windows.Forms.PictureBox btnSignUpPasswordShow;
        private System.Windows.Forms.PictureBox btnSignUpPasswordHide;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator;
    }
}