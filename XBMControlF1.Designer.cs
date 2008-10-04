﻿namespace XBMControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.ilMediaType = new System.Windows.Forms.ImageList(this.components);
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsControls = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPause = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStop = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNext = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMute = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXBMC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsShowScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsXBMCrestart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXBMCreboot = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXBMCshutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSaveMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeperatorSaveMedia = new System.Windows.Forms.ToolStripSeparator();
            this.cmsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pDetails = new System.Windows.Forms.Panel();
            this.pbLastFM = new System.Windows.Forms.PictureBox();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lAlbumTitle = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.lTitleTitle = new System.Windows.Forms.Label();
            this.lAlbum = new System.Windows.Forms.Label();
            this.lArtistTitle = new System.Windows.Forms.Label();
            this.pNowPlayingInfo = new System.Windows.Forms.Panel();
            this.lArtistSong = new System.Windows.Forms.Label();
            this.pbMediaType = new System.Windows.Forms.PictureBox();
            this.lSamplerate = new System.Windows.Forms.Label();
            this.lSamplerateTitle = new System.Windows.Forms.Label();
            this.lBitrate = new System.Windows.Forms.Label();
            this.lBitrateTitle = new System.Windows.Forms.Label();
            this.lTimePlayed = new System.Windows.Forms.Label();
            this.pControls = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.bMute = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.tbProgress = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bNext = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.pToolbar = new System.Windows.Forms.Panel();
            this.lMainTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.MainContextMenu.SuspendLayout();
            this.pDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLastFM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.pNowPlayingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaType)).BeginInit();
            this.pControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.timerShort_Tick);
            // 
            // ilMediaType
            // 
            this.ilMediaType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMediaType.ImageStream")));
            this.ilMediaType.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMediaType.Images.SetKeyName(0, "video-32x32.png");
            this.ilMediaType.Images.SetKeyName(1, "audio-cd-32x32.png");
            this.ilMediaType.Images.SetKeyName(2, "pictures-32x32.png");
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "previous.png");
            this.ilButtons.Images.SetKeyName(1, "previous_hover.png");
            this.ilButtons.Images.SetKeyName(2, "previous_click.png");
            this.ilButtons.Images.SetKeyName(3, "play.png");
            this.ilButtons.Images.SetKeyName(4, "play_hover.png");
            this.ilButtons.Images.SetKeyName(5, "play_click.png");
            this.ilButtons.Images.SetKeyName(6, "pause.png");
            this.ilButtons.Images.SetKeyName(7, "pause_hover.png");
            this.ilButtons.Images.SetKeyName(8, "pause_click.png");
            this.ilButtons.Images.SetKeyName(9, "stop.png");
            this.ilButtons.Images.SetKeyName(10, "stop_hover.png");
            this.ilButtons.Images.SetKeyName(11, "stop_click.png");
            this.ilButtons.Images.SetKeyName(12, "next.png");
            this.ilButtons.Images.SetKeyName(13, "next_hover.png");
            this.ilButtons.Images.SetKeyName(14, "next_click.png");
            this.ilButtons.Images.SetKeyName(15, "open.png");
            this.ilButtons.Images.SetKeyName(16, "open_hover.png");
            this.ilButtons.Images.SetKeyName(17, "open_click.png");
            this.ilButtons.Images.SetKeyName(18, "mute.png");
            this.ilButtons.Images.SetKeyName(19, "mute_hover.png");
            this.ilButtons.Images.SetKeyName(20, "mute_click.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click to open the XBMController";
            this.notifyIcon1.BalloonTipTitle = "XBMController";
            this.notifyIcon1.ContextMenuStrip = this.MainContextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "XBMControl";
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsControls,
            this.cmsXBMC,
            this.toolStripSeparator2,
            this.cmsSaveMedia,
            this.cmsSeperatorSaveMedia,
            this.cmsShow,
            this.cmsHide,
            this.toolStripSeparator1,
            this.cmsConfigure,
            this.toolStripSeparator3,
            this.cmsExit});
            this.MainContextMenu.Name = "cmsNotifyIcon";
            this.MainContextMenu.Size = new System.Drawing.Size(79, 182);
            this.MainContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.MainContextMenu_Opening);
            // 
            // cmsControls
            // 
            this.cmsControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsPrevious,
            this.cmsPlay,
            this.cmsPause,
            this.cmsStop,
            this.cmsNext,
            this.cmsMute});
            this.cmsControls.Image = global::XBMControl.Properties.Resources.folder_16x16;
            this.cmsControls.Name = "cmsControls";
            this.cmsControls.Size = new System.Drawing.Size(78, 22);
            // 
            // cmsPrevious
            // 
            this.cmsPrevious.Image = global::XBMControl.Properties.Resources.previous_16x16;
            this.cmsPrevious.Name = "cmsPrevious";
            this.cmsPrevious.Size = new System.Drawing.Size(78, 22);
            this.cmsPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // cmsPlay
            // 
            this.cmsPlay.Image = global::XBMControl.Properties.Resources.play2_16x16;
            this.cmsPlay.Name = "cmsPlay";
            this.cmsPlay.Size = new System.Drawing.Size(78, 22);
            // 
            // cmsPause
            // 
            this.cmsPause.Image = global::XBMControl.Properties.Resources.pause_16x16;
            this.cmsPause.Name = "cmsPause";
            this.cmsPause.Size = new System.Drawing.Size(78, 22);
            // 
            // cmsStop
            // 
            this.cmsStop.Image = global::XBMControl.Properties.Resources.stop_16x16;
            this.cmsStop.Name = "cmsStop";
            this.cmsStop.Size = new System.Drawing.Size(78, 22);
            this.cmsStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // cmsNext
            // 
            this.cmsNext.Image = global::XBMControl.Properties.Resources.next_16x16;
            this.cmsNext.Name = "cmsNext";
            this.cmsNext.Size = new System.Drawing.Size(78, 22);
            this.cmsNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // cmsMute
            // 
            this.cmsMute.Image = global::XBMControl.Properties.Resources.mute_16x16;
            this.cmsMute.Name = "cmsMute";
            this.cmsMute.Size = new System.Drawing.Size(78, 22);
            // 
            // cmsXBMC
            // 
            this.cmsXBMC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowScreenshot,
            this.toolStripSeparator4,
            this.cmsXBMCrestart,
            this.cmsXBMCreboot,
            this.cmsXBMCshutdown});
            this.cmsXBMC.Image = global::XBMControl.Properties.Resources.folder_16x16;
            this.cmsXBMC.Name = "cmsXBMC";
            this.cmsXBMC.Size = new System.Drawing.Size(78, 22);
            // 
            // cmsShowScreenshot
            // 
            this.cmsShowScreenshot.Image = global::XBMControl.Properties.Resources.image_16x16;
            this.cmsShowScreenshot.Name = "cmsShowScreenshot";
            this.cmsShowScreenshot.Size = new System.Drawing.Size(78, 22);
            this.cmsShowScreenshot.Click += new System.EventHandler(this.cmsShowScreenshot_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(75, 6);
            // 
            // cmsXBMCrestart
            // 
            this.cmsXBMCrestart.Image = global::XBMControl.Properties.Resources.restart_16x16;
            this.cmsXBMCrestart.Name = "cmsXBMCrestart";
            this.cmsXBMCrestart.Size = new System.Drawing.Size(78, 22);
            this.cmsXBMCrestart.Click += new System.EventHandler(this.cmsXBMCrebootXBMC_Click);
            // 
            // cmsXBMCreboot
            // 
            this.cmsXBMCreboot.Image = global::XBMControl.Properties.Resources.reboot_16x16;
            this.cmsXBMCreboot.Name = "cmsXBMCreboot";
            this.cmsXBMCreboot.Size = new System.Drawing.Size(78, 22);
            this.cmsXBMCreboot.Click += new System.EventHandler(this.cmsXBMCrebootComputer_Click);
            // 
            // cmsXBMCshutdown
            // 
            this.cmsXBMCshutdown.Image = global::XBMControl.Properties.Resources.shutdown_16x16;
            this.cmsXBMCshutdown.Name = "cmsXBMCshutdown";
            this.cmsXBMCshutdown.Size = new System.Drawing.Size(78, 22);
            this.cmsXBMCshutdown.Click += new System.EventHandler(this.cmsXBMCshutdown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(75, 6);
            // 
            // cmsSaveMedia
            // 
            this.cmsSaveMedia.Image = global::XBMControl.Properties.Resources.save_16x16;
            this.cmsSaveMedia.Name = "cmsSaveMedia";
            this.cmsSaveMedia.Size = new System.Drawing.Size(78, 22);
            this.cmsSaveMedia.Visible = false;
            this.cmsSaveMedia.Click += new System.EventHandler(this.cmsSaveMedia_Click);
            // 
            // cmsSeperatorSaveMedia
            // 
            this.cmsSeperatorSaveMedia.Name = "cmsSeperatorSaveMedia";
            this.cmsSeperatorSaveMedia.Size = new System.Drawing.Size(75, 6);
            this.cmsSeperatorSaveMedia.Visible = false;
            // 
            // cmsShow
            // 
            this.cmsShow.Image = global::XBMControl.Properties.Resources.show_16x16;
            this.cmsShow.Name = "cmsShow";
            this.cmsShow.Size = new System.Drawing.Size(78, 22);
            this.cmsShow.Click += new System.EventHandler(this.cmsNotifyShow_Click);
            // 
            // cmsHide
            // 
            this.cmsHide.Image = global::XBMControl.Properties.Resources.hide_16x16;
            this.cmsHide.Name = "cmsHide";
            this.cmsHide.Size = new System.Drawing.Size(78, 22);
            this.cmsHide.Click += new System.EventHandler(this.cmsNotifyHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(75, 6);
            // 
            // cmsConfigure
            // 
            this.cmsConfigure.Image = global::XBMControl.Properties.Resources.configure_16x16;
            this.cmsConfigure.Name = "cmsConfigure";
            this.cmsConfigure.Size = new System.Drawing.Size(78, 22);
            this.cmsConfigure.Click += new System.EventHandler(this.cmsConfigure_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(75, 6);
            // 
            // cmsExit
            // 
            this.cmsExit.Image = global::XBMControl.Properties.Resources.exit_16x16;
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.Size = new System.Drawing.Size(78, 22);
            this.cmsExit.Click += new System.EventHandler(this.cmsNotifyExit_Click);
            // 
            // pDetails
            // 
            this.pDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pDetails.BackColor = System.Drawing.Color.Transparent;
            this.pDetails.BackgroundImage = global::XBMControl.Properties.Resources.background_details3;
            this.pDetails.Controls.Add(this.pbLastFM);
            this.pDetails.Controls.Add(this.pbThumbnail);
            this.pDetails.Controls.Add(this.lTitle);
            this.pDetails.Controls.Add(this.lAlbumTitle);
            this.pDetails.Controls.Add(this.lArtist);
            this.pDetails.Controls.Add(this.lTitleTitle);
            this.pDetails.Controls.Add(this.lAlbum);
            this.pDetails.Controls.Add(this.lArtistTitle);
            this.pDetails.Location = new System.Drawing.Point(2, 79);
            this.pDetails.Name = "pDetails";
            this.pDetails.Size = new System.Drawing.Size(264, 54);
            this.pDetails.TabIndex = 18;
            // 
            // pbLastFM
            // 
            this.pbLastFM.Image = global::XBMControl.Properties.Resources.last_fm_16x16;
            this.pbLastFM.Location = new System.Drawing.Point(247, 36);
            this.pbLastFM.Name = "pbLastFM";
            this.pbLastFM.Size = new System.Drawing.Size(16, 16);
            this.pbLastFM.TabIndex = 33;
            this.pbLastFM.TabStop = false;
            this.pbLastFM.Visible = false;
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbThumbnail.ErrorImage = null;
            this.pbThumbnail.Image = global::XBMControl.Properties.Resources.XBMClogo_90x90;
            this.pbThumbnail.InitialImage = global::XBMControl.Properties.Resources.XBMClogo_90x90;
            this.pbThumbnail.Location = new System.Drawing.Point(212, 1);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(52, 52);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumbnail.TabIndex = 39;
            this.pbThumbnail.TabStop = false;
            this.pbThumbnail.MouseLeave += new System.EventHandler(this.pbThumbnail_MouseLeave);
            this.pbThumbnail.Click += new System.EventHandler(this.pbThumbnail_Click);
            this.pbThumbnail.MouseEnter += new System.EventHandler(this.pbThumbnail_MouseHover);
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lTitle.Location = new System.Drawing.Point(43, 19);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(171, 13);
            this.lTitle.TabIndex = 38;
            // 
            // lAlbumTitle
            // 
            this.lAlbumTitle.BackColor = System.Drawing.Color.Transparent;
            this.lAlbumTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAlbumTitle.ForeColor = System.Drawing.Color.Silver;
            this.lAlbumTitle.Location = new System.Drawing.Point(2, 32);
            this.lAlbumTitle.Name = "lAlbumTitle";
            this.lAlbumTitle.Size = new System.Drawing.Size(44, 13);
            this.lAlbumTitle.TabIndex = 35;
            this.lAlbumTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lArtist
            // 
            this.lArtist.BackColor = System.Drawing.Color.Transparent;
            this.lArtist.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lArtist.Location = new System.Drawing.Point(43, 6);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(171, 13);
            this.lArtist.TabIndex = 37;
            // 
            // lTitleTitle
            // 
            this.lTitleTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitleTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTitleTitle.ForeColor = System.Drawing.Color.Silver;
            this.lTitleTitle.Location = new System.Drawing.Point(2, 19);
            this.lTitleTitle.Name = "lTitleTitle";
            this.lTitleTitle.Size = new System.Drawing.Size(44, 13);
            this.lTitleTitle.TabIndex = 34;
            this.lTitleTitle.Tag = "";
            this.lTitleTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lAlbum
            // 
            this.lAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lAlbum.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lAlbum.Location = new System.Drawing.Point(43, 32);
            this.lAlbum.Name = "lAlbum";
            this.lAlbum.Size = new System.Drawing.Size(170, 13);
            this.lAlbum.TabIndex = 36;
            // 
            // lArtistTitle
            // 
            this.lArtistTitle.BackColor = System.Drawing.Color.Transparent;
            this.lArtistTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lArtistTitle.ForeColor = System.Drawing.Color.Silver;
            this.lArtistTitle.Location = new System.Drawing.Point(2, 6);
            this.lArtistTitle.Name = "lArtistTitle";
            this.lArtistTitle.Size = new System.Drawing.Size(44, 13);
            this.lArtistTitle.TabIndex = 33;
            this.lArtistTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pNowPlayingInfo
            // 
            this.pNowPlayingInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pNowPlayingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.pNowPlayingInfo.Controls.Add(this.lArtistSong);
            this.pNowPlayingInfo.Controls.Add(this.pbMediaType);
            this.pNowPlayingInfo.Controls.Add(this.lSamplerate);
            this.pNowPlayingInfo.Controls.Add(this.lSamplerateTitle);
            this.pNowPlayingInfo.Controls.Add(this.lBitrate);
            this.pNowPlayingInfo.Controls.Add(this.lBitrateTitle);
            this.pNowPlayingInfo.Controls.Add(this.lTimePlayed);
            this.pNowPlayingInfo.Location = new System.Drawing.Point(2, 22);
            this.pNowPlayingInfo.Name = "pNowPlayingInfo";
            this.pNowPlayingInfo.Size = new System.Drawing.Size(264, 57);
            this.pNowPlayingInfo.TabIndex = 21;
            // 
            // lArtistSong
            // 
            this.lArtistSong.BackColor = System.Drawing.Color.Transparent;
            this.lArtistSong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArtistSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lArtistSong.Location = new System.Drawing.Point(2, 37);
            this.lArtistSong.Margin = new System.Windows.Forms.Padding(0);
            this.lArtistSong.Name = "lArtistSong";
            this.lArtistSong.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lArtistSong.Size = new System.Drawing.Size(259, 19);
            this.lArtistSong.TabIndex = 7;
            this.lArtistSong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lArtistSong.MouseLeave += new System.EventHandler(this.lArtistSong_MouseLeave);
            this.lArtistSong.Click += new System.EventHandler(this.lArtistSong_Click);
            this.lArtistSong.MouseHover += new System.EventHandler(this.lArtistSong_MouseEnter);
            // 
            // pbMediaType
            // 
            this.pbMediaType.Image = global::XBMControl.Properties.Resources.audio_cd_32x32;
            this.pbMediaType.Location = new System.Drawing.Point(228, 1);
            this.pbMediaType.Name = "pbMediaType";
            this.pbMediaType.Size = new System.Drawing.Size(32, 32);
            this.pbMediaType.TabIndex = 6;
            this.pbMediaType.TabStop = false;
            this.pbMediaType.Visible = false;
            // 
            // lSamplerate
            // 
            this.lSamplerate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lSamplerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lSamplerate.Location = new System.Drawing.Point(183, 15);
            this.lSamplerate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lSamplerate.Name = "lSamplerate";
            this.lSamplerate.Size = new System.Drawing.Size(23, 10);
            this.lSamplerate.TabIndex = 4;
            this.lSamplerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSamplerateTitle
            // 
            this.lSamplerateTitle.AutoSize = true;
            this.lSamplerateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lSamplerateTitle.ForeColor = System.Drawing.Color.Silver;
            this.lSamplerateTitle.Location = new System.Drawing.Point(203, 15);
            this.lSamplerateTitle.Name = "lSamplerateTitle";
            this.lSamplerateTitle.Size = new System.Drawing.Size(19, 11);
            this.lSamplerateTitle.TabIndex = 3;
            this.lSamplerateTitle.Text = "khz";
            // 
            // lBitrate
            // 
            this.lBitrate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lBitrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lBitrate.Location = new System.Drawing.Point(181, 5);
            this.lBitrate.Margin = new System.Windows.Forms.Padding(0);
            this.lBitrate.Name = "lBitrate";
            this.lBitrate.Size = new System.Drawing.Size(25, 10);
            this.lBitrate.TabIndex = 2;
            this.lBitrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBitrateTitle
            // 
            this.lBitrateTitle.AutoSize = true;
            this.lBitrateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lBitrateTitle.ForeColor = System.Drawing.Color.Silver;
            this.lBitrateTitle.Location = new System.Drawing.Point(203, 4);
            this.lBitrateTitle.Name = "lBitrateTitle";
            this.lBitrateTitle.Size = new System.Drawing.Size(24, 11);
            this.lBitrateTitle.TabIndex = 1;
            this.lBitrateTitle.Text = "kbps";
            // 
            // lTimePlayed
            // 
            this.lTimePlayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.lTimePlayed.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimePlayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.lTimePlayed.Location = new System.Drawing.Point(10, 0);
            this.lTimePlayed.Name = "lTimePlayed";
            this.lTimePlayed.Size = new System.Drawing.Size(163, 32);
            this.lTimePlayed.TabIndex = 0;
            this.lTimePlayed.Text = "00:00";
            // 
            // pControls
            // 
            this.pControls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.pControls.BackgroundImage = global::XBMControl.Properties.Resources.background_controls2;
            this.pControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pControls.Controls.Add(this.tbVolume);
            this.pControls.Controls.Add(this.bMute);
            this.pControls.Controls.Add(this.bOpen);
            this.pControls.Controls.Add(this.tbProgress);
            this.pControls.Controls.Add(this.pictureBox1);
            this.pControls.Controls.Add(this.bNext);
            this.pControls.Controls.Add(this.bStop);
            this.pControls.Controls.Add(this.bPause);
            this.pControls.Controls.Add(this.bPlay);
            this.pControls.Controls.Add(this.bPrevious);
            this.pControls.Location = new System.Drawing.Point(2, 133);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(264, 50);
            this.pControls.TabIndex = 16;
            // 
            // tbVolume
            // 
            this.tbVolume.AutoSize = false;
            this.tbVolume.LargeChange = 2;
            this.tbVolume.Location = new System.Drawing.Point(172, 2);
            this.tbVolume.Maximum = 100;
            this.tbVolume.MaximumSize = new System.Drawing.Size(200, 21);
            this.tbVolume.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(65, 18);
            this.tbVolume.TabIndex = 22;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            this.tbVolume.MouseHover += new System.EventHandler(this.tbVolume_MouseHover);
            // 
            // bMute
            // 
            this.bMute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMute.BackColor = System.Drawing.Color.Transparent;
            this.bMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bMute.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bMute.FlatAppearance.BorderSize = 0;
            this.bMute.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMute.ForeColor = System.Drawing.Color.Transparent;
            this.bMute.ImageIndex = 18;
            this.bMute.ImageList = this.ilButtons;
            this.bMute.Location = new System.Drawing.Point(235, 2);
            this.bMute.Name = "bMute";
            this.bMute.Size = new System.Drawing.Size(24, 18);
            this.bMute.TabIndex = 21;
            this.bMute.UseVisualStyleBackColor = false;
            this.bMute.MouseLeave += new System.EventHandler(this.bMute_MouseLeave);
            this.bMute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bMute_MouseDown);
            this.bMute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bMute_MouseUp);
            this.bMute.MouseEnter += new System.EventHandler(this.bMute_MouseEnter);
            // 
            // bOpen
            // 
            this.bOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bOpen.BackColor = System.Drawing.Color.Transparent;
            this.bOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bOpen.FlatAppearance.BorderSize = 0;
            this.bOpen.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpen.ForeColor = System.Drawing.Color.Transparent;
            this.bOpen.ImageIndex = 15;
            this.bOpen.ImageList = this.ilButtons;
            this.bOpen.Location = new System.Drawing.Point(137, 22);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(24, 18);
            this.bOpen.TabIndex = 20;
            this.bOpen.UseVisualStyleBackColor = false;
            this.bOpen.MouseLeave += new System.EventHandler(this.bOpen_MouseLeave);
            this.bOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bOpen_MouseDown);
            this.bOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bOpen_MouseUp);
            this.bOpen.MouseEnter += new System.EventHandler(this.bOpen_MouseEnter);
            // 
            // tbProgress
            // 
            this.tbProgress.AutoSize = false;
            this.tbProgress.Location = new System.Drawing.Point(5, 2);
            this.tbProgress.Maximum = 100;
            this.tbProgress.MaximumSize = new System.Drawing.Size(350, 22);
            this.tbProgress.Minimum = 1;
            this.tbProgress.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(164, 18);
            this.tbProgress.TabIndex = 19;
            this.tbProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbProgress.Value = 1;
            this.tbProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbProgress_MouseDown);
            this.tbProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbProgress_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XBMControl.Properties.Resources.openContextMenuArrow1;
            this.pictureBox1.Location = new System.Drawing.Point(252, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bNext
            // 
            this.bNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNext.BackColor = System.Drawing.Color.Transparent;
            this.bNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.ForeColor = System.Drawing.Color.Transparent;
            this.bNext.ImageIndex = 12;
            this.bNext.ImageList = this.ilButtons;
            this.bNext.Location = new System.Drawing.Point(109, 22);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(24, 18);
            this.bNext.TabIndex = 16;
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.MouseLeave += new System.EventHandler(this.bNext_MouseLeave);
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            this.bNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bNext_MouseDown);
            this.bNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bNext_MouseUp);
            this.bNext.MouseEnter += new System.EventHandler(this.bNext_MouseEnter);
            // 
            // bStop
            // 
            this.bStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bStop.BackColor = System.Drawing.Color.Transparent;
            this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.ForeColor = System.Drawing.Color.Transparent;
            this.bStop.ImageIndex = 9;
            this.bStop.ImageList = this.ilButtons;
            this.bStop.Location = new System.Drawing.Point(85, 22);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(24, 18);
            this.bStop.TabIndex = 15;
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.MouseLeave += new System.EventHandler(this.bStop_MouseLeave);
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            this.bStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bStop_MouseDown);
            this.bStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bStop_MouseUp);
            this.bStop.MouseEnter += new System.EventHandler(this.bStop_MouseEnter);
            // 
            // bPause
            // 
            this.bPause.BackColor = System.Drawing.Color.Transparent;
            this.bPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bPause.FlatAppearance.BorderSize = 0;
            this.bPause.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPause.ForeColor = System.Drawing.Color.Transparent;
            this.bPause.ImageIndex = 6;
            this.bPause.ImageList = this.ilButtons;
            this.bPause.Location = new System.Drawing.Point(61, 22);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(24, 18);
            this.bPause.TabIndex = 14;
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.MouseLeave += new System.EventHandler(this.bPause_MouseLeave);
            this.bPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bPause_MouseDown);
            this.bPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bPause_MouseUp);
            this.bPause.MouseEnter += new System.EventHandler(this.bPause_MouseEnter);
            // 
            // bPlay
            // 
            this.bPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPlay.BackColor = System.Drawing.Color.Transparent;
            this.bPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bPlay.FlatAppearance.BorderSize = 0;
            this.bPlay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.ForeColor = System.Drawing.Color.Transparent;
            this.bPlay.ImageIndex = 3;
            this.bPlay.ImageList = this.ilButtons;
            this.bPlay.Location = new System.Drawing.Point(37, 22);
            this.bPlay.Margin = new System.Windows.Forms.Padding(0);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(24, 18);
            this.bPlay.TabIndex = 13;
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.MouseLeave += new System.EventHandler(this.bPlay_MouseLeave);
            this.bPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bPlay_MouseDown);
            this.bPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bPlay_MouseUp);
            this.bPlay.MouseEnter += new System.EventHandler(this.bPlay_MouseEnter);
            // 
            // bPrevious
            // 
            this.bPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPrevious.BackColor = System.Drawing.Color.Transparent;
            this.bPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bPrevious.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bPrevious.FlatAppearance.BorderSize = 0;
            this.bPrevious.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.bPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.bPrevious.ImageIndex = 0;
            this.bPrevious.ImageList = this.ilButtons;
            this.bPrevious.Location = new System.Drawing.Point(13, 22);
            this.bPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(24, 18);
            this.bPrevious.TabIndex = 12;
            this.bPrevious.UseVisualStyleBackColor = false;
            this.bPrevious.MouseLeave += new System.EventHandler(this.bPrevious_MouseLeave);
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            this.bPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bPrevious_MouseDown);
            this.bPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bPrevious_MouseUp);
            this.bPrevious.MouseEnter += new System.EventHandler(this.bPrevious_MouseEnter);
            // 
            // pToolbar
            // 
            this.pToolbar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pToolbar.BackgroundImage = global::XBMControl.Properties.Resources.toolbar1;
            this.pToolbar.Controls.Add(this.lMainTitle);
            this.pToolbar.Controls.Add(this.pictureBox2);
            this.pToolbar.Controls.Add(this.pbMinimize);
            this.pToolbar.Controls.Add(this.pbClose);
            this.pToolbar.Location = new System.Drawing.Point(2, 2);
            this.pToolbar.Name = "pToolbar";
            this.pToolbar.Size = new System.Drawing.Size(264, 20);
            this.pToolbar.TabIndex = 22;
            this.pToolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseMove);
            this.pToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseDown);
            this.pToolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseUp);
            // 
            // lMainTitle
            // 
            this.lMainTitle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lMainTitle.Location = new System.Drawing.Point(29, 3);
            this.lMainTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lMainTitle.Name = "lMainTitle";
            this.lMainTitle.Size = new System.Drawing.Size(212, 13);
            this.lMainTitle.TabIndex = 3;
            this.lMainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseMove);
            this.lMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseDown);
            this.lMainTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::XBMControl.Properties.Resources.XBMC;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseMove);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pToolbar_MouseUp);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = global::XBMControl.Properties.Resources.minimize1;
            this.pbMinimize.Location = new System.Drawing.Point(244, 4);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(9, 9);
            this.pbMinimize.TabIndex = 1;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMinimize_MouseUp);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::XBMControl.Properties.Resources.close1;
            this.pbClose.Location = new System.Drawing.Point(251, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(9, 9);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseUp);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::XBMControl.Properties.Resources.MainFormBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 184);
            this.ControlBox = false;
            this.Controls.Add(this.pToolbar);
            this.Controls.Add(this.pNowPlayingInfo);
            this.Controls.Add(this.pDetails);
            this.Controls.Add(this.pControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBMControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainContextMenu.ResumeLayout(false);
            this.pDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLastFM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.pNowPlayingInfo.ResumeLayout(false);
            this.pNowPlayingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaType)).EndInit();
            this.pControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ImageList ilMediaType;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmsShow;
        private System.Windows.Forms.ToolStripMenuItem cmsHide;
        private System.Windows.Forms.ToolStripMenuItem cmsConfigure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmsControls;
        private System.Windows.Forms.ToolStripMenuItem cmsPrevious;
        private System.Windows.Forms.ToolStripMenuItem cmsPlay;
        private System.Windows.Forms.ToolStripMenuItem cmsPause;
        private System.Windows.Forms.ToolStripMenuItem cmsStop;
        private System.Windows.Forms.ToolStripMenuItem cmsNext;
        private System.Windows.Forms.ToolStripMenuItem cmsMute;
        private System.Windows.Forms.ToolStripMenuItem cmsXBMC;
        private System.Windows.Forms.ToolStripMenuItem cmsXBMCreboot;
        private System.Windows.Forms.ToolStripMenuItem cmsXBMCrestart;
        private System.Windows.Forms.ToolStripMenuItem cmsXBMCshutdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cmsSaveMedia;
        private System.Windows.Forms.ToolStripSeparator cmsSeperatorSaveMedia;
        private System.Windows.Forms.ToolStripMenuItem cmsShowScreenshot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TrackBar tbProgress;
        private System.Windows.Forms.Panel pDetails;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lAlbumTitle;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.Label lTitleTitle;
        private System.Windows.Forms.Label lAlbum;
        private System.Windows.Forms.Label lArtistTitle;
        private System.Windows.Forms.ImageList ilButtons;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Panel pNowPlayingInfo;
        private System.Windows.Forms.PictureBox pbLastFM;
        private System.Windows.Forms.PictureBox pbMediaType;
        private System.Windows.Forms.Label lSamplerate;
        private System.Windows.Forms.Label lSamplerateTitle;
        private System.Windows.Forms.Label lBitrate;
        private System.Windows.Forms.Label lBitrateTitle;
        private System.Windows.Forms.Label lTimePlayed;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Label lArtistSong;
        private System.Windows.Forms.Panel pToolbar;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lMainTitle;
        private System.Windows.Forms.Button bMute;
        private System.Windows.Forms.TrackBar tbVolume;
    }
}

