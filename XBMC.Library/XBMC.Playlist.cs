// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Playlist.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:54 AM

#region Using Directives

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "ExceptionNotDocumented")] public class XbmcPlaylist {
        private readonly XbmcCommunicator _parent;
        private string[] _aCurrentPlaylist;

        public XbmcPlaylist(XbmcCommunicator p) {
            _parent = p;
        }

        public string[] Get(bool parse, bool refresh) {
            if (refresh) {
                var aPlaylistTemp = _parent.Request("GetPlaylistContents(GetCurrentPlaylist)");

                if (parse) {
                    if (aPlaylistTemp != null) {
                        _aCurrentPlaylist = new string[aPlaylistTemp.Length];
                        for (var x = 0; x < aPlaylistTemp.Length; x++) {
                            var i = aPlaylistTemp[x].LastIndexOf(".", StringComparison.Ordinal);
                            if (i > 1) {
                                var extension = aPlaylistTemp[x].Substring(i, aPlaylistTemp[x].Length - i);
                                aPlaylistTemp[x] = aPlaylistTemp[x].Replace("/", "\\");
                                var aPlaylistEntry = aPlaylistTemp[x].Split('\\');
                                var playlistEntry = aPlaylistEntry[aPlaylistEntry.Length - 1].Replace(extension, "");
                                _aCurrentPlaylist[x] = playlistEntry;
                            }
                            else
                                _aCurrentPlaylist[x] = "";
                        }
                    }
                }
                else
                    _aCurrentPlaylist = aPlaylistTemp;
            }

            return _aCurrentPlaylist;
        }

        public void PlaySong(int position) {
            _parent.Request("SetPlaylistSong(" + position + ")");
        }

        public void Remove(int position) {
            _parent.Request("RemoveFromPlaylist(" + position + ")");
        }

        public string GetCurrentIdentifier() {
            var curPlaylist = _parent.Request("GetCurrentPlaylist()");
            return (curPlaylist == null) ? null : curPlaylist[0];
        }

        public void Clear() {
            _parent.Request("ClearPlayList()");
        }

        public void AddDirectoryContent(string folderPath, string mask, bool recursive) {
            var p = "";
            var m = "";
            var r = "";

            if (mask != null) {
                m = ";[" + mask + "]";
                p = ";0";
                r = (recursive) ? ";1" : ";0";
            }

            _parent.Request("AddToPlayList(" + folderPath + p + m + r + ")");
        }

        public void AddDirectoryContent(string folderPath, string mask) {
            AddDirectoryContent(folderPath, mask, false);
        }

        public void AddFilesToPlaylist(string filePath) {
            AddDirectoryContent(filePath, null);
        }

        public void SetSong(int position) {
            _parent.Request("SetPlaylistSong(" + position + ")");
        }

        public void SetType(string type) {
            var playlistType = (type == "video") ? "1" : "0";
            _parent.Request("SetCurrentPlaylist(" + playlistType + ")");
        }
    }
}