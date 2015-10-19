using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using XBMControl.Properties;

namespace XBMControl
{
    public partial class SendMediaUrl : Form
    {
        MainForm parent;

        public SendMediaUrl(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
        }

        private void bSendMediaUrl_Click(object sender, EventArgs e)
        {
            if (tbMediaUrl.Text != "") parent.XBMC.Controls.PlayMedia(tbMediaUrl.Text);
            Close();
        }
    }
}
