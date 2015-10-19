// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Communicator.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:49 AM

#region Using Directives

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Text;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "ExceptionNotDocumented"), SuppressMessage("ReSharper", "CatchAllClause"), SuppressMessage("ReSharper", "CyclomaticComplexity"), SuppressMessage("ReSharper", "StringLiteralTypo"), SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional"), SuppressMessage("ReSharper", "AssignNullToNotNullAttribute"),
     SuppressMessage("ReSharper", "IdentifierTypo")]       public class XbmcCommunicator {
        private readonly string _apiPath = "/xbmcCmds/xbmcHttp";
        private readonly string _logFile = "log/xbmcontrol.log";
        private string _configuredIp;
        private int _connectionTimeout = 2000;
        private string _xbmcPassword;
        private string _xbmcUsername;
        public XbmcControls Controls;
        public XbmcDatabase Database;
        public XbmcMedia Media;
        public XbmcNowPlaying NowPlaying;
        public XbmcPlaylist Playlist;
        public XbmcStatus Status;
        public XbmcVideo Video;

        public XbmcCommunicator() {
            Database = new XbmcDatabase(this);
            Playlist = new XbmcPlaylist(this);
            Controls = new XbmcControls(this);
            NowPlaying = new XbmcNowPlaying(this);
            Status = new XbmcStatus(this);
            Media = new XbmcMedia(this);
            Video = new XbmcVideo(this);
        }

        private string[] MySplitString(string stringToBeSplitted, string delimeter) {
            if (string.IsNullOrEmpty(stringToBeSplitted))
                throw new ArgumentNullException("stringToBeSplitted");
            if (delimeter == null)
                throw new ArgumentNullException("delimeter");

            var dsum = 0;
            var ssum = 0;
            var dl = delimeter.Length;
            var sl = stringToBeSplitted.Length;

            if (dl == 0 ||
                sl == 0 ||
                sl < dl)
                return new[] {stringToBeSplitted};

            var cd = delimeter.ToCharArray();
            var cs = stringToBeSplitted.ToCharArray();

            var list = new List<string>();

            for (var i = 0; i < dl; i++) {
                dsum += cd[i];
                ssum += cs[i];
            }

            var start = 0;
            for (var i = start; i < sl - dl; i++) {
                if (i >= start &&
                    dsum == ssum &&
                    stringToBeSplitted.Substring(i, dl) == delimeter) {
                    list.Add(stringToBeSplitted.Substring(start, i - start));
                    start = i + dl;
                }

                ssum += cs[i + dl] - cs[i];
            }

            if (dsum == ssum &&
                stringToBeSplitted.Substring(sl - dl, dl) == delimeter) {
                list.Add(stringToBeSplitted.Substring(start, sl - dl - start));
                list.Add("");
            }
            else
                list.Add(stringToBeSplitted.Substring(start, sl - start));

            return list.ToArray();
        }

        public string[] Request(string command, string parameter, string ip) {
            string[] pageItems = null;
            HttpWebResponse response = null;
            StreamReader reader = null;

            var isQuery = (command.ToLower() == "querymusicdatabase" || command.ToLower() == "queryvideodatabase");

            var ipAddress = ip ?? _configuredIp;
            parameter = parameter ?? "";
            command = "?command=" + Uri.EscapeDataString(command);
            command += string.IsNullOrEmpty(parameter) ? "" : "&parameter=" + Uri.EscapeDataString(parameter);
            var uri = "http://" + ipAddress + _apiPath + command;

            //WriteToLog(uri);

            try {
                var request = (HttpWebRequest) WebRequest.Create(uri);
                request.Method = "GET";
                request.Timeout = _connectionTimeout;
                if (_xbmcUsername != "" &&
                    _xbmcPassword != "") request.Credentials = new NetworkCredential(_xbmcUsername, _xbmcPassword);
                response = (HttpWebResponse) request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                string[] pageContent;
                string tempString;
                if (isQuery) {
                    tempString = reader.ReadToEnd().
                        Replace("</field>", "").
                        Replace("\n", "").
                        Replace("<html>", "").
                        Replace("</html>", "");
                    pageContent = MySplitString(tempString, "<field>");
                }
                else {
                    tempString = reader.ReadToEnd().
                        Replace("\n", "").
                        Replace("<html>", "").
                        Replace("</html>", "");
                    pageContent = MySplitString(tempString, "<li>");
                }

                if (pageContent != null)
                    if (pageContent.Length > 1) {
                        pageItems = new string[pageContent.Length - 1];

                        for (var x = 1; x < pageContent.Length; x++)
                            pageItems[x - 1] = pageContent[x];
                    }
                    else {
                        pageItems = new string[1];
                        pageItems[0] = pageContent[0];
                    }
            }
            catch (WebException e) {
                WriteToLog("ERROR - " + e.Message);
            }
            finally {
                if (response != null) response.Close();
                if (reader != null) reader.Close();
            }

            return pageItems;
        }

        public string[] Request(string command, string parameter) {
            return Request(command, parameter, null);
        }

        public string[] Request(string command) {
            return Request(command, null, null);
        }

        private void WriteToLog(string message) {
            StreamWriter sw = null;

            try {
                sw = new StreamWriter(_logFile, true);
                sw.WriteLine(DateTime.Now + " : " + message);
            }
            catch (Exception) {
                // ignored
            }

            if (sw == null) return;
            sw.Flush();
            sw.Close();
        }

        public void SetIp(string ip) {
            _configuredIp = ip;

            if (string.IsNullOrEmpty(_configuredIp))
                Status.DisableHeartBeat();
            else
                Status.EnableHeartBeat();
        }

        public string GetIp() {
            return _configuredIp;
        }

        public void SetCredentials(string username, string password) {
            _xbmcUsername = username;
            _xbmcPassword = password;
        }

        public void SetConnectionTimeout(int timeOut) {
            _connectionTimeout = timeOut;
        }
    }
}