namespace SiloWindowsFormsApp
{
    partial class BootPage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BootPage));
            this.bootPicture = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingBar = new System.Windows.Forms.Panel();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bootPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bootPicture
            // 
            this.bootPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bootPicture.Image = ((System.Drawing.Image)(resources.GetObject("bootPicture.Image")));
            this.bootPicture.Location = new System.Drawing.Point(0, 0);
            this.bootPicture.Name = "bootPicture";
            this.bootPicture.Size = new System.Drawing.Size(700, 400);
            this.bootPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bootPicture.TabIndex = 0;
            this.bootPicture.TabStop = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingPanel.Location = new System.Drawing.Point(0, 390);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(700, 10);
            this.loadingPanel.TabIndex = 1;
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.loadingBar.Location = new System.Drawing.Point(0, 390);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(26, 10);
            this.loadingBar.TabIndex = 2;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 15;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // BootPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.bootPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BootPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootPage";
            ((System.ComponentModel.ISupportInitialize)(this.bootPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bootPicture;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Panel loadingBar;
        private System.Windows.Forms.Timer loadingTimer;
    }
}

