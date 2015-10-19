using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XBMControl.Animations
{
    class Animation
    {
        Timer fadeTimer;
        object fadeObject;

        public Animation()
        {
            fadeTimer           = new Timer();
            fadeTimer.Interval  = 5;
            fadeTimer.Enabled   = false;
        }

        public void StartFadeIn(object sender)
        {
            fadeObject          = sender;
            fadeTimer.Tick      += FadeIn;
            fadeTimer.Enabled   = true;
        }

        public void StartFadeOut(object sender)
        {
            fadeObject = sender;
            fadeTimer.Tick += FadeOut;
            fadeTimer.Enabled = true;
        }

        public void FadeIn(object sender, EventArgs e)
        {
            if (fadeObject is Form)
            {
                Form frm = fadeObject as Form;
                frm.Opacity += 0.05;

                if (frm.Opacity >= .95)
                {
                    frm.Opacity         = 1;
                    fadeTimer.Enabled   = false;
                    fadeTimer.Tick      -= FadeIn;
                }
            }
        }

        public void FadeOut(object sender, EventArgs e)
        {
            if (fadeObject is Form)
            {
                Form frm = fadeObject as Form;
                frm.Opacity -= 0.05;
                if (frm.Opacity <= .05)
                {
                    frm.Opacity = 0;
                    fadeTimer.Enabled = false;
                    fadeTimer.Tick -= FadeOut;
                }
            }
        }
    }
}
