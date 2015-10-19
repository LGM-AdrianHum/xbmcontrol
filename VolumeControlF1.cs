// Author: Hum, Adrian
// Project: XBMControl/XBMControl/VolumeControlF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:36 AM

#region Using Directives

using System;
using System.Windows.Forms;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class VolumeControlF1 : Form {
        private readonly MainForm _parent;
        private bool _connectedToXbmc;

        public VolumeControlF1(MainForm parentForm) {
            _parent = parentForm;
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            if (_parent.XBMC.Status.IsConnected()) {
                _connectedToXbmc = _parent.XBMC.Status.IsConnected();
                _parent.XBMC.Status.Refresh();
                GetCurrentVolume();
                timer1.Enabled = true;
                if (_parent.XBMC.Status.IsMuted()) bMute.BackgroundImage = Resources.button_mute_click;
            }
            else
                Close();
        }

        private void GetCurrentVolume() {
            _parent.XBMC.Status.Refresh();
            tbVolumeSysTray.Value = _parent.XBMC.Status.GetVolume();
        }

        private void VolumeControlF1_LostFocus(object sender, EventArgs e) {
            if (!tbVolumeSysTray.Focused &&
                !bMute.Focused) Dispose();
        }

        private void tbVolumeSysTray_LostFocus(object sender, EventArgs e) {
            if (!Focused &&
                !bMute.Focused) Dispose();
        }

        private void bMute_LostFocus(object sender, EventArgs e) {
            if (!Focused &&
                !tbVolumeSysTray.Focused) Dispose();
        }

        private void tbVolumeSysTray_MouseHover(object sender, EventArgs e) {
            tbVolumeSysTray.Focus();
        }

        private void VolumeControlF1_MouseHover(object sender, EventArgs e) {
            tbVolumeSysTray.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (_connectedToXbmc)
                GetCurrentVolume();
            else
                Close();

            if (_parent.XBMC.Status.IsMuted()) bMute.BackgroundImage = Resources.button_mute_click;
        }

        private void tbVolumeSysTray_MouseDown(object sender, MouseEventArgs e) {
            timer1.Enabled = false;
        }

        private void tbVolumeSysTray_MouseUp(object sender, MouseEventArgs e) {
            timer1.Enabled = true;
        }

        private void bMute_Click(object sender, EventArgs e) {
            _parent.XBMC.Controls.ToggleMute();
        }

        private void tbVolumeSysTray_ValueChanged(object sender, EventArgs e) {
            _parent.XBMC.Controls.SetVolume(tbVolumeSysTray.Value);
        }

        private void bMute_MouseHover(object sender, EventArgs e) {
            tbVolumeSysTray.Focus();
        }

        private void bMute_MouseEnter(object sender, EventArgs e) {
            bMute.BackgroundImage = Resources.button_mute_hover;
        }

        private void bMute_MouseDown(object sender, MouseEventArgs e) {
            bMute.BackgroundImage = Resources.button_mute_click;
        }

        private void bMute_MouseLeave(object sender, EventArgs e) {
            bMute.BackgroundImage = Resources.button_mute;
        }

        private void bMute_MouseUp(object sender, MouseEventArgs e) {
            bMute.BackgroundImage = Resources.button_mute_hover;
        }
    }
}