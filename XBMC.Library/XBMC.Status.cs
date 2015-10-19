// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Status.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:56 AM

#region Using Directives

using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "InconsistentNaming"), SuppressMessage("ReSharper", "CyclomaticComplexity"), SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional"), SuppressMessage("ReSharper", "ExceptionNotDocumented")] public class XbmcStatus {
        private readonly int _connectedInterval = 5000;
        private readonly int _disconnectedInterval = 10000;
        private readonly Timer _heartBeatTimer;
        private readonly XbmcCommunicator _parent;
        private bool _isMuted;
        private bool _isNotPlaying = true;
        private bool _isPaused;
        private bool _isPlaying;
        private bool _isPlayingLastFm;
        private string _mediaNowPlaying;
        private bool _newMediaPlaying = true;
        private int _progress = 1;
        private int _volume;
        //XBMC Properties
        internal bool isConnected;

        public XbmcStatus(XbmcCommunicator p) {
            _parent = p;
            _heartBeatTimer = new Timer {Interval = _connectedInterval};
            _heartBeatTimer.Tick += HeartBeat_Tick;
        }

        public void Refresh() {
            if (isConnected) {
                if (_mediaNowPlaying != _parent.NowPlaying.Get("filename", true) ||
                    _mediaNowPlaying == null) {
                    _mediaNowPlaying = _parent.NowPlaying.Get("filename");
                    _newMediaPlaying = true;
                }
                else
                    _newMediaPlaying = false;

                _isPlaying = (_parent.NowPlaying.Get("playstatus", true) == "Playing");
                _isPaused = (_parent.NowPlaying.Get("playstatus", true) == "Paused");
                _isNotPlaying = (_mediaNowPlaying == "[Nothing Playing]" || _mediaNowPlaying == null);

                if (_mediaNowPlaying == null ||
                    _isNotPlaying ||
                    _mediaNowPlaying.Length < 6)
                    _isPlayingLastFm = false;
                else
                    _isPlayingLastFm = (_mediaNowPlaying.Substring(0, 6) == "lastfm");

                var aVolume = _parent.Request("GetVolume");
                var aProgress = _parent.Request("GetPercentage");

                if (aVolume == null ||
                    aVolume[0] == "Error")
                    _volume = 0;
                else
                    _volume = Convert.ToInt32(aVolume[0]);

                if (aProgress == null ||
                    aProgress[0] == "Error" ||
                    aProgress[0] == "0" ||
                    Convert.ToInt32(aProgress[0]) > 99)
                    _progress = 1;
                else
                    _progress = Convert.ToInt32(aProgress[0]);

                _isMuted = (_volume == 0);
            }
        }

        private void HeartBeat_Tick(object sender, EventArgs e) {
            isConnected = _parent.Controls.SetResponseFormat();
            _heartBeatTimer.Interval = (isConnected) ? _connectedInterval : _disconnectedInterval;
        }

        public bool IsConnected() {
            return isConnected;
        }

        public void EnableHeartBeat() {
            HeartBeat_Tick(null, null);
            _heartBeatTimer.Enabled = true;
        }

        public void DisableHeartBeat() {
            _heartBeatTimer.Enabled = false;
        }

        public bool WebServerEnabled() {
            var webserverEnabled = _parent.Request("WebServerStatus");

            if (webserverEnabled == null)
                return false;
            return (webserverEnabled[0] == "On");
        }

        public bool IsNewMediaPlaying() {
            return _newMediaPlaying;
        }

        public bool IsPlaying(string lastfm) {
            return (lastfm != null) ? _isPlayingLastFm : _isPlaying;
        }

        public bool IsPlaying() {
            return IsPlaying(null);
        }

        public bool IsNotPlaying() {
            return _isNotPlaying;
        }

        public bool IsPaused() {
            return _isPaused;
        }

        public bool IsMuted() {
            return _isMuted;
        }

        public int GetVolume() {
            return _volume;
        }

        public int GetProgress() {
            return _progress;
        }

        public bool LastFmEnabled() {
            var aLastFmUsername = _parent.Request("GetGuiSetting(3;lastfm.username)");
            var aLastFmPassword = _parent.Request("GetGuiSetting(3;lastfm.password)");

            if (aLastFmUsername == null ||
                aLastFmPassword == null)
                return false;
            return (aLastFmUsername[0] != "" && aLastFmPassword[0] != "");
        }

        public bool RepeatEnabled() {
            var aRepeatEnabled = _parent.Request("GetGuiSetting(1;musicfiles.repeat)");
            if (aRepeatEnabled == null)
                return false;
            return (aRepeatEnabled[0] != "False");
        }
    }
}