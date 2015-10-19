// Author: Hum, Adrian
// Project: XBMControl/XBMControl/VideoInfoF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:33 AM

#region Using Directives

using System;
using System.Windows.Forms;

#endregion

namespace XBMControl {
    public partial class VideoInfoF1 : Form {
        private readonly MainForm _parent;
        private string[] _videoInfoList;

        /// <exception cref="Exception">A top-level window cannot have an owner. </exception>
        public VideoInfoF1(MainForm parentForm, string videoId) {
            _parent = parentForm;
            InitializeComponent();
            Owner = _parent;
            FillVideoInfo(videoId);
        }

        private void bClose_Click(object sender, EventArgs e) {
            _parent.videoInfoOpened = false;
            Close();
        }

        private void FillVideoInfo(string videoId) {
            _videoInfoList = _parent.XBMC.Video.GetVideoLibraryInfo(videoId);

            videoPicture.Image = _parent.XBMC.Video.GetVideoThumb(videoId);
            videoName.Text = _videoInfoList[1];
            videoPlot.Text = _videoInfoList[2];
            videoGenre.Text = _videoInfoList[15];
            videoYear.Text = _videoInfoList[8];
            videoRuntime.Text = _videoInfoList[12];
            videoRating.Text = _videoInfoList[6] + @" (" + _videoInfoList[5] + @" votes)";
            videoTagline.Text = _videoInfoList[4];
            videoMPAARating.Text = _videoInfoList[13];
        }
    }
}