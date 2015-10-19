// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMC.Media.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:54 AM

#region Using Directives

using System.Diagnostics.CodeAnalysis;

#endregion

namespace XBMC {
    [SuppressMessage("ReSharper", "ExceptionNotDocumented")] public class XbmcMedia {
        private readonly XbmcCommunicator _parent;

        public XbmcMedia(XbmcCommunicator p) {
            _parent = p;
        }

        public string[] GetShares(string type, bool path) {
            var aMediaShares = _parent.Request("GetShares(" + type + ")");

            if (aMediaShares != null) {
                var aShareNames = new string[aMediaShares.Length];
                var aSharePaths = new string[aMediaShares.Length];

                for (var x = 0; x < aMediaShares.Length; x++) {
                    var aTmpShare = aMediaShares[x].Split(';');

                    aShareNames[x] = aTmpShare[0];
                    aSharePaths[x] = aTmpShare[1];
                }

                return (path) ? aSharePaths : aShareNames;
            }
            return null;
        }

        public string[] GetShares(string type) {
            return GetShares(type, false);
        }

        public string[] GetDirectoryContentPaths(string directory, string mask) {
            mask = (mask == null) ? "" : ";" + mask;

            var aDirectoryContent = _parent.Request("GetDirectory(" + directory + mask + ")");

            if (aDirectoryContent != null) {
                var aContentPaths = new string[aDirectoryContent.Length];

                for (var x = 0; x < aDirectoryContent.Length; x++) {
                    aDirectoryContent[x] = aDirectoryContent[x].Replace("/", "\\");
                    aContentPaths[x] = (aDirectoryContent[x] == "Error:Not folder" || aDirectoryContent[x] == "Error") ? null : aDirectoryContent[x];
                }
                return aContentPaths;
            }
            return null;
        }

        public string[] GetDirectoryContentPaths(string directory) {
            return GetDirectoryContentPaths(directory, null);
        }

        public string[] GetDirectoryContentNames(string directory, string mask) {
            var aContentPaths = GetDirectoryContentPaths(directory, mask);

            if (aContentPaths != null) {
                var aContentNames = new string[aContentPaths.Length];

                for (var x = 0; x < aContentPaths.Length; x++) {
                    if (aContentPaths[x] == null ||
                        aContentPaths[x] == "")
                        aContentNames[x] = null;
                    else {
                        aContentPaths[x] = aContentPaths[x].Replace("/", "\\");
                        var aTmpContent = aContentPaths[x].Split('\\');
                        aContentNames[x] = (aTmpContent[aTmpContent.Length - 1] == "") ? aTmpContent[aTmpContent.Length - 2] : aTmpContent[aTmpContent.Length - 1];
                    }
                }

                return aContentNames;
            }
            return null;
        }

        public string[] GetDirectoryContentNames(string directory) {
            return GetDirectoryContentNames(directory, null);
        }
    }
}