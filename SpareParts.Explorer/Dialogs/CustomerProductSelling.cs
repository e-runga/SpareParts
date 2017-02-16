using DevExpress.XtraEditors.Popup;
using SpareParts.Dto;
using SpareParts.Explorer.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpareParts.Explorer.Dialogs
{
    public partial class CustomerProductSelling : BaseForm
    {
        #region .: Properties :.
        private CustomerDto _Customer;

        public CustomerDto Customer
        {
            get { return this._Customer; }
            set { this._Customer = value; }
        }
        #endregion

        #region .: Constructor :.
        public CustomerProductSelling()
        {
            InitializeComponent();
            //Set Visibility
            this.checkedComboBoxEditBrand.Enabled = !string.IsNullOrEmpty(this.lookUpEditProductType.Text);
            this.checkedComboBoxEditModel.Enabled = this.checkedComboBoxEditBrand.SelectionLength > 0;
            this.lookUpEditSubModel.Enabled = this.checkedComboBoxEditModel.SelectionLength > 0;

            //Set width
            this.lookUpEditProductType.Popup += this.CommonControlLookupPopup;
            this.lookUpEditItem.Popup += this.CommonControlLookupPopup;
            this.lookUpEditState.Popup += this.CommonControlLookupPopup;
            this.checkedComboBoxEditCategory.Popup += this.CommonContrrolComboBoxEditPopup;
            this.checkedComboBoxEditBrand.Popup += this.CommonContrrolComboBoxEditPopup;
            this.checkedComboBoxEditModel.Popup += this.CommonContrrolComboBoxEditPopup;
            this.lookUpEditSubCategory1.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubCategory2.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubModel.Popup += this.CommonControlLookupPopup;
        }

        #endregion

        #region .: Override :.
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
                return Properties.Resources.Title_CreateCustomerProduct;
            }
        }

        /// <summary>
        /// Forces the control to invalidate its client area and immediately redraw itself and any child controls.
        /// </summary>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public override void Refresh()
        {
            this.lookUpEditItem.Properties.DataSource = base.ServiceClient.GetAllItems();
            this.lookUpEditLocation.Properties.DataSource = base.ServiceClient.GetAllLocations();
            this.lookUpEditProductType.Properties.DataSource = base.ServiceClient.GetAllProductTypes();
            this.lookUpEditState.Properties.DataSource = base.ServiceClient.GetAllStates();
            this.checkedComboBoxEditCategory.Properties.DataSource = base.ServiceClient.GetAllCategories();
            this.checkedComboBoxEditYear.Properties.DataSource = base.ServiceClient.GetAllYears();
        }
        #endregion

        /// <summary>
        /// Handles the Load event of the CustomerProductSelling control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerProductSelling_Load(object sender, EventArgs e)
        {
            this.lookUpEditItem.Properties.Popup += this.CommonControlLookupPopup;
            this.lookUpEditLocation.Properties.Popup += this.CommonControlLookupPopup;
            this.lookUpEditProductType.Properties.Popup += this.CommonControlLookupPopup;
            this.lookUpEditState.Properties.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubModel.Properties.Popup += this.CommonControlLookupPopup;
            this.checkedComboBoxEditCategory.Popup += this.CommonContrrolComboBoxEditPopup;
            this.checkedComboBoxEditBrand.Popup += this.CommonContrrolComboBoxEditPopup;
            this.checkedComboBoxEditModel.Popup += this.CommonContrrolComboBoxEditPopup;
            this.lookUpEditSubCategory1.Properties.Popup += this.CommonControlLookupPopup;
            this.lookUpEditSubCategory2.Properties.Popup += this.CommonControlLookupPopup;
            this.checkedComboBoxEditYear.Properties.Popup += this.CommonContrrolComboBoxEditPopup;

            this.textEditCustomer.Text = this.Customer.DisplayName;
            this.pictureBoxAddLocation.Visible = Singletons.Security.Instance.LoggedUser.Profile.Name == Tools.Enums.ProfileType.Administrator.ToString();
            this.Refresh();
        }

        #region .: Events :.
        /// <summary>
        /// Handles the EditValueChanged event of the lookUpEditProductType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lookUpEditProductType_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.checkedComboBoxEditBrand.Properties.DataSource = base.ServiceClient.GetBrandsByProductType(Convert.ToInt32(lookUp.EditValue));
                this.checkedComboBoxEditBrand.Enabled = true;
                this.checkedComboBoxEditCategory.Properties.DataSource = base.ServiceClient.GetCategoriesByProductType(Convert.ToInt32(lookUp.EditValue));
                this.checkedComboBoxEditCategory.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the checkedComboBoxEditModel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkedComboBoxEditModel_EditValueChanged(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var selected = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                where item.CheckState == CheckState.Checked
                                select Convert.ToInt32(item.Value)).ToList<int>();
                this.lookUpEditSubModel.Properties.DataSource = this.ServiceClient.GetSubModelByModels(selected.ToArray());
                this.lookUpEditSubModel.Enabled = true;
            }
        }

        private void checkedComboBoxEditBrand_EditValueChanged(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var selected = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                where item.CheckState == CheckState.Checked
                                select Convert.ToInt32(item.Value)).ToList<int>();
                this.checkedComboBoxEditModel.Properties.DataSource = this.ServiceClient.GetModelsByBrands(selected.ToArray());
                this.checkedComboBoxEditModel.Enabled = true;
            }
        }

        private void lookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                var categoryIds = new int[] { Convert.ToInt32(lookUp.EditValue) };
                this.lookUpEditSubCategory1.Properties.DataSource = base.ServiceClient.GetSubCategory1(categoryIds);
                this.lookUpEditSubCategory1.Enabled = true;
            }
        }

        private void checkedComboBoxEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var selected = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                where item.CheckState == CheckState.Checked
                                select Convert.ToInt32(item.Value)).ToList<int>();
                this.lookUpEditSubCategory1.Properties.DataSource = this.ServiceClient.GetSubCategory1(selected.ToArray());
            }
        }

        private void lookUpEditSubCategory1_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.lookUpEditSubCategory2.Properties.DataSource = base.ServiceClient.GetSubCategory2(new int[] { Convert.ToInt32(lookUp.EditValue) });
                this.lookUpEditSubCategory2.Enabled = true;
            }
        }
        #endregion

        #region .: Buttons :.
        private void simpleButtonSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.lookUpEditProductType.EditValue == null
                //    || string.IsNullOrEmpty(this.checkedComboBoxEditBrand.EditValue.ToString())
                //    || string.IsNullOrEmpty(this.checkedComboBoxEditCategory.EditValue.ToString())
                //    || this.lookUpEditItem.EditValue == null
                //    || string.IsNullOrEmpty(this.checkedComboBoxEditYear.EditValue.ToString())
                //    || this.lookUpEditLocation.EditValue == null
                //    || this.lookUpEditState.EditValue == null
                //    || string.IsNullOrEmpty(this.textEditName.Text)
                //    || string.IsNullOrEmpty(this.textEditStockLocation.Text)
                //    || string.IsNullOrEmpty(this.textEditSellPrice.Text)
                //    )
                //{
                //    MessageBox.Show(Properties.Resources.Error_MandatoryFields, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                var brandIds = new List<int>();
                var categoryIds = new List<int>();
                var modelIds = new List<int>();
                var yearIds = new List<int>();

                this.checkedComboBoxEditBrand.Properties.GetItems().GetCheckedValues().ForEach(b => brandIds.Add(Convert.ToInt32(b)));
                this.checkedComboBoxEditCategory.Properties.GetItems().GetCheckedValues().ForEach(c => categoryIds.Add(Convert.ToInt32(c)));
                this.checkedComboBoxEditModel.Properties.GetItems().GetCheckedValues().ForEach(m => modelIds.Add(Convert.ToInt32(m)));
                this.checkedComboBoxEditYear.Properties.GetItems().GetCheckedValues().ForEach(y => yearIds.Add(Convert.ToInt32(y)));

                var brands = new List<BrandDto>();
                brandIds.ForEach(b => brands.Add(new BrandDto { Id = b }));
                var categories = new List<CategoryDto>();
                categoryIds.ForEach(c => categories.Add(new CategoryDto { Id = c }));
                var models = new List<ModelDto>();
                modelIds.ForEach(m => models.Add(new ModelDto { Id = m }));
                var city = this.lookUpEditLocation.GetSelectedDataRow() as LocationViewDto;
                var type = this.lookUpEditProductType.GetSelectedDataRow() as ProductTypeViewDto;

                var product = new ProductDto
                {
                    Name = this.textEditName.Text,
                    ProductType = new ProductTypeDto { Id = type.Id, Name = type.Name },
                    Customer = this.Customer,
                    Operator = Singletons.Security.Instance.LoggedUser.ToOperator(),
                    Item = this.lookUpEditItem.GetSelectedDataRow() as ItemDto,
                    BuyingPrice = Convert.ToDecimal(this.textEditSellPrice.Text),
                    DepositBuyDate = DateTime.Now,
                    State = this.lookUpEditState.GetSelectedDataRow() as StateDto,
                    City = new CityDto { Id = city.Id },
                    Categories = categories,
                    Brands = brands,
                    Models = models,
                    YearIds = yearIds.ToArray()
                };

                var savedProduct = this.ServiceClient.SaveProductBasicInfo(product);

                if (savedProduct != null)
                {
                    MessageBox.Show(Properties.Resources.Message_SuccessProductCreated, Properties.Resources.Message_Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBoxAddLocation_Click(object sender, EventArgs e)
        {
            var form = new ViewLocationForm();
            form.ShowDialog();
            this.lookUpEditLocation.Properties.DataSource = base.ServiceClient.GetAllLocations();
        }

        private void pictureBoxAddLocation_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(this.pictureBoxAddLocation, Properties.Resources.TooTip_AddLocation);
        }
        #endregion

        #region .: Common events :.
        private void CommonControlLookupPopup(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;
            var form = (lookUp as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupLookUpEditForm;
            form.Width = lookUp.Width;
        }

        private void CommonContrrolComboBoxEditPopup(object sender, EventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;
            var form = (combo as DevExpress.Utils.Win.IPopupControl).PopupWindow as CheckedPopupContainerForm;
            form.Width = combo.Width;
            form.Height = 160;
        }
        #endregion
    }
}