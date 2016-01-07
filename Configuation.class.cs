using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XBMControl.Configuration
{
    class XBMControlConfiguration
    {
        private string ip;
        private string username;
        private string password;

        private struct SConfigData
        {
            string ip, username, password;
        }

        public XBMControlConfiguration()
        {
        }

        public void SaveConfiguration(string ip, string username, string password)
        {
            XmlTextWriter XMLwriter = new XmlTextWriter("configuration.xml", System.Text.Encoding.UTF8);
            XMLwriter.WriteStartElement("configuration");
            XMLwriter.WriteElementString("ip", ip);
            XMLwriter.WriteElementString("username", username);
            XMLwriter.WriteElementString("password", password);
            XMLwriter.WriteEndElement();
            XMLwriter.Flush();
            XMLwriter.Close();
        }

        public void LoadConfiguration()
        {
            SConfigData ConfigData;
            FileStream fConfigStream = new FileStream("configuraion.xml", FileMode.Open);
            XmlSerializer ConfigSerialized = new XmlSerializer(typeof(SConfigData));
            ConfigData = (SConfigData)ConfigSerialized.Deserialize(fConfigStream);
            fConfigStream.Close();
        }

    }
}
