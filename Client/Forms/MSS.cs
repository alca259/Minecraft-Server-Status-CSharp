using System.Collections.Generic;
using Client.Logic;
using Client.Utils;
using Telerik.WinControls.UI;

namespace Client.Forms
{
    public partial class MSS : RadForm
    {
        
        public MSS()
        {
            InitializeComponent();
            AddressManager.Initialize();
        }
        /*
         * 87.235.219.212
         * theverge.game.nfoservers.com
         * belowaverage.ga
         */
    }
}
