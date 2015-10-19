// ------------------------------------------------------------------------
//    XBMControl - A compact remote controller for XBMC (.NET 3.5)
//    Copyright (C) 2008  Bram van Oploo (bramvano@gmail.com)
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBMControl.Language;
using XBMControl.Properties;

namespace XBMControl
{
    public partial class MediaBrowserF1 : Form
    {
        MainForm parent;
        TreeNode tNode;
        bool artistDirectorySelected = false;
        bool albumDirectorySelected = false;
        bool rightClick = false;

        public MediaBrowserF1(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            this.PopulateDirectoryBrowser();
            this.Owner = parent;

            cbShareType.SelectedIndex = 0;
        }

        private TreeView ActiveTreeView()
        {
            TreeView activeTreeView = null;
            string tabName = tcMediaBrowser.SelectedTab.Name.ToString();

            if (tabName == "tabShares")
                activeTreeView = tvMediaShares;
            else if (tabName == "tabArtists")
                activeTreeView = tvArtists;
            else if (tabName == "tabAlbums")
                activeTreeView = tvAlbums;
            else if (tabName == "tabSongs")
                activeTreeView = null;
            else if (tabName == "tabVideos")
                activeTreeView = null;

            return activeTreeView;
        }

        private ListView ActiveListView()
        {
            ListView activeListView = null;
            string tabName = tcMediaBrowser.SelectedTab.Name.ToString();

            if (tabName == "tabShares")
                activeListView = lvDirectorySongs;
            else if (tabName == "tabArtists")
                activeListView = lvArtistSongs;
            else if (tabName == "tabAlbums")
                activeListView = lvAlbumSongs;
            else if (tabName == "tabSongs")
                activeListView = lvSongs;
            else if (tabName == "tabVideos")
                activeListView = lvVideos;

            return activeListView;
        }

        private TabPage ActiveTab()
        {
            return tcMediaBrowser.SelectedTab;
        }

        private void PopulateDirectoryBrowser(string searchString)
        {
            ActiveTreeView().Nodes.Clear();
            ActiveListView().Items.Clear();

            string[] aDirectories = null;
            string[] aDirectoryIds = null;

            if (this.ActiveTab() == tabShares)
            {
                parent.XBMC.Playlist.SetType(cbShareType.Text);

                aDirectories = parent.XBMC.Media.GetShares(cbShareType.Text);
                aDirectoryIds = parent.XBMC.Media.GetShares(cbShareType.Text, true);
            }
            else if (this.ActiveTab() == tabArtists)
            {
                aDirectories = parent.XBMC.Database.GetArtists(searchString);
                aDirectoryIds = parent.XBMC.Database.GetArtistIds(searchString);
            }
            else if (this.ActiveTab() == tabAlbums || (this.ActiveTab() == tabArtists && artistDirectorySelected))
            {
                aDirectories = parent.XBMC.Database.GetAlbums(searchString);
                aDirectoryIds = parent.XBMC.Database.GetAlbumIds(searchString);
            }

            if (aDirectories != null)
            {
                for (int x = 0; x < aDirectories.Length; x++)
                {
                    tNode = new TreeNode();
                    tNode.Name = aDirectories[x];
                    tNode.Text = aDirectories[x];
                    if (aDirectoryIds != null) tNode.ToolTipText = aDirectoryIds[x];
                    ActiveTreeView().Nodes.Add(tNode);
                    ActiveTreeView().Nodes[x].ImageIndex = 0;         
                }
            }
        }

        private void PopulateDirectoryBrowser()
        { 
            this.PopulateDirectoryBrowser(null);
        }

        private void PopulateSongBrowser()
        {
            this.TestConnectivity();

            string[] aTitles = null;
            string[] aPaths = null;

            ActiveListView().Items.Clear();

            if (ActiveTab() == tabShares)
            {
                if (cbShareType.Text == "video")
                {
                    aTitles = parent.XBMC.Media.GetDirectoryContentNames(ActiveTreeView().SelectedNode.ToolTipText, "[" + cbShareType.Text + "]");
                    aPaths = parent.XBMC.Media.GetDirectoryContentPaths(ActiveTreeView().SelectedNode.ToolTipText, "[" + cbShareType.Text + "]");
                }
                else
                {
                    aTitles = parent.XBMC.Media.GetDirectoryContentNames(ActiveTreeView().SelectedNode.ToolTipText, "[" + cbShareType.Text + "]");
                    aPaths = parent.XBMC.Media.GetDirectoryContentPaths(ActiveTreeView().SelectedNode.ToolTipText, "[" + cbShareType.Text + "]");
                }
            }
            else if (ActiveTab() == tabSongs)
            {
                aTitles = parent.XBMC.Database.GetSearchSongTitles(tbSearchSong.Text);
                aPaths = parent.XBMC.Database.GetSearchSongPaths(tbSearchSong.Text);
            }
            else if ((ActiveTab() == tabArtists && albumDirectorySelected) || ActiveTab() == tabAlbums)
                aTitles = parent.XBMC.Database.GetTitlesByAlbumId(ActiveTreeView().SelectedNode.ToolTipText);
            else
                aTitles = parent.XBMC.Database.GetTitlesByArtistId(ActiveTreeView().SelectedNode.ToolTipText);

            if (aTitles != null)
            {
                for (int x = 0; x < aTitles.Length; x++)
                {
                    ActiveListView().Items.Add(aTitles[x]);

                    if (aTitles[x] != null)
                    {
                        string[] tempName = aTitles[x].Split('.');
                        if (tempName[tempName.Length - 1] == "IFO" || tempName[tempName.Length - 1] == "VOB")
                            ActiveListView().Items[x].ImageIndex = 3;
                        else
                            ActiveListView().Items[x].ImageIndex = 1;
                    }
                    else
                    {
                        ActiveListView().Items[x].ImageIndex = 1;
                    }
                    if (aPaths != null) ActiveListView().Items[x].ToolTipText = aPaths[x];
                }
            }
        }

        private void PopulateVideoBrowser()
        {
            PopulateVideoBrowser(null);
        }

        private void PopulateVideoBrowser(string searchString)
        {
            this.TestConnectivity();

            string[] aTitles = null;
            string[] aYears = null;
            string[] aIMDB_ID = null;
            ListViewItem itemName;

            ActiveListView().Items.Clear();

            aTitles = parent.XBMC.Video.GetVideoNames(searchString);
            aYears = parent.XBMC.Video.GetVideoYears(searchString);
            aIMDB_ID = parent.XBMC.Video.GetVideoIMDB(searchString);
            if (aTitles != null)
            {
                for (int x = 0; x < aTitles.Length; x++)
                {
                    itemName = new ListViewItem(aTitles[x]);
                    itemName.SubItems.Add(aYears[x]);
                    itemName.SubItems.Add(aIMDB_ID[x]);
                    this.lvVideos.Items.Add(itemName);

                }
            }
        }

        private void ExpandSharedDirectory()
        {
            this.TestConnectivity();
            ActiveListView().Items.Clear();

            if (ActiveTreeView().SelectedNode.GetNodeCount(false) == 0)
            {
                string[] aDirectoryContentPaths = parent.XBMC.Media.GetDirectoryContentPaths(ActiveTreeView().SelectedNode.ToolTipText, "/");
                string[] aDirectoryContentNames = parent.XBMC.Media.GetDirectoryContentNames(ActiveTreeView().SelectedNode.ToolTipText, "/");

                if (aDirectoryContentPaths != null)
                {
                    for (int x = 0; x < aDirectoryContentPaths.Length; x++)
                    {
                        if (aDirectoryContentPaths[x] != null && aDirectoryContentPaths[x] != "")
                        {
                            tNode = new TreeNode();
                            tNode.Name = aDirectoryContentNames[x];
                            tNode.Text = aDirectoryContentNames[x];
                            tNode.ToolTipText = aDirectoryContentPaths[x];
                            ActiveTreeView().SelectedNode.Nodes.Add(tNode);
                            ActiveTreeView().SelectedNode.Nodes[x].ImageIndex = 0;
                        }
                    }

                    ActiveTreeView().SelectedNode.Expand();
                }
            }
        }

        private void ExpandArtistDirectory()
        {
            this.TestConnectivity();
            ActiveListView().Items.Clear();

            if (ActiveTreeView().SelectedNode.GetNodeCount(false) == 0)
            {
                string[] aAlbums = parent.XBMC.Database.GetAlbumsByArtistId(ActiveTreeView().SelectedNode.ToolTipText);
                string[] albumIds = parent.XBMC.Database.GetAlbumIdsByArtistId(ActiveTreeView().SelectedNode.ToolTipText);

                if (aAlbums != null)
                {
                    for (int x = 0; x < aAlbums.Length; x++)
                    {
                        tNode = new TreeNode();
                        tNode.Name = aAlbums[x];
                        tNode.Text = aAlbums[x];
                        tNode.ToolTipText = albumIds[x];
                        ActiveTreeView().SelectedNode.Nodes.Add(tNode);
                        ActiveTreeView().SelectedNode.Nodes[x].ImageIndex = 0;
                        ActiveTreeView().SelectedNode.Expand();
                    }
                }
            }
        }

        private void TestConnectivity()
        {
            if (!parent.XBMC.Status.IsConnected())
                this.Dispose();
        }

        private void AddDirectoryContentToPlaylist(bool play, bool enqueue, bool recursive)
        {
            this.TestConnectivity();
            if (play) parent.XBMC.Playlist.Clear();
            parent.XBMC.Playlist.AddDirectoryContent(tvMediaShares.SelectedNode.ToolTipText, cbShareType.Text, recursive);
            if (play) parent.XBMC.Playlist.PlaySong(0);
            if (Settings.Default.playlistOpened) parent.Playlist.RefreshPlaylist();
        }

        private void AddArtistSongsToPlaylist(string artistId, bool play)
        {
            this.TestConnectivity();
            if (play) parent.XBMC.Playlist.Clear();

            string[] songPaths = parent.XBMC.Database.GetPathsByArtistId(artistId);

            if (songPaths != null)
            {
                for (int x = 0; x < songPaths.Length; x++)
                    parent.XBMC.Playlist.AddFilesToPlaylist(songPaths[x]);

                if (play) parent.XBMC.Playlist.PlaySong(0);
            }

            if (Settings.Default.playlistOpened) parent.Playlist.RefreshPlaylist();
        }

        private void AddAlbumSongsToPlaylist(string albumId, bool play)
        {
            this.TestConnectivity();
            if (play) parent.XBMC.Playlist.Clear();

            string[] songPaths = parent.XBMC.Database.GetPathsByAlbumId(albumId);

            if (songPaths != null)
            {
                for (int x = 0; x < songPaths.Length; x++)
                    parent.XBMC.Playlist.AddFilesToPlaylist(songPaths[x]);

                if (play) parent.XBMC.Playlist.PlaySong(0);
            }

            if (Settings.Default.playlistOpened) parent.Playlist.RefreshPlaylist();
        }

        private void AddFilesToPlaylist(bool play)
        {
            this.TestConnectivity();
            string songPath = null;

            if (ActiveListView().SelectedItems.Count > 0)
            {
                if (play) parent.XBMC.Playlist.Clear();

                foreach (ListViewItem item in ActiveListView().SelectedItems)
                {
                    if (albumDirectorySelected || ActiveTab() == tabAlbums)
                        songPath = parent.XBMC.Database.GetPathBySongTitle(ActiveTreeView().SelectedNode.ToolTipText, item.Text, false);
                    else if (artistDirectorySelected)
                        songPath = parent.XBMC.Database.GetPathBySongTitle(ActiveTreeView().SelectedNode.ToolTipText, item.Text, true);
                    else if (ActiveTab() == tabVideos)
                        songPath = parent.XBMC.Video.GetVideoPath(item.Text);
                    else
                        songPath = item.ToolTipText;

                    parent.XBMC.Playlist.AddFilesToPlaylist(songPath);
                }

                if (play) parent.XBMC.Playlist.PlaySong(0);
                if (Settings.Default.playlistOpened) parent.Playlist.RefreshPlaylist();
            }
        }

        private void AddFilesToPlaylist()
        {
            this.AddFilesToPlaylist(false);
        }

        private void cbShareType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateDirectoryBrowser();
        }

        private void PlaySelectedFiles(object sender, MouseEventArgs e)
        { 
            AddFilesToPlaylist(true);
            parent.Playlist.RefreshPlaylist();
        }

        private void EnqueSelectedFiles(object sender, MouseEventArgs e)
        {
            AddFilesToPlaylist();
            parent.Playlist.RefreshPlaylist();
        }

        private void InfoSelectedFiles(object sender, MouseEventArgs e)
        {
            string videoID;

            if (!parent.videoInfoOpened)
            {
                videoID = lvVideos.Items[lvVideos.FocusedItem.Index].SubItems[2].Text;
                parent.videoInfoForm = new videoInfoF1(parent, videoID);
                parent.videoInfoForm.Show();
            }
        }

        private void MediaBrowserF1_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.shareBrowserOpened = false;
            this.Dispose();
        }

        private void tsiCollapseAll_Click(object sender, EventArgs e)
        {
            ActiveTreeView().CollapseAll();
        }

        //START Playlis controls
        private void tsiPlayRecursive_Click(object sender, EventArgs e)
        {
            if (ActiveTab() == tabShares)
                AddDirectoryContentToPlaylist(true, false, true);
            else if (ActiveTab() == tabArtists && artistDirectorySelected)
                AddArtistSongsToPlaylist(ActiveTreeView().SelectedNode.ToolTipText, true);
            else if ((ActiveTab() == tabArtists && albumDirectorySelected) || ActiveTab() == tabAlbums)
                AddAlbumSongsToPlaylist(ActiveTreeView().SelectedNode.ToolTipText, true);
        }

        private void tsiEnqueueRecursive_Click(object sender, EventArgs e)
        {
            if (ActiveTab() == tabShares)
                AddDirectoryContentToPlaylist(false, true, true);
            else if (ActiveTab() == tabArtists && artistDirectorySelected)
                AddArtistSongsToPlaylist(ActiveTreeView().SelectedNode.ToolTipText, false);
            else if ((ActiveTab() == tabArtists && albumDirectorySelected) || ActiveTab() == tabAlbums)
                AddAlbumSongsToPlaylist(ActiveTreeView().SelectedNode.ToolTipText, false);
        }

        private void tcMediaBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumDirectorySelected = false;
            artistDirectorySelected = false;

            if (ActiveTab() != tabSongs && ActiveTab() != tabVideos)
            {
                if (ActiveTreeView().Nodes.Count == 0)
                    PopulateDirectoryBrowser();
            }

            if (ActiveTab() == tabVideos)
            {
                PopulateVideoBrowser();
            }

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

        private void SetFocus(object sender, EventArgs e)
        {
            if (ActiveTreeView() != null)
                ActiveTreeView().Focus();
        }

        private void cbShareType_MouseHover(object sender, EventArgs e)
        {
            cbShareType.Focus();
        }

        private void tbSearchArtist_TextChanged(object sender, EventArgs e)
        {
            string searchString = (tbSearchArtist.Text == "") ? null : tbSearchArtist.Text;
            this.PopulateDirectoryBrowser(searchString);
        }

        private void tbSearchAlbum_TextChanged(object sender, EventArgs e)
        {
            string searchString = (tbSearchAlbum.Text == "") ? null : tbSearchAlbum.Text;
            this.PopulateDirectoryBrowser(searchString);
        }

        private void tbSearchVideo_TextChanged(object sender, EventArgs e)
        {
            string searchString = (tbSearchVideo.Text == "") ? null : tbSearchVideo.Text;
            this.PopulateVideoBrowser(searchString);
        }

        private void tsiRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateDirectoryBrowser();
        }

        private void SetTreeViewSelection(object sender, MouseEventArgs e)
        {
            ActiveTreeView().SelectedNode = ActiveTreeView().GetNodeAt(e.X, e.Y);
            rightClick = (e.Button == MouseButtons.Right) ? true : false;

            if (ActiveTreeView().SelectedNode == null)
            {
                albumDirectorySelected = false;
                artistDirectorySelected = false;
            }
            else if (ActiveTreeView().SelectedNode.Parent != null && ActiveTab() == tabArtists)
            {
                albumDirectorySelected = true;
                artistDirectorySelected = false;
            }
            else if (ActiveTab() == tabArtists || ActiveTab() == tabAlbums)
            {
                albumDirectorySelected = false;
                artistDirectorySelected = true;
            }
        }

        private void ShowSongs(object sender, MouseEventArgs e)
        {
            if (!rightClick && ActiveTreeView().SelectedNode != null)
            {
                if (!ActiveTreeView().SelectedNode.IsExpanded && ActiveTab() != tabAlbums)
                {
                    if (ActiveTab() == tabShares)
                        ExpandSharedDirectory();
                    else if (ActiveTab() == tabArtists && artistDirectorySelected)
                        ExpandArtistDirectory();
                }

                if (ActiveTreeView().SelectedNode.Nodes.Count == 0 || ActiveTab() == tabShares)
                    PopulateSongBrowser();
            }
        }

        private void UpdateMusicLibrary(object sender, EventArgs e)
        {
            MessageBox.Show("XBMC will now start updating your music library.\nThis will take a while, depending on the amount of files to be indexed!");
            parent.XBMC.Controls.UpdateLibrary("music");
        }

        private void UpdateVideoLibrary(object sender, EventArgs e)
        {
            MessageBox.Show("XBMC will now start updating your music library.\nThis will take a while, depending on the amount of files to be indexed!");
            parent.XBMC.Controls.UpdateLibrary("video");
        }

        private void cmsFolder_Opening(object sender, CancelEventArgs e)
        {
            if (ActiveTreeView().SelectedNode == null)
                e.Cancel = true;
        }

        private void cmsSongs_Opening(object sender, CancelEventArgs e)
        {
            if (ActiveListView().SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void bSearchSong_Click(object sender, EventArgs e)
        {
            if (tbSearchSong.Text.Length < 3)
                MessageBox.Show("At least 3 characters have to be entered. Otherwise you'll have to wait ages before you'll see any results.\nIt might still take a while though before you see the requested result, depending on the size of your music database.");
            else
            {
                if (tbSearchSong.Text == "")
                    lvSongs.Items.Clear();
                else
                    PopulateSongBrowser();
            }
        }

        private void tbSearchSong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bSearchSong_Click(null, null);
        }

        private void tbSearchVideo_TextChanged_1(object sender, EventArgs e)
        {
            string searchString = (tbSearchVideo.Text == "") ? null : tbSearchVideo.Text;
            this.PopulateVideoBrowser(searchString);
        }
        //END HOVER FOCUS
    }
}
