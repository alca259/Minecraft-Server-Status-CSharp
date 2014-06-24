using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Client.Utils;

namespace Client.Logic
{
    public static class AddressManager
    {
        #region Constants
        private const string _fileName = "Address.xml";
        private const string _folderName = "AppData";
        #endregion

        #region Vars
        private static string _fullDirPath;
        private static string _fullFilePath;
        private static List<AddressModel> _addresses = new List<AddressModel>();
        #endregion

        #region Initialize
        public static void Initialize()
        {
            _fullDirPath = Path.Combine(Application.StartupPath, _folderName);
            _fullFilePath = Path.Combine(_fullDirPath, _fileName);
            GetXml();
        }
        #endregion

        #region List Management
        private static bool Exists(AddressModel address)
        {
            return false;
        }
        public static void Add(AddressModel address)
        {
            
        }
        public static void Remove(AddressModel address)
        {

        }
        #endregion

        #region Utils file & directory
        private static void CheckIfDirectoryExists()
        {
            if (!Directory.Exists(_fullDirPath)) Directory.CreateDirectory(_fullDirPath);
        }

        private static bool CheckIfFileExists()
        {
            return File.Exists(_fullFilePath);
        }
        #endregion

        #region Load & Save XML
        private static void GetXml()
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            // Si no existe el fichero devolvemos
            if (!CheckIfFileExists()) return;

            // Cargamos el fichero XML
            XDocument doc = XDocument.Load(_fullFilePath);

            // Nos recorremos todas y las guardamos
            _addresses = (List<AddressModel>)from b in doc.Descendants("Address")
                select new AddressModel
                {
                    HostIp = (string)b.Attribute("HOST_IP"),
                    HostPort = (int)b.Attribute("HOST_PORT"),
                    Favorite = (bool)b.Attribute("FAVORITE")
                };
        }

        private static void SetXml()
        {
            // Comprobamos si existe el directorio
            CheckIfDirectoryExists();

            // Si existe el fichero, lo borramos
            if (CheckIfFileExists())
            {
                File.Delete(_fullFilePath);
            }

            // Creamos un nuevo XDocument
            XDocument xDocument = new XDocument();

            // Creamos un elemento
            XElement sectionXML = new XElement("Addresses", (
                _addresses.Select(x => new XElement("Address",
                    new XAttribute("HOST_IP", x.HostIp),
                    new XAttribute("HOST_PORT", x.HostPort),
                    new XAttribute("FAVORITE", x.Favorite)
            ))));

            // Lo añadimos al XDocument
            xDocument.Add(sectionXML);

            // Guardamos el XDocument en disco
            xDocument.Save(_fullFilePath, SaveOptions.None);
        }
        #endregion
    }
}

