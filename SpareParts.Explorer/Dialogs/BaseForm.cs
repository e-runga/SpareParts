using DevExpress.XtraEditors.Popup;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace SpareParts.Explorer.Dialogs
{
    public partial class BaseForm : Form
    {
        /// <summary>
        /// The _ service client
        /// </summary>
        private DataService.IDataService _ServiceClient;

        /// <summary>
        /// Gets the service client.
        /// </summary>
        /// <value>
        /// The service client.
        /// </value>
        protected DataService.IDataService ServiceClient
        {
            get
            {
                if (this._ServiceClient == null)
                {
                    this._ServiceClient = new ChannelFactory<DataService.IDataService>("DataService").CreateChannel();
                }

                return this._ServiceClient;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public override string Text
        {
            get
            {
                return "Base";
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        #region .: Common events :.
        internal void CommonControlLookupPopup(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;
            var form = (lookUp as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupLookUpEditForm;
            form.Width = lookUp.Width;
            form.Height = 120;
        }

        internal void CommonContrrolComboBoxEditPopup(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;
            var form = (combo as DevExpress.Utils.Win.IPopupControl).PopupWindow as CheckedPopupContainerForm;
            form.Width = combo.Width;
            form.Height = 160;
        }
        #endregion


    }
}