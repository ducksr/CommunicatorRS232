using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RS232_Communicator.Utilities
{

    internal class GlobalsSettings
    {
        readonly NameValueCollection? _configSettings =
           ConfigurationManager.GetSection("appSettings") as NameValueCollection;




        // Config System
        public  string SerialPort => _configSettings["SerialPort"].Trim() ?? "5";
        public string BaundRate => _configSettings["BaundRate"].Trim() ?? "9600";
        public string DataBits => _configSettings["DataBits"].Trim() ?? "7";
        public string StopBits => _configSettings["StopBits"].Trim() ?? "2";
        public string Parity => _configSettings["Parity"].Trim() ?? "Even";
        public string FlowControl => _configSettings["FlowControl"].Trim() ?? "None";


        public void SaveConfig(string configname,string newvalue) {
            string filePath = "RS232 Communicator.dll.config";

            // Cargar el archivo XML
            XDocument config = XDocument.Load(filePath);

            // Verificar si hay un namespace (xmlns)
            XNamespace ns = config.Root?.GetDefaultNamespace() ?? XNamespace.None;

            // Buscar el nodo <appSettings>
            XElement? appSettings = config.Descendants(ns + "appSettings").FirstOrDefault();

            if (appSettings != null)
            {
                // Buscar la clave "BaudRate"
                XElement? value = appSettings.Elements(ns + "add")
                    .FirstOrDefault(e => (string?)e.Attribute("key") == configname);

                if (value != null)
                {
                    value.SetAttributeValue("value", newvalue);
                    config.Save(filePath);

                }
            }
            else
            {
                MessageBox.Show("⚠️ No Configuration AppSettings Found!");
            }
        }


    }

}
