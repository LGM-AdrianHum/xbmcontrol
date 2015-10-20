// Author: Hum, Adrian
// Project: XBMControl/XBMControl/XBMControl.Language.cs
//
// Created  Date: 2015-10-20  8:59 AM
// Modified Date: 2015-10-20  9:42 AM

#region Using Directives

using System;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using XBMControl.Properties;

#endregion

namespace XBMControl.Language {
    public class XbmcLanguage {
        private readonly DirectoryInfo _execPath;
        //private string languageFilePath;
        private readonly XmlDocument _languageFile;
        private XmlNode _languageNode;

        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        public XbmcLanguage() {
            _languageFile = new XmlDocument();
            var directoryName = Path.GetDirectoryName(Application.ExecutablePath);

            try { if (directoryName != null)
                _execPath = new DirectoryInfo(directoryName + "\\language\\"); }
            catch (ArgumentException) {
                //
            }
        }

        public string[] GetAvailableLanguages() {
            var languages = new string[4];

            languages[0] = "english";
            languages[1] = "francais";
            languages[2] = "nederlands";
            languages[3] = "german";
            return languages;
        }

        /// <exception cref="XmlException">
        ///     There is a load or parse error in the XML. In this case, a
        ///     <see cref="T:System.IO.FileNotFoundException" /> is raised.
        /// </exception>
        /// <exception cref="ArgumentNullException"><paramref name="buffer" /> is null. </exception>
        public void SetLanguage(string language) {
            string tempString;

            switch (language) {
                case "english":
                    tempString = Resources.english;
                    break;
                case "francais":
                    tempString = Resources.francais;
                    break;
                case "nederlands":
                    tempString = Resources.nederlands;
                    break;
                case "german":
                    tempString = Resources.german;
                    break;
                default:
                    tempString = Resources.english;
                    break;
            }

            try {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(tempString));
                _languageFile.Load(stream);
            }
            catch (EncoderFallbackException) {
                //
            }
        }

        /// <exception cref="XPathException">The XPath expression contains a prefix. </exception>
        public string GetString(string node) {
            if (_languageFile.DocumentElement != null) _languageNode = _languageFile.DocumentElement.SelectSingleNode("/language/" + node);
            return _languageNode != null ? _languageNode.InnerText.Replace("\\n", "\n") : string.Empty;
        }
    }
}