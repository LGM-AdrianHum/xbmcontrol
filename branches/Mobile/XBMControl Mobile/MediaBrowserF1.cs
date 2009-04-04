﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        }

        private void cbShareType_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbShareType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowSongs()
        {
            if (ActiveTreeView().SelectedNode.Nodes.Count == 0)
                PopulateSongBrowser();
        }

        private void SetTreeViewSelection(object sender, KeyEventArgs e)
        {
            //rightClick = (e.Button == MouseButtons.Right) ? true : false;
            albumDirectorySelected = false;
            artistDirectorySelected = false;
        }

        private void PlaySelectedFiles(object sender, MouseEventArgs e)
        {

        }

        private TreeView ActiveTreeView()
        {
            TreeView activeTreeView = null;
            activeTreeView = tvMediaShares;

            return activeTreeView;
        }

        private void PopulateDirectoryBrowser(string searchString)
        {
            ActiveTreeView().Nodes.Clear();
            //ActiveListView().Items.Clear();

            string[] aDirectories = null;
            string[] aDirectoryIds = null;

            if (parent.XBMC.Status.IsConnected() == false)
                return;
            aDirectories = parent.XBMC.Media.GetShares("music");
            aDirectoryIds = parent.XBMC.Media.GetShares("music", true);

            if (aDirectories != null)
            {
                for (int x = 0; x < aDirectories.Length; x++)
                {
                    tNode = new TreeNode();
                   // tNode.Name = aDirectories[x];
                    tNode.Text = aDirectories[x];
                    if (aDirectoryIds != null) tNode.Tag = (object)aDirectoryIds[x];
                    ActiveTreeView().Nodes.Add(tNode);
                    ActiveTreeView().Nodes[x].ImageIndex = 0;
                }
            }
        }

        private void PopulateDirectoryBrowser()
        {
            this.PopulateDirectoryBrowser(null);
        }

        private void ExpandSharedDirectory()
        {
            this.TestConnectivity();
            //ActiveListView().Items.Clear();

            if (ActiveTreeView().SelectedNode.GetNodeCount(false) == 0)
            {
                string[] aDirectoryContentPaths = parent.XBMC.Media.GetDirectoryContentPaths((string)ActiveTreeView().SelectedNode.Tag, "/");
                string[] aDirectoryContentNames = parent.XBMC.Media.GetDirectoryContentNames((string)ActiveTreeView().SelectedNode.Tag, "/");

                if (aDirectoryContentPaths != null)
                {
                    for (int x = 0; x < aDirectoryContentPaths.Length; x++)
                    {
                        if (aDirectoryContentPaths[x] != null && aDirectoryContentPaths[x] != "")
                        {
                            tNode = new TreeNode();
                            //tNode.Name = aDirectoryContentNames[x];
                            tNode.Text = aDirectoryContentNames[x];
                            tNode.Tag = (object)aDirectoryContentPaths[x];
                            ActiveTreeView().SelectedNode.Nodes.Add(tNode);
                            ActiveTreeView().SelectedNode.Nodes[x].ImageIndex = 0;
                        }
                    }

                    ActiveTreeView().SelectedNode.Expand();
                }
            }
        }

        private void PopulateSongBrowser()
        {
            this.TestConnectivity();

            string[] aTitles = null;
            string[] aPaths = null;
            ListViewItem tempItem = null;

            aTitles = parent.XBMC.Media.GetDirectoryContentNames((string)ActiveTreeView().SelectedNode.Tag, "[music]");
            aPaths = parent.XBMC.Media.GetDirectoryContentPaths((string)ActiveTreeView().SelectedNode.Tag, "[music]");
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
            parent.XBMC.Playlist.AddDirectoryContent((string)tvMediaShares.SelectedNode.Tag, "music", recursive);
            if (play) parent.XBMC.Playlist.PlaySong(0);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            AddDirectoryContentToPlaylist(false, true, true);
            MessageBox.Show("Added to Playlist");
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MediaBrowserF1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                ExpandSharedDirectory();
                //ShowSongs();
            }
        }

        private void tvMediaShares_AfterSelect(object sender, TreeViewEventArgs e)
        {
           // ExpandSharedDirectory();
        }

    }
}