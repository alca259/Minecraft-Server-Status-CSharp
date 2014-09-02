using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.Logic;
using Client.Resources;
using Client.Utils;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Client.Forms
{
    public partial class MSS : RadForm
    {
        #region Initialize
        public MSS()
        {
            Font titleFont = new Font(FormElement.TitleBar.Font.FontFamily, 10.0F, FontStyle.Regular);
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Dark");
            FormElement.TitleBar.TitlePrimitive.Font = titleFont;
            AddressManager.Initialize();
            ReloadAddressList();

            // Events start
            addressList.SelectedItemChanged += addressList_SelectedItemChanged;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnInfo.Click += btnInfo_Click;
        }
        #endregion

        #region Reload data
        private void ReloadAddressList()
        {
            addressList.DataSource = AddressManager.GetAll()
                .OrderByDescending(o => o.Favorite)
                .ThenBy(o => o.HostIp)
                .ThenBy(o => o.HostPort);
            addressList.DisplayMember = "Text";
            addressList.ValueMember = "Id";
        }

        private void RefreshServerData(bool ForceReload = false)
        {
            AddressModel model = AddressManager.Get(valHostIP.Text, valHostPort.Text);
            model.Id = model.Id == Guid.Empty ? Guid.NewGuid() : model.Id;
            model.HostIp = valHostIP.Text;
            model.HostPort = int.Parse(valHostPort.Text);

            if (string.IsNullOrEmpty(model.HostIp)) return;

            // If have force reload, or response of the model is null
            if (ForceReload || model.Response == null)
            {
                // Launch petition
                MCQuery query = new MCQuery();

                // Save properties
                model.Response = query.Query(model.HostIp, model.HostPort);
                valServerResponse.Text = string.Format(Messages.PingServer, query.timeReply);
                AddressManager.Add(model);
            }
            else
            {
                valServerResponse.Text = Messages.LocalPingServer;
            }

            // Asign data
            valGameMode.Text = model.Response.GetGameMode();
            valGameVersion.Text = model.Response.GetGameVersion();
            valPlayers.Text = model.Response.GetPlayers();
            valGameMap.Text = model.Response.GetMapName();

            valGameId.Text = model.Response.GetGameId();
            valMOTD.Text = model.Response.GetMOTD();
            valServerHostIP.Text = model.Response.GetHostIP();
            valServerHostPort.Text = model.Response.GetHostPort().ToString();
            valServerInfo.Text = model.Response.GetServerInfo();

            pluginsList.DataSource = model.Response.GetPlugins();
            playersList.DataSource = model.Response.GetPlayerList();
        }
        #endregion

        #region Events
        private void addressList_SelectedItemChanged(object sender, EventArgs e)
        {
            if (addressList.SelectedItems.Count <= 0) return;

            AddressModel model;

            if (addressList.SelectedItem.Value is AddressModel)
            {
                model = (AddressModel)addressList.SelectedItem.Value;
            }
            else
            {
                Guid id = Guid.Parse(addressList.SelectedItem.Value.ToString());
                model = AddressManager.Get(id);
            }

            valHostIP.Text = model.HostIp;
            valHostPort.Text = model.HostPort.ToString();
            valFavorite.Checked = model.Favorite;
            RefreshServerData();
        }
        #endregion

        #region Action buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddressModel model = AddressManager.Get(valHostIP.Text, valHostPort.Text);
            model.Id = model.Id == Guid.Empty ? Guid.NewGuid() : model.Id;
            model.HostIp = valHostIP.Text;
            model.HostPort = int.Parse(valHostPort.Text);
            model.Favorite = valFavorite.Checked;

            if (string.IsNullOrEmpty(model.HostIp)) return;

            AddressManager.Add(model);
            ReloadAddressList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (addressList.SelectedItems.Count <= 0) return;

            Guid id = Guid.Parse(addressList.SelectedItem.Value.ToString());
            AddressModel model = AddressManager.Get(id);

            if (model.Favorite)
            {
                DialogResult result = RadMessageBox.Show(string.Format(Messages.AreYouSureToDelete, model.HostIp),
                    Messages.Confirm, MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (result != DialogResult.Yes) return;
                AddressManager.Remove(model);
                ReloadAddressList();
            }
            else
            {
                AddressManager.Remove(model);
                ReloadAddressList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshServerData(true);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show(Messages.AboutMe.Replace(@"\n", Environment.NewLine), Messages.Info,
                MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        #endregion
    }
}
