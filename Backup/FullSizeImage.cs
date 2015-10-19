using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using XBMControl.Properties;

namespace XBMControl
{
    public partial class FullSizeImageF1 : Form
    {
        public FullSizeImageF1(Image fImage)
        {
            InitializeComponent();
            ShowImage(fImage);
        }

        private void ShowImage(Image fImage)
        {
            this.BackgroundImage = (fImage == null)? Resources.XBMClogo : fImage;
            this.Width = fImage.Width;
            this.Height = fImage.Height;
        }

        private void FullSizeImageF1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FullSizeImageF1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
