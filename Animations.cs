// Author: Hum, Adrian
// Project: XBMControl/XBMControl/Animations.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:05 AM

#region Using Directives

using System;
using System.Windows.Forms;

#endregion

namespace XBMControl.Animations {
    internal class Animation {
        private readonly Timer _fadeTimer;
        private object _fadeObject;

        public Animation() {
            _fadeTimer = new Timer {Interval = 5, Enabled = false};
        }

        public void StartFadeIn(object sender) {
            _fadeObject = sender;
            _fadeTimer.Tick += FadeIn;
            _fadeTimer.Enabled = true;
        }

        public void StartFadeOut(object sender) {
            _fadeObject = sender;
            _fadeTimer.Tick += FadeOut;
            _fadeTimer.Enabled = true;
        }

        public void FadeIn(object sender, EventArgs e) {
            if (!(_fadeObject is Form)) return;
            var frm = (Form) _fadeObject;
            frm.Opacity += 0.05;

            if (!(frm.Opacity >= .95)) return;
            frm.Opacity = 1;
            _fadeTimer.Enabled = false;
            _fadeTimer.Tick -= FadeIn;
        }

        public void FadeOut(object sender, EventArgs e) {
            if (!(_fadeObject is Form)) return;
            var frm = (Form) _fadeObject;
            frm.Opacity -= 0.05;
            if (!(frm.Opacity <= .05)) return;
            frm.Opacity = 0;
            _fadeTimer.Enabled = false;
            _fadeTimer.Tick -= FadeOut;
        }
    }
}