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
    public partial class NavigatorF1 : Form
    {
        private MainForm parent;
        private bool isDragging = false;
        private int clickOffsetX, clickOffsetY;

        public NavigatorF1(MainForm parentForm)
        {
            parent = parentForm;
            InitializeComponent();
            if (parent.XBMC.Status.IsConnected())
            {
                parent.XBMC.Status.Refresh();
            }

            Settings.Default.NavigatorOpened = true;
            Settings.Default.Save();

            this.Owner = parent;
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("3");
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("1");
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("2");
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("4");
        }

        //START FAKE DRAG DROP
        private void pToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            parent.Focus();
            this.Focus();
            isDragging = true;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
        }

        private void pToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                this.Left = e.X + this.Left - clickOffsetX;
                this.Top = e.Y + this.Top - clickOffsetY;
            }
        }
        //END FAKE DRAG DROP

        private void bSelect_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("7");
        }

        private void bUndo_Click_1(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("9");
        }

        private void NavigatorF1_Load(object sender, EventArgs e)
        {
        }

        private void bVolDown_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("89");
        }

        private void bVolUp_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("88");
        }

        private void bRewind_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("78");
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("13");
        }

        private void bPlayPause_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("12");
        }

        private void bForward_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("77");
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("10");
        }

        private void bOptions_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("18");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Settings.Default.NavigatorOpened = false;
            Settings.Default.Save();
            this.Dispose();
        }

        //START CLOSE BUTTON
        private void bClose_MouseEnter(object sender, EventArgs e)
        {
            bClose.BackgroundImage = Resources.button_exit_hover;
        }

        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.BackgroundImage = Resources.button_exit;
        }

        private void bClose_MouseUp(object sender, MouseEventArgs e)
        {
            bClose.BackgroundImage = Resources.button_exit;
        }

        private void bClose_MouseDown(object sender, MouseEventArgs e)
        {
            bClose.BackgroundImage = Resources.button_exit_click;
        }
        // END CLOSE BUTTON

        private void bPrevious_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("15");
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("14");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("59");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("60");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("61");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("62");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("63");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("64");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("65");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("66");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("67");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            parent.XBMC.Video.sendAction("58");
        }
    }
}
