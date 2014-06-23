using Client.Logic;

namespace Client.Forms
{
    public partial class MSS : Telerik.WinControls.UI.RadForm
    {
        public MSS()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            MCQuery query = new MCQuery();
            query.Query("87.235.219.212", 25565);
        }
    }
}
