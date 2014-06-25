using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.Logic;
using Client.Resources;
using Client.Utils;
using Telerik.WinControls.UI;

namespace Client.Forms
{
    public partial class MSS : RadForm
    {
        #region Initialize
        public MSS()
        {
            InitializeComponent();
            FormElement.TitleBar.TitlePrimitive.Font = new Font(FormElement.TitleBar.Font, FontStyle.Bold);
            AddressManager.Initialize();
            ReloadAddressList();
        }
        #endregion

        #region Reload data
        private void ReloadAddressList()
        {
            addressList.DataSource = AddressManager.GetAll().OrderByDescending(o => o.Favorite);
            addressList.DisplayMember = "Text";
            addressList.ValueMember = "Id";
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
                if (
                    MessageBox.Show(Messages.AreYouSureToDelete, Messages.Confirm, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes) return;
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

        }
        #endregion
    }
}
