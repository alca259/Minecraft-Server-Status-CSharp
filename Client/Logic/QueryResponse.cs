using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Logic 
{
    public class QueryResponse
    {
        #region Variables
        private readonly string _motd;
        private readonly string _gameMode;
        private readonly string _mapName;
        private readonly string _hostname;
        private readonly string _gameID;
        private readonly string _version;
        private readonly string _plugins;
        private readonly int _onlinePlayers;
        private readonly int _maxPlayers;
        private readonly List<string> _playerList;
        private readonly List<string> _pluginList;
        #endregion

        #region Constructor
        public QueryResponse(byte[] data)
        {
            List<string> datos = SplitByteArray(data);

            _motd = datos[3];
            _gameMode = datos[5];
            _gameID = datos[7];
            _version = datos[9];
            _plugins = datos[10];
            _mapName = datos[12];
            _onlinePlayers = int.Parse(datos[14]);
            _maxPlayers = int.Parse(datos[16]);
            _hostname = datos[21];

            _playerList = new List<string>();
            for (int i = 24; i < datos.Count; i++)
            {
                _playerList.Add(datos[i]);
            }

        }
        #endregion

        #region Getters
        public string getMOTD()
        {
            return _motd;
        }

        public string getGameMode()
        {
            return _gameMode;
        }

        public string getMapName()
        {
            return _mapName;
        }

        public int getOnlinePlayers()
        {
            return _onlinePlayers;
        }

        public int getMaxPlayers()
        {
            return _maxPlayers;
        }

        public string getHostname()
        {
            return _hostname;
        }

        public string getGameId()
        {
            return _gameID;
        }

        public string getGameVersion()
        {
            return _version;
        }

        public List<string> getPlugins()
        {
            List<string> plugins = new List<string>();
            if (string.IsNullOrEmpty(_plugins))
            {
                plugins.Add("No");
            }
            else
            {
                plugins.Add("Yes");
            }
            return plugins;
        }

        public List<string> getPlayerList()
        {
            return _playerList;
        }
        #endregion

        #region Byte[] Utils

        public List<string> SplitByteArray(byte[] input)
        {
            List<string> output = new List<string>();
            List<byte> bytes = new List<byte>();

            foreach (byte bInput in input)
            {
                if (bInput == 0x00)
                {
                    if (bytes.Count <= 0) continue;

                    string data = Encoding.UTF8.GetString(bytes.ToArray()).Trim();
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
        #endregion
    }
}
