using System.ComponentModel;
using System.Windows.Forms;

namespace XBMControl
{
    partial class VideoInfoF1
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
            this.videoPlot = new System.Windows.Forms.RichTextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.videoGenre = new System.Windows.Forms.TextBox();
            this.videoYear = new System.Windows.Forms.TextBox();
            this.videoRuntime = new System.Windows.Forms.TextBox();
            this.videoRating = new System.Windows.Forms.TextBox();
            this.videoTagline = new System.Windows.Forms.RichTextBox();
            this.videoMPAARating = new System.Windows.Forms.RichTextBox();
            this.videoName = new System.Windows.Forms.Label();
            this.videoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPicture)).BeginInit();
            this.SuspendLayout();
            //
            // videoPlot
            //
            this.videoPlot.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoPlot.Location = new System.Drawing.Point(12, 252);
            this.videoPlot.Name = "videoPlot";
            this.videoPlot.ReadOnly = true;
            this.videoPlot.Size = new System.Drawing.Size(486, 146);
            this.videoPlot.TabIndex = 2;
            this.videoPlot.Text = "";
            //
            // bClose
            //
            this.bClose.Location = new System.Drawing.Point(403, 410);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(94, 21);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            //
            // videoGenre
            //
            this.videoGenre.BackColor = System.Drawing.SystemColors.Control;
            this.videoGenre.Location = new System.Drawing.Point(202, 110);
            this.videoGenre.Name = "videoGenre";
            this.videoGenre.ReadOnly = true;
            this.videoGenre.Size = new System.Drawing.Size(295, 20);
            this.videoGenre.TabIndex = 4;
            //
            // videoYear
            //
            this.videoYear.BackColor = System.Drawing.SystemColors.Control;
            this.videoYear.Location = new System.Drawing.Point(202, 136);
            this.videoYear.Name = "videoYear";
            this.videoYear.ReadOnly = true;
            this.videoYear.Size = new System.Drawing.Size(295, 20);
            this.videoYear.TabIndex = 5;
            //
            // videoRuntime
            //
            this.videoRuntime.BackColor = System.Drawing.SystemColors.Control;
            this.videoRuntime.Location = new System.Drawing.Point(202, 162);
            this.videoRuntime.Name = "videoRuntime";
            this.videoRuntime.ReadOnly = true;
            this.videoRuntime.Size = new System.Drawing.Size(295, 20);
            this.videoRuntime.TabIndex = 6;
            //
            // videoRating
            //
            this.videoRating.BackColor = System.Drawing.SystemColors.Control;
            this.videoRating.Location = new System.Drawing.Point(202, 188);
            this.videoRating.Name = "videoRating";
            this.videoRating.ReadOnly = true;
            this.videoRating.Size = new System.Drawing.Size(295, 20);
            this.videoRating.TabIndex = 7;
            //
            // videoTagline
            //
            this.videoTagline.BackColor = System.Drawing.SystemColors.Control;
            this.videoTagline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoTagline.Location = new System.Drawing.Point(202, 44);
            this.videoTagline.Name = "videoTagline";
            this.videoTagline.Size = new System.Drawing.Size(295, 49);
            this.videoTagline.TabIndex = 10;
            this.videoTagline.Text = "";
            //
            // videoMPAARating
            //
            this.videoMPAARating.BackColor = System.Drawing.SystemColors.Control;
            this.videoMPAARating.Location = new System.Drawing.Point(202, 214);
            this.videoMPAARating.Name = "videoMPAARating";
            this.videoMPAARating.Size = new System.Drawing.Size(295, 32);
            this.videoMPAARating.TabIndex = 11;
            this.videoMPAARating.Text = "";
            //
            // videoName
            //
            this.videoName.AutoSize = true;
            this.videoName.Location = new System.Drawing.Point(141, 9);
            this.videoName.Name = "videoName";
            this.videoName.Size = new System.Drawing.Size(0, 13);
            this.videoName.TabIndex = 12;
            //
            // videoPicture
            //
            this.videoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoPicture.Location = new System.Drawing.Point(12, 44);
            this.videoPicture.Name = "videoPicture";
            this.videoPicture.Size = new System.Drawing.Size(172, 201);
            this.videoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoPicture.TabIndex = 13;
            this.videoPicture.TabStop = false;
            //
            // videoInfoF1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 441);
            this.Controls.Add(this.videoPicture);
            this.Controls.Add(this.videoName);
            this.Controls.Add(this.videoMPAARating);
            this.Controls.Add(this.videoTagline);
            this.Controls.Add(this.videoRating);
            this.Controls.Add(this.videoRuntime);
            this.Controls.Add(this.videoYear);
            this.Controls.Add(this.videoGenre);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.videoPlot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VideoInfoF1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Info";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.videoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox videoPlot;
        private Button bClose;
        private TextBox videoGenre;
        private TextBox videoYear;
        private TextBox videoRuntime;
        private TextBox videoRating;
        private RichTextBox videoTagline;
        private RichTextBox videoMPAARating;
        private Label videoName;
        private PictureBox videoPicture;
    }
}