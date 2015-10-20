// Author: Hum, Adrian
// Project: XBMControl/XBMControl/ConfigurationF1.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:22 AM

#region Using Directives

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;
using XBMControl.Properties;

#endregion

namespace XBMControl {
    public partial class ConfigurationF1 : Form {
        private readonly MainForm _parent;
        private RegistryKey _regRunAtStartup;

        /// <exception cref="InvalidEnumArgumentException">
        ///     The assigned value is not one of the
        ///     <see cref="T:System.Windows.Forms.ComboBoxStyle" /> values.
        /// </exception>
        public ConfigurationF1(MainForm parentForm) {
            _parent = parentForm;
            _parent.configFormOpened = true;

            InitializeComponent();
            LoadConfiguration();
            _parent.Language.SetLanguage(Settings.Default.Language);
            SetLanguageStrings();
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConnectionTimeout.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetLanguageStrings() {
            Text = _parent.Language.GetString("global/appName") + @" " + _parent.Language.GetString("configuration/title");
            lConnectionTimeout.Text = _parent.Language.GetString("configuration/label/connectionTimeout");
            lLanguageTitle.Text = _parent.Language.GetString("configuration/label/language");
            lIpTitle.Text = _parent.Language.GetString("configuration/label/ip");
            lUsernameTitle.Text = _parent.Language.GetString("configuration/label/username");
            lPasswordTitle.Text = _parent.Language.GetString("configuration/label/password");
            cbShowInTray.Text = _parent.Language.GetString("configuration/label/showInTray");
            cbShowInTaskbar.Text = _parent.Language.GetString("configuration/label/showInTaskbar");
            cbShowNowPlayingBalloonTip.Text = _parent.Language.GetString("configuration/label/showNowPlayingBalloonTip");
            cbShowPlayStatusBalloonTip.Text = _parent.Language.GetString("configuration/label/showPlayStatusBalloonTip");
            cbShowConnectionStatusBalloonTip.Text = _parent.Language.GetString("configuration/label/showConnectionStatusBalloonTip");
            cbRunAtStartup.Text = _parent.Language.GetString("configuration/label/runAtStartup");
            cbStartMinimized.Text = _parent.Language.GetString("configuration/label/startMinimized");
            cbShowConfigurationAtStart.Text = _parent.Language.GetString("configuration/label/showConfigurationAtStart");
            bConfirm.Text = _parent.Language.GetString("global/button/confirm");
            bCancel.Text = _parent.Language.GetString("global/button/cancel");
        }

        // ReSharper disable once CyclomaticComplexity
        private void SaveConfiguration() {
            Settings.Default.Language = cbLanguage.Text;
            Settings.Default.Ip = tbIp.Text;
            Settings.Default.Username = tbUsername.Text;
            Settings.Default.Password = tbPassword.Text;
            Settings.Default.ConnectionTimeout = Convert.ToInt32(cbConnectionTimeout.Text);
            Settings.Default.ShowInSystemTray = cbShowInTray.Checked;
            Settings.Default.ShowNowPlayingBalloonTips = cbShowNowPlayingBalloonTip.Checked;
            Settings.Default.ShowPlayStatusBalloonTips = cbShowPlayStatusBalloonTip.Checked;
            Settings.Default.ShowInTaskbar = cbShowInTaskbar.Checked;
            Settings.Default.StartMinimized = cbStartMinimized.Checked;
            Settings.Default.ShowConnectionInfo = cbShowConnectionStatusBalloonTip.Checked;
            Settings.Default.ShowConfigurationAtStart = cbShowConfigurationAtStart.Checked;

            _regRunAtStartup = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (cbRunAtStartup.Checked) { if (_regRunAtStartup != null) _regRunAtStartup.SetValue(_parent.Language.GetString("global/appName"), "\"" + Application.ExecutablePath + "\""); }
            else if (_regRunAtStartup != null &&
                     _regRunAtStartup.GetValue(_parent.Language.GetString("global/appName")) != null)
                _regRunAtStartup.DeleteValue(_parent.Language.GetString("global/appName"));

            if (_regRunAtStartup != null) _regRunAtStartup.Close();

            if (!Settings.Default.ShowInSystemTray) Settings.Default.ShowInTaskbar = true;

            Settings.Default.Save();
        }

        private void LoadConfiguration() {
            ShowAvailableLanguages();
            SetSystrayCheckboxesEnabled(Settings.Default.ShowInSystemTray);
            cbLanguage.Text = Settings.Default.Language;
            tbIp.Text = Settings.Default.Ip;
            tbUsername.Text = Settings.Default.Username;
            tbPassword.Text = Settings.Default.Password;
            cbConnectionTimeout.Text = Settings.Default.ConnectionTimeout.ToString();

            cbShowInTray.Checked = Settings.Default.ShowInSystemTray;
            cbShowNowPlayingBalloonTip.Checked = Settings.Default.ShowNowPlayingBalloonTips;
            cbShowPlayStatusBalloonTip.Checked = Settings.Default.ShowPlayStatusBalloonTips;
            cbShowInTaskbar.Checked = Settings.Default.ShowInTaskbar;
            cbStartMinimized.Checked = Settings.Default.StartMinimized;
            cbShowConnectionStatusBalloonTip.Checked = Settings.Default.ShowConnectionInfo;
            cbShowConfigurationAtStart.Checked = Settings.Default.ShowConfigurationAtStart;
            _regRunAtStartup = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (_regRunAtStartup != null) {
                cbRunAtStartup.Checked = (_regRunAtStartup.GetValue(_parent.Language.GetString("global/appName")) != null);
                _regRunAtStartup.Close();
            }
        }

        private void SetSystrayCheckboxesEnabled(bool enabled) {
            cbShowNowPlayingBalloonTip.Enabled = enabled;
            cbShowPlayStatusBalloonTip.Enabled = enabled;
            cbShowInTaskbar.Enabled = enabled;
            cbShowConnectionStatusBalloonTip.Enabled = enabled;
        }

        private bool IsValidIp() {
            _parent.XBMC.SetIp(tbIp.Text);

            if (tbIp.Text == "") {
                MessageBox.Show(_parent.Language.GetString("mainform/dialog/ipNotConfigured"), _parent.Language.GetString("mainform/dialog/ipNotConfiguredTitle"));
                return false;
            }
            if (_parent.XBMC.Status.IsConnected()) return true;
            return MessageBox.Show(_parent.Language.GetString("mainform/dialog/unableToConnect") + @"\n\n" + _parent.Language.GetString("mainform/dialog/proceedMessage"), _parent.Language.GetString("mainform/dialog/unableToConnectTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void ShowAvailableLanguages() {
            var languages = _parent.Language.GetAvailableLanguages();

            if (languages.Length > 0) {
                cbLanguage.Items.Clear();
                foreach (var lang in languages)
                    cbLanguage.Items.Add(lang);
            }
            else
                MessageBox.Show(_parent.Language.GetString("configuration/language/noLanguages"));
        }

        private void bCancel_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            if (tbIp.Text == "")
                MessageBox.Show(_parent.Language.GetString("configuration/ipAddress/required"));
            else
                Close();
            Cursor = Cursors.Default;
        }

        private void bConfirm_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            if (IsValidIp()) {
                SaveConfiguration();
                Close();
            }
            Cursor = Cursors.Default;
        }

        private void cbShowInTray_Click(object sender, EventArgs e) {
            SetSystrayCheckboxesEnabled(cbShowInTray.Checked);
            if (!cbShowInTray.Checked) cbShowInTaskbar.Checked = true;
        }

        private void cbLanguage_TextChanged(object sender, EventArgs e) {
            _parent.Language.SetLanguage(cbLanguage.Text);
            SetLanguageStrings();
        }

        private void cbConnectionTimeout_SelectedValueChanged(object sender, EventArgs e) {
            Settings.Default.ConnectionTimeout = Convert.ToInt32(cbConnectionTimeout.Text);
        }

        //private void cbShowPlayStatusWindow_Click(object sender, EventArgs e) {
        //    if (cbShowPlayStatusBalloonTip.Checked)
        //        cbShowPlayStatusBalloonTip.Checked = false;
        //}

        private void ConfigurationF1_FormClosed(object sender, FormClosedEventArgs e) {
            _parent.ApplySettings();
            _parent.UpdateData();
            _parent.configFormOpened = false;
        }
    }
}