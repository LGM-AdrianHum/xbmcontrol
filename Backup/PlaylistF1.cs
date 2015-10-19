using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBMControl.Properties;
using System.IO;

namespace XBMControl
{
    public partial class PlaylistF1 : Form
    {
        private MainForm parent;
        private bool isDragging = false;
        private int clickOffsetX, clickOffsetY;
        private int previouslySelectedItem = -1;

        public PlaylistF1(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();

            if (parent.XBMC.Status.IsConnected())
            {
                parent.XBMC.Status.Refresh();
                this.PopulatePlaylist();
                this.UpdatePlaylistSelection();
                this.timerUpdateSelection.Enabled = true;
            }

            Settings.Default.playlistOpened = true;
            Settings.Default.Save();

            this.Owner = parent;
        }

        internal void PopulatePlaylist()
        {
            lbPlaylist.Items.Clear();

            if (parent.XBMC.Status.IsConnected())
            {
                string currentPlaylistType = (parent.XBMC.NowPlaying.GetMediaType() == "Video") ? "video" : "";
                parent.XBMC.Playlist.SetType(currentPlaylistType);

                string[] aPlaylistEntries = parent.XBMC.Playlist.Get(true, true);

                if (aPlaylistEntries != null)
                {
                    for (int x = 0; x < aPlaylistEntries.Length; x++)
                    {
                        if (aPlaylistEntries[x] != "")
                        {
                            lbPlaylist.Items.Add(x + ". " + aPlaylistEntries[x]);
                        }
                    }
                }
            }
        }

        private void RemoveSelected(object sender, EventArgs e)
        {
            if (parent.XBMC.Status.IsConnected())
            {
                string selectedEntry = GetSelectedPlaylistEntry();
                if (selectedEntry != null)
                {
                    parent.XBMC.Playlist.Remove(lbPlaylist.SelectedIndex);
                    PopulatePlaylist();
                }
            }
            else
                lbPlaylist.Items.Clear();
        }

        private void RemoveSelected()
        {
            RemoveSelected(null, null);
        }

        private string GetSelectedPlaylistEntry()
        {
            if (parent.XBMC.Status.IsConnected())
            {
                string[] aPlaylistEntry = parent.XBMC.Request("GetPlaylistSong(" + lbPlaylist.SelectedIndex + ")");
                return (aPlaylistEntry != null) ? aPlaylistEntry[0] : null;
            }
            else
            {
                lbPlaylist.Items.Clear();
                return null;
            }
        }

        internal void UpdatePlaylistSelection()
        {
            if (parent.XBMC.Status.IsConnected())
            {
                int currentSongNo = Convert.ToInt32(parent.XBMC.NowPlaying.Get("songno"));

                if (lbPlaylist.Items.Count > 0 && currentSongNo < lbPlaylist.Items.Count)
                    lbPlaylist.SelectedIndex = currentSongNo;
            }
            else
                lbPlaylist.Items.Clear();
        }

        internal void RefreshPlaylist(object sender, EventArgs e)
        {
            this.PopulatePlaylist();
            this.UpdatePlaylistSelection();
        }

        internal void RefreshPlaylist()
        {
            this.RefreshPlaylist(null, null);
        }

        internal void ClearPlaylist(object sender, EventArgs e)
        {
            if (parent.XBMC.Status.IsConnected())
            {
                parent.XBMC.Playlist.Clear();
                PopulatePlaylist();
            }
            else
                lbPlaylist.Items.Clear();
        }

        internal void ClearPlaylist()
        {
            this.ClearPlaylist(null, null);
        }

        internal void PlaySelectedEntry()
        {
            if (parent.XBMC.Status.IsConnected() && lbPlaylist.SelectedIndex != -1)
            {
                parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
                this.RefreshPlaylist();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Settings.Default.playlistOpened = false;
            Settings.Default.Save();
            this.Dispose();
        }

        private void PlaylistF1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void timerUpdateSelection_Tick(object sender, EventArgs e)
        {
            if (parent.XBMC.Status.IsConnected())
            {
                if (!lbPlaylist.Focused)
                {
                    PopulatePlaylist();
                    if (!parent.XBMC.Status.IsNotPlaying()) UpdatePlaylistSelection();
                }
            }
            else
                lbPlaylist.Items.Clear();
        }

        private void lbPlaylist_KeyUp(object sender, KeyEventArgs e)
        {
            if (parent.XBMC.Status.IsConnected())
            {
                if (e.KeyData.ToString() == "Delete")
                {
                    this.RemoveSelected();
                    this.PopulatePlaylist();

                    if (previouslySelectedItem < lbPlaylist.Items.Count)
                        lbPlaylist.SelectedIndex = previouslySelectedItem;
                    else
                        this.UpdatePlaylistSelection();
                }
                else if (e.KeyData.ToString() == "Return")
                    parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
            }
            else
                lbPlaylist.Items.Clear();
        }

        private void cmsPlayFromSelection_Click(object sender, EventArgs e)
        {
            this.PlaySelectedEntry();   
        }

        private void lbPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            lbPlaylist.SelectedIndex = lbPlaylist.IndexFromPoint(e.X, e.Y);
            previouslySelectedItem = lbPlaylist.SelectedIndex;
            //cmsPlaylist.Enabled = (e.Button == MouseButtons.Right && lbPlaylist.SelectedIndex == -1) ? false : true;
        }

        private void lbPlaylist_MouseUp(object sender, MouseEventArgs e)
        {
            int tempIndex = 0;
            string tempString;
            string[] aPlaylistEntries = null;

            tempIndex = lbPlaylist.IndexFromPoint(e.X, e.Y);
            
            if (previouslySelectedItem != -1 && 
                (previouslySelectedItem != tempIndex) &&
                e.Button == MouseButtons.Left)
            {
                aPlaylistEntries = parent.XBMC.Playlist.Get(false, true);
                tempString = aPlaylistEntries[previouslySelectedItem];
                List<string> myList = new List<string>(aPlaylistEntries);
                myList.RemoveAt(previouslySelectedItem);
                if (tempIndex != -1)
                    myList.Insert(tempIndex, tempString);
                else
                    myList.Add(tempString);

                parent.XBMC.Playlist.Clear();

                foreach (string entry in myList)
                {
                    tempString = entry.Replace("/", "\\");

                    parent.XBMC.Playlist.AddFilesToPlaylist(tempString);
                }
                previouslySelectedItem = -1;
                parent.Playlist.RefreshPlaylist();
            }

        }

        private void lbPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (parent.XBMC.Status.IsConnected())
                parent.XBMC.Playlist.PlaySong(lbPlaylist.SelectedIndex);
        }

        //START FAKE DRAG DROP
        private void pToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            parent.Focus();
            this.Focus();
            isDragging = true;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
        }

        private void pToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                this.Left = e.X + this.Left - clickOffsetX;
                this.Top = e.Y + this.Top - clickOffsetY;
            }
        }

        private void cmsPlaylist_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cmsSavePlayLit_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            int count;
            string tempString;
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
            saveFileDialog1.FilterIndex = 2 ;
            saveFileDialog1.RestoreDirectory = true ;

             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 if((myStream = saveFileDialog1.OpenFile()) != null)
                 {
                     string[] aPlaylistEntries = parent.XBMC.Playlist.Get(false, true);

                     for (count = 0; count < aPlaylistEntries.Length; count++)
                     {
                         tempString = (string)aPlaylistEntries[count];
                         tempString += "\r\n";
                         Byte[] tempBytes = encoding.GetBytes(tempString);
                         myStream.Write(tempBytes, 0, tempString.Length);
                     }
                     myStream.Close();
                 }
             }
        }

        private void cmsLoadPlayList_Click(object sender, EventArgs e)
        {
            StreamReader myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string line;

            
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!parent.XBMC.Status.IsConnected())
                    this.Dispose();

                myStream = new System.IO.StreamReader(openFileDialog1.FileName);
                while((line = myStream.ReadLine()) != null)
                {
                    parent.XBMC.Playlist.AddFilesToPlaylist(line);
                }
                myStream.Close();
                parent.Playlist.RefreshPlaylist();
            }
        }
        //END FAKE DRAG DROP

        //START CLOSE BUTTON
        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Resources.close1_hover;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Resources.close1;
        }

        private void pbClose_MouseUp(object sender, MouseEventArgs e)
        {
            //this.Dispose();
        }
        //END CLOSE BUTTON
    }
}
