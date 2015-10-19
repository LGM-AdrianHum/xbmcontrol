namespace XBMControl
{
    partial class VolumeControlF1
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
            this.tbVolumeSysTray = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bMute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumeSysTray)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolumeSysTray
            // 
            this.tbVolumeSysTray.AutoSize = false;
            this.tbVolumeSysTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.tbVolumeSysTray.Location = new System.Drawing.Point(3, -2);
            this.tbVolumeSysTray.Maximum = 100;
            this.tbVolumeSysTray.Name = "tbVolumeSysTray";
            this.tbVolumeSysTray.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolumeSysTray.Size = new System.Drawing.Size(23, 127);
            this.tbVolumeSysTray.TabIndex = 2;
            this.tbVolumeSysTray.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolumeSysTray.ValueChanged += new System.EventHandler(this.tbVolumeSysTray_ValueChanged);
            this.tbVolumeSysTray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbVolumeSysTray_MouseDown);
            this.tbVolumeSysTray.LostFocus += new System.EventHandler(this.tbVolumeSysTray_LostFocus);
            this.tbVolumeSysTray.MouseHover += new System.EventHandler(this.tbVolumeSysTray_MouseHover);
            this.tbVolumeSysTray.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbVolumeSysTray_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bMute
            // 
            this.bMute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMute.BackColor = System.Drawing.Color.Transparent;
            this.bMute.BackgroundImage = global::XBMControl.Properties.Resources.button_mute;
            this.bMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bMute.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bMute.FlatAppearance.BorderSize = 0;
            this.bMute.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMute.ForeColor = System.Drawing.Color.Transparent;
            this.bMute.Location = new System.Drawing.Point(2, 122);
            this.bMute.Margin = new System.Windows.Forms.Padding(0);
            this.bMute.Name = "bMute";
            this.bMute.Size = new System.Drawing.Size(24, 18);
            this.bMute.TabIndex = 22;
            this.bMute.UseVisualStyleBackColor = false;
            this.bMute.MouseLeave += new System.EventHandler(this.bMute_MouseLeave);
            this.bMute.Click += new System.EventHandler(this.bMute_Click);
            this.bMute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bMute_MouseDown);
            this.bMute.LostFocus += new System.EventHandler(this.bMute_LostFocus);
            this.bMute.MouseHover += new System.EventHandler(this.bMute_MouseHover);
            this.bMute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bMute_MouseUp);
            this.bMute.MouseEnter += new System.EventHandler(this.bMute_MouseEnter);
            // 
            // VolumeControlF1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(28, 139);
            this.ControlBox = false;
            this.Controls.Add(this.bMute);
            this.Controls.Add(this.tbVolumeSysTray);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumeControlF1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.LostFocus += new System.EventHandler(this.VolumeControlF1_LostFocus);
            this.MouseHover += new System.EventHandler(this.VolumeControlF1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumeSysTray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolumeSysTray;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bMute;

    }
}