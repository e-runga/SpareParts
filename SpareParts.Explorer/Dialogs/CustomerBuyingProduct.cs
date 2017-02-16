using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpareParts.Explorer.Dialogs
{
    public partial class CustomerBuyingProduct : BaseForm
    {
        #region .: Properties :.
        private CustomerDto _Customer;

        public CustomerDto Customer
        {
            get { return this._Customer; }
            set { this._Customer = value; }
        }

        private int _ProductId;

        public int ProductId
        {
            get { return this._ProductId; }
            set { this._ProductId = value; }
        }
        #endregion

        #region .: Constructor :.
        public CustomerBuyingProduct()
        {
            InitializeComponent();
        }

        #endregion

        #region .: Form :.
        private void CustomerBuyingProduct_Load(object sender, EventArgs e)
        {
            this.Refresh();

            //Set Visibility
            this.lookUpEditBrand.Enabled = !string.IsNullOrEmpty(this.lookUpEditProductType.Text);
            this.lookUpEditModel.Enabled = !string.IsNullOrEmpty(this.lookUpEditBrand.Text);
            this.lookUpEditSubModel.Enabled = !string.IsNullOrEmpty(this.lookUpEditModel.Text);

            //Set width
            this.checkedComboBoxEditYears.Popup += this.CommonControlComboBoxEditPopup;
            this.lookUpEditProductType.Popup += this.CommonControlLookupPopup;
            this.lookUpEditItem.Popup += this.CommonControlLookupPopup;
            this.lookUpEditState.Popup += this.CommonControlLookupPopup;
            this.lookUpEditBrand.Popup += this.CommonControlLookupPopup;
            this.lookUpEditCategory.Popup += this.CommonControlLookupPopup;
            this.lookUpEditModel.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubCategory1.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubCategory2.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubModel.Popup += this.CommonControlLookupPopup;

            //Set Customer Infos
            this.labelCustomerFName.Text = this.Customer.FirstName;
            this.labelCustomerLName.Text = this.Customer.LastName;
            this.labelCustomerEmail.Text = this.Customer.Email;
            this.labelCustomerMobile.Text = this.Customer.Mobile;
            base.Show();
        }

        public override void Refresh()
        {
            this.checkedComboBoxEditYears.Properties.DataSource = base.ServiceClient.GetAllYears();
            this.lookUpEditProductType.Properties.DataSource = base.ServiceClient.GetAllProductTypes();
            this.lookUpEditItem.Properties.DataSource = base.ServiceClient.GetAllItems();
            this.lookUpEditState.Properties.DataSource = base.ServiceClient.GetAllStates();
            this.lookUpEditModel.Properties.DataSource = base.ServiceClient.GetAllModels();
            this.lookUpEditCategory.Properties.DataSource = base.ServiceClient.GetAllCategories();
        }
        #endregion

        #region .: Buttons :.
        private void buttonEditActions_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var form = new CustomerBuyingConfirmation();
            form.Customer = this.Customer;
            form.Product = this.gridViewProducts.GetRow(this.gridViewProducts.FocusedRowHandle) as ProductViewDto;
            form.ShowDialog();
        }

        #endregion

        #region .: Events :.
        private void lookUpEditProductType_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.lookUpEditBrand.Properties.DataSource = base.ServiceClient.GetBrandsByProductType(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditBrand.Enabled = true;

                this.lookUpEditCategory.Properties.DataSource = base.ServiceClient.GetCategoriesByProductType(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditCategory.Enabled = true;
            }
        }

        private void lookUpEditModel_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.lookUpEditSubModel.Properties.DataSource = base.ServiceClient.GetSubModelByModelId(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditSubModel.Enabled = true;
            }
        }

        private void lookUpEditBrand_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.lookUpEditModel.Properties.DataSource = base.ServiceClient.GetModelsByBrand(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditModel.Enabled = true;
            }
        }

        private void lookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                //this.lookUpEditSubCategory1.Properties.DataSource = base.ServiceClient.GetSubCategory1ByCategoryId(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditSubCategory1.Enabled = true;
            }
        }

        private void lookUpEditSubCategory1_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                //this.lookUpEditSubCategory2.Properties.DataSource = base.ServiceClient.GetSubCategory2BySubCategory1Id(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditSubCategory2.Enabled = true;
            }
        }
        #endregion

        #region .: Common events :.
        private void CommonControlLookupPopup(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;
            var form = (lookUp as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupLookUpEditForm;
            form.Width = lookUp.Width;
        }

        private void CommonControlComboBoxEditPopup(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;
            var form = (combo as DevExpress.Utils.Win.IPopupControl).PopupWindow as CheckedPopupContainerForm;
            form.Width = combo.Width;
        }
        #endregion

        private void simpleButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxVIN.Text)
                && this.lookUpEditProductType.EditValue == null
                && this.lookUpEditBrand.EditValue == null
                && this.lookUpEditCategory.EditValue == null
                && this.lookUpEditSubCategory1.EditValue == null
                && this.lookUpEditSubCategory2.EditValue == null
                && this.checkedComboBoxEditYears.EditValue == null
                && this.lookUpEditModel.EditValue == null
                && this.lookUpEditSubModel.EditValue == null
                && this.lookUpEditState.EditValue == null
                && this.lookUpEditItem.EditValue == null
                )
            {
                MessageBox.Show(Properties.Resources.Error_AtLEastOneCriteriaRequired, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
                return;
            }

            try
            {
                var selectedYears = new List<string>();

                foreach (CheckedListBoxItem item in this.checkedComboBoxEditYears.Properties.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                    {
                        selectedYears.Add(item.Description);
                    }
                }

                var searchResults = base.ServiceClient.SearchSellableProducts(
                !string.IsNullOrEmpty(this.lookUpEditProductType.Text) ? this.lookUpEditProductType.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditBrand.Text) ? this.lookUpEditBrand.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditCategory.Text) ? this.lookUpEditCategory.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditModel.Text) ? this.lookUpEditModel.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditItem.Text) ? this.lookUpEditItem.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditState.Text) ? this.lookUpEditState.Text : string.Empty,
                selectedYears.ToArray(),
                !string.IsNullOrEmpty(this.textBoxVIN.Text) ? this.textBoxVIN.Text : string.Empty
                    ).ToList();

                this.gridControlCustomerProducts.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridViewProducts_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Convert.ToBoolean(gridViewProducts.GetRowCellValue(gridViewProducts.FocusedRowHandle, "Sold"));
        }
    }
}