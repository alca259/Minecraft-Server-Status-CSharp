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
            List<byte[]> datos = SplitByteArray(data);

            _motd = data[3].ToString();
            _gameMode = data[5].ToString();
            _gameID = data[7].ToString();
            _version = data[9].ToString();
            _plugins = data[11].ToString();
            _mapName = data[13].ToString();
            _onlinePlayers = int.Parse(data[15].ToString());
            _maxPlayers = int.Parse(data[17].ToString());
            _hostname = data[21].ToString();

            _playerList = new List<string>();
            for (int i = 25; i < data.Length; i++)
            {
                _playerList.Add(data[i].ToString());
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

        public List<byte[]> SplitByteArray(byte[] input)
        {
            List<byte[]> output = new List<byte[]>();
            byte[] builder = {};
            int index = 0;

            foreach (byte bInput in input)
            {
                if (bInput == 0x00 && builder.Length > 0)
                {
                    output.Add(builder);
                    builder = new byte[]{};
                    index = 0;
                }
                else
                {
                    builder[index] = bInput;
                    index++;
                }
            }

            return output;
        }
        #endregion
    }
}
