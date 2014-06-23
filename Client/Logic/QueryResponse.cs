using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Logic 
{
    public class QueryResponse
    {
        #region Variables
        private readonly string _motd;
        private readonly string _gameMode;
        private readonly string _mapName;
        private readonly string _hostIP;
        private readonly string _gameID;
        private readonly string _version;
        private string _serverInfo;
        private readonly int _onlinePlayers;
        private readonly int _maxPlayers;
        private readonly int _hostPort;
        private List<string> _playerList;
        private List<string> _pluginList;
        #endregion

        #region Constructores
        public QueryResponse() {}
        public QueryResponse(byte[] data)
        {
            List<string> datos = SplitByteArray(data);

            _motd = datos[3];
            _gameMode = datos[5];
            _gameID = datos[7];
            _version = datos[9];
            _mapName = datos[13];
            _onlinePlayers = int.Parse(datos[15]);
            _maxPlayers = int.Parse(datos[17]);
            _hostPort = int.Parse(datos[19]);
            _hostIP = datos[21];

            SetPluginList(datos[11]);
            SetPlayerList(datos);
        }
        #endregion

        #region Setters
        private void SetPlayerList(List<string> players)
        {
            _playerList = new List<string>();

            for (int i = 25; i < players.Count; i++)
            {
                _playerList.Add(players[i]);
            }
        }

        private void SetPluginList(string pluginInfo)
        {
            _pluginList = new List<string>();
            if (string.IsNullOrEmpty(pluginInfo))
            {
                _serverInfo = "Vanilla";
                _pluginList.Add("Ninguno");
            }
            else
            {
                string[] infoPlugins = pluginInfo.Split(':');
                string[] plugins = infoPlugins.Last().Split(';');

                _serverInfo = infoPlugins.First();
                
                foreach (string plugin in plugins)
                {
                    _pluginList.Add(plugin.Trim());
                }
            }
        }
        #endregion

        #region Getters
        public string GetMOTD()
        {
            return _motd;
        }

        public string GetGameMode()
        {
            return _gameMode;
        }

        public string GetMapName()
        {
            return _mapName;
        }

        public int GetOnlinePlayers()
        {
            return _onlinePlayers;
        }

        public int GetMaxPlayers()
        {
            return _maxPlayers;
        }

        public string GetHostIP()
        {
            return _hostIP;
        }

        public int GetHostPort()
        {
            return _hostPort;
        }

        public string GetGameId()
        {
            return _gameID;
        }

        public string GetGameVersion()
        {
            return _version;
        }

        public string GetServerInfo()
        {
            return _serverInfo;
        }

        public List<string> GetPlugins()
        {
            return _pluginList;
        }

        public List<string> GetPlayerList()
        {
            return _playerList;
        }
        #endregion

        #region Byte Utils

        private List<string> SplitByteArray(byte[] input)
        {
            // Limpiamos el inicio y el final de caracteres nulos
            input = CleanByteArray(input);

            List<string> output = new List<string>();
            List<byte> bytes = new List<byte>();

            foreach (byte bInput in input)
            {
                if (bInput == 0x00)
                {
                    string data = string.Empty;
                    if (bytes.Count > 0)
                    {
                        data = Encoding.UTF8.GetString(bytes.ToArray()).Trim();
                    }
                    
                    output.Add(data);
                    bytes = new List<byte>();
                }
                else
                {
                    bytes.Add(bInput);
                }
            }

            return output;
        }

        private byte[] CleanByteArray(byte[] inputBytes)
        {
            // Variables de indices
            int firstIndex = 0;
            int lastIndex = inputBytes.Length;

            // Buscamos el primer cáracter no nulo
            for (int i = 0; i < inputBytes.Length; i++)
            {
                if (inputBytes[i] == 0x00) continue;

                firstIndex = i;
                break;
            }

            // Buscamos el último cáracter no nulo
            for (int i = inputBytes.Length - 1; i >= 0; i--)
            {
                if (inputBytes[i] == 0x00) continue;

                lastIndex = i + 1;
                break;
            }

            return SubByteArray(inputBytes, firstIndex, lastIndex);
        }

        private byte[] SubByteArray(byte[] inputBytes, int startIndex, int lastIndex)
        {
            if (lastIndex - startIndex > inputBytes.Length) return inputBytes;

            byte[] outputBytes = new byte[(lastIndex - startIndex) + 1];

            for (int i = startIndex; i <= lastIndex; i++)
            {
                outputBytes[i - startIndex] = inputBytes[i];
            }

            return outputBytes;
        }
        #endregion
    }
}
