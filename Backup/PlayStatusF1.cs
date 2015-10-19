using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBMC;
using XBMControl.Animations;

namespace XBMControl.PlayStatusForm
{
    public partial class PlayStatusF1 : Form
    {
        XBMC_Communicator XBMC; 
        Animation Animate;
        DateTime startTime;
        int screenHeight;
        int screenWidth;
        double hideTimeout = 10.0;
        bool activated = false;

        public PlayStatusF1()
        {
            XBMC          = new XBMC_Communicator(); 
            Animate       = new Animation();
            screenHeight  = SystemInformation.PrimaryMonitorSize.Height;
            screenWidth   = SystemInformation.PrimaryMonitorSize.Width;
            InitializeComponent();
            SetFormPosition();
            ShowCoverArt();
        }

        private void SetFormPosition()
        {
            int pixelLeft           = screenWidth - this.Width;
            int pixelTop            = screenHeight - (this.Height + 32);
            this.DesktopLocation    = new Point(pixelLeft, pixelTop);
        }

        private void ShowCoverArt()
        {
            Image coverArt = this.XBMC.NowPlaying.GetCoverArt();
            pbThumbnail.Image = (coverArt == null)? Properties.Resources.XBMClogo : coverArt;
        }
        
        private void UpdateMediaInfo()
        {
            string year = (this.XBMC.NowPlaying.Get("year") == null) ? "" : " [" + this.XBMC.NowPlaying.Get("year") + "]";
            lArtist.Text = this.XBMC.NowPlaying.Get("artist");
            string duration = this.XBMC.NowPlaying.Get("duration");
            string time       = (duration == null) ? "" : " [" + duration + "]";
            lTitle.Text = this.XBMC.NowPlaying.Get("title") + time;
            lAlbum.Text = this.XBMC.NowPlaying.Get("album") + year;
        }

        private void PlayStatusF1_Activated(object sender, EventArgs e)
        {
            if (!activated)
            {
                startTime = DateTime.Now;
                this.XBMC.Status.Refresh();
                UpdateMediaInfo();
                Animate.StartFadeIn(this);
                hideFormTimer.Enabled = true;
                activated = true;
            }
        }

        private void hideFormTimer_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - startTime).TotalSeconds > hideTimeout)
                Animate.StartFadeOut(this);

            if (this.Opacity == 0)
            {
                hideFormTimer.Enabled = false;
                activated = false;
                this.Hide();
            }
        }

        private void PlayStatusF1_Click(object sender, EventArgs e)
        {
            Animate.StartFadeOut(this);
        }
    }
}
