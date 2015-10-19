// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Database.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:53 AM

#region Using Directives

using System.Diagnostics.CodeAnalysis;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "ExceptionNotDocumented")] public class XbmcDatabase {
        private readonly XbmcCommunicator _parent;

        public XbmcDatabase(XbmcCommunicator p) {
            _parent = p;
        }

        public string[] GetArtists(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE strArtist LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryMusicDatabase", "SELECT strArtist FROM artist" + condition + " ORDER BY strArtist");
        }

        public string[] GetArtists() {
            return GetArtists(null);
        }

        public string[] GetArtistIds(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE strArtist LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryMusicDatabase", "SELECT idArtist FROM artist" + condition + " ORDER BY strArtist");
        }

        public string[] GetArtistIds() {
            return GetArtistIds(null);
        }

        public string[] GetAlbums(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE strAlbum LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryMusicDatabase", "SELECT strAlbum FROM album" + condition + " ORDER BY strAlbum");
        }

        public string[] GetAlbums() {
            return GetAlbums(null);
        }

        public string[] GetAlbumIds(string searchString) {
            var condition = (searchString == null) ? "" : " WHERE strAlbum LIKE '%%" + searchString + "%%'";
            return _parent.Request("QueryMusicDatabase", "SELECT idAlbum FROM album" + condition + " ORDER BY strAlbum");
        }

        public string[] GetAlbumIds() {
            return GetAlbumIds(null);
        }

        public string GetArtistId(string artist) {
            var aArtistId = _parent.Request("QueryMusicDatabase", "SELECT idArtist FROM artist WHERE strArtist='" + artist + "'");
            return (aArtistId != null) ? aArtistId[0] : null;
        }

        public string GetAlbumId(string artist, string album) {
            var conditions = " WHERE strAlbum='" + album + "'";
            if (artist != null) conditions += " AND idArtist='" + GetArtistId(artist) + "'";
            var aArtistId = _parent.Request("QueryMusicDatabase", "SELECT idAlbum FROM album" + conditions);
            return (aArtistId != null) ? aArtistId[0] : null;
        }

        public string GetAlbumId(string album) {
            return GetAlbumId(null, album);
        }

        public string GetPathById(string pathId) {
            var aPath = _parent.Request("QueryMusicDatabase", "SELECT strPath FROM path WHERE idPath='" + pathId + "'");
            return (aPath != null) ? aPath[0] : null;
        }

        public string GetAlbumPath(string albumId) {
            var aPathId = _parent.Request("QueryMusicDatabase", "SELECT idPath FROM song WHERE idAlbum='" + albumId + "'");
            return (aPathId != null) ? GetPathById(aPathId[0]) : null;
        }

        public string GetSongPath(string songId) {
            var aPathId = _parent.Request("QueryMusicDatabase", "SELECT idPath FROM song WHERE idSong='" + songId + "'");
            return (aPathId != null) ? GetPathById(aPathId[0]) : null;
        }

        public string[] GetAlbumsByArtist(string artist) {
            return GetAlbumsByArtistId(GetArtistId(artist));
        }

        public string[] GetAlbumsByArtistId(string artistId) {
            return (artistId == null) ? null : _parent.Request("QueryMusicDatabase", "SELECT strAlbum FROM album WHERE idArtist='" + artistId + "' ORDER BY strAlbum");
        }

        public string[] GetAlbumIdsByArtist(string artist) {
            return GetAlbumIdsByArtistId(GetArtistId(artist));
        }

        public string[] GetAlbumIdsByArtistId(string artistId) {
            return (artistId == null) ? null : _parent.Request("QueryMusicDatabase", "SELECT idAlbum FROM album WHERE idArtist='" + artistId + "' ORDER BY strAlbum");
        }

        public string[] GetTitlesByAlbum(string artist, string album) {
            return GetTitlesByAlbumId(GetAlbumId(artist, album));
        }

        public string[] GetTitlesByAlbum(string album) {
            return GetTitlesByAlbum(null, album);
        }

        public string[] GetTitlesByAlbumId(string albumId) {
            return (albumId == null) ? null : _parent.Request("QueryMusicDatabase", "SELECT strTitle FROM song WHERE idAlbum='" + albumId + "' ORDER BY iTrack");
        }

        public string[] GetPathsByAlbum(string artist, string album) {
            return GetPathsByAlbumId(GetAlbumId(artist, album));
        }

        public string[] GetPathsByAlbum(string album) {
            return GetPathsByAlbum(null, album);
        }

        public string[] GetPathsByAlbumId(string albumId) {
            string[] aPath = null;

            if (albumId != null) {
                var aFileName = _parent.Request("QueryMusicDatabase", "SELECT strFileName FROM song WHERE idAlbum='" + albumId + "' ORDER BY iTrack");

                if (aFileName != null) {
                    aPath = new string[aFileName.Length];
                    aPath[0] = "";

                    for (var x = 0; x < aFileName.Length; x++)
                        aPath[x] = GetAlbumPath(albumId) + aFileName[x];
                }
            }

            return aPath;
        }

        public string[] GetSearchSongTitles(string searchString) {
            return _parent.Request("QueryMusicDatabase", "SELECT strTitle FROM song WHERE strTitle LIKE '%%" + searchString + "%%' ORDER BY strTitle");
        }

        public string[] GetSearchSongPaths(string searchString) {
            string[] aSongPaths = null;
            var aSongPathIds = _parent.Request("QueryMusicDatabase", "SELECT idPath FROM song WHERE strTitle LIKE '%%" + searchString + "%%' ORDER BY strTitle");
            var aFileNames = _parent.Request("QueryMusicDatabase", "SELECT strFileName FROM song WHERE strTitle LIKE '%%" + searchString + "%%' ORDER BY strTitle");

            if (aSongPathIds != null) {
                aSongPaths = new string[aSongPathIds.Length];

                for (var x = 0; x < aSongPathIds.Length; x++) {
                    var aSongPath = _parent.Request("QueryMusicDatabase", "SELECT strPath FROM path WHERE idPath='" + aSongPathIds[x] + "'");
                    aSongPaths[x] = aSongPath[0] + aFileNames[x];
                }
            }

            return aSongPaths;
        }

        public string[] GetTitlesByArtist(string artist) {
            return GetTitlesByArtistId(GetArtistId(artist));
        }

        public string[] GetTitlesByArtistId(string artistId) {
            return (artistId == null) ? null : _parent.Request("QueryMusicDatabase", "SELECT strTitle FROM song WHERE idArtist='" + artistId + "' ORDER BY iTrack");
        }

        public string[] GetPathsByArtist(string artist) {
            return GetPathsByArtistId(GetArtistId(artist));
        }

        public string[] GetPathsByArtistId(string artistId) {
            if (artistId == null) return null;
            var aSongPathIds = _parent.Request("QueryMusicDatabase", "SELECT idPath FROM song WHERE idArtist='" + artistId + "'");
            var aFileNames = _parent.Request("QueryMusicDatabase", "SELECT strFileName FROM song WHERE idArtist='" + artistId + "'");

            if (aFileNames == null) return null;
            var aPaths = new string[aFileNames.Length];
            for (var x = 0; x < aFileNames.Length; x++)
                aPaths[x] = GetPathById(aSongPathIds[x]) + aFileNames[x];

            return aPaths;
        }

        public string GetPathBySongTitle(string artistAlbumId, string songTitle, bool artist) {
            string songPath = null;
            var idField = (artist) ? "idArtist" : "idAlbum";
            var aSongPathIds = _parent.Request("QueryMusicDatabase", "SELECT idPath FROM song WHERE " + idField + "='" + artistAlbumId + "' AND strTitle='" + songTitle + "'");
            var aSongFileNames = _parent.Request("QueryMusicDatabase", "SELECT strFileName FROM song WHERE " + idField + "='" + artistAlbumId + "' AND strTitle='" + songTitle + "'");

            if (aSongPathIds != null) {
                var aSongPaths = _parent.Request("QueryMusicDatabase", "SELECT strPath FROM path WHERE idPath='" + aSongPathIds[0] + "'");

                if (aSongPaths != null)
                    songPath = aSongPaths[0] + aSongFileNames[0];
            }

            return songPath;
        }

        public string GetPathBySongTitle(string artistAlbumId, string songTitle) {
            return GetPathBySongTitle(artistAlbumId, songTitle, false);
        }
    }
}