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
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;
using XBMC;
using XBMControl.Language;
using XBMControl.Properties;

namespace XBMControl
{
    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    public partial class MainForm : Form
    {
        private MediaBrowserF1 _shareBrowser;
        internal XbmcCommunicator Xbmc;
        internal XbmcLanguage Language;
        private ConfigurationF1 _configForm;
        private FullSizeImageF1 _fullSizeImage;
        private VolumeControlF1 _sysTrayVolumeControl;
        public VideoInfoF1 VideoInfoForm;
        internal PlaylistF1 Playlist;
        internal NavigatorF1 Navigator;

        internal bool ConfigFormOpened = false;
        internal bool ShareBrowserOpened;
        internal bool VolumeControlOpened;
        internal bool VideoInfoOpened = false;

        private int _updateTimerConnected = 1000;
        private int _updateTimerDisconnected = 10000;

        private string[,] _maNowPlayingInfo      = new string[50, 2];

        private bool _playStatusMessageShowed;
        private bool _showedConnectionStatus;
        private bool _showConfigurationAtStart;
        private bool _resetToDefault;
        private bool _isDragging;
        private int _clickOffsetX, _clickOffsetY;
        private int _originalWindowHeight;

        private bool _repeatEnabled;
        private bool _partyModeEnabled;

        public MainForm()
        {
            Language = new XbmcLanguage();
            Xbmc = new XbmcCommunicator();
            Xbmc.SetIp(Settings.Default.Ip);
            Xbmc.SetConnectionTimeout(Settings.Default.ConnectionTimeout);
            Xbmc.SetCredentials(Settings.Default.Username, Settings.Default.Password);
            InitializeComponent();
            ApplySettings();
            SetLanguageStrings();
            Initialize();
        }

        private void Initialize()
        {
            _originalWindowHeight = Height;
            ToggleShowDetails();

            if (Xbmc.Status.IsConnected())
            {
                if (!Xbmc.Status.WebServerEnabled())
                {
                    // Webserver inactive: Ask for continue (default is no)
                    var dlgRet = MessageBox.Show(Language.GetString("mainform/dialog/webserverDisabled"),
                        Language.GetString("mainform/dialog/webserverDisabledTitle"),
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button2);
                    if (dlgRet == DialogResult.No)
                    {
                        Dispose();
                        return;
                    }
                }

                updateTimer.Enabled = true;
            }
            else
            {
                if (Settings.Default.ShowConfigurationAtStart == true)
                {
                    if (Settings.Default.Ip == "")
                        MessageBox.Show(Language.GetString("mainform/dialog/ipNotConfigured"), Language.GetString("mainform/dialog/ipNotConfiguredTitle"));
                    else
                        MessageBox.Show(Language.GetString("mainform/dialog/unableToConnect"), Language.GetString("mainform/dialog/unableToConnectTitle"));

                    ShowConfigurationForm();
                }
                updateTimer.Enabled = true;
            }
        }

//START Helper functions
        private void SetControlsEnabled(bool enabled)
        {
            bPrevious.Enabled = enabled;
            bPlay.Enabled = enabled;
            bPause.Enabled = enabled;
            bStop.Enabled = enabled;
            bNext.Enabled = enabled;
            bOpen.Enabled = enabled;
            bMute.Enabled = enabled;
            bRepeat.Enabled = enabled;
            bShuffle.Enabled = enabled;
            bPartymode.Enabled = enabled;
            tbProgress.Enabled = enabled;
            tbVolume.Enabled = enabled;
            cmsXBMC.Visible = enabled;
            cmsControls.Visible = enabled;
            cmsSeperatorFolders.Visible = enabled;
        }

        internal void ApplySettings()
        {
            Xbmc.SetConnectionTimeout(Settings.Default.ConnectionTimeout);
            Xbmc.SetCredentials(Settings.Default.Username, Settings.Default.Password);
            Xbmc.SetIp(Settings.Default.Ip);

            Language.SetLanguage(Settings.Default.Language);
            notifyIcon1.Visible = Settings.Default.ShowInSystemTray;

            Visible = Settings.Default.ShowInTaskbar;
            WindowState = (Settings.Default.StartMinimized) ? FormWindowState.Minimized : FormWindowState.Normal;
            SetLanguageStrings();
        }

        private void SetLanguageStrings()
        {
            //MainForm
            Text = Language.GetString("global/appName") + " v" + Settings.Default.Version;
            lMainTitle.Text = Language.GetString("global/appName") + " v" + Settings.Default.Version;
            lArtistTitle.Text = Language.GetString("mainform/label/artist");
            lTitleTitle.Text = Language.GetString("mainform/label/title");
            lAlbumTitle.Text = Language.GetString("mainform/label/album");

            //Context Menu
            cmsControls.Text = Language.GetString("contextMenu/controls/title");
            cmsPrevious.Text = Language.GetString("contextMenu/controls/previous");
            cmsPlay.Text = Language.GetString("contextMenu/controls/play");
            cmsPause.Text = Language.GetString("contextMenu/controls/pause");
            cmsStop.Text = Language.GetString("contextMenu/controls/stop");
            cmsNext.Text = Language.GetString("contextMenu/controls/next");
            cmsMute.Text = Language.GetString("contextMenu/controls/mute");
            cmsXBMC.Text = Language.GetString("contextMenu/xbmc/title");
            cmsSendMediaUrl.Text = Language.GetString("contextMenu/xbmc/sendMediaUrl");
            cmsShowScreenshot.Text = Language.GetString("contextMenu/xbmc/showScreenshot");
            cmsXBMCreboot.Text = Language.GetString("contextMenu/xbmc/reboot");
            cmsXBMCrestart.Text = Language.GetString("contextMenu/xbmc/restart");
            cmsXBMCshutdown.Text = Language.GetString("contextMenu/xbmc/shutdown");
            cmsView.Text = Language.GetString("contextMenu/view/title");
            cmsViewPlaylist.Text = Language.GetString("contextMenu/view/playlist");
            cmsViewMediaBrowser.Text = Language.GetString("contextMenu/view/mediabrowser");
            cmsSaveMedia.Text = Language.GetString("contextMenu/saveMedia");
            cmsShow.Text = Language.GetString("contextMenu/show");
            cmsHide.Text = Language.GetString("contextMenu/hide");
            cmsConfigure.Text = Language.GetString("contextMenu/configure");
            cmsExit.Text = Language.GetString("contextMenu/exit");
        }
        //END Helper functions

//START Timer events
        internal void UpdateData()
        {
            _resetToDefault = (!Xbmc.Status.IsConnected() || Xbmc.Status.IsNotPlaying()) ? true : false;

            if (Xbmc.Status.IsConnected())
            {
                updateTimer.Interval = _updateTimerConnected;
                updateTimer.Enabled = true;

                Xbmc.Status.Refresh();
                SetControlsEnabled(true);
                tbProgress.Value = Xbmc.Status.GetProgress();
                tbVolume.Value = Xbmc.Status.GetVolume();
                SetNowPlayingTimePlayed(_resetToDefault);
                GetNowPlayingSongInfo(_resetToDefault);
                ShowNowPlayingInfo(_resetToDefault);
                ShowPlayStatusInfo();
                SetMediaTypeImage();

                //Set control button states
                bOpen.BackgroundImage   = (ShareBrowserOpened) ? Resources.button_open_click : Resources.button_open;
                bPause.BackgroundImage = (Xbmc.Status.IsPaused()) ? Resources.button_pause_click : Resources.button_pause;
                bPlay.BackgroundImage = (Xbmc.Status.IsPlaying()) ? Resources.button_play_click : Resources.button_play;
                bStop.BackgroundImage = (Xbmc.Status.IsNotPlaying()) ? Resources.button_stop_click : Resources.button_stop;
                bMute.BackgroundImage = (Xbmc.Status.IsMuted()) ? Resources.button_mute_click : Resources.button_mute;
                bLastFmHate.Visible = (Xbmc.Status.IsPlaying("lastfm")) ? true : false;
                bLastFmLove.Visible = (Xbmc.NowPlaying.GetMediaType() == "Audio") ? true : false;
                bPlaylist.BackgroundImage = (Settings.Default.playlistOpened && Playlist != null) ? Resources.button_playlist_click : Resources.button_playlist ;
                bNavigator.BackgroundImage = (Settings.Default.NavigatorOpened && Navigator != null) ? Resources.button_remote_click : Resources.button_remote;

                if (Settings.Default.playlistOpened && Playlist == null)
                    cmsViewPlaylist_Click(null, null);
            }
            else
            {
                updateTimer.Interval = _updateTimerDisconnected;
                updateTimer.Enabled = true;

                SetControlsEnabled(false);
                ShowConnectionInfo();
                ShowNowPlayingInfo(_resetToDefault);
                SetNowPlayingTimePlayed(_resetToDefault);
                SetMediaTypeImage();
                bPause.BackgroundImage = Resources.button_pause;
                bPlay.BackgroundImage = Resources.button_play;
                bMute.BackgroundImage = Resources.button_mute;

                if (Playlist != null)
                    Playlist.Hide();
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
//END Timer events

//START Main window events
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Visible = Settings.Default.ShowInTaskbar;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Visible = Settings.Default.ShowInTaskbar;
            if (Settings.Default.playlistOpened && Playlist != null && !Settings.Default.StartMinimized)
            {
                Playlist.Show();
                Playlist.Focus();
                Focus();
            }
        }

        private void ToggleShowDetails()
        {
            if (Height == _originalWindowHeight)
            {
                Height = (Height - pDetails.Height);
                pDetails.Height = 0;
            }
            else
            {
                pDetails.Height = (_originalWindowHeight - Height);
                Height = _originalWindowHeight;
            }
        }

        private void GetNowPlayingSongInfo(bool resetToDefault)
        {
            if (!Xbmc.Status.IsPlaying() && !Xbmc.Status.IsPaused())
            {
                lArtistSong.Text    = Language.GetString("mainform/playing/nothing");
                pbThumbnail.Image   = Resources.XBMClogo;
                lBitrate.Text       = "";
                lSamplerate.Text    = "";
                lArtist.Text        = "";
                lTitle.Text         = "";
                lAlbum.Text         = "";
            }
            else if (Xbmc.Status.IsNewMediaPlaying())
            {
                if(Settings.Default.playlistOpened && Playlist != null) Playlist.RefreshPlaylist();
                var coverArt = Xbmc.NowPlaying.GetCoverArt();
                pbThumbnail.Image       = (coverArt == null) ? Resources.XBMClogo : coverArt;
                var year = (Xbmc.NowPlaying.Get("year") == null) ? "" : " [" + Xbmc.NowPlaying.Get("year") + "]";
                lBitrate.Text = Xbmc.NowPlaying.Get("bitrate");
                lSamplerate.Text = Xbmc.NowPlaying.Get("samplerate");
                var genre = (Xbmc.NowPlaying.Get("genre") == null) ? "" : " [" + Xbmc.NowPlaying.Get("genre") + "]";
                var artistLable = (Xbmc.NowPlaying.Get("artist") == "" || Xbmc.NowPlaying.Get("artist") == null) ? "" : Xbmc.NowPlaying.Get("artist") + " - ";
                lArtistSong.Text = artistLable + Xbmc.NowPlaying.Get("title");
                lArtist.Text = Xbmc.NowPlaying.Get("artist") + genre;
                lTitle.Text = Xbmc.NowPlaying.Get("title") + " [" + Xbmc.NowPlaying.Get("duration") + "]";
                lAlbum.Text = Xbmc.NowPlaying.Get("album") + year;
                pLastFmButtons.Visible  = (Xbmc.Status.LastFmEnabled()) ? true : false;
            }
        }

        public void SetMediaTypeImage()
        {
            if (!Xbmc.Status.IsPlaying() && !Xbmc.Status.IsPaused())
                pbMediaType.Visible = false;
            else
            {
                if (Xbmc.NowPlaying.GetMediaType() == "Audio" || Xbmc.Status.IsPlaying("lastfm"))
                {
                    pbMediaType.Cursor  = Cursors.Hand;
                    pbMediaType.Image   = (Xbmc.Status.IsPlaying("lastfm")) ? Resources.lastfm_32x32 : Resources.audio_cd_32x32;
                }
                else if (Xbmc.NowPlaying.GetMediaType() == "Video")
                {
                    pbMediaType.Cursor  = Cursors.Default;
                    pbMediaType.Image   = Resources.video_32x32;
                }
                else if (Xbmc.NowPlaying.GetMediaType() == "Picture")
                {
                    pbMediaType.Cursor  = Cursors.Default;
                    pbMediaType.Image   = Resources.pictures_32x32;
                }
                pbMediaType.Visible = true;
            }
        }

        private void SetNowPlayingTimePlayed(bool resetToDefault)
        {
            lTimePlayed.Text = (resetToDefault) ? "00:00" : Xbmc.NowPlaying.Get("time");
        }

        private void pbThumbnail_Click(object sender, EventArgs e)
        {
            var coverArt = Xbmc.NowPlaying.GetCoverArt();
            if (coverArt != null)
            {
                _fullSizeImage = new FullSizeImageF1(coverArt);
                _fullSizeImage.Show();
            }
        }

        private void pbThumbnail_MouseHover(object sender, EventArgs e)
        {
            if (Xbmc.NowPlaying.Get("thumb") != "defaultAlbumCover.png")
                pbThumbnail.Cursor = Cursors.Hand;
        }

        private void pbThumbnail_MouseLeave(object sender, EventArgs e)
        {
            if (Xbmc.NowPlaying.Get("thumb") != "defaultAlbumCover.png")
                pbThumbnail.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainContextMenu.Show(pictureBox1, new Point(0, pictureBox1.Height));
        }

        private void pbMediaType_Click(object sender, EventArgs e)
        {
            if (Xbmc.NowPlaying.GetMediaType() == "Audio" || Xbmc.Status.IsPlaying("lastfm")) pbLastFM_Click();
        }

        private void pbLastFM_Click()
        {
            var artist = Xbmc.NowPlaying.Get("artist");
            artist = (artist == null) ? "" : artist.Replace(" ", "+");

            var lastFmUrl = "http://www.last.fm/music/" + artist;
            Help.ShowHelp(this, lastFmUrl);
        }

        private void lArtistSong_Click(object sender, EventArgs e)
        {
            if (Xbmc.Status.IsPlaying() || Xbmc.Status.IsPaused()) ToggleShowDetails();
        }
 //END Main window events

//START Notification events
        private void ShowNowPlayingInfo(bool resetToDefault)
        {
            string tempString;

            if (Settings.Default.ShowNowPlayingBalloonTips)
            {
                if (!Xbmc.Status.IsNotPlaying() && Xbmc.Status.IsNewMediaPlaying())
                {
                    var currentFilename = Xbmc.NowPlaying.Get("filename");
                    var genre = (Xbmc.NowPlaying.Get("genre") == "" || Xbmc.NowPlaying.Get("genre") == null) ? "" : " [" + Xbmc.NowPlaying.Get("genre") + "]";
                    var artist = Xbmc.NowPlaying.Get("artist");
                    var duration = Xbmc.NowPlaying.Get("duration");
                    var time = (duration == "" || duration == null) ? "" : " [" + duration + "]";
                    var title = Xbmc.NowPlaying.Get("title");
                    var year = Xbmc.NowPlaying.Get("year");
                    year = (year == "" || year == null) ? "" : " [" + year + "]";
                    var album = Xbmc.NowPlaying.Get("album") + year;
                    var lastFm = (currentFilename.Substring(0, 6) == "lastfm") ? "(Last.FM)" : "";

                    if (Xbmc.Status.IsConnected() && Settings.Default.ShowPlayStatusBalloonTips)
                    {
                        notifyIcon1.ShowBalloonTip(2000, "XBMControl : " + Language.GetString("mainform/playing/now") + lastFm, artist + genre + "\n" + title + time + "\n" + album, ToolTipIcon.Info);
                        tempString = artist + "\n" + title;
                        // System tray tooltip text for "hover" can only be 64 characters long maximum.
                        if (tempString.Length > 64)
                            tempString = tempString.Substring(0, 63);
                        notifyIcon1.Text = tempString;
                    }
                }
            }
        }

        private void ShowPlayStatusInfo()
        {
            if (!Xbmc.Status.IsConnected() && Settings.Default.ShowPlayStatusBalloonTips)
            {
                if (Xbmc.Status.IsNotPlaying())
                {
                    if (!_playStatusMessageShowed)
                    {
                        notifyIcon1.ShowBalloonTip(2000, Language.GetString("global/appName"), Language.GetString("mainform/playing/nothing"), ToolTipIcon.Info);
                        _playStatusMessageShowed = true;
                    }
                }
                else if (Xbmc.Status.IsPaused())
                {
                    if (!_playStatusMessageShowed)
                    {
                        notifyIcon1.ShowBalloonTip(2000, Language.GetString("global/appName"), Language.GetString("mainform/playing/paused"), ToolTipIcon.Info);
                        notifyIcon1.Text = "XBMControl\n" + Language.GetString("mainform/playing/paused");
                        _playStatusMessageShowed = true;
                    }
                }
                else
                    _playStatusMessageShowed = false;
            }
        }

        private void ShowConnectionInfo()
        {
            if (!Xbmc.Status.IsConnected() && Settings.Default.ShowConnectionInfo)
            {
                if (!_showedConnectionStatus)
                {
                    lArtistSong.Text = Language.GetString("mainform/connection/none");
                    if (Settings.Default.ShowConnectionInfo)
                    {
                        notifyIcon1.ShowBalloonTip(2000, Language.GetString("global/appName"), Language.GetString("mainform/connection/none"), ToolTipIcon.Error);
                        notifyIcon1.Text = "XBMControl\n" + Language.GetString("mainform/connection/none");
                    }
                    else
                        MessageBox.Show(Language.GetString("mainform/connection/none"));

                    _showedConnectionStatus = true;
                }
            }
            else
                _showedConnectionStatus = false;
        }

        private void ShowConfigurationAtStart()
        {
            if (!Xbmc.Status.IsConnected() && Settings.Default.ShowConfigurationAtStart)
            {
                if (!_showConfigurationAtStart)
                {
                    lArtistSong.Text = Language.GetString("mainform/connection/none");
                    if (Settings.Default.ShowConfigurationAtStart)
                    {
                        notifyIcon1.ShowBalloonTip(2000, Language.GetString("global/appName"), Language.GetString("mainform/connection/none"), ToolTipIcon.Error);
                        notifyIcon1.Text = "XBMControl\n" + Language.GetString("mainform/connection/none");
                    }
                    else
                        MessageBox.Show(Language.GetString("mainform/connection/none"));

                    _showConfigurationAtStart = true;
                }
            }
            else
                _showConfigurationAtStart = false;
        }
//END Notification events

//START Configuration form events
        private void ShowConfigurationForm()
        {
            if (!ConfigFormOpened)
            {
                _configForm              = new ConfigurationF1(this);
                _configForm.Show();
            }
        }
//END Configuration form events

//START Volume control events
        private void ToggleShowVolumeControl()
        {
            if (Xbmc.Status.IsConnected())
            {
                if (!VolumeControlOpened)
                {
                    _sysTrayVolumeControl = new VolumeControlF1(this);
                    _sysTrayVolumeControl.FormClosed += new FormClosedEventHandler(VolumeControlClosed);
                    _sysTrayVolumeControl.Left = Cursor.Position.X - (_sysTrayVolumeControl.Width / 2);
                    _sysTrayVolumeControl.Top = Cursor.Position.Y - (_sysTrayVolumeControl.Height + 15);
                    _sysTrayVolumeControl.Show();
                    _sysTrayVolumeControl.Focus();
                    VolumeControlOpened = true;
                }
                else
                {
                    _sysTrayVolumeControl.Dispose();
                    VolumeControlOpened = false;
                }
            }
        }

        public void VolumeControlClosed(object sender, EventArgs e)
        {
            VolumeControlOpened = false;
        }
//END Volume control events

//START Progress bar events
        private void tbProgress_MouseUp(object sender, MouseEventArgs e)
        {
            Xbmc.Controls.SeekPercentage(tbProgress.Value);
            updateTimer.Enabled = true;
        }

        private void tbProgress_MouseDown(object sender, MouseEventArgs e)
        {
            updateTimer.Enabled = false;
        }

        private void tbProgress_MouseHover(object sender, EventArgs e)
        {
            tbProgress.Focus();
        }
//END Progress bar events

//START Volume bar events
        private void tbVolume_MouseHover(object sender, EventArgs e)
        {
            tbVolume.Focus();
        }

        private void tbVolume_MouseDown(object sender, MouseEventArgs e)
        {
            updateTimer.Enabled = false;
        }

        private void tbVolume_MouseUp(object sender, MouseEventArgs e)
        {
            Xbmc.Controls.SetVolume(tbVolume.Value);
            updateTimer.Enabled = true;
        }
//START Volume bar events

//START Context menu events
        private void MainContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (Xbmc.Status.IsPlaying())
            {
                //cmsSeperatorSaveMedia.Visible = true;
                //cmsSaveMedia.Visible          = true;
            }
        }

        private void cmsNotifyExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmsNotifyPrevious_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.Previous();
        }

        private void cmsNotifyPlay_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.Play();
        }

        private void cmsNotifyPause_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.Play();
        }

        private void cmsNotifyStop_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.Stop();
        }

        private void cmsNotifyNext_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.Next();
        }

        private void cmsNotifyMute_Click(object sender, EventArgs e)
        {
            Xbmc.Controls.ToggleMute();
        }

        private void cmsNotifyShow_Click(object sender, EventArgs e)
        {
            Visible        = true;
            WindowState    = FormWindowState.Normal;
            Focus();
        }

        private void cmsNotifyHide_Click(object sender, EventArgs e)
        {
            WindowState    = FormWindowState.Minimized;
            Visible        = Settings.Default.ShowInTaskbar;
        }

        private void cmsConfigure_Click(object sender, EventArgs e)
        {
            ShowConfigurationForm();
        }

        private void cmsXBMCrebootComputer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.GetString("configuration/ipAddress/proceedMessage"), Language.GetString("contextMenu/xbmc/reboot"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                Xbmc.Controls.Reboot();
        }

        private void cmsXBMCrebootXBMC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.GetString("configuration/ipAddress/proceedMessage"), Language.GetString("contextMenu/xbmc/restart"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                Xbmc.Controls.Restart();
        }

        private void cmsXBMCshutdown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.GetString("configuration/ipAddress/proceedMessage"), Language.GetString("contextMenu/xbmc/shutdown"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                Xbmc.Controls.Shutdown();
        }

        private void cmsSaveMedia_Click(object sender, EventArgs e)
        {

        }

        private void cmsShowScreenshot_Click(object sender, EventArgs e)
        {
            var screenshot = Xbmc.Controls.GetScreenshot();

            if (screenshot == null)
                MessageBox.Show("Failed taking screenshot");
            else
            {
                _fullSizeImage = new FullSizeImageF1(screenshot);
                _fullSizeImage.Show();
            }
        }

        private void cmsSendMediaUrl_Click(object sender, EventArgs e)
        {
            var sendMedia = new SendMediaUrl(this);
            sendMedia.Show();
        }

        private void cmsViewPlaylist_Click(object sender, EventArgs e)
        {
            if (Playlist == null || !Settings.Default.playlistOpened)
            {
                Playlist = new PlaylistF1(this);
                //Playlist.Scale(new SizeF((float)2, (float)2));
                Playlist.Show();
                Playlist.Top = Top;
                Playlist.Left = (Left + Width);
            }
            else if (Settings.Default.playlistOpened && Playlist != null)
                Playlist.Focus();
        }
//END Context menu events

//START Notify icon events
        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (VolumeControlOpened) _sysTrayVolumeControl.Focus();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToggleShowMainWindow();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
                ToggleShowVolumeControl();
        }

        private void ToggleShowMainWindow()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState    = FormWindowState.Minimized;
                Visible        = Settings.Default.ShowInTaskbar;

                if (Settings.Default.playlistOpened && Playlist != null)
                    Playlist.Hide();
            }
            else
            {
                Visible        = true;
                WindowState    = FormWindowState.Normal;

                if (Settings.Default.playlistOpened && Playlist != null)
                {
                    Playlist.Show();
                    Playlist.Focus();
                    Focus();
                }
            }
        }
//END Notify icon events

//START PREVIOUS BUTTON
        private void bPrevious_MouseEnter(object sender, EventArgs e)
        {
            bPrevious.BackgroundImage = Resources.button_previous_hover;
            //ToggelHoverImage(bPrevious);
        }

        private void bPrevious_MouseLeave(object sender, EventArgs e)
        {
            bPrevious.BackgroundImage = Resources.button_previous;
        }

        private void bPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            bPrevious.BackgroundImage = Resources.button_previous_click;
            Xbmc.Controls.Previous();
            if (Settings.Default.playlistOpened && Playlist != null)
                Playlist.RefreshPlaylist();
        }

        private void bPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            bPrevious.BackgroundImage = Resources.button_previous_hover;
        }
//END PREVIOUS BUTTON

//START PLAY BUTTON
        private void bPlay_MouseEnter(object sender, EventArgs e)
        {
            bPlay.BackgroundImage = Resources.button_play_hover;
        }

        private void bPlay_MouseLeave(object sender, EventArgs e)
        {
            bPlay.BackgroundImage = Resources.button_play_hover;
        }

        private void bPlay_MouseDown(object sender, MouseEventArgs e)
        {
            bPlay.BackgroundImage = Resources.button_play_click;
            if(Xbmc.Status.IsPaused())
                Xbmc.Controls.Play();
            else if (Settings.Default.playlistOpened && Playlist != null)
                Playlist.PlaySelectedEntry();
        }

        private void bPlay_MouseUp(object sender, MouseEventArgs e)
        {
            bPlay.BackgroundImage = Resources.button_play_hover;
        }
//END PLAY BUTTON

//START PAUSE BUTTON
        private void bPause_MouseEnter(object sender, EventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bPause.BackgroundImage = Resources.button_pause_hover;
        }

        private void bPause_MouseLeave(object sender, EventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bPause.BackgroundImage = Resources.button_pause;
        }

        private void bPause_MouseDown(object sender, MouseEventArgs e)
        {
            bPause.BackgroundImage = Resources.button_pause_click;
            Xbmc.Controls.Play();
        }

        private void bPause_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bPause.BackgroundImage = Resources.button_pause_hover;
        }
//END PAUSE BUTTON

//START STOP BUTTON
        private void bStop_MouseEnter(object sender, EventArgs e)
        {
            if (Xbmc.Status.IsPlaying() || Xbmc.Status.IsPaused()) bStop.BackgroundImage = Resources.button_stop_hover;
        }

        private void bStop_MouseLeave(object sender, EventArgs e)
        {
            if (Xbmc.Status.IsPlaying() || Xbmc.Status.IsPaused()) bStop.BackgroundImage = Resources.button_stop;
        }

        private void bStop_MouseDown(object sender, MouseEventArgs e)
        {
            bStop.BackgroundImage = Resources.button_stop_click;
            Xbmc.Controls.Stop();
            if (Settings.Default.playlistOpened && Playlist != null)
                Playlist.RefreshPlaylist();
        }

        private void bStop_MouseUp(object sender, MouseEventArgs e)
        {
            if (Xbmc.Status.IsPlaying() || Xbmc.Status.IsPaused()) bStop.BackgroundImage = Resources.button_stop_hover;
            GetNowPlayingSongInfo(_resetToDefault);
            if (Settings.Default.ShowNowPlayingBalloonTips) ShowNowPlayingInfo(_resetToDefault);
        }
//END STOP BUTTON

//START NEXT BUTTON
        private void bNext_MouseEnter(object sender, EventArgs e)
        {
            bNext.BackgroundImage = Resources.button_next_hover;
        }

        private void bNext_MouseLeave(object sender, EventArgs e)
        {
            bNext.BackgroundImage = Resources.button_next;
        }

        private void bNext_MouseDown(object sender, MouseEventArgs e)
        {
            bNext.BackgroundImage = Resources.button_next_click;
            Xbmc.Controls.Next();
            if (Settings.Default.playlistOpened && Playlist != null)
                Playlist.RefreshPlaylist();
        }

        private void bNext_MouseUp(object sender, MouseEventArgs e)
        {
            bNext.BackgroundImage = Resources.button_next_hover;
        }

//END NEXT BUTTON

//START OPEN BUTTON
        private void bOpen_MouseEnter(object sender, EventArgs e)
        {
            bOpen.BackgroundImage = Resources.button_open_hover;
        }

        private void bOpen_MouseLeave(object sender, EventArgs e)
        {
            bOpen.BackgroundImage = Resources.button_open;
        }

        private void bOpen_MouseDown(object sender, MouseEventArgs e)
        {
            bOpen.BackgroundImage = Resources.button_open_click;
            if (!ShareBrowserOpened)
            {
                _shareBrowser = new MediaBrowserF1(this);
                _shareBrowser.Show();
                ShareBrowserOpened = true;
            }
        }

        private void bOpen_MouseUp(object sender, MouseEventArgs e)
        {
            bOpen.BackgroundImage = Resources.button_open_hover;
        }

//END OPEN BUTTON

//START MUTE BUTTON
        private void bMute_MouseEnter(object sender, EventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bMute.BackgroundImage = Resources.button_mute_hover;
        }

        private void bMute_MouseLeave(object sender, EventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bMute.BackgroundImage = Resources.button_mute;
        }

        private void bMute_MouseDown(object sender, MouseEventArgs e)
        {
            bMute.BackgroundImage = Resources.button_mute_click;
            Xbmc.Controls.ToggleMute();
        }

        private void bMute_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Xbmc.Status.IsPaused()) bMute.BackgroundImage = Resources.button_mute_hover;
        }
//END MUTE BUTTON

//START LASTFM BUTTONS
        private void bLastFmLove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.GetString("mainform/dialog/lastfmLove"), Language.GetString("mainform/dialog/lastfmLoveTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                Xbmc.Controls.LastFmLove();
        }

        private void bLastFmHate_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(Language.GetString("mainform/dialog/lastfmHate"), Language.GetString("mainform/dialog/lastfmHateTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                Xbmc.Controls.LastFmHate();
        }
//END LASTFM BUTTONS

//START MINIMIZE BUTTON
        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackgroundImage = Resources.minimize1_hover;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackgroundImage = Resources.minimize1;
        }

        private void pbMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
        }
//END MINIMIZE BUTTON

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
            Dispose();
        }
//END CLOSE BUTTON

//START REPEAT BUTTON
        private void bRepeat_MouseEnter(object sender, EventArgs e)
        {
            bRepeat.BackgroundImage = Resources.button_repeat_hover;
        }

        private void bRepeat_MouseLeave(object sender, EventArgs e)
        {
            if (_repeatEnabled)
                bRepeat.BackgroundImage = Resources.button_repeat_selected;
            else
                bRepeat.BackgroundImage = Resources.button_repeat;
        }

        private void bRepeat_MouseDown(object sender, MouseEventArgs e)
        {
            bRepeat.BackgroundImage = Resources.button_repeat_click;
        }

        private void bRepeat_MouseUp(object sender, MouseEventArgs e)
        {
            if (_repeatEnabled)
                bRepeat.BackgroundImage = Resources.button_repeat_selected;
            else
                bRepeat.BackgroundImage = Resources.button_repeat;
        }

        private void bRepeat_Click(object sender, EventArgs e)
        {
            _repeatEnabled = (_repeatEnabled) ? false : true;
            Xbmc.Controls.Repeat(_repeatEnabled);
        }

//END REPEAT BUTTON

//START SHUFFLE BUTTON
        private void bShuffle_MouseEnter(object sender, EventArgs e)
        {
            bShuffle.BackgroundImage = Resources.button_shuffle_hover;
        }

        private void bShuffle_MouseLeave(object sender, EventArgs e)
        {
            bShuffle.BackgroundImage = Resources.button_shuffle;
        }

        private void bShuffle_MouseDown(object sender, MouseEventArgs e)
        {
            bShuffle.BackgroundImage = Resources.button_shuffle_click;
            Xbmc.Controls.ToggleShuffle();
        }

        private void bShuffle_MouseUp(object sender, MouseEventArgs e)
        {
            bShuffle.BackgroundImage = Resources.button_shuffle_hover;
        }
//END SHUFFLE BUTTON

//START PARTYMODE BUTTON
        private void bPartymode_MouseEnter(object sender, EventArgs e)
        {
            bPartymode.BackgroundImage = Resources.button_partymode_hover;
        }

        private void bPartymode_MouseLeave(object sender, EventArgs e)
        {
            if (_partyModeEnabled)
                bPartymode.BackgroundImage = Resources.button_partymode_selected;
            else
                bPartymode.BackgroundImage = Resources.button_partymode;
        }

        private void bPartymode_MouseDown(object sender, MouseEventArgs e)
        {
            bPartymode.BackgroundImage = Resources.button_partymode_click;
        }

        private void bPartymode_MouseUp(object sender, MouseEventArgs e)
        {
            if (_partyModeEnabled)
                bPartymode.BackgroundImage = Resources.button_partymode_selected;
            else
                bPartymode.BackgroundImage = Resources.button_partymode;
        }

        private void bPartymode_Click(object sender, EventArgs e)
        {
            _partyModeEnabled = (_partyModeEnabled) ? false : true;
            Xbmc.Controls.TogglePartymode();
        }
        //END PARTYMODE BUTTON

//START PLAYLIST BUTTON
        private void bPlaylist_MouseHover(object sender, EventArgs e)
        {
            bPlaylist.BackgroundImage = Resources.button_playlist_hover;
        }

        private void bPlaylist_MouseLeave(object sender, EventArgs e)
        {
            bPlaylist.BackgroundImage = Resources.button_playlist;
        }

        private void bPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            bPlaylist.BackgroundImage = Resources.button_playlist_click;
        }

        private void bPlaylist_MouseUp(object sender, MouseEventArgs e)
        {
            bPlaylist.BackgroundImage = Resources.button_playlist_hover;

            if (Settings.Default.playlistOpened && Playlist != null)
            {
                Playlist.Show();
                Playlist.Focus();
                Focus();
            }
            else
                cmsViewPlaylist_Click(null, null);
        }

        private void cmsViewNavigator_Click(object sender, EventArgs e)
        {
            if (Navigator == null || !Settings.Default.NavigatorOpened)
            {
                Navigator = new NavigatorF1(this);
                Navigator.Show();
                Navigator.Top = Top;
                Navigator.Left = (Left + Width);
            }
            else if (Settings.Default.NavigatorOpened && Navigator != null)
                Navigator.Focus();
        }
//END PLAYLIST BUTTON

//START NAVIGATOR BUTTON
        private void bNavigator_MouseHover(object sender, EventArgs e)
        {
            bNavigator.BackgroundImage = Resources.button_remote_hover;
        }

        private void bNavigator_MouseLeave(object sender, EventArgs e)
        {
            bNavigator.BackgroundImage = Resources.button_remote;
        }

        private void bNavigator_MouseDown(object sender, MouseEventArgs e)
        {
            bNavigator.BackgroundImage = Resources.button_remote_click;
        }

        private void bNavigator_MouseUp(object sender, MouseEventArgs e)
        {
            bNavigator.BackgroundImage = Resources.button_remote_hover;

            if (Settings.Default.NavigatorOpened && Navigator != null)
            {
                Navigator.Show();
                Navigator.Focus();
                Focus();
            }
            else
                cmsViewNavigator_Click(null, null);
        }
//END NAVIGATOR BUTTON

//START FAKE DRAG DROP
        private void pToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging   = true;
            _clickOffsetX = e.X;
            _clickOffsetY = e.Y;
        }

        private void pToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            if (e.Button == MouseButtons.Right)
                MainContextMenu.Show(pToolbar, new Point(0, pToolbar.Height));
        }

        private void pToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging == true)
            {
                Left = e.X + Left - _clickOffsetX;
                Top  = e.Y + Top - _clickOffsetY;

                if (Settings.Default.playlistOpened && Playlist != null)
                {
                    Playlist.Top = Top;
                    Playlist.Left = Left + Width;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainContextMenu.Show(pToolbar, new Point(0, pToolbar.Height));
        }
//END FAKE DRAG DROP

        private void cmsViewMediaBrowser_Click(object sender, EventArgs e)
        {
            bOpen_MouseDown(null, null);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void bNavigator_Click(object sender, EventArgs e)
        {

        }

        private void bPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
