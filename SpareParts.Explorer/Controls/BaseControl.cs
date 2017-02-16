using DevExpress.XtraEditors.Popup;
using SpareParts.Contracts;
using System;
using System.ComponentModel;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public delegate void AddNewTabEventHandler(BaseControl baseControl);

    public partial class BaseControl : UserControl
    {
        public event AddNewTabEventHandler AddNewTab;

        #region Properties
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public virtual string Title
        {
            get
            {
                return "Base";
            }
        }

        /// <summary>
        /// Gets the image title.
        /// </summary>
        /// <value>
        /// The image title.
        /// </value>
        public virtual Image ImageTitle
        {
            get
            {
                return Properties.Resources.Home16x16;
            }
        }

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

        #endregion

        #region .: Constructor :.
        public BaseControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Public Functions :.
        /// <summary>
        /// Called when [load].
        /// </summary>
        public virtual new void Show()
        {

        }

        /// <summary>
        /// Res the show.
        /// </summary>
        public virtual void ReShow()
        {
        }
        #endregion

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

        #region .: Protected Functions :.
        protected void OpenWindow(BaseControl baseControl)
        {
            if (this.AddNewTab != null)
            {
                Invoke(this.AddNewTab, baseControl);
            }
        }
        #endregion
    }
}