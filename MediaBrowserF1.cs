// Author: Hum, Adrian
// Project: XBMControl/XBMControl/MediaBrowserF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:19 AM

#region Using Directives

using System;
using System.ComponentModel;
using System.Windows.Forms;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class MediaBrowserF1 : Form {
        private readonly MainForm _parent;
        private bool _albumDirectorySelected;
        private bool _artistDirectorySelected;
        private bool _rightClick;
        private TreeNode _tNode;

        /// <exception cref="Exception">A top-level window cannot have an owner. </exception>
        public MediaBrowserF1(MainForm parentForm) {
            _parent = parentForm;
            InitializeComponent();
            PopulateDirectoryBrowser();
            Owner = _parent;

            try {
                cbShareType.SelectedIndex = 0;
            }
                // ReSharper disable once UnusedVariable
            catch (ArgumentOutOfRangeException argumentOutOfRangeException) {
                //
            }
        }

        private TreeView ActiveTreeView() {
            TreeView activeTreeView = null;
            var tabName = tcMediaBrowser.SelectedTab.Name;

            switch (tabName) {
                case "tabShares":
                    activeTreeView = tvMediaShares;
                    break;
                case "tabArtists":
                    activeTreeView = tvArtists;
                    break;
                case "tabAlbums":
                    activeTreeView = tvAlbums;
                    break;
                case "tabSongs":
                    // ReSharper disable once RedundantAssignment
                    activeTreeView = null;
                    break;
                case "tabVideos":
                    // ReSharper disable once RedundantAssignment
                    activeTreeView = null;
                    break;
            }

            return activeTreeView;
        }

        private ListView ActiveListView() {
            ListView activeListView = null;
            var tabName = tcMediaBrowser.SelectedTab.Name;

            switch (tabName) {
                case "tabShares":
                    activeListView = lvDirectorySongs;
                    break;
                case "tabArtists":
                    activeListView = lvArtistSongs;
                    break;
                case "tabAlbums":
                    activeListView = lvAlbumSongs;
                    break;
                case "tabSongs":
                    activeListView = lvSongs;
                    break;
                case "tabVideos":
                    activeListView = lvVideos;
                    break;
            }

            return activeListView;
        }

        private TabPage ActiveTab() {
            return tcMediaBrowser.SelectedTab;
        }

        private void PopulateDirectoryBrowser(string searchString = null) {
            ActiveTreeView().
                Nodes.Clear();
            ActiveListView().
                Items.Clear();

            string[] aDirectories = null;
            string[] aDirectoryIds = null;

            if (ActiveTab() == tabShares) {
                _parent.Xbmc.Playlist.SetType(cbShareType.Text);

                aDirectories = _parent.Xbmc.Media.GetShares(cbShareType.Text);
                aDirectoryIds = _parent.Xbmc.Media.GetShares(cbShareType.Text, true);
            }
            else if (ActiveTab() == tabArtists) {
                aDirectories = _parent.Xbmc.Database.GetArtists(searchString);
                aDirectoryIds = _parent.Xbmc.Database.GetArtistIds(searchString);
            }
            else if (ActiveTab() == tabAlbums ||
                     (ActiveTab() == tabArtists && _artistDirectorySelected)) {
                aDirectories = _parent.Xbmc.Database.GetAlbums(searchString);
                aDirectoryIds = _parent.Xbmc.Database.GetAlbumIds(searchString);
            }

            if (aDirectories != null)
                for (var x = 0; x < aDirectories.Length; x++) {
                    _tNode = new TreeNode {Name = aDirectories[x], Text = aDirectories[x]};
                    if (aDirectoryIds != null) _tNode.ToolTipText = aDirectoryIds[x];
                    ActiveTreeView().
                        Nodes.Add(_tNode);
                    ActiveTreeView().
                        Nodes[x].ImageIndex = 0;
                }
        }

        private void PopulateSongBrowser() {
            TestConnectivity();

            string[] aTitles;
            string[] aPaths = null;

            ActiveListView().
                Items.Clear();

            if (ActiveTab() == tabShares)
                if (cbShareType.Text == @"video") {
                    aTitles = _parent.Xbmc.Media.GetDirectoryContentNames(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        "[" + cbShareType.Text + "]");
                    aPaths = _parent.Xbmc.Media.GetDirectoryContentPaths(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        "[" + cbShareType.Text + "]");
                }
                else {
                    aTitles = _parent.Xbmc.Media.GetDirectoryContentNames(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        "[" + cbShareType.Text + "]");
                    aPaths = _parent.Xbmc.Media.GetDirectoryContentPaths(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        "[" + cbShareType.Text + "]");
                }
            else if (ActiveTab() == tabSongs) {
                aTitles = _parent.Xbmc.Database.GetSearchSongTitles(tbSearchSong.Text);
                aPaths = _parent.Xbmc.Database.GetSearchSongPaths(tbSearchSong.Text);
            }
            else if ((ActiveTab() == tabArtists && _albumDirectorySelected) ||
                     ActiveTab() == tabAlbums)
                aTitles = _parent.Xbmc.Database.GetTitlesByAlbumId(ActiveTreeView().
                    SelectedNode.ToolTipText);
            else
                aTitles = _parent.Xbmc.Database.GetTitlesByArtistId(ActiveTreeView().
                    SelectedNode.ToolTipText);

            if (aTitles != null)
                for (var x = 0; x < aTitles.Length; x++) {
                    ActiveListView().
                        Items.Add(aTitles[x]);

                    if (aTitles[x] != null) {
                        var tempName = aTitles[x].Split('.');
                        if (tempName[tempName.Length - 1] == "IFO" ||
                            tempName[tempName.Length - 1] == "VOB")
                            ActiveListView().
                                Items[x].ImageIndex = 3;
                        else
                            ActiveListView().
                                Items[x].ImageIndex = 1;
                    }
                    else
                        ActiveListView().
                            Items[x].ImageIndex = 1;
                    if (aPaths != null)
                        ActiveListView().
                            Items[x].ToolTipText = aPaths[x];
                }
        }

        private void PopulateVideoBrowser(string searchString = null) {
            TestConnectivity();

            ActiveListView().
                Items.Clear();

            var aTitles = _parent.Xbmc.Video.GetVideoNames(searchString);
            var aYears = _parent.Xbmc.Video.GetVideoYears(searchString);
            var aImdbId = _parent.Xbmc.Video.GetVideoIMDB(searchString);
            if (aTitles == null) return;
            for (var x = 0; x < aTitles.Length; x++) {
                var itemName = new ListViewItem(aTitles[x]);
                itemName.SubItems.Add(aYears[x]);
                itemName.SubItems.Add(aImdbId[x]);
                lvVideos.Items.Add(itemName);
            }
        }

        private void ExpandSharedDirectory() {
            TestConnectivity();
            ActiveListView().
                Items.Clear();

            if (ActiveTreeView().
                SelectedNode.GetNodeCount(false) != 0) return;
            var aDirectoryContentPaths = _parent.Xbmc.Media.GetDirectoryContentPaths(ActiveTreeView().
                SelectedNode.ToolTipText,
                "/");
            var aDirectoryContentNames = _parent.Xbmc.Media.GetDirectoryContentNames(ActiveTreeView().
                SelectedNode.ToolTipText,
                "/");

            if (aDirectoryContentPaths == null) return;
            for (var x = 0; x < aDirectoryContentPaths.Length; x++) {
                if (aDirectoryContentPaths[x] == null ||
                    aDirectoryContentPaths[x] == "") continue;
                _tNode = new TreeNode {Name = aDirectoryContentNames[x], Text = aDirectoryContentNames[x], ToolTipText = aDirectoryContentPaths[x]};
                ActiveTreeView().
                    SelectedNode.Nodes.Add(_tNode);
                ActiveTreeView().
                    SelectedNode.Nodes[x].ImageIndex = 0;
            }

            ActiveTreeView().
                SelectedNode.Expand();
        }

        private void ExpandArtistDirectory() {
            TestConnectivity();
            ActiveListView().
                Items.Clear();

            if (ActiveTreeView().
                SelectedNode.GetNodeCount(false) != 0) return;
            var aAlbums = _parent.Xbmc.Database.GetAlbumsByArtistId(ActiveTreeView().
                SelectedNode.ToolTipText);
            var albumIds = _parent.Xbmc.Database.GetAlbumIdsByArtistId(ActiveTreeView().
                SelectedNode.ToolTipText);

            if (aAlbums == null) return;
            for (var x = 0; x < aAlbums.Length; x++) {
                _tNode = new TreeNode {Name = aAlbums[x], Text = aAlbums[x], ToolTipText = albumIds[x]};
                ActiveTreeView().
                    SelectedNode.Nodes.Add(_tNode);
                ActiveTreeView().
                    SelectedNode.Nodes[x].ImageIndex = 0;
                ActiveTreeView().
                    SelectedNode.Expand();
            }
        }

        private void TestConnectivity() {
            if (!_parent.Xbmc.Status.IsConnected())
                Dispose();
        }

        // ReSharper disable once UnusedParameter.Local
        private void AddDirectoryContentToPlaylist(bool play, bool enqueue, bool recursive) {
            TestConnectivity();
            if (play) _parent.Xbmc.Playlist.Clear();
            _parent.Xbmc.Playlist.AddDirectoryContent(tvMediaShares.SelectedNode.ToolTipText, cbShareType.Text, recursive);
            if (play) _parent.Xbmc.Playlist.PlaySong(0);
            if (Settings.Default.playlistOpened) _parent.Playlist.RefreshPlaylist();
        }

        private void AddArtistSongsToPlaylist(string artistId, bool play) {
            TestConnectivity();
            if (play) _parent.Xbmc.Playlist.Clear();

            var songPaths = _parent.Xbmc.Database.GetPathsByArtistId(artistId);

            if (songPaths != null)
            {
                foreach (var t in songPaths)
                    _parent.Xbmc.Playlist.AddFilesToPlaylist(t);

                if (play) _parent.Xbmc.Playlist.PlaySong(0);
            }

            if (Settings.Default.playlistOpened) _parent.Playlist.RefreshPlaylist();
        }

        private void AddAlbumSongsToPlaylist(string albumId, bool play) {
            TestConnectivity();
            if (play) _parent.Xbmc.Playlist.Clear();

            var songPaths = _parent.Xbmc.Database.GetPathsByAlbumId(albumId);

            if (songPaths != null)
            {
                foreach (var t in songPaths)
                    _parent.Xbmc.Playlist.AddFilesToPlaylist(t);

                if (play) _parent.Xbmc.Playlist.PlaySong(0);
            }

            if (Settings.Default.playlistOpened) _parent.Playlist.RefreshPlaylist();
        }

        private void AddFilesToPlaylist(bool play = false) {
            TestConnectivity();

            if (ActiveListView().
                SelectedItems.Count <= 0) return;
            if (play) _parent.Xbmc.Playlist.Clear();

            foreach (ListViewItem item in ActiveListView().
                SelectedItems) {
                string songPath;
                if (_albumDirectorySelected || ActiveTab() == tabAlbums)
                    songPath = _parent.Xbmc.Database.GetPathBySongTitle(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        item.Text,
                        false);
                else if (_artistDirectorySelected)
                    songPath = _parent.Xbmc.Database.GetPathBySongTitle(ActiveTreeView().
                        SelectedNode.ToolTipText,
                        item.Text,
                        true);
                else if (ActiveTab() == tabVideos)
                    songPath = _parent.Xbmc.Video.GetVideoPath(item.Text);
                else
                    songPath = item.ToolTipText;

                _parent.Xbmc.Playlist.AddFilesToPlaylist(songPath);
            }

            if (play) _parent.Xbmc.Playlist.PlaySong(0);
            if (Settings.Default.playlistOpened) _parent.Playlist.RefreshPlaylist();
        }

        private void cbShareType_SelectedIndexChanged(object sender, EventArgs e) {
            PopulateDirectoryBrowser();
        }

        private void PlaySelectedFiles(object sender, MouseEventArgs e) {
            AddFilesToPlaylist(true);
            _parent.Playlist.RefreshPlaylist();
        }

        private void EnqueSelectedFiles(object sender, MouseEventArgs e) {
            AddFilesToPlaylist();
            _parent.Playlist.RefreshPlaylist();
        }

        private void InfoSelectedFiles(object sender, MouseEventArgs e) {
            if (_parent.VideoInfoOpened) return;
            var videoId = lvVideos.Items[lvVideos.FocusedItem.Index].SubItems[2].Text;
            _parent.VideoInfoForm = new VideoInfoF1(_parent, videoId);
            _parent.VideoInfoForm.Show();
        }

        private void MediaBrowserF1_FormClosing(object sender, FormClosingEventArgs e) {
            _parent.ShareBrowserOpened = false;
            Dispose();
        }

        private void tsiCollapseAll_Click(object sender, EventArgs e) {
            ActiveTreeView().
                CollapseAll();
        }

        //START Playlist controls
        private void tsiPlayRecursive_Click(object sender, EventArgs e) {
            if (ActiveTab() == tabShares)
                AddDirectoryContentToPlaylist(true, false, true);
            else if (ActiveTab() == tabArtists && _artistDirectorySelected)
                AddArtistSongsToPlaylist(ActiveTreeView().
                    SelectedNode.ToolTipText,
                    true);
            else if ((ActiveTab() == tabArtists && _albumDirectorySelected) ||
                     ActiveTab() == tabAlbums)
                AddAlbumSongsToPlaylist(ActiveTreeView().
                    SelectedNode.ToolTipText,
                    true);
        }

        private void tsiEnqueueRecursive_Click(object sender, EventArgs e) {
            if (ActiveTab() == tabShares)
                AddDirectoryContentToPlaylist(false, true, true);
            else if (ActiveTab() == tabArtists && _artistDirectorySelected)
                AddArtistSongsToPlaylist(ActiveTreeView().
                    SelectedNode.ToolTipText,
                    false);
            else if ((ActiveTab() == tabArtists && _albumDirectorySelected) ||
                     ActiveTab() == tabAlbums)
                AddAlbumSongsToPlaylist(ActiveTreeView().
                    SelectedNode.ToolTipText,
                    false);
        }

        private void tcMediaBrowser_SelectedIndexChanged(object sender, EventArgs e) {
            _albumDirectorySelected = false;
            _artistDirectorySelected = false;

            if (ActiveTab() != tabSongs &&
                ActiveTab() != tabVideos)
                if (ActiveTreeView().
                    Nodes.Count == 0)
                    PopulateDirectoryBrowser();

            if (ActiveTab() == tabVideos)
                PopulateVideoBrowser();

            if (ActiveTab() == tabArtists)
                tbSearchArtist.Focus();
            else if (ActiveTab() == tabAlbums)
                tbSearchAlbum.Focus();
            else if (ActiveTab() == tabSongs)
                tbSearchSong.Focus();
            else if (ActiveTab() == tabVideos)
                tbSearchVideo.Focus();
        }

        //END Playlist controls

        //START HOVER FOCUS

        private void SetFocus(object sender, EventArgs e) {
            if (ActiveTreeView() != null)
                ActiveTreeView().
                    Focus();
        }

        private void cbShareType_MouseHover(object sender, EventArgs e) {
            cbShareType.Focus();
        }

        private void tbSearchArtist_TextChanged(object sender, EventArgs e) {
            var searchString = (tbSearchArtist.Text == "") ? null : tbSearchArtist.Text;
            PopulateDirectoryBrowser(searchString);
        }

        private void tbSearchAlbum_TextChanged(object sender, EventArgs e) {
            var searchString = (tbSearchAlbum.Text == "") ? null : tbSearchAlbum.Text;
            PopulateDirectoryBrowser(searchString);
        }

        //private void tbSearchVideo_TextChanged(object sender, EventArgs e) {
        //    var searchString = (tbSearchVideo.Text == "") ? null : tbSearchVideo.Text;
        //    PopulateVideoBrowser(searchString);
        //}

        private void tsiRefresh_Click(object sender, EventArgs e) {
            PopulateDirectoryBrowser();
        }

        private void SetTreeViewSelection(object sender, MouseEventArgs e) {
            ActiveTreeView().
                SelectedNode = ActiveTreeView().
                    GetNodeAt(e.X, e.Y);
            _rightClick = (e.Button == MouseButtons.Right);

            if (ActiveTreeView().
                SelectedNode == null) {
                _albumDirectorySelected = false;
                _artistDirectorySelected = false;
            }
            else if (ActiveTreeView().
                SelectedNode.Parent != null &&
                     ActiveTab() == tabArtists) {
                _albumDirectorySelected = true;
                _artistDirectorySelected = false;
            }
            else if (ActiveTab() == tabArtists ||
                     ActiveTab() == tabAlbums) {
                _albumDirectorySelected = false;
                _artistDirectorySelected = true;
            }
        }

        private void ShowSongs(object sender, MouseEventArgs e) {
            if (!_rightClick &&
                ActiveTreeView().
                    SelectedNode != null) {
                if (!ActiveTreeView().
                    SelectedNode.IsExpanded &&
                    ActiveTab() != tabAlbums)
                    if (ActiveTab() == tabShares)
                        ExpandSharedDirectory();
                    else if (ActiveTab() == tabArtists && _artistDirectorySelected)
                        ExpandArtistDirectory();

                if (ActiveTreeView().
                    SelectedNode.Nodes.Count == 0 ||
                    ActiveTab() == tabShares)
                    PopulateSongBrowser();
            }
        }

        private void UpdateMusicLibrary(object sender, EventArgs e) {
            MessageBox.Show(Resources.MediaBrowserF1_UpdateMusicLibrary_);
            _parent.Xbmc.Controls.UpdateLibrary("music");
        }

        private void UpdateVideoLibrary(object sender, EventArgs e) {
            MessageBox.Show(Resources.MediaBrowserF1_UpdateMusicLibrary_);
            _parent.Xbmc.Controls.UpdateLibrary("video");
        }

        private void cmsFolder_Opening(object sender, CancelEventArgs e) {
            if (ActiveTreeView().
                SelectedNode == null)
                e.Cancel = true;
        }

        private void cmsSongs_Opening(object sender, CancelEventArgs e) {
            if (ActiveListView().
                SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void bSearchSong_Click(object sender, EventArgs e) {
            if (tbSearchSong.Text.Length < 3)
                MessageBox.Show(Resources.MediaBrowserF1_bSearchSong_Click_);
            else if (tbSearchSong.Text == "")
                lvSongs.Items.Clear();
            else
                PopulateSongBrowser();
        }

        private void tbSearchSong_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter)
                bSearchSong_Click(null, null);
        }

        private void tbSearchVideo_TextChanged_1(object sender, EventArgs e) {
            var searchString = (tbSearchVideo.Text == "") ? null : tbSearchVideo.Text;
            PopulateVideoBrowser(searchString);
        }
    }
}