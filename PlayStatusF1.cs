// Author: Hum, Adrian
// Project: XBMControl/XBMControl/PlayStatusF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:32 AM

#region Using Directives

using System;
using System.Drawing;
using System.Windows.Forms;
using XBMC;
using XBMControl.Animations;
using XBMControl.Properties;

#endregion

namespace XBMControl.PlayStatusForm {
    public partial class PlayStatusF1 : Form {
        private readonly Animation _animate;
        private readonly double _hideTimeout = 10.0;
        private readonly int _screenHeight;
        private readonly int _screenWidth;
        private readonly XbmcCommunicator _xbmc;
        private bool _activated;
        private DateTime _startTime;

        public PlayStatusF1() {
            _xbmc = new XbmcCommunicator();
            _animate = new Animation();
            _screenHeight = SystemInformation.PrimaryMonitorSize.Height;
            _screenWidth = SystemInformation.PrimaryMonitorSize.Width;
            InitializeComponent();
            SetFormPosition();
            ShowCoverArt();
        }

        private void SetFormPosition() {
            var pixelLeft = _screenWidth - Width;
            var pixelTop = _screenHeight - (Height + 32);
            DesktopLocation = new Point(pixelLeft, pixelTop);
        }

        private void ShowCoverArt() {
            var coverArt = _xbmc.NowPlaying.GetCoverArt();
            pbThumbnail.Image = coverArt ?? Resources.XBMClogo;
        }

        private void UpdateMediaInfo() {
            var year = (_xbmc.NowPlaying.Get("year") == null) ? "" : " [" + _xbmc.NowPlaying.Get("year") + "]";
            lArtist.Text = _xbmc.NowPlaying.Get("artist");
            var duration = _xbmc.NowPlaying.Get("duration");
            var time = (duration == null) ? "" : " [" + duration + "]";
            lTitle.Text = _xbmc.NowPlaying.Get("title") + time;
            lAlbum.Text = _xbmc.NowPlaying.Get("album") + year;
        }

        private void PlayStatusF1_Activated(object sender, EventArgs e) {
            if (!_activated) {
                _startTime = DateTime.Now;
                _xbmc.Status.Refresh();
                UpdateMediaInfo();
                _animate.StartFadeIn(this);
                hideFormTimer.Enabled = true;
                _activated = true;
            }
        }

        private void hideFormTimer_Tick(object sender, EventArgs e) {
            if ((DateTime.Now - _startTime).TotalSeconds > _hideTimeout)
                _animate.StartFadeOut(this);

            if (Math.Abs(Opacity) < .01) {
                hideFormTimer.Enabled = false;
                _activated = false;
                Hide();
            }
        }

        private void PlayStatusF1_Click(object sender, EventArgs e) {
            _animate.StartFadeOut(this);
        }
    }
}