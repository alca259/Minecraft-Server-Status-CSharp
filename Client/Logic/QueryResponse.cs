using System.Collections.Generic;
using System.Linq;
using MSSClient.Resources;
using MSSUtils.Byte;

namespace MSSClient.Logic 
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
            List<string> datos = ByteUtils.SplitByteArray(data);

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

            if (_playerList.Count == 0)
            {
                _playerList.Add(Messages.None);
            }
        }

        private void SetPluginList(string pluginInfo)
        {
            _pluginList = new List<string>();
            if (string.IsNullOrEmpty(pluginInfo))
            {
                _serverInfo = Messages.Vanilla;
                _pluginList.Add(Messages.None);
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

        public string GetPlayers()
        {
            return string.Format(Messages.PlayersOnline, GetOnlinePlayers(), GetMaxPlayers());
        }
        private int GetOnlinePlayers()
        {
            return _onlinePlayers;
        }

        private int GetMaxPlayers()
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
    }
}
