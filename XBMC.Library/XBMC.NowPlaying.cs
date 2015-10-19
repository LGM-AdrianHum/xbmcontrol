// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.NowPlaying.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:54 AM

#region Using Directives

using System;
using System.Drawing;
using System.IO;
using System.Net;

#endregion

namespace XBMC {
    public class XbmcNowPlaying {
        private readonly XbmcCommunicator _parent;
        private string _error;
        private string[,] _maNowPlayingInfo;

        public XbmcNowPlaying(XbmcCommunicator p) {
            _parent = p;
        }

        public string Get(string field, bool refresh) {
            string returnValue = null;

            if (refresh) {
                var aNowPlayingTemp = _parent.Request("GetCurrentlyPlaying");

                if (aNowPlayingTemp != null) {
                    _maNowPlayingInfo = new string[aNowPlayingTemp.Length, 2];
                    for (var x = 0; x < aNowPlayingTemp.Length; x++) {
                        var splitIndex = aNowPlayingTemp[x].IndexOf(':') + 1;

                        if (splitIndex > 2) {
                            _maNowPlayingInfo[x, 0] = aNowPlayingTemp[x].Substring(0, splitIndex - 1).
                                Replace(" ", "").
                                ToLower();
                            _maNowPlayingInfo[x, 1] = aNowPlayingTemp[x].Substring(splitIndex, aNowPlayingTemp[x].Length - splitIndex);

                            if (_maNowPlayingInfo[x, 0] == field)
                                returnValue = _maNowPlayingInfo[x, 1];
                        }
                    }
                }
            }
            else
                for (var x = 0; x < _maNowPlayingInfo.GetLength(0); x++) {
                    if (_maNowPlayingInfo[x, 0] == field)
                        returnValue = _maNowPlayingInfo[x, 1];
                }

            return returnValue;
        }

        public string Get(string field) {
            return Get(field, false);
        }

        public Image GetCoverArt() {
            string[] stringList;
            MemoryStream stream = null;
            Image thumbnail = null;
            var client = new WebClient();
            var xbmcThumbUri = new Uri("http://" + _parent.GetIp() + "/thumb.jpg");
            stringList = _parent.Request("GetCurrentlyPlaying", "q:/web/thumb.jpg");

            try {
                stream = new MemoryStream(client.DownloadData(xbmcThumbUri));
                thumbnail = new Bitmap(Image.FromStream(stream));
            }
            catch (Exception e) {
                _error = e.Message;
            }
            finally { client.Dispose(); }

            return thumbnail;
        }

        public string GetMediaType() {
            return Get("type", true);
        }
    }
}