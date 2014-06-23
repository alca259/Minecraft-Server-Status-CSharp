using System.Collections.Generic;
using Client.Logic;
using Client.Utils;
using Telerik.WinControls.UI;

namespace Client.Forms
{
    public partial class MSS : RadForm
    {
        private List<AddressModel> address;
        public MSS()
        {
            InitializeComponent();
            address = new List<AddressModel>
            {
                new AddressModel {Favorite = true, HostIp = "87.235.219.212", HostPort = 25565},
                new AddressModel {Favorite = true, HostIp = "theverge.game.nfoservers.com", HostPort = 25565},
                new AddressModel {Favorite = true, HostIp = "belowaverage.ga", HostPort = 25565}
            };
            AddressManager.SetXml(address);
            AddressManager.GetXml();
        }
        /*
         * 87.235.219.212
         * theverge.game.nfoservers.com
         * belowaverage.ga
         */
    }
}
