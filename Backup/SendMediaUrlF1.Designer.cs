namespace XBMControl
{
    partial class SendMediaUrl
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
            this.tbMediaUrl = new System.Windows.Forms.TextBox();
            this.lMediaUrl = new System.Windows.Forms.Label();
            this.bSendMediaUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMediaUrl
            // 
            this.tbMediaUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.tbMediaUrl.Location = new System.Drawing.Point(44, 12);
            this.tbMediaUrl.Name = "tbMediaUrl";
            this.tbMediaUrl.Size = new System.Drawing.Size(176, 21);
            this.tbMediaUrl.TabIndex = 0;
            // 
            // lMediaUrl
            // 
            this.lMediaUrl.AutoSize = true;
            this.lMediaUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lMediaUrl.Location = new System.Drawing.Point(12, 15);
            this.lMediaUrl.Name = "lMediaUrl";
            this.lMediaUrl.Size = new System.Drawing.Size(26, 13);
            this.lMediaUrl.TabIndex = 1;
            this.lMediaUrl.Text = "URL";
            // 
            // bSendMediaUrl
            // 
            this.bSendMediaUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.bSendMediaUrl.Location = new System.Drawing.Point(226, 10);
            this.bSendMediaUrl.Name = "bSendMediaUrl";
            this.bSendMediaUrl.Size = new System.Drawing.Size(48, 23);
            this.bSendMediaUrl.TabIndex = 2;
            this.bSendMediaUrl.Text = "Send";
            this.bSendMediaUrl.UseVisualStyleBackColor = true;
            this.bSendMediaUrl.Click += new System.EventHandler(this.bSendMediaUrl_Click);
            // 
            // SendMediaUrl
            // 
            this.AcceptButton = this.bSendMediaUrl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(286, 45);
            this.Controls.Add(this.bSendMediaUrl);
            this.Controls.Add(this.lMediaUrl);
            this.Controls.Add(this.tbMediaUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SendMediaUrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send media url";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMediaUrl;
        private System.Windows.Forms.Label lMediaUrl;
        private System.Windows.Forms.Button bSendMediaUrl;
    }
}