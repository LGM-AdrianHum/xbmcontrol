using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XBMControl.Properties;

namespace XBMControl
{
    public partial class VolumeControlF1 : Form
    {
        MainForm parent;
        private bool connectedToXbmc = false;

        public VolumeControlF1(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            if (parent.XBMC.Status.IsConnected())
            {
                connectedToXbmc = parent.XBMC.Status.IsConnected();
                parent.XBMC.Status.Refresh();
                GetCurrentVolume();
                timer1.Enabled = true;
                if (parent.XBMC.Status.IsMuted()) bMute.BackgroundImage = Resources.button_mute_click;
            }
            else
                this.Close();
        }

        private void GetCurrentVolume()
        {
            parent.XBMC.Status.Refresh();
            tbVolumeSysTray.Value = parent.XBMC.Status.GetVolume();
        }

        private void VolumeControlF1_LostFocus(object sender, EventArgs e)
        {
            if (!tbVolumeSysTray.Focused && !bMute.Focused) this.Dispose();
        }

        private void tbVolumeSysTray_LostFocus(object sender, EventArgs e)
        {
            if (!this.Focused && !bMute.Focused) this.Dispose();
        }

        private void bMute_LostFocus(object sender, EventArgs e)
        {
            if (!this.Focused && !tbVolumeSysTray.Focused) this.Dispose();
        }

        private void tbVolumeSysTray_MouseHover(object sender, EventArgs e)
        {
            tbVolumeSysTray.Focus();
        }

        private void VolumeControlF1_MouseHover(object sender, EventArgs e)
        {
            tbVolumeSysTray.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (connectedToXbmc)
                GetCurrentVolume();
            else
                Close();

            if (parent.XBMC.Status.IsMuted()) bMute.BackgroundImage = Resources.button_mute_click;
        }

        private void tbVolumeSysTray_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void tbVolumeSysTray_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void bMute_Click(object sender, EventArgs e)
        {
            parent.XBMC.Controls.ToggleMute();
        }

        private void tbVolumeSysTray_ValueChanged(object sender, EventArgs e)
        {
            parent.XBMC.Controls.SetVolume(tbVolumeSysTray.Value);
        }

        private void bMute_MouseHover(object sender, EventArgs e)
        {
            tbVolumeSysTray.Focus();
        }

        private void bMute_MouseEnter(object sender, EventArgs e)
        {
            bMute.BackgroundImage = Resources.button_mute_hover;
        }

        private void bMute_MouseDown(object sender, MouseEventArgs e)
        {
            bMute.BackgroundImage = Resources.button_mute_click;
        }

        private void bMute_MouseLeave(object sender, EventArgs e)
        {
            bMute.BackgroundImage = Resources.button_mute;
        }

        private void bMute_MouseUp(object sender, MouseEventArgs e)
        {
            bMute.BackgroundImage = Resources.button_mute_hover;
        }
    }
}
