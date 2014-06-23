using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Client.Utils;

namespace Client.Logic
{
    public static class AddressManager
    {
        private static readonly string _fullPath = Path.Combine(Application.StartupPath, "AppData/");
        private const string _fileName = "Address.xml";

        private static void CheckIfDirectoryExists()
        {
            if (!Directory.Exists(_fullPath)) Directory.CreateDirectory(_fullPath);
        }

        private static bool CheckIfFileExists()
        {
            return File.Exists(Path.Combine(_fullPath, _fileName));
        }

        public static List<AddressModel> GetXml()
        {
            CheckIfDirectoryExists();
            if (!CheckIfFileExists()) return new List<AddressModel>();

            XDocument doc = XDocument.Load(Path.Combine(_fullPath, _fileName));
            var addresses = from b in doc.Descendants("Address")
                select new AddressModel
                {
                    Favorite = (bool)b.Attribute("FAVORITE"),
                    HostIp = (string)b.Attribute("HOST_IP"),
                    HostPort = (int)b.Attribute("HOST_PORT")
                };

            return (List<AddressModel>) addresses;
        }

        public static void SetXml(List<AddressModel> addresses)
        {
            CheckIfDirectoryExists();
            if (CheckIfFileExists())
            {
                File.Delete(Path.Combine(_fullPath, _fileName));
            }

            XDocument xDocument = new XDocument();

            XElement sectionXML = new XElement("Addresses", (
                addresses.Select(x => new XElement("Address",
                    new XAttribute("HOST_IP", x.HostIp),
                    new XAttribute("HOST_PORT", x.HostPort),
                    new XAttribute("FAVORITE", x.Favorite)
            ))));

            xDocument.Add(sectionXML);
            xDocument.Save(Path.Combine(_fullPath, _fileName), SaveOptions.None);
        }
    }
}
