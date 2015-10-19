namespace XBMControl
{
    partial class ConfigurationF1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationF1));
            this.bCancel = new System.Windows.Forms.Button();
            this.bConfirm = new System.Windows.Forms.Button();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.lIpTitle = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lUsernameTitle = new System.Windows.Forms.Label();
            this.lPasswordTitle = new System.Windows.Forms.Label();
            this.cbShowInTray = new System.Windows.Forms.CheckBox();
            this.cbShowNowPlayingBalloonTip = new System.Windows.Forms.CheckBox();
            this.cbShowPlayStatusBalloonTip = new System.Windows.Forms.CheckBox();
            this.cbShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.cbShowConnectionStatusBalloonTip = new System.Windows.Forms.CheckBox();
            this.lLanguageTitle = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbRunAtStartup = new System.Windows.Forms.CheckBox();
            this.cbConnectionTimeout = new System.Windows.Forms.ComboBox();
            this.lConnectionTimeout = new System.Windows.Forms.Label();
            this.lMs = new System.Windows.Forms.Label();
            this.pbXBMCLogo = new System.Windows.Forms.PictureBox();
            this.cbStartMinimized = new System.Windows.Forms.CheckBox();
            this.cbShowConfigurationAtStart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbXBMCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(305, 334);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(72, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bConfirm
            // 
            this.bConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bConfirm.Location = new System.Drawing.Point(227, 334);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(72, 23);
            this.bConfirm.TabIndex = 1;
            this.bConfirm.Text = "OK";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // tbIp
            // 
            this.tbIp.AcceptsReturn = true;
            this.tbIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIp.Location = new System.Drawing.Point(241, 39);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(134, 20);
            this.tbIp.TabIndex = 5;
            // 
            // lIpTitle
            // 
            this.lIpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lIpTitle.Location = new System.Drawing.Point(138, 42);
            this.lIpTitle.Name = "lIpTitle";
            this.lIpTitle.Size = new System.Drawing.Size(100, 18);
            this.lIpTitle.TabIndex = 8;
            this.lIpTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(241, 66);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(134, 20);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(241, 93);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(134, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // lUsernameTitle
            // 
            this.lUsernameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lUsernameTitle.Location = new System.Drawing.Point(138, 69);
            this.lUsernameTitle.Name = "lUsernameTitle";
            this.lUsernameTitle.Size = new System.Drawing.Size(100, 18);
            this.lUsernameTitle.TabIndex = 11;
            this.lUsernameTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lPasswordTitle
            // 
            this.lPasswordTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPasswordTitle.Location = new System.Drawing.Point(24, 96);
            this.lPasswordTitle.Name = "lPasswordTitle";
            this.lPasswordTitle.Size = new System.Drawing.Size(211, 18);
            this.lPasswordTitle.TabIndex = 12;
            this.lPasswordTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbShowInTray
            // 
            this.cbShowInTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowInTray.AutoSize = true;
            this.cbShowInTray.Location = new System.Drawing.Point(12, 188);
            this.cbShowInTray.Name = "cbShowInTray";
            this.cbShowInTray.Size = new System.Drawing.Size(15, 14);
            this.cbShowInTray.TabIndex = 13;
            this.cbShowInTray.UseVisualStyleBackColor = true;
            this.cbShowInTray.Click += new System.EventHandler(this.cbShowInTray_Click);
            // 
            // cbShowNowPlayingBalloonTip
            // 
            this.cbShowNowPlayingBalloonTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowNowPlayingBalloonTip.AutoSize = true;
            this.cbShowNowPlayingBalloonTip.Enabled = false;
            this.cbShowNowPlayingBalloonTip.Location = new System.Drawing.Point(12, 224);
            this.cbShowNowPlayingBalloonTip.Name = "cbShowNowPlayingBalloonTip";
            this.cbShowNowPlayingBalloonTip.Size = new System.Drawing.Size(15, 14);
            this.cbShowNowPlayingBalloonTip.TabIndex = 14;
            this.cbShowNowPlayingBalloonTip.UseVisualStyleBackColor = true;
            // 
            // cbShowPlayStatusBalloonTip
            // 
            this.cbShowPlayStatusBalloonTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowPlayStatusBalloonTip.AutoSize = true;
            this.cbShowPlayStatusBalloonTip.Enabled = false;
            this.cbShowPlayStatusBalloonTip.Location = new System.Drawing.Point(12, 242);
            this.cbShowPlayStatusBalloonTip.Name = "cbShowPlayStatusBalloonTip";
            this.cbShowPlayStatusBalloonTip.Size = new System.Drawing.Size(15, 14);
            this.cbShowPlayStatusBalloonTip.TabIndex = 15;
            this.cbShowPlayStatusBalloonTip.UseVisualStyleBackColor = true;
            // 
            // cbShowInTaskbar
            // 
            this.cbShowInTaskbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowInTaskbar.AutoSize = true;
            this.cbShowInTaskbar.Enabled = false;
            this.cbShowInTaskbar.Location = new System.Drawing.Point(12, 206);
            this.cbShowInTaskbar.Name = "cbShowInTaskbar";
            this.cbShowInTaskbar.Size = new System.Drawing.Size(15, 14);
            this.cbShowInTaskbar.TabIndex = 16;
            this.cbShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // cbShowConnectionStatusBalloonTip
            // 
            this.cbShowConnectionStatusBalloonTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowConnectionStatusBalloonTip.AutoSize = true;
            this.cbShowConnectionStatusBalloonTip.Enabled = false;
            this.cbShowConnectionStatusBalloonTip.Location = new System.Drawing.Point(12, 260);
            this.cbShowConnectionStatusBalloonTip.Name = "cbShowConnectionStatusBalloonTip";
            this.cbShowConnectionStatusBalloonTip.Size = new System.Drawing.Size(15, 14);
            this.cbShowConnectionStatusBalloonTip.TabIndex = 17;
            this.cbShowConnectionStatusBalloonTip.UseVisualStyleBackColor = true;
            // 
            // lLanguageTitle
            // 
            this.lLanguageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLanguageTitle.Location = new System.Drawing.Point(138, 15);
            this.lLanguageTitle.Name = "lLanguageTitle";
            this.lLanguageTitle.Size = new System.Drawing.Size(100, 18);
            this.lLanguageTitle.TabIndex = 18;
            this.lLanguageTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbLanguage
            // 
            this.cbLanguage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(241, 12);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(136, 21);
            this.cbLanguage.Sorted = true;
            this.cbLanguage.TabIndex = 19;
            this.cbLanguage.TextChanged += new System.EventHandler(this.cbLanguage_TextChanged);
            // 
            // cbRunAtStartup
            // 
            this.cbRunAtStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRunAtStartup.AutoSize = true;
            this.cbRunAtStartup.Location = new System.Drawing.Point(12, 278);
            this.cbRunAtStartup.Name = "cbRunAtStartup";
            this.cbRunAtStartup.Size = new System.Drawing.Size(15, 14);
            this.cbRunAtStartup.TabIndex = 21;
            this.cbRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // cbConnectionTimeout
            // 
            this.cbConnectionTimeout.FormattingEnabled = true;
            this.cbConnectionTimeout.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "750",
            "1000",
            "1250",
            "1500",
            "1750",
            "2000",
            "2250",
            "2500",
            "2750",
            "3000",
            "3250",
            "3500",
            "3750",
            "4000"});
            this.cbConnectionTimeout.Location = new System.Drawing.Point(241, 120);
            this.cbConnectionTimeout.Name = "cbConnectionTimeout";
            this.cbConnectionTimeout.Size = new System.Drawing.Size(105, 21);
            this.cbConnectionTimeout.TabIndex = 22;
            this.cbConnectionTimeout.SelectedValueChanged += new System.EventHandler(this.cbConnectionTimeout_SelectedValueChanged);
            // 
            // lConnectionTimeout
            // 
            this.lConnectionTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lConnectionTimeout.Location = new System.Drawing.Point(24, 123);
            this.lConnectionTimeout.Name = "lConnectionTimeout";
            this.lConnectionTimeout.Size = new System.Drawing.Size(211, 18);
            this.lConnectionTimeout.TabIndex = 23;
            this.lConnectionTimeout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lMs
            // 
            this.lMs.Location = new System.Drawing.Point(355, 123);
            this.lMs.Name = "lMs";
            this.lMs.Size = new System.Drawing.Size(22, 23);
            this.lMs.TabIndex = 24;
            this.lMs.Text = "ms";
            // 
            // pbXBMCLogo
            // 
            this.pbXBMCLogo.Image = global::XBMControl.Properties.Resources.XBMClogo;
            this.pbXBMCLogo.Location = new System.Drawing.Point(11, 12);
            this.pbXBMCLogo.Name = "pbXBMCLogo";
            this.pbXBMCLogo.Size = new System.Drawing.Size(124, 72);
            this.pbXBMCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbXBMCLogo.TabIndex = 20;
            this.pbXBMCLogo.TabStop = false;
            // 
            // cbStartMinimized
            // 
            this.cbStartMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStartMinimized.AutoSize = true;
            this.cbStartMinimized.Location = new System.Drawing.Point(12, 170);
            this.cbStartMinimized.Name = "cbStartMinimized";
            this.cbStartMinimized.Size = new System.Drawing.Size(15, 14);
            this.cbStartMinimized.TabIndex = 26;
            this.cbStartMinimized.UseVisualStyleBackColor = true;
            // 
            // cbShowConfigurationAtStart
            // 
            this.cbShowConfigurationAtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowConfigurationAtStart.AutoSize = true;
            this.cbShowConfigurationAtStart.Location = new System.Drawing.Point(12, 298);
            this.cbShowConfigurationAtStart.Name = "cbShowConfigurationAtStart";
            this.cbShowConfigurationAtStart.Size = new System.Drawing.Size(15, 14);
            this.cbShowConfigurationAtStart.TabIndex = 27;
            this.cbShowConfigurationAtStart.UseVisualStyleBackColor = true;
            // 
            // ConfigurationF1
            // 
            this.AcceptButton = this.bConfirm;
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(389, 369);
            this.Controls.Add(this.cbShowConfigurationAtStart);
            this.Controls.Add(this.cbStartMinimized);
            this.Controls.Add(this.lMs);
            this.Controls.Add(this.lConnectionTimeout);
            this.Controls.Add(this.cbConnectionTimeout);
            this.Controls.Add(this.cbRunAtStartup);
            this.Controls.Add(this.pbXBMCLogo);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lLanguageTitle);
            this.Controls.Add(this.cbShowConnectionStatusBalloonTip);
            this.Controls.Add(this.cbShowInTaskbar);
            this.Controls.Add(this.cbShowPlayStatusBalloonTip);
            this.Controls.Add(this.cbShowNowPlayingBalloonTip);
            this.Controls.Add(this.cbShowInTray);
            this.Controls.Add(this.lPasswordTitle);
            this.Controls.Add(this.lUsernameTitle);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lIpTitle);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.bCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationF1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBMControl Configuration";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationF1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbXBMCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Label lIpTitle;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lUsernameTitle;
        private System.Windows.Forms.Label lPasswordTitle;
        private System.Windows.Forms.CheckBox cbShowInTray;
        private System.Windows.Forms.CheckBox cbShowNowPlayingBalloonTip;
        private System.Windows.Forms.CheckBox cbShowPlayStatusBalloonTip;
        private System.Windows.Forms.CheckBox cbShowInTaskbar;
        private System.Windows.Forms.CheckBox cbShowConnectionStatusBalloonTip;
        private System.Windows.Forms.Label lLanguageTitle;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.PictureBox pbXBMCLogo;
        private System.Windows.Forms.CheckBox cbRunAtStartup;
        private System.Windows.Forms.ComboBox cbConnectionTimeout;
        private System.Windows.Forms.Label lConnectionTimeout;
        private System.Windows.Forms.Label lMs;
        private System.Windows.Forms.CheckBox cbStartMinimized;
        private System.Windows.Forms.CheckBox cbShowConfigurationAtStart;
    }
}