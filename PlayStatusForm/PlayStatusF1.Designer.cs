using System.ComponentModel;
using System.Windows.Forms;

namespace XBMControl.PlayStatusForm
{
    partial class PlayStatusF1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.hideFormTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.lAlbum = new System.Windows.Forms.Label();
            this.lNowPlaying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // pbThumbnail
            //
            this.pbThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThumbnail.Location = new System.Drawing.Point(0, 0);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(80, 80);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumbnail.TabIndex = 0;
            this.pbThumbnail.TabStop = false;
            //
            // hideFormTimer
            //
            this.hideFormTimer.Tick += new System.EventHandler(this.hideFormTimer_Tick);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.lArtist);
            this.panel1.Controls.Add(this.lAlbum);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(80, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 55);
            this.panel1.TabIndex = 1;
            //
            // lTitle
            //
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(4, 19);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(247, 16);
            this.lTitle.TabIndex = 50;
            //
            // lArtist
            //
            this.lArtist.BackColor = System.Drawing.Color.Transparent;
            this.lArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArtist.ForeColor = System.Drawing.Color.Red;
            this.lArtist.Location = new System.Drawing.Point(4, 3);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(247, 13);
            this.lArtist.TabIndex = 49;
            //
            // lAlbum
            //
            this.lAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlbum.ForeColor = System.Drawing.Color.Red;
            this.lAlbum.Location = new System.Drawing.Point(4, 38);
            this.lAlbum.Name = "lAlbum";
            this.lAlbum.Size = new System.Drawing.Size(247, 14);
            this.lAlbum.TabIndex = 48;
            //
            // lNowPlaying
            //
            this.lNowPlaying.AutoSize = true;
            this.lNowPlaying.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNowPlaying.Location = new System.Drawing.Point(83, 5);
            this.lNowPlaying.Name = "lNowPlaying";
            this.lNowPlaying.Size = new System.Drawing.Size(94, 14);
            this.lNowPlaying.TabIndex = 2;
            this.lNowPlaying.Text = "Now Playing...";
            //
            // PlayStatusF1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(335, 80);
            this.ControlBox = false;
            this.Controls.Add(this.lNowPlaying);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbThumbnail);
            this.Enabled = false;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayStatusF1";
            this.Opacity = 0;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Play Status";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.PlayStatusF1_Activated);
            this.Click += new System.EventHandler(this.PlayStatusF1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbThumbnail;
        private Timer hideFormTimer;
        private Panel panel1;
        private Label lTitle;
        private Label lArtist;
        private Label lAlbum;
        private Label lNowPlaying;
    }
}