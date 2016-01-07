// Author: Hum, Adrian
// Project: XBMControl/XBMControl/NavigatorF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:45 AM

#region Using Directives

using System;
using System.Windows.Forms;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class NavigatorF1 : Form {
        private readonly MainForm _parent;

        private int _clickOffsetX,
            _clickOffsetY;

        private bool _isDragging;

        public NavigatorF1(MainForm parentForm) {
            _parent = parentForm;
            InitializeComponent();
            if (_parent.Xbmc.Status.IsConnected())
                _parent.Xbmc.Status.Refresh();

            Settings.Default.NavigatorOpened = true;
            Settings.Default.Save();

            try { Owner = _parent; }
                // ReSharper disable once CatchAllClause
            catch {
                // ignored
            }
        }

        private void bUp_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("3");
        }

        private void bLeft_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("1");
        }

        private void bRight_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("2");
        }

        private void bDown_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("4");
        }

        //START FAKE DRAG DROP
        private void pToolbar_MouseDown(object sender, MouseEventArgs e) {
            _parent.Focus();
            Focus();
            _isDragging = true;
            _clickOffsetX = e.X;
            _clickOffsetY = e.Y;
        }

        private void pToolbar_MouseUp(object sender, MouseEventArgs e) {
            _isDragging = false;
        }

        private void pToolbar_MouseMove(object sender, MouseEventArgs e) {
            if (!_isDragging) return;
            Left = e.X + Left - _clickOffsetX;
            Top = e.Y + Top - _clickOffsetY;
        }

        //END FAKE DRAG DROP

        private void bSelect_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("7");
        }

        private void bUndo_Click_1(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("9");
        }

        private void NavigatorF1_Load(object sender, EventArgs e) {}

        private void bVolDown_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("89");
        }

        private void bVolUp_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("88");
        }

        private void bRewind_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("78");
        }

        private void bStop_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("13");
        }

        private void bPlayPause_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("12");
        }

        private void bForward_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("77");
        }

        private void bHome_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("10");
        }

        private void bOptions_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("18");
        }

        private void bClose_Click(object sender, EventArgs e) {
            Settings.Default.NavigatorOpened = false;
            Settings.Default.Save();
            Dispose();
        }

        //START CLOSE BUTTON
        private void bClose_MouseEnter(object sender, EventArgs e) {
            bClose.BackgroundImage = Resources.button_exit_hover;
        }

        private void bClose_MouseLeave(object sender, EventArgs e) {
            bClose.BackgroundImage = Resources.button_exit;
        }

        private void bClose_MouseUp(object sender, MouseEventArgs e) {
            bClose.BackgroundImage = Resources.button_exit;
        }

        private void bClose_MouseDown(object sender, MouseEventArgs e) {
            bClose.BackgroundImage = Resources.button_exit_click;
        }

        // END CLOSE BUTTON

        private void bPrevious_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("15");
        }

        private void bNext_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("14");
        }

        private void button1_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("59");
        }

        private void button2_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("60");
        }

        private void button3_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("61");
        }

        private void button4_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("62");
        }

        private void button5_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("63");
        }

        private void button6_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("64");
        }

        private void button7_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("65");
        }

        private void button8_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("66");
        }

        private void button9_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("67");
        }

        private void button0_Click(object sender, EventArgs e) {
            _parent.Xbmc.Video.SendAction("58");
        }
    }
}