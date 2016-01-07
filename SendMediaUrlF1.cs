// Author: Hum, Adrian
// Project: XBMControl/XBMControl/SendMediaUrlF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:32 AM

#region Using Directives

using System;
using System.Windows.Forms;

#endregion

namespace XBMControl {
    public partial class SendMediaUrl : Form {
        private readonly MainForm _parent;

        public SendMediaUrl(MainForm parentForm) {
            _parent = parentForm;
            InitializeComponent();
        }

        private void bSendMediaUrl_Click(object sender, EventArgs e) {
            if (tbMediaUrl.Text != "") _parent.Xbmc.Controls.PlayMedia(tbMediaUrl.Text);
            Close();
        }
    }
}