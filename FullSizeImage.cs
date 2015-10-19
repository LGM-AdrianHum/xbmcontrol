// Author: Hum, Adrian
// Project: XBMControl/XBMControl/FullSizeImage.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:10 AM

#region Using Directives

using System;
using System.Drawing;
using System.Windows.Forms;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class FullSizeImageF1 : Form {
        public FullSizeImageF1(Image fImage) {
            InitializeComponent();
            ShowImage(fImage);
        }

        private void ShowImage(Image fImage) {
            BackgroundImage = fImage ?? Resources.XBMClogo;
            if (fImage == null) return;
            Width = fImage.Width;
            Height = fImage.Height;
        }

        private void FullSizeImageF1_FormClosed(object sender, FormClosedEventArgs e) {}

        private void FullSizeImageF1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}