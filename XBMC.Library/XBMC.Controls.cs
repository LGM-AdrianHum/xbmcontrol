// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Controls.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:53 AM

#region Using Directives

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "StringLiteralTypo")] public class XbmcControls {
        private readonly XbmcCommunicator _parent;

        public XbmcControls(XbmcCommunicator p) {
            _parent = p;
        }

        public void Play() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Play)");
        }

        public void PlayFile(string filename) {
            _parent.Request("PlayFile(" + filename + ")");
        }

        public void PlayMedia(string media) {
            _parent.Request("ExecBuiltIn", "PlayMedia(" + media + ")");
        }

        public void Stop() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Stop)");
        }

        public void Next() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Next)");
        }

        public void PlayListNext() {
            _parent.Request("PlayListNext");
        }

        public void Previous() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Previous)");
        }

        public void ToggleShuffle() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Random)");
        }

        public void TogglePartymode() {
            _parent.Request("ExecBuiltIn", "PlayerControl(Partymode(music))");
        }

        public void Repeat(bool enable) {
            var mode = (enable) ? "Repeat" : "RepeatOff";
            _parent.Request("ExecBuiltIn", "PlayerControl(" + mode + ")");
        }

        public void LastFmLove() {
            _parent.Request("ExecBuiltIn", "LastFM.Love(false)");
        }

        public void LastFmHate() {
            _parent.Request("ExecBuiltIn", "LastFM.Ban(false)");
        }

        public void ToggleMute() {
            _parent.Request("ExecBuiltIn", "Mute");
        }

        public void SetVolume(int percentage) {
            _parent.Request("ExecBuiltIn", "SetVolume(" + Convert.ToString(percentage) + ")");
        }

        public void SeekPercentage(int percentage) {
            _parent.Request("SeekPercentage", Convert.ToString(percentage));
        }

        public void Reboot() {
            _parent.Request("ExecBuiltIn", "Reboot");
        }

        public void Shutdown() {
            _parent.Request("ExecBuiltIn", "Shutdown");
        }

        public void Restart() {
            _parent.Request("ExecBuiltIn", "RestartApp");
        }

        public string GetGuiDescription(string field) {
            string returnValue = null;
            var aGuiDescription = _parent.Request("GetGUIDescription");

            foreach (var t in aGuiDescription) {
                var splitIndex = t.IndexOf(':') + 1;
                if (splitIndex <= 1) continue;
                var resultField = t.Substring(0, splitIndex - 1).
                    Replace(" ", "").
                    ToLower();
                if (resultField == field) returnValue = t.Substring(splitIndex, t.Length - splitIndex);
            }

            return returnValue;
        }

        public string GetScreenshotBase64() {
            var base64Screenshot = _parent.Request("takescreenshot", "screenshot.png;false;0;" + GetGuiDescription("width") + ";" + GetGuiDescription("height") + ";75;true;");
            return (base64Screenshot == null) ? null : base64Screenshot[0];
        }

        public Image Base64StringToImage(string base64String) {
            Bitmap file = null;
            var bytes = Convert.FromBase64String(base64String);
            var stream = new MemoryStream(bytes);

            if (!string.IsNullOrEmpty(base64String))
                file = new Bitmap(Image.FromStream(stream));

            return file;
        }

        public Image GetScreenshot() {
            Image screenshot = null;
            var base64ImageString = GetScreenshotBase64();

            if (base64ImageString != null &&
                !base64ImageString.Contains("Error"))
                screenshot = Base64StringToImage(base64ImageString);

            return screenshot;
        }

        public void UpdateLibrary(string library) {
            if (library == "music" ||
                library == "video")
                _parent.Request("ExecBuiltIn", "updatelibrary(" + library + ")");
        }

        public bool SetResponseFormat() {
            string[] aResult = null;
            var ip = _parent.GetIp();

            if (!string.IsNullOrEmpty(ip))
                aResult = _parent.Request("SetResponseFormat", null, ip);

            if (aResult == null)
                return false;
            return (aResult[0] == "OK");
        }
    }
}