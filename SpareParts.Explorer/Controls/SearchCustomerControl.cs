using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using SpareParts.Dto;
using SpareParts.Explorer.Data;
using SpareParts.Explorer.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class SearchCustomerControl : BaseControl
    {
        #region .: Properties :.
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public override string Title
        {
            get
            {
                return Properties.Resources.SearchCustomerPanelTitle;
            }
        }

        /// <summary>
        /// Gets the image title.
        /// </summary>
        /// <value>
        /// The image title.
        /// </value>
        public override Image ImageTitle
        {
            get
            {
                return Properties.Resources.customer_search_32;
            }
        }

        ///// <summary>
        ///// The current page
        ///// </summary>
        //private int CurrentPage = 1;

        ///// <summary>
        ///// The page size, the number of elements to display in the grid
        ///// </summary>
        //private int PageSize = 100;

        ///// <summary>
        ///// The page count
        ///// </summary>
        //private int PageCount;

        #endregion

        #region .: Constructors :
        public SearchCustomerControl()
        {
            InitializeComponent();
            this.lookUpEditCustomerType.EditValue = null;
            var actions = new List<ActionItem>();
            actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
            actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
            this.lookUpEditActionButtons.DataSource = actions;
            this.lookUpEditActionButtons.Popup += this.CommonControlLookupPopup;
            this.lookUpEditCustomerType.Properties.DataSource = this.ServiceClient.GetAllCustomerTypes();
        }

        #endregion

        #region .: Overrides :.
        public override void Show()
        {
            try
            {
                base.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region .: Search :.
        private void simpleButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textEditFirstName.Text)
                && string.IsNullOrEmpty(this.textEditLastName.Text)
                && string.IsNullOrEmpty(this.textEditEmail.Text)
                && string.IsNullOrEmpty(this.textEditMobile.Text)
                && string.IsNullOrEmpty(this.textEditPhoneNumber.Text)
                && this.lookUpEditCustomerType.EditValue == null
                )
            {
                MessageBox.Show(Properties.Resources.Error_AtLEastOneCriteriaRequired, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
                return;
            }

            try
            {
                this.lookUpEditCustomerType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                var searchResults = base.ServiceClient.SearchCustomer(this.textEditFirstName.Text.Trim(),
                    this.textEditLastName.Text.Trim(),
                    this.textEditEmail.Text.Trim(),
                    this.textEditMobile.Text.Trim(),
                    this.textEditPhoneNumber.Text.Trim())
                    .ToList();

                gridControlCustomers.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region .: Events :.
        private void lookUpEditCustomerType_Popup(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;
            var form = (lookUp as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupLookUpEditForm;
            form.Width = lookUp.Width;
        }

        private void simpleButtonAddCustomer_Click(object sender, EventArgs e)
        {
            using (NewCustomer form = new NewCustomer())
            {
                form.Text = Properties.Resources.Title_CreateCustomer;
                form.ShowDialog();
            }
        }

        private void repositoryItemButtonEditBuy_Click(object sender, EventArgs e)
        {
            var customer = this.gridViewCustomers.GetRow(this.gridViewCustomers.FocusedRowHandle) as CustomerDto;
            var form = new CustomerBuyProductControl();
            form.CurrentCustomer = customer;
            base.OpenWindow(form);
        }

        private void lookUpEditActionButtons_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var action = (sender as LookUpEdit).EditValue.ToString();
                var customer = this.gridViewCustomers.GetRow(this.gridViewCustomers.FocusedRowHandle) as CustomerDto;

                switch (action)
                {

                    case "Buy":
                        using (var form = new CustomerBuyingProduct())
                        {
                            form.Text = Properties.Resources.Title_BuyProduct;
                            form.Customer = customer;
                            form.ShowDialog();
                        }
                        break;
                    case "Sell":
                        using (var form1 = new CustomerProductSelling())
                        {
                            form1.Text = Properties.Resources.Title_SellProduct;
                            form1.Customer = customer;
                            form1.ShowDialog();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}