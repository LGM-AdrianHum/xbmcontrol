using System.ComponentModel;
using System.Windows.Forms;

namespace XBMControl
{
    partial class NavigatorF1
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigatorF1));
            this.bRight = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.bUndo = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.bVolDown = new System.Windows.Forms.Button();
            this.bVolUp = new System.Windows.Forms.Button();
            this.bRewind = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bPlayPause = new System.Windows.Forms.Button();
            this.bForward = new System.Windows.Forms.Button();
            this.pToolbar = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.lMainTitle = new System.Windows.Forms.Label();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.navigatorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.pToolbar.SuspendLayout();
            this.SuspendLayout();
            //
            // bRight
            //
            this.bRight.BackColor = System.Drawing.Color.DimGray;
            this.bRight.BackgroundImage = global::XBMControl.Properties.Resources.navigator_right;
            this.bRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bRight.FlatAppearance.BorderSize = 0;
            this.bRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRight.ForeColor = System.Drawing.Color.DimGray;
            this.bRight.Location = new System.Drawing.Point(135, 138);
            this.bRight.Margin = new System.Windows.Forms.Padding(0);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(45, 45);
            this.bRight.TabIndex = 9;
            this.navigatorToolTip.SetToolTip(this.bRight, "Move Right");
            this.bRight.UseVisualStyleBackColor = false;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            //
            // bLeft
            //
            this.bLeft.BackColor = System.Drawing.Color.Transparent;
            this.bLeft.BackgroundImage = global::XBMControl.Properties.Resources.navigator_left;
            this.bLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bLeft.FlatAppearance.BorderSize = 0;
            this.bLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLeft.ForeColor = System.Drawing.Color.DimGray;
            this.bLeft.Location = new System.Drawing.Point(45, 138);
            this.bLeft.Margin = new System.Windows.Forms.Padding(0);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(45, 45);
            this.bLeft.TabIndex = 10;
            this.navigatorToolTip.SetToolTip(this.bLeft, "Move Left");
            this.bLeft.UseVisualStyleBackColor = false;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            //
            // bUp
            //
            this.bUp.BackColor = System.Drawing.Color.Transparent;
            this.bUp.BackgroundImage = global::XBMControl.Properties.Resources.navigator_up;
            this.bUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bUp.FlatAppearance.BorderSize = 0;
            this.bUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUp.ForeColor = System.Drawing.Color.DimGray;
            this.bUp.Location = new System.Drawing.Point(90, 93);
            this.bUp.Margin = new System.Windows.Forms.Padding(0);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(45, 45);
            this.bUp.TabIndex = 11;
            this.navigatorToolTip.SetToolTip(this.bUp, "Move Up");
            this.bUp.UseVisualStyleBackColor = false;
            this.bUp.Click += new System.EventHandler(this.bUp_Click);
            //
            // bDown
            //
            this.bDown.AllowDrop = true;
            this.bDown.BackColor = System.Drawing.Color.Transparent;
            this.bDown.BackgroundImage = global::XBMControl.Properties.Resources.navigator_down;
            this.bDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bDown.FlatAppearance.BorderSize = 0;
            this.bDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDown.ForeColor = System.Drawing.Color.DimGray;
            this.bDown.Location = new System.Drawing.Point(90, 183);
            this.bDown.Margin = new System.Windows.Forms.Padding(0);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(45, 45);
            this.bDown.TabIndex = 12;
            this.navigatorToolTip.SetToolTip(this.bDown, "Move Down");
            this.bDown.UseVisualStyleBackColor = false;
            this.bDown.Click += new System.EventHandler(this.bDown_Click);
            //
            // bSelect
            //
            this.bSelect.BackColor = System.Drawing.Color.Transparent;
            this.bSelect.BackgroundImage = global::XBMControl.Properties.Resources.navigator_select;
            this.bSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bSelect.FlatAppearance.BorderSize = 0;
            this.bSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelect.ForeColor = System.Drawing.Color.DimGray;
            this.bSelect.Location = new System.Drawing.Point(90, 138);
            this.bSelect.Margin = new System.Windows.Forms.Padding(0);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(45, 45);
            this.bSelect.TabIndex = 14;
            this.navigatorToolTip.SetToolTip(this.bSelect, "Select");
            this.bSelect.UseVisualStyleBackColor = false;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            //
            // bUndo
            //
            this.bUndo.BackColor = System.Drawing.Color.Transparent;
            this.bUndo.BackgroundImage = global::XBMControl.Properties.Resources.navigator_back;
            this.bUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bUndo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bUndo.FlatAppearance.BorderSize = 0;
            this.bUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUndo.ForeColor = System.Drawing.Color.DimGray;
            this.bUndo.Location = new System.Drawing.Point(160, 33);
            this.bUndo.Margin = new System.Windows.Forms.Padding(0);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(45, 45);
            this.bUndo.TabIndex = 15;
            this.navigatorToolTip.SetToolTip(this.bUndo, "XBMC Back Menu");
            this.bUndo.UseVisualStyleBackColor = false;
            this.bUndo.Click += new System.EventHandler(this.bUndo_Click_1);
            //
            // bOptions
            //
            this.bOptions.BackColor = System.Drawing.Color.Transparent;
            this.bOptions.BackgroundImage = global::XBMControl.Properties.Resources.navigator_options;
            this.bOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bOptions.FlatAppearance.BorderSize = 0;
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOptions.ForeColor = System.Drawing.Color.DimGray;
            this.bOptions.Location = new System.Drawing.Point(90, 36);
            this.bOptions.Margin = new System.Windows.Forms.Padding(0);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(45, 45);
            this.bOptions.TabIndex = 16;
            this.bOptions.UseVisualStyleBackColor = false;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            //
            // bHome
            //
            this.bHome.BackgroundImage = global::XBMControl.Properties.Resources.navigator_home;
            this.bHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHome.FlatAppearance.BorderSize = 0;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.ForeColor = System.Drawing.Color.DimGray;
            this.bHome.Location = new System.Drawing.Point(25, 36);
            this.bHome.Margin = new System.Windows.Forms.Padding(0);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(45, 45);
            this.bHome.TabIndex = 17;
            this.navigatorToolTip.SetToolTip(this.bHome, "XBMC Main Menu");
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            //
            // bVolDown
            //
            this.bVolDown.BackgroundImage = global::XBMControl.Properties.Resources.navigator_vol_down;
            this.bVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVolDown.FlatAppearance.BorderSize = 0;
            this.bVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolDown.ForeColor = System.Drawing.Color.DimGray;
            this.bVolDown.Location = new System.Drawing.Point(25, 93);
            this.bVolDown.Margin = new System.Windows.Forms.Padding(0);
            this.bVolDown.Name = "bVolDown";
            this.bVolDown.Size = new System.Drawing.Size(45, 45);
            this.bVolDown.TabIndex = 18;
            this.navigatorToolTip.SetToolTip(this.bVolDown, "Volume Down");
            this.bVolDown.UseVisualStyleBackColor = true;
            this.bVolDown.Click += new System.EventHandler(this.bVolDown_Click);
            //
            // bVolUp
            //
            this.bVolUp.BackgroundImage = global::XBMControl.Properties.Resources.navigator_vol_up;
            this.bVolUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVolUp.FlatAppearance.BorderSize = 0;
            this.bVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolUp.ForeColor = System.Drawing.Color.DimGray;
            this.bVolUp.Location = new System.Drawing.Point(160, 93);
            this.bVolUp.Margin = new System.Windows.Forms.Padding(0);
            this.bVolUp.Name = "bVolUp";
            this.bVolUp.Size = new System.Drawing.Size(45, 45);
            this.bVolUp.TabIndex = 19;
            this.navigatorToolTip.SetToolTip(this.bVolUp, "Volume Up");
            this.bVolUp.UseVisualStyleBackColor = true;
            this.bVolUp.Click += new System.EventHandler(this.bVolUp_Click);
            //
            // bRewind
            //
            this.bRewind.BackgroundImage = global::XBMControl.Properties.Resources.navigator_rewind;
            this.bRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRewind.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bRewind.FlatAppearance.BorderSize = 0;
            this.bRewind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bRewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRewind.ForeColor = System.Drawing.Color.DimGray;
            this.bRewind.Location = new System.Drawing.Point(25, 237);
            this.bRewind.Margin = new System.Windows.Forms.Padding(0);
            this.bRewind.Name = "bRewind";
            this.bRewind.Size = new System.Drawing.Size(45, 45);
            this.bRewind.TabIndex = 20;
            this.navigatorToolTip.SetToolTip(this.bRewind, "Rewind");
            this.bRewind.UseVisualStyleBackColor = true;
            this.bRewind.Click += new System.EventHandler(this.bRewind_Click);
            //
            // bStop
            //
            this.bStop.BackgroundImage = global::XBMControl.Properties.Resources.navigator_stop;
            this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.ForeColor = System.Drawing.Color.DimGray;
            this.bStop.Location = new System.Drawing.Point(70, 237);
            this.bStop.Margin = new System.Windows.Forms.Padding(0);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(45, 45);
            this.bStop.TabIndex = 21;
            this.navigatorToolTip.SetToolTip(this.bStop, "Stop");
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            //
            // bPlayPause
            //
            this.bPlayPause.BackgroundImage = global::XBMControl.Properties.Resources.navigator_play_pause;
            this.bPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPlayPause.FlatAppearance.BorderSize = 0;
            this.bPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlayPause.ForeColor = System.Drawing.Color.DimGray;
            this.bPlayPause.Location = new System.Drawing.Point(115, 237);
            this.bPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.bPlayPause.Name = "bPlayPause";
            this.bPlayPause.Size = new System.Drawing.Size(45, 45);
            this.bPlayPause.TabIndex = 22;
            this.navigatorToolTip.SetToolTip(this.bPlayPause, "Play/Pause");
            this.bPlayPause.UseVisualStyleBackColor = true;
            this.bPlayPause.Click += new System.EventHandler(this.bPlayPause_Click);
            //
            // bForward
            //
            this.bForward.BackgroundImage = global::XBMControl.Properties.Resources.navigator_forward;
            this.bForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bForward.FlatAppearance.BorderSize = 0;
            this.bForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bForward.ForeColor = System.Drawing.Color.DimGray;
            this.bForward.Location = new System.Drawing.Point(160, 237);
            this.bForward.Margin = new System.Windows.Forms.Padding(0);
            this.bForward.Name = "bForward";
            this.bForward.Size = new System.Drawing.Size(45, 45);
            this.bForward.TabIndex = 23;
            this.navigatorToolTip.SetToolTip(this.bForward, "Fast Foward");
            this.bForward.UseVisualStyleBackColor = true;
            this.bForward.Click += new System.EventHandler(this.bForward_Click);
            //
            // pToolbar
            //
            this.pToolbar.BackColor = System.Drawing.Color.Transparent;
            this.pToolbar.Controls.Add(this.bClose);
            this.pToolbar.Controls.Add(this.lMainTitle);
            this.pToolbar.Location = new System.Drawing.Point(0, -1);
            this.pToolbar.Name = "pToolbar";
            this.pToolbar.Size = new System.Drawing.Size(233, 31);
            this.pToolbar.TabIndex = 24;
            this.pToolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseMove);
            this.pToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseDown);
            this.pToolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseUp);
            //
            // bClose
            //
            this.bClose.BackColor = System.Drawing.Color.DimGray;
            this.bClose.BackgroundImage = global::XBMControl.Properties.Resources.button_exit;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.Black;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bClose.Location = new System.Drawing.Point(209, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(20, 21);
            this.bClose.TabIndex = 1;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bClose_MouseDown);
            this.bClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bClose_MouseUp);
            this.bClose.MouseEnter += new System.EventHandler(this.bClose_MouseEnter);
            //
            // lMainTitle
            //
            this.lMainTitle.AutoSize = true;
            this.lMainTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMainTitle.Location = new System.Drawing.Point(57, 2);
            this.lMainTitle.Name = "lMainTitle";
            this.lMainTitle.Size = new System.Drawing.Size(115, 23);
            this.lMainTitle.TabIndex = 0;
            this.lMainTitle.Text = "Navigator";
            this.lMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lMainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseMove);
            this.lMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseDown);
            this.lMainTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseUp);
            //
            // bPrevious
            //
            this.bPrevious.BackgroundImage = global::XBMControl.Properties.Resources.navigator_previous;
            this.bPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrevious.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bPrevious.FlatAppearance.BorderSize = 0;
            this.bPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.ForeColor = System.Drawing.Color.DimGray;
            this.bPrevious.Location = new System.Drawing.Point(25, 192);
            this.bPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(45, 45);
            this.bPrevious.TabIndex = 25;
            this.navigatorToolTip.SetToolTip(this.bPrevious, "Previous");
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            //
            // bNext
            //
            this.bNext.BackgroundImage = global::XBMControl.Properties.Resources.navigator_next;
            this.bNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.ForeColor = System.Drawing.Color.DimGray;
            this.bNext.Location = new System.Drawing.Point(160, 192);
            this.bNext.Margin = new System.Windows.Forms.Padding(0);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(45, 45);
            this.bNext.TabIndex = 26;
            this.navigatorToolTip.SetToolTip(this.bNext, "Next");
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            //
            // button1
            //
            this.button1.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(45, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 27;
            this.navigatorToolTip.SetToolTip(this.button1, "Volume Down");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2
            //
            this.button2.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(90, 294);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 28;
            this.navigatorToolTip.SetToolTip(this.button2, "Volume Down");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3
            //
            this.button3.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_3;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(135, 294);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 29;
            this.navigatorToolTip.SetToolTip(this.button3, "Volume Down");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // button4
            //
            this.button4.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_4;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(45, 339);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 32;
            this.navigatorToolTip.SetToolTip(this.button4, "Volume Down");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button5
            //
            this.button5.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_5;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(90, 339);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 31;
            this.navigatorToolTip.SetToolTip(this.button5, "Volume Down");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // button6
            //
            this.button6.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_6;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(135, 339);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 30;
            this.navigatorToolTip.SetToolTip(this.button6, "Volume Down");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            //
            // button7
            //
            this.button7.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_7;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.DimGray;
            this.button7.Location = new System.Drawing.Point(45, 384);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 35;
            this.navigatorToolTip.SetToolTip(this.button7, "Volume Down");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            //
            // button8
            //
            this.button8.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_8;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.DimGray;
            this.button8.Location = new System.Drawing.Point(90, 384);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 34;
            this.navigatorToolTip.SetToolTip(this.button8, "Volume Down");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            //
            // button9
            //
            this.button9.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_9;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.DimGray;
            this.button9.Location = new System.Drawing.Point(135, 384);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 33;
            this.navigatorToolTip.SetToolTip(this.button9, "Volume Down");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            //
            // button0
            //
            this.button0.BackgroundImage = global::XBMControl.Properties.Resources.navigator_numpad_0;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.ForeColor = System.Drawing.Color.DimGray;
            this.button0.Location = new System.Drawing.Point(90, 429);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 45);
            this.button0.TabIndex = 36;
            this.navigatorToolTip.SetToolTip(this.button0, "Volume Down");
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            //
            // NavigatorF1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 479);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.pToolbar);
            this.Controls.Add(this.bForward);
            this.Controls.Add(this.bPlayPause);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bRewind);
            this.Controls.Add(this.bVolUp);
            this.Controls.Add(this.bVolDown);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.bUndo);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bRight);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavigatorF1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Navigator";
            this.Load += new System.EventHandler(this.NavigatorF1_Load);
            this.pToolbar.ResumeLayout(false);
            this.pToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bRight;
        private Button bLeft;
        private Button bUp;
        private Button bDown;
        private Button bSelect;
        private Button bUndo;
        private Button bOptions;
        private Button bHome;
        private Button bVolDown;
        private Button bVolUp;
        private Button bRewind;
        private Button bStop;
        private Button bPlayPause;
        private Button bForward;
        private Panel pToolbar;
        private Button bClose;
        private Label lMainTitle;
        private Button bPrevious;
        private Button bNext;
        private ToolTip navigatorToolTip;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
    }
}