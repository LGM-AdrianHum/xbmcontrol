using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XBMControl
{
    public partial class videoInfoF1 : Form
    {
        MainForm parent;
        string[] videoInfoList;

        public videoInfoF1(MainForm parentForm, string videoID)
        {
            parent = parentForm;
            InitializeComponent();
            this.Owner = parent;
            this.fillVideoInfo(videoID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            parent.videoInfoOpened = false;
            this.Close();
        }

        private void fillVideoInfo(string videoID)
        {
            videoInfoList = parent.XBMC.Video.GetVideoLibraryInfo(videoID);

            this.videoPicture.Image = parent.XBMC.Video.getVideoThumb(videoID);
            this.videoName.Text = videoInfoList[1];
            this.videoPlot.Text = videoInfoList[2];
            this.videoGenre.Text = videoInfoList[15];
            this.videoYear.Text = videoInfoList[8];
            this.videoRuntime.Text = videoInfoList[12];
            this.videoRating.Text = videoInfoList[6] + " (" + videoInfoList[5] + " votes)";
            this.videoTagline.Text = videoInfoList[4];
            this.videoMPAARating.Text = videoInfoList[13];
        }
    }
}
