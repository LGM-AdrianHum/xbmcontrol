using System.ComponentModel;
using System.Windows.Forms;

namespace XBMControl
{
    partial class MediaBrowserF1
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaBrowserF1));
            this.cmsFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiPlayRecursive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEnqueueRecursive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiUpdateLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdateMusicLibrary1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdateVideoLibrary1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ilFiletypes = new System.Windows.Forms.ImageList(this.components);
            this.cmsSongs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiPlayFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEnqueueFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiUpdateLibrary2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdateMusicLibrary2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdateVideoLibrary2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMediaBrowser = new System.Windows.Forms.TabControl();
            this.tabShares = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbShareType = new System.Windows.Forms.ComboBox();
            this.tvMediaShares = new System.Windows.Forms.TreeView();
            this.lvDirectorySongs = new System.Windows.Forms.ListView();
            this.tabArtists = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbSearchArtist = new System.Windows.Forms.TextBox();
            this.tvArtists = new System.Windows.Forms.TreeView();
            this.lvArtistSongs = new System.Windows.Forms.ListView();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tbSearchAlbum = new System.Windows.Forms.TextBox();
            this.tvAlbums = new System.Windows.Forms.TreeView();
            this.lvAlbumSongs = new System.Windows.Forms.ListView();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.bSearchSong = new System.Windows.Forms.Button();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.tbSearchSong = new System.Windows.Forms.TextBox();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.cmsVideo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiPlayVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEnqueueVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInfoVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiUpdateLibrary3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvVideos = new System.Windows.Forms.ListView();
            this.nameVideo = new System.Windows.Forms.ColumnHeader();
            this.yearVideo = new System.Windows.Forms.ColumnHeader();
            this.IMDB_ID = new System.Windows.Forms.ColumnHeader();
            this.tbSearchVideo = new System.Windows.Forms.TextBox();
            this.cmsFolder.SuspendLayout();
            this.cmsSongs.SuspendLayout();
            this.tcMediaBrowser.SuspendLayout();
            this.tabShares.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabArtists.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabAlbums.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tabVideos.SuspendLayout();
            this.cmsVideo.SuspendLayout();
            this.SuspendLayout();
            //
            // cmsFolder
            //
            this.cmsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPlayRecursive,
            this.tsiEnqueueRecursive,
            this.toolStripSeparator2,
            this.tsiUpdateLibrary,
            this.toolStripSeparator1,
            this.tsiCollapseAll,
            this.tsiRefresh});
            this.cmsFolder.Name = "cmsFolder";
            this.cmsFolder.Size = new System.Drawing.Size(175, 126);
            this.cmsFolder.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFolder_Opening);
            //
            // tsiPlayRecursive
            //
            this.tsiPlayRecursive.Name = "tsiPlayRecursive";
            this.tsiPlayRecursive.Size = new System.Drawing.Size(174, 22);
            this.tsiPlayRecursive.Text = "Play";
            this.tsiPlayRecursive.Click += new System.EventHandler(this.tsiPlayRecursive_Click);
            //
            // tsiEnqueueRecursive
            //
            this.tsiEnqueueRecursive.Name = "tsiEnqueueRecursive";
            this.tsiEnqueueRecursive.Size = new System.Drawing.Size(174, 22);
            this.tsiEnqueueRecursive.Text = "Enqueue";
            this.tsiEnqueueRecursive.Click += new System.EventHandler(this.tsiEnqueueRecursive_Click);
            //
            // toolStripSeparator2
            //
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            //
            // tsiUpdateLibrary
            //
            this.tsiUpdateLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUpdateMusicLibrary1,
            this.tsiUpdateVideoLibrary1});
            this.tsiUpdateLibrary.Name = "tsiUpdateLibrary";
            this.tsiUpdateLibrary.Size = new System.Drawing.Size(174, 22);
            this.tsiUpdateLibrary.Text = "Update library";
            //
            // tsiUpdateMusicLibrary1
            //
            this.tsiUpdateMusicLibrary1.Name = "tsiUpdateMusicLibrary1";
            this.tsiUpdateMusicLibrary1.Size = new System.Drawing.Size(111, 22);
            this.tsiUpdateMusicLibrary1.Text = "Music";
            this.tsiUpdateMusicLibrary1.Click += new System.EventHandler(this.UpdateMusicLibrary);
            //
            // tsiUpdateVideoLibrary1
            //
            this.tsiUpdateVideoLibrary1.Name = "tsiUpdateVideoLibrary1";
            this.tsiUpdateVideoLibrary1.Size = new System.Drawing.Size(111, 22);
            this.tsiUpdateVideoLibrary1.Text = "Video";
            this.tsiUpdateVideoLibrary1.Click += new System.EventHandler(this.UpdateVideoLibrary);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            //
            // tsiCollapseAll
            //
            this.tsiCollapseAll.Name = "tsiCollapseAll";
            this.tsiCollapseAll.Size = new System.Drawing.Size(174, 22);
            this.tsiCollapseAll.Text = "Collapse all folders";
            this.tsiCollapseAll.Click += new System.EventHandler(this.tsiCollapseAll_Click);
            //
            // tsiRefresh
            //
            this.tsiRefresh.Name = "tsiRefresh";
            this.tsiRefresh.Size = new System.Drawing.Size(174, 22);
            this.tsiRefresh.Text = "Refresh";
            this.tsiRefresh.Click += new System.EventHandler(this.tsiRefresh_Click);
            //
            // ilFiletypes
            //
            this.ilFiletypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFiletypes.ImageStream")));
            this.ilFiletypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFiletypes.Images.SetKeyName(0, "folder2.png");
            this.ilFiletypes.Images.SetKeyName(1, "music.png");
            this.ilFiletypes.Images.SetKeyName(2, "picture.png");
            this.ilFiletypes.Images.SetKeyName(3, "video.png");
            this.ilFiletypes.Images.SetKeyName(4, "file.png");
            //
            // cmsSongs
            //
            this.cmsSongs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPlayFiles,
            this.tsiEnqueueFiles,
            this.toolStripSeparator3,
            this.tsiUpdateLibrary2});
            this.cmsSongs.Name = "cmsFiles";
            this.cmsSongs.Size = new System.Drawing.Size(154, 76);
            this.cmsSongs.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSongs_Opening);
            //
            // tsiPlayFiles
            //
            this.tsiPlayFiles.Name = "tsiPlayFiles";
            this.tsiPlayFiles.Size = new System.Drawing.Size(153, 22);
            this.tsiPlayFiles.Text = "Play";
            this.tsiPlayFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tsiEnqueueFiles
            //
            this.tsiEnqueueFiles.Name = "tsiEnqueueFiles";
            this.tsiEnqueueFiles.Size = new System.Drawing.Size(153, 22);
            this.tsiEnqueueFiles.Text = "Enqueue";
            this.tsiEnqueueFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EnqueSelectedFiles);
            //
            // toolStripSeparator3
            //
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            //
            // tsiUpdateLibrary2
            //
            this.tsiUpdateLibrary2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUpdateMusicLibrary2,
            this.tsiUpdateVideoLibrary2});
            this.tsiUpdateLibrary2.Name = "tsiUpdateLibrary2";
            this.tsiUpdateLibrary2.Size = new System.Drawing.Size(153, 22);
            this.tsiUpdateLibrary2.Text = "Update library";
            //
            // tsiUpdateMusicLibrary2
            //
            this.tsiUpdateMusicLibrary2.Name = "tsiUpdateMusicLibrary2";
            this.tsiUpdateMusicLibrary2.Size = new System.Drawing.Size(111, 22);
            this.tsiUpdateMusicLibrary2.Text = "Music";
            this.tsiUpdateMusicLibrary2.Click += new System.EventHandler(this.UpdateMusicLibrary);
            //
            // tsiUpdateVideoLibrary2
            //
            this.tsiUpdateVideoLibrary2.Name = "tsiUpdateVideoLibrary2";
            this.tsiUpdateVideoLibrary2.Size = new System.Drawing.Size(111, 22);
            this.tsiUpdateVideoLibrary2.Text = "Video";
            this.tsiUpdateVideoLibrary2.Click += new System.EventHandler(this.UpdateVideoLibrary);
            //
            // tcMediaBrowser
            //
            this.tcMediaBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMediaBrowser.Controls.Add(this.tabShares);
            this.tcMediaBrowser.Controls.Add(this.tabArtists);
            this.tcMediaBrowser.Controls.Add(this.tabAlbums);
            this.tcMediaBrowser.Controls.Add(this.tabSongs);
            this.tcMediaBrowser.Controls.Add(this.tabVideos);
            this.tcMediaBrowser.Location = new System.Drawing.Point(0, 1);
            this.tcMediaBrowser.Name = "tcMediaBrowser";
            this.tcMediaBrowser.SelectedIndex = 0;
            this.tcMediaBrowser.Size = new System.Drawing.Size(525, 450);
            this.tcMediaBrowser.TabIndex = 2;
            this.tcMediaBrowser.MouseHover += new System.EventHandler(this.SetFocus);
            this.tcMediaBrowser.SelectedIndexChanged += new System.EventHandler(this.tcMediaBrowser_SelectedIndexChanged);
            //
            // tabShares
            //
            this.tabShares.Controls.Add(this.splitContainer1);
            this.tabShares.Location = new System.Drawing.Point(4, 22);
            this.tabShares.Name = "tabShares";
            this.tabShares.Padding = new System.Windows.Forms.Padding(3);
            this.tabShares.Size = new System.Drawing.Size(517, 424);
            this.tabShares.TabIndex = 0;
            this.tabShares.Text = "Shares";
            this.tabShares.ToolTipText = "Browse configured media shares (file mode)";
            this.tabShares.UseVisualStyleBackColor = true;
            //
            // splitContainer1
            //
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 6);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.cbShareType);
            this.splitContainer1.Panel1.Controls.Add(this.tvMediaShares);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.lvDirectorySongs);
            this.splitContainer1.Size = new System.Drawing.Size(514, 418);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 6;
            //
            // cbShareType
            //
            this.cbShareType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShareType.FormattingEnabled = true;
            this.cbShareType.Items.AddRange(new object[] {
            "music",
            "video",
            "pictures",
            "files"});
            this.cbShareType.Location = new System.Drawing.Point(0, 3);
            this.cbShareType.Name = "cbShareType";
            this.cbShareType.Size = new System.Drawing.Size(162, 21);
            this.cbShareType.TabIndex = 6;
            this.cbShareType.MouseHover += new System.EventHandler(this.cbShareType_MouseHover);
            this.cbShareType.SelectedIndexChanged += new System.EventHandler(this.cbShareType_SelectedIndexChanged);
            //
            // tvMediaShares
            //
            this.tvMediaShares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMediaShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvMediaShares.ContextMenuStrip = this.cmsFolder;
            this.tvMediaShares.ImageIndex = 0;
            this.tvMediaShares.ImageList = this.ilFiletypes;
            this.tvMediaShares.ItemHeight = 16;
            this.tvMediaShares.Location = new System.Drawing.Point(0, 29);
            this.tvMediaShares.Name = "tvMediaShares";
            this.tvMediaShares.SelectedImageIndex = 0;
            this.tvMediaShares.Size = new System.Drawing.Size(162, 389);
            this.tvMediaShares.TabIndex = 1;
            this.tvMediaShares.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowSongs);
            this.tvMediaShares.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetTreeViewSelection);
            //
            // lvDirectorySongs
            //
            this.lvDirectorySongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDirectorySongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDirectorySongs.ContextMenuStrip = this.cmsSongs;
            this.lvDirectorySongs.Location = new System.Drawing.Point(0, 0);
            this.lvDirectorySongs.Name = "lvDirectorySongs";
            this.lvDirectorySongs.Size = new System.Drawing.Size(348, 418);
            this.lvDirectorySongs.SmallImageList = this.ilFiletypes;
            this.lvDirectorySongs.TabIndex = 0;
            this.lvDirectorySongs.UseCompatibleStateImageBehavior = false;
            this.lvDirectorySongs.View = System.Windows.Forms.View.List;
            this.lvDirectorySongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tabArtists
            //
            this.tabArtists.Controls.Add(this.splitContainer2);
            this.tabArtists.Location = new System.Drawing.Point(4, 22);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtists.Size = new System.Drawing.Size(517, 424);
            this.tabArtists.TabIndex = 1;
            this.tabArtists.Text = "Artists";
            this.tabArtists.UseVisualStyleBackColor = true;
            //
            // splitContainer2
            //
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(1, 3);
            this.splitContainer2.Name = "splitContainer2";
            //
            // splitContainer2.Panel1
            //
            this.splitContainer2.Panel1.Controls.Add(this.tbSearchArtist);
            this.splitContainer2.Panel1.Controls.Add(this.tvArtists);
            //
            // splitContainer2.Panel2
            //
            this.splitContainer2.Panel2.Controls.Add(this.lvArtistSongs);
            this.splitContainer2.Size = new System.Drawing.Size(514, 418);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 7;
            //
            // tbSearchArtist
            //
            this.tbSearchArtist.Location = new System.Drawing.Point(0, 0);
            this.tbSearchArtist.Name = "tbSearchArtist";
            this.tbSearchArtist.Size = new System.Drawing.Size(162, 20);
            this.tbSearchArtist.TabIndex = 13;
            this.tbSearchArtist.TextChanged += new System.EventHandler(this.tbSearchArtist_TextChanged);
            //
            // tvArtists
            //
            this.tvArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvArtists.ContextMenuStrip = this.cmsFolder;
            this.tvArtists.ImageIndex = 0;
            this.tvArtists.ImageList = this.ilFiletypes;
            this.tvArtists.ItemHeight = 16;
            this.tvArtists.Location = new System.Drawing.Point(0, 24);
            this.tvArtists.Name = "tvArtists";
            this.tvArtists.SelectedImageIndex = 0;
            this.tvArtists.Size = new System.Drawing.Size(162, 394);
            this.tvArtists.TabIndex = 1;
            this.tvArtists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowSongs);
            this.tvArtists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetTreeViewSelection);
            this.tvArtists.MouseHover += new System.EventHandler(this.SetFocus);
            //
            // lvArtistSongs
            //
            this.lvArtistSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvArtistSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvArtistSongs.ContextMenuStrip = this.cmsSongs;
            this.lvArtistSongs.Location = new System.Drawing.Point(0, 0);
            this.lvArtistSongs.Name = "lvArtistSongs";
            this.lvArtistSongs.Size = new System.Drawing.Size(347, 418);
            this.lvArtistSongs.SmallImageList = this.ilFiletypes;
            this.lvArtistSongs.TabIndex = 0;
            this.lvArtistSongs.UseCompatibleStateImageBehavior = false;
            this.lvArtistSongs.View = System.Windows.Forms.View.List;
            this.lvArtistSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tabAlbums
            //
            this.tabAlbums.Controls.Add(this.splitContainer3);
            this.tabAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Size = new System.Drawing.Size(517, 424);
            this.tabAlbums.TabIndex = 2;
            this.tabAlbums.Text = "Albums";
            this.tabAlbums.UseVisualStyleBackColor = true;
            //
            // splitContainer3
            //
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(1, 3);
            this.splitContainer3.Name = "splitContainer3";
            //
            // splitContainer3.Panel1
            //
            this.splitContainer3.Panel1.Controls.Add(this.tbSearchAlbum);
            this.splitContainer3.Panel1.Controls.Add(this.tvAlbums);
            //
            // splitContainer3.Panel2
            //
            this.splitContainer3.Panel2.Controls.Add(this.lvAlbumSongs);
            this.splitContainer3.Size = new System.Drawing.Size(514, 418);
            this.splitContainer3.SplitterDistance = 162;
            this.splitContainer3.TabIndex = 8;
            //
            // tbSearchAlbum
            //
            this.tbSearchAlbum.Location = new System.Drawing.Point(0, 0);
            this.tbSearchAlbum.Name = "tbSearchAlbum";
            this.tbSearchAlbum.Size = new System.Drawing.Size(162, 20);
            this.tbSearchAlbum.TabIndex = 14;
            this.tbSearchAlbum.TextChanged += new System.EventHandler(this.tbSearchAlbum_TextChanged);
            //
            // tvAlbums
            //
            this.tvAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvAlbums.ContextMenuStrip = this.cmsFolder;
            this.tvAlbums.ImageIndex = 0;
            this.tvAlbums.ImageList = this.ilFiletypes;
            this.tvAlbums.ItemHeight = 16;
            this.tvAlbums.Location = new System.Drawing.Point(0, 24);
            this.tvAlbums.Name = "tvAlbums";
            this.tvAlbums.SelectedImageIndex = 0;
            this.tvAlbums.Size = new System.Drawing.Size(162, 394);
            this.tvAlbums.TabIndex = 1;
            this.tvAlbums.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowSongs);
            this.tvAlbums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetTreeViewSelection);
            this.tvAlbums.MouseHover += new System.EventHandler(this.SetFocus);
            //
            // lvAlbumSongs
            //
            this.lvAlbumSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAlbumSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAlbumSongs.ContextMenuStrip = this.cmsSongs;
            this.lvAlbumSongs.Location = new System.Drawing.Point(0, 0);
            this.lvAlbumSongs.Name = "lvAlbumSongs";
            this.lvAlbumSongs.Size = new System.Drawing.Size(347, 418);
            this.lvAlbumSongs.SmallImageList = this.ilFiletypes;
            this.lvAlbumSongs.TabIndex = 0;
            this.lvAlbumSongs.UseCompatibleStateImageBehavior = false;
            this.lvAlbumSongs.View = System.Windows.Forms.View.List;
            this.lvAlbumSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tabSongs
            //
            this.tabSongs.Controls.Add(this.bSearchSong);
            this.tabSongs.Controls.Add(this.lvSongs);
            this.tabSongs.Controls.Add(this.tbSearchSong);
            this.tabSongs.Location = new System.Drawing.Point(4, 22);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Size = new System.Drawing.Size(517, 424);
            this.tabSongs.TabIndex = 3;
            this.tabSongs.Text = "Songs";
            this.tabSongs.UseVisualStyleBackColor = true;
            //
            // bSearchSong
            //
            this.bSearchSong.Location = new System.Drawing.Point(439, 3);
            this.bSearchSong.Name = "bSearchSong";
            this.bSearchSong.Size = new System.Drawing.Size(75, 23);
            this.bSearchSong.TabIndex = 11;
            this.bSearchSong.Text = "Search";
            this.bSearchSong.UseVisualStyleBackColor = true;
            this.bSearchSong.Click += new System.EventHandler(this.bSearchSong_Click);
            //
            // lvSongs
            //
            this.lvSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSongs.ContextMenuStrip = this.cmsSongs;
            this.lvSongs.Location = new System.Drawing.Point(3, 30);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(511, 391);
            this.lvSongs.SmallImageList = this.ilFiletypes;
            this.lvSongs.TabIndex = 10;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.List;
            this.lvSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tbSearchSong
            //
            this.tbSearchSong.Location = new System.Drawing.Point(3, 3);
            this.tbSearchSong.Name = "tbSearchSong";
            this.tbSearchSong.Size = new System.Drawing.Size(430, 20);
            this.tbSearchSong.TabIndex = 9;
            this.tbSearchSong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchSong_KeyUp);
            //
            // tabVideos
            //
            this.tabVideos.ContextMenuStrip = this.cmsVideo;
            this.tabVideos.Controls.Add(this.lvVideos);
            this.tabVideos.Controls.Add(this.tbSearchVideo);
            this.tabVideos.Location = new System.Drawing.Point(4, 22);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Size = new System.Drawing.Size(517, 424);
            this.tabVideos.TabIndex = 4;
            this.tabVideos.Text = "Video";
            this.tabVideos.UseVisualStyleBackColor = true;
            //
            // cmsVideo
            //
            this.cmsVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPlayVideo,
            this.tsiEnqueueVideo,
            this.tsiInfoVideo,
            this.toolStripSeparator4,
            this.tsiUpdateLibrary3});
            this.cmsVideo.Name = "cmsFiles";
            this.cmsVideo.Size = new System.Drawing.Size(154, 98);
            //
            // tsiPlayVideo
            //
            this.tsiPlayVideo.Name = "tsiPlayVideo";
            this.tsiPlayVideo.Size = new System.Drawing.Size(153, 22);
            this.tsiPlayVideo.Text = "Play";
            this.tsiPlayVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedFiles);
            //
            // tsiEnqueueVideo
            //
            this.tsiEnqueueVideo.Name = "tsiEnqueueVideo";
            this.tsiEnqueueVideo.Size = new System.Drawing.Size(153, 22);
            this.tsiEnqueueVideo.Text = "Enqueue";
            this.tsiEnqueueVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EnqueSelectedFiles);
            //
            // tsiInfoVideo
            //
            this.tsiInfoVideo.Name = "tsiInfoVideo";
            this.tsiInfoVideo.Size = new System.Drawing.Size(153, 22);
            this.tsiInfoVideo.Text = "Information";
            this.tsiInfoVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InfoSelectedFiles);
            //
            // toolStripSeparator4
            //
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            //
            // tsiUpdateLibrary3
            //
            this.tsiUpdateLibrary3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.tsiUpdateLibrary3.Name = "tsiUpdateLibrary3";
            this.tsiUpdateLibrary3.Size = new System.Drawing.Size(153, 22);
            this.tsiUpdateLibrary3.Text = "Update library";
            //
            // toolStripMenuItem4
            //
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem4.Text = "Music";
            //
            // toolStripMenuItem5
            //
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem5.Text = "Video";
            //
            // lvVideos
            //
            this.lvVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVideos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameVideo,
            this.yearVideo,
            this.IMDB_ID});
            this.lvVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVideos.FullRowSelect = true;
            this.lvVideos.GridLines = true;
            this.lvVideos.Location = new System.Drawing.Point(10, 29);
            this.lvVideos.MultiSelect = false;
            this.lvVideos.Name = "lvVideos";
            this.lvVideos.Size = new System.Drawing.Size(497, 376);
            this.lvVideos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvVideos.TabIndex = 12;
            this.lvVideos.UseCompatibleStateImageBehavior = false;
            this.lvVideos.View = System.Windows.Forms.View.Details;
            //
            // nameVideo
            //
            this.nameVideo.Text = "Video";
            this.nameVideo.Width = 418;
            //
            // yearVideo
            //
            this.yearVideo.Text = "Year";
            this.yearVideo.Width = 76;
            //
            // IMDB_ID
            //
            this.IMDB_ID.Text = "IMDB ID";
            this.IMDB_ID.Width = 70;
            //
            // tbSearchVideo
            //
            this.tbSearchVideo.Location = new System.Drawing.Point(10, 3);
            this.tbSearchVideo.Name = "tbSearchVideo";
            this.tbSearchVideo.Size = new System.Drawing.Size(405, 20);
            this.tbSearchVideo.TabIndex = 0;
            this.tbSearchVideo.TextChanged += new System.EventHandler(this.tbSearchVideo_TextChanged_1);
            //
            // MediaBrowserF1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.tcMediaBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaBrowserF1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaBrowserF1_FormClosing);
            this.cmsFolder.ResumeLayout(false);
            this.cmsSongs.ResumeLayout(false);
            this.tcMediaBrowser.ResumeLayout(false);
            this.tabShares.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabArtists.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabAlbums.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tabSongs.PerformLayout();
            this.tabVideos.ResumeLayout(false);
            this.tabVideos.PerformLayout();
            this.cmsVideo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageList ilFiletypes;
        private ContextMenuStrip cmsFolder;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsiCollapseAll;
        private ToolStripMenuItem tsiPlayRecursive;
        private ToolStripMenuItem tsiEnqueueRecursive;
        private ContextMenuStrip cmsSongs;
        private ToolStripMenuItem tsiEnqueueFiles;
        private ToolStripMenuItem tsiPlayFiles;
        private TabControl tcMediaBrowser;
        private TabPage tabShares;
        private SplitContainer splitContainer1;
        private TreeView tvMediaShares;
        private ListView lvDirectorySongs;
        private TabPage tabArtists;
        private TabPage tabAlbums;
        private TabPage tabSongs;
        private TextBox tbSearchSong;
        private ComboBox cbShareType;
        private SplitContainer splitContainer2;
        private TreeView tvArtists;
        private ListView lvArtistSongs;
        private SplitContainer splitContainer3;
        private TreeView tvAlbums;
        private ListView lvAlbumSongs;
        private TextBox tbSearchArtist;
        private TextBox tbSearchAlbum;
        private ToolStripMenuItem tsiRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsiUpdateLibrary;
        private ToolStripMenuItem tsiUpdateMusicLibrary1;
        private ToolStripMenuItem tsiUpdateVideoLibrary1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsiUpdateLibrary2;
        private ToolStripMenuItem tsiUpdateMusicLibrary2;
        private ToolStripMenuItem tsiUpdateVideoLibrary2;
        private ListView lvSongs;
        private Button bSearchSong;
        private TabPage tabVideos;
        private TextBox tbSearchVideo;
        private ListView lvVideos;
        private ColumnHeader nameVideo;
        private ColumnHeader yearVideo;
        private ColumnHeader IMDB_ID;
        private ContextMenuStrip cmsVideo;
        private ToolStripMenuItem tsiPlayVideo;
        private ToolStripMenuItem tsiEnqueueVideo;
        private ToolStripMenuItem tsiInfoVideo;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsiUpdateLibrary3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
    }
}