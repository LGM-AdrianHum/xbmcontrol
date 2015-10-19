// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Video.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  10:07 AM

#region Using Directives

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Text;
using XBMControl.Properties;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "InconsistentNaming"), SuppressMessage("ReSharper", "IdentifierTypo"), SuppressMessage("ReSharper", "StringLiteralTypo"), SuppressMessage("ReSharper", "CatchAllClause")] public class XbmcVideo {
        private readonly XbmcCommunicator _parent;

        public XbmcVideo(XbmcCommunicator p) {
            _parent = p;
        }

        /// <exception cref="ArgumentNullException"><paramref name="input" /> is null. </exception>
        /// <exception cref="FormatException">
        ///     The format item in <paramref name="mCrc" /> is invalid.-or- The index of a format
        ///     item is not zero.
        /// </exception>
        public string Hash(string input) {
            var mCrc = 0xffffffff;
            var encoding = new ASCIIEncoding();
            var bytes = encoding.GetBytes(input.ToLower());
            foreach (var myByte in bytes) {
                mCrc ^= ((uint) (myByte) << 24);
                for (var i = 0; i < 8; i++) {
                    if ((Convert.ToUInt32(mCrc) & 0x80000000) == 0x80000000)
                        mCrc = (mCrc << 1) ^ 0x04C11DB7;
                    else
                        mCrc <<= 1;
                }
            }
            return string.Format("{0:x8}", mCrc);
        }

        public Image GetVideoThumb(string videoId) {
            Image retThumbnail = Resources.video_32x32;

            var condition = (videoId == null) ? "" : " WHERE C09 LIKE '%%" + videoId + "%%'";
            var strPath = _parent.Request("QueryVideoDatabase", "SELECT strpath FROM movieview " + condition);
            var hashName = Hash(strPath[0] + "VIDEO_TS.IFO");
            var ipString = "P:\\Thumbnails\\Video\\" + hashName[0] + "\\" + hashName + ".tbn";
            var fileExist = _parent.Request("FileExists", ipString);

            if (fileExist[0] != "True") return retThumbnail;
            try {
                var downloadData = _parent.Request("FileDownload", ipString);

                // Convert Base64 String to byte[]
                var imageBytes = Convert.FromBase64String(downloadData[0]);
                var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                retThumbnail = Image.FromStream(ms, true);
            }
            catch {
                // ignored
            }

            return retThumbnail;
        }

        public string GetVideoPath(string movieName) {
            var condition = (movieName == null) ? "" : " WHERE C00 LIKE '%%" + movieName + "%%'";
            var tempStringList = _parent.Request("QueryVideoDatabase", "SELECT strpath FROM movieview " + condition);
            var tempString = tempStringList[0];
            tempString += "VIDEO_TS.IFO";
            return tempString;
        }

        public string[] GetVideoNames(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE C00 LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryVideoDatabase", "SELECT C00 FROM movie " + condition);
        }

        public string[] GetVideoNames() {
            return GetVideoNames(null);
        }

        public string[] GetVideoYears(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE C00 LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryVideoDatabase", "SELECT C07 FROM movie " + condition);
        }

        public string[] GetVideoYears() {
            return GetVideoYears(null);
        }

        public string[] GetVideoIMDB(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE C00 LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryVideoDatabase", "SELECT C09 FROM movie " + condition);
        }

        public string[] GetVideoIMDB() {
            return GetVideoIMDB(null);
        }

        public string[] GetVideoIds(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE C00 LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryVideoDatabase", "SELECT idMovie FROM movie" + condition + " ORDER BY idMovie");
        }

        public string[] GetVideoIds() {
            return GetVideoIds(null);
        }

        public string[] GetVideoLibraryInfo(string videoId) {
            var condition = (videoId == null) ? "" : " WHERE C09 LIKE '%%" + videoId + "%%'";
            return _parent.Request("QueryVideoDatabase", "SELECT * FROM movie " + condition);
        }

        public void SendAction(string buttonAction) {
            _parent.Request("action", buttonAction);
        }
    }
}