using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using MSSModels;

namespace MSSClient.Logic
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
            try
            {
                return _addresses.Any(w => w.HostIp == address.HostIp &&
                                           w.HostPort == address.HostPort);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void Add(AddressModel address)
        {
            if (address != null && !Exists(address))
            {
                // Insert
                _addresses.Add(address);
                SetXml();
            }
            else if (address != null)
            {
                // Update
                foreach (AddressModel model in _addresses.Where(w => w.Id == address.Id))
                {
                    model.HostIp = address.HostIp;
                    model.HostPort = address.HostPort;
                    model.Favorite = address.Favorite;
                    //model.Response = address.Response;
                    SetXml();
                }
            }
        }
        public static void Remove(AddressModel address)
        {
            if (address != null && Exists(address))
            {
                // Delete
                _addresses.Remove(address);
                SetXml();
            }
        }
        public static List<AddressModel> GetAll()
        {
            return _addresses;
        }
        public static AddressModel Get(Guid Id)
        {
            return _addresses.Find(f => f.Id == Id);
        }
        public static AddressModel Get(string HostIp, string HostPort)
        {
            try
            {
                AddressModel model = _addresses.Find(w => w.HostIp == HostIp &&
                                           w.HostPort == int.Parse(HostPort));
                return model ?? new AddressModel();
            }
            catch (Exception)
            {
                return new AddressModel();
            }
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
            var data = from b in doc.Descendants("Address")
                select new AddressModel
                {
                    Id = (Guid)b.Attribute("ID"),
                    HostIp = (string)b.Attribute("HOST_IP"),
                    HostPort = (int)b.Attribute("HOST_PORT"),
                    Favorite = (bool)b.Attribute("FAVORITE")
                };

            _addresses = data.ToList();
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
                    new XAttribute("ID", x.Id),
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

