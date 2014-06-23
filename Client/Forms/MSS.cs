using Client.Logic;

namespace Client.Forms
{
    public partial class MSS : Telerik.WinControls.UI.RadForm
    {
        public MSS()
        {
            InitializeComponent();
        }
        /*
         * 87.235.219.212
         * theverge.game.nfoservers.com
         * belowaverage.ga
         */
        private void radButton1_Click(object sender, System.EventArgs e)
        {
            MCQuery query = new MCQuery();
            var abc = query.Query("87.235.219.212", 25565);
        }

        private void radButton2_Click(object sender, System.EventArgs e)
        {
            MCQuery query = new MCQuery();
            var abc = query.Query("belowaverage.ga", 25565);
        }
    }
}
