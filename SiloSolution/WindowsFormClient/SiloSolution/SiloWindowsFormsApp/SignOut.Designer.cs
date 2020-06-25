namespace SiloWindowsFormsApp
{
    partial class SignOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignOut));
            this.lblAccountSettings = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFirstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSettings.ForeColor = System.Drawing.Color.White;
            this.lblAccountSettings.Location = new System.Drawing.Point(209, 95);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(90, 23);
            this.lblAccountSettings.TabIndex = 1;
            this.lblAccountSettings.Text = "Sign Out";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(209, 163);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(261, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Are you sure you want to sign out?";
            // 
            // btnSignOut
            // 
            this.btnSignOut.ActiveBorderThickness = 1;
            this.btnSignOut.ActiveCornerRadius = 25;
            this.btnSignOut.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSignOut.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignOut.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSignOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.BackgroundImage")));
            this.btnSignOut.ButtonText = "Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignOut.IdleBorderThickness = 1;
            this.btnSignOut.IdleCornerRadius = 25;
            this.btnSignOut.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignOut.IdleForecolor = System.Drawing.Color.White;
            this.btnSignOut.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSignOut.Location = new System.Drawing.Point(213, 203);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(115, 47);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // SignOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblAccountSettings;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFirstName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignOut;
    }
}