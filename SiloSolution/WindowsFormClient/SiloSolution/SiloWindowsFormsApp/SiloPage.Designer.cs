namespace SiloWindowsFormsApp
{
    partial class SiloPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiloPage));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pictureUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblWelcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnMenu = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnHide = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureSiloSolutions = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlAnimator = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlSide.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSiloSolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Controls.Add(this.pnlUser);
            this.pnlSide.Controls.Add(this.btnSignOut);
            this.pnlSide.Controls.Add(this.bunifuSeparator1);
            this.pnlSide.Controls.Add(this.btnSettings);
            this.pnlSide.Controls.Add(this.btnData);
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlAnimator.SetDecoration(this.pnlSide, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlSide.Location = new System.Drawing.Point(0, 50);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(270, 670);
            this.pnlSide.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.pictureUser);
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Controls.Add(this.lblWelcome);
            this.pnlUser.Controls.Add(this.btnMenu);
            this.pnlAnimator.SetDecoration(this.pnlUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(270, 228);
            this.pnlUser.TabIndex = 0;
            // 
            // pictureUser
            // 
            this.pictureUser.AllowFocused = false;
            this.pictureUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUser.AutoSizeHeight = true;
            this.pictureUser.BorderRadius = 0;
            this.pnlAnimator.SetDecoration(this.pictureUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.IsCircle = false;
            this.pictureUser.Location = new System.Drawing.Point(89, 4);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(100, 100);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 0;
            this.pictureUser.TabStop = false;
            this.pictureUser.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.pictureUser.Click += new System.EventHandler(this.pictureUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAnimator.SetDecoration(this.lblUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(3, 156);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(268, 72);
            this.lblUser.TabIndex = 10;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AllowParentOverrides = false;
            this.lblWelcome.AutoEllipsis = true;
            this.lblWelcome.CursorType = null;
            this.pnlAnimator.SetDecoration(this.lblWelcome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(72, 126);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(117, 31);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnMenu
            // 
            this.btnMenu.ActiveImage = null;
            this.btnMenu.AllowAnimations = true;
            this.btnMenu.AllowBuffering = false;
            this.btnMenu.AllowZooming = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAnimator.SetDecoration(this.btnMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.ErrorImage")));
            this.btnMenu.FadeWhenInactive = false;
            this.btnMenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.ImageLocation = null;
            this.btnMenu.ImageMargin = 0;
            this.btnMenu.ImageSize = new System.Drawing.Size(39, 39);
            this.btnMenu.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.InitialImage")));
            this.btnMenu.Location = new System.Drawing.Point(220, 5);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0;
            this.btnMenu.ShowActiveImage = true;
            this.btnMenu.ShowCursorChanges = false;
            this.btnMenu.ShowImageBorders = false;
            this.btnMenu.ShowSizeMarkers = false;
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.ToolTipText = "";
            this.btnMenu.WaitOnLoad = false;
            this.btnMenu.Zoom = 0;
            this.btnMenu.ZoomSpeed = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Active = false;
            this.btnSignOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = "Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAnimator.SetDecoration(this.btnSignOut, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Iconimage")));
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 50;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 60D;
            this.btnSignOut.IsTab = false;
            this.btnSignOut.Location = new System.Drawing.Point(0, 550);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(271, 60);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Textcolor = System.Drawing.Color.White;
            this.btnSignOut.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAnimator.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 222);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(270, 17);
            this.bunifuSeparator1.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Active = false;
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAnimator.SetDecoration(this.btnSettings, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 50;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 60D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(0, 460);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(271, 60);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnData
            // 
            this.btnData.Active = false;
            this.btnData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnData.BorderRadius = 0;
            this.btnData.ButtonText = "Data";
            this.btnData.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAnimator.SetDecoration(this.btnData, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnData.DisabledColor = System.Drawing.Color.Gray;
            this.btnData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Iconcolor = System.Drawing.Color.Transparent;
            this.btnData.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnData.Iconimage")));
            this.btnData.Iconimage_right = null;
            this.btnData.Iconimage_right_Selected = null;
            this.btnData.Iconimage_Selected = null;
            this.btnData.IconMarginLeft = 50;
            this.btnData.IconMarginRight = 0;
            this.btnData.IconRightVisible = true;
            this.btnData.IconRightZoom = 0D;
            this.btnData.IconVisible = true;
            this.btnData.IconZoom = 60D;
            this.btnData.IsTab = false;
            this.btnData.Location = new System.Drawing.Point(0, 370);
            this.btnData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnData.Name = "btnData";
            this.btnData.Normalcolor = System.Drawing.Color.Transparent;
            this.btnData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnData.OnHoverTextColor = System.Drawing.Color.White;
            this.btnData.selected = false;
            this.btnData.Size = new System.Drawing.Size(271, 60);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Data";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Textcolor = System.Drawing.Color.White;
            this.btnData.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Active = true;
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAnimator.SetDecoration(this.btnDashboard, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 50;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 60D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 280);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = true;
            this.btnDashboard.Size = new System.Drawing.Size(271, 60);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.pnlTop.Controls.Add(this.btnHide);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.pictureSiloSolutions);
            this.pnlAnimator.SetDecoration(this.pnlTop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // btnHide
            // 
            this.btnHide.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnHide.ActiveImage")));
            this.btnHide.AllowAnimations = true;
            this.btnHide.AllowBuffering = false;
            this.btnHide.AllowZooming = true;
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAnimator.SetDecoration(this.btnHide, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnHide.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHide.ErrorImage")));
            this.btnHide.FadeWhenInactive = false;
            this.btnHide.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnHide.ImageActive")));
            this.btnHide.ImageLocation = null;
            this.btnHide.ImageMargin = 0;
            this.btnHide.ImageSize = new System.Drawing.Size(69, 49);
            this.btnHide.ImageZoomSize = new System.Drawing.Size(70, 50);
            this.btnHide.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHide.InitialImage")));
            this.btnHide.Location = new System.Drawing.Point(1137, 0);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Rotation = 0;
            this.btnHide.ShowActiveImage = true;
            this.btnHide.ShowCursorChanges = false;
            this.btnHide.ShowImageBorders = true;
            this.btnHide.ShowSizeMarkers = false;
            this.btnHide.Size = new System.Drawing.Size(70, 50);
            this.btnHide.TabIndex = 1;
            this.btnHide.ToolTipText = "";
            this.btnHide.WaitOnLoad = false;
            this.btnHide.Zoom = 0;
            this.btnHide.ZoomSpeed = 10;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ActiveImage")));
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAnimator.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 0;
            this.btnClose.ImageSize = new System.Drawing.Size(70, 49);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(71, 50);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1209, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = false;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(71, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureSiloSolutions
            // 
            this.pnlAnimator.SetDecoration(this.pictureSiloSolutions, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureSiloSolutions.Image = ((System.Drawing.Image)(resources.GetObject("pictureSiloSolutions.Image")));
            this.pictureSiloSolutions.Location = new System.Drawing.Point(21, -12);
            this.pictureSiloSolutions.Name = "pictureSiloSolutions";
            this.pictureSiloSolutions.Size = new System.Drawing.Size(225, 73);
            this.pictureSiloSolutions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSiloSolutions.TabIndex = 3;
            this.pictureSiloSolutions.TabStop = false;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.pnlTop;
            this.bunifuDragControl.Vertical = true;
            // 
            // pnlAnimator
            // 
            this.pnlAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.pnlAnimator.Cursor = null;
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
            this.pnlAnimator.DefaultAnimation = animation1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.pnlAnimator.SetDecoration(this.pnlCenter, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlCenter.Location = new System.Drawing.Point(270, 50);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1010, 670);
            this.pnlCenter.TabIndex = 2;
            // 
            // SiloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlCenter);
            this.pnlAnimator.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiloPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiloPage";
            this.pnlSide.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSiloSolutions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlUser;
        private Bunifu.UI.WinForms.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnHide;
        private Bunifu.Framework.UI.BunifuFlatButton btnData;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignOut;
        private System.Windows.Forms.PictureBox pictureSiloSolutions;
        private Bunifu.UI.WinForms.BunifuLabel lblWelcome;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUser;
        private Bunifu.UI.WinForms.BunifuTransition pnlAnimator;
        private System.Windows.Forms.Panel pnlCenter;
        public Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureUser;
    }
}