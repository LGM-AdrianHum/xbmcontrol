// Author: Hum, Adrian
// Project: XBMControl/XBMControl/PlaylistF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:29 AM

#region Using Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class PlaylistF1 : Form {
        private readonly MainForm _parent;

        private int _clickOffsetX,
            _clickOffsetY;

        private bool _isDragging;
        private int _previouslySelectedItem = -1;

        /// <exception cref="Exception">A top-level window cannot have an owner. </exception>
        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        public PlaylistF1(MainForm parentForm) {
            _parent = parentForm;
            InitializeComponent();

            if (_parent.XBMC.Status.IsConnected()) {
                _parent.XBMC.Status.Refresh();
                PopulatePlaylist();
                UpdatePlaylistSelection();
                timerUpdateSelection.Enabled = true;
            }

            Settings.Default.playlistOpened = true;
            Settings.Default.Save();

            Owner = _parent;
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void ClearPlaylist(object sender, EventArgs e) {
            if (_parent.XBMC.Status.IsConnected()) {
                _parent.XBMC.Playlist.Clear();
                PopulatePlaylist();
            }
            else
                lbPlaylist.Items.Clear();
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void ClearPlaylist() {
            ClearPlaylist(null, null);
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void PlaySelectedEntry() {
            if (_parent.XBMC.Status.IsConnected() &&
                lbPlaylist.SelectedIndex != -1) {
                _parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
                RefreshPlaylist();
            }
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void PopulatePlaylist() {
            lbPlaylist.Items.Clear();

            if (!_parent.XBMC.Status.IsConnected()) return;
            var currentPlaylistType = (_parent.XBMC.NowPlaying.GetMediaType() == "Video") ? "video" : "";
            _parent.XBMC.Playlist.SetType(currentPlaylistType);

            var aPlaylistEntries = _parent.XBMC.Playlist.Get(true, true);

            if (aPlaylistEntries == null) return;
            for (var x = 0; x < aPlaylistEntries.Length; x++) {
                if (aPlaylistEntries[x] == "") continue;
                try { lbPlaylist.Items.Add(x + ". " + aPlaylistEntries[x]); }
                catch (ArgumentNullException) {}
            }
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void RefreshPlaylist(object sender, EventArgs e) {
            PopulatePlaylist();
            UpdatePlaylistSelection();
        }

        /// <exception cref="SystemException">There is insufficient space available to add the new item to the list. </exception>
        internal void RefreshPlaylist() {
            RefreshPlaylist(null, null);
        }

        /// <exception cref="FormatException">
#pragma warning disable 1584,1711,1572,1581,1580
        ///     <paramref name="SelectedIndex" /> does not consist of an optional sign followed by a sequence
#pragma warning restore 1584,1711,1572,1581,1580
        ///     of digits (0 through 9).
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">The assigned value is less than -1 or greater than or equal to the item count.</exception>
        internal void UpdatePlaylistSelection() {
            if (_parent.XBMC.Status.IsConnected())
                try {
                    var currentSongNo = Convert.ToInt32(_parent.XBMC.NowPlaying.Get("songno"));
                    if (lbPlaylist.Items.Count > 0 &&
                        currentSongNo < lbPlaylist.Items.Count)
                        lbPlaylist.SelectedIndex = currentSongNo;
                }
                catch (OverflowException) {}
            else
                lbPlaylist.Items.Clear();
        }

        private void cmsLoadPlayList_Click(object sender, EventArgs e) {
            var openFileDialog1 = new OpenFileDialog {Filter = Resources.PlaylistF1_cmsLoadPlayListFilter, FilterIndex = 2, RestoreDirectory = true};

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (!_parent.XBMC.Status.IsConnected())
                Dispose();

            var myStream = new StreamReader(openFileDialog1.FileName);
            string line;
            while ((line = myStream.ReadLine()) != null)
                _parent.XBMC.Playlist.AddFilesToPlaylist(line);
            myStream.Close();
            _parent.Playlist.RefreshPlaylist();
        }

        private void cmsPlayFromSelection_Click(object sender, EventArgs e) {
            PlaySelectedEntry();
        }

        private void cmsPlaylist_Opening(object sender, CancelEventArgs e) {}

        private void cmsSavePlayLit_Click(object sender, EventArgs e) {
            var saveFileDialog1 = new SaveFileDialog();
            var encoding = new UTF8Encoding();

            saveFileDialog1.Filter = Resources.PlaylistF1_cmsLoadPlayListFilter;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var myStream = saveFileDialog1.OpenFile();
            {
                var aPlaylistEntries = _parent.XBMC.Playlist.Get(false, true);

                int count;
                for (count = 0; count < aPlaylistEntries.Length; count++) {
                    var tempString = aPlaylistEntries[count];
                    tempString += "\r\n";
                    var tempBytes = encoding.GetBytes(tempString);
                    myStream.Write(tempBytes, 0, tempString.Length);
                }
                myStream.Close();
            }
        }

        private string GetSelectedPlaylistEntry() {
            if (_parent.XBMC.Status.IsConnected()) {
                var aPlaylistEntry = _parent.XBMC.Request("GetPlaylistSong(" + lbPlaylist.SelectedIndex + ")");
                return (aPlaylistEntry != null) ? aPlaylistEntry[0] : null;
            }
            lbPlaylist.Items.Clear();
            return null;
        }

        private void lbPlaylist_KeyUp(object sender, KeyEventArgs e) {
            if (_parent.XBMC.Status.IsConnected()) {
                if (e.KeyData.ToString() == "Delete") {
                    RemoveSelected();
                    PopulatePlaylist();

                    if (_previouslySelectedItem < lbPlaylist.Items.Count)
                        lbPlaylist.SelectedIndex = _previouslySelectedItem;
                    else
                        UpdatePlaylistSelection();
                }
                else if (e.KeyData.ToString() == "Return")
                    _parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
            }
            else
                lbPlaylist.Items.Clear();
        }

        private void lbPlaylist_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (_parent.XBMC.Status.IsConnected())
                _parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
        }

        private void lbPlaylist_MouseDown(object sender, MouseEventArgs e) {
            lbPlaylist.SelectedIndex = lbPlaylist.IndexFromPoint(e.X, e.Y);
            _previouslySelectedItem = lbPlaylist.SelectedIndex;
            //cmsPlaylist.Enabled = (e.Button == MouseButtons.Right && lbPlaylist.SelectedIndex == -1) ? false : true;
        }

        private void lbPlaylist_MouseUp(object sender, MouseEventArgs e) {
            var tempIndex = lbPlaylist.IndexFromPoint(e.X, e.Y);

            if (_previouslySelectedItem == -1 ||
                (_previouslySelectedItem == tempIndex) ||
                e.Button != MouseButtons.Left) return;
            var aPlaylistEntries = _parent.XBMC.Playlist.Get(false, true);
            var tempString = aPlaylistEntries[_previouslySelectedItem];
            var myList = new List<string>(aPlaylistEntries);
            myList.RemoveAt(_previouslySelectedItem);
            if (tempIndex != -1)
                myList.Insert(tempIndex, tempString);
            else
                myList.Add(tempString);

            _parent.XBMC.Playlist.Clear();

            foreach (var entry in myList) {
                tempString = entry.Replace("/", "\\");

                _parent.XBMC.Playlist.AddFilesToPlaylist(tempString);
            }
            _previouslySelectedItem = -1;
            _parent.Playlist.RefreshPlaylist();
        }

        private void pbClose_Click(object sender, EventArgs e) {
            Settings.Default.playlistOpened = false;
            Settings.Default.Save();
            Dispose();
        }

        //START CLOSE BUTTON
        private void pbClose_MouseEnter(object sender, EventArgs e) {
            pbClose.BackgroundImage = Resources.close1_hover;
        }

        //END FAKE DRAG DROP
        private void pbClose_MouseLeave(object sender, EventArgs e) {
            pbClose.BackgroundImage = Resources.close1;
        }

        private void pbClose_MouseUp(object sender, MouseEventArgs e) {
            //this.Dispose();
        }

        private void PlaylistF1_FormClosed(object sender, FormClosedEventArgs e) {
            Dispose();
        }

        //START FAKE DRAG DROP
        private void pToolbar_MouseDown(object sender, MouseEventArgs e) {
            _parent.Focus();
            Focus();
            _isDragging = true;
            _clickOffsetX = e.X;
            _clickOffsetY = e.Y;
        }

        private void pToolbar_MouseMove(object sender, MouseEventArgs e) {
            if (_isDragging) {
                Left = e.X + Left - _clickOffsetX;
                Top = e.Y + Top - _clickOffsetY;
            }
        }

        private void pToolbar_MouseUp(object sender, MouseEventArgs e) {
            _isDragging = false;
        }

        private void RemoveSelected(object sender = null, EventArgs e = null) {
            if (_parent.XBMC.Status.IsConnected()) {
                var selectedEntry = GetSelectedPlaylistEntry();
                if (selectedEntry == null) return;
                _parent.XBMC.Playlist.Remove(lbPlaylist.SelectedIndex);
                PopulatePlaylist();
            }
            else
                lbPlaylist.Items.Clear();
        }

        private void timerUpdateSelection_Tick(object sender, EventArgs e) {
            if (_parent.XBMC.Status.IsConnected()) {
                if (!lbPlaylist.Focused) {
                    PopulatePlaylist();
                    if (!_parent.XBMC.Status.IsNotPlaying()) UpdatePlaylistSelection();
                }
            }
            else
                lbPlaylist.Items.Clear();
        }
    }
}