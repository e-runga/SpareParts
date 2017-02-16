using SpareParts.Dto;
using System;

namespace SpareParts.Explorer.Dialogs
{
    public partial class NewProductForm : BaseForm
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
        public NewProductForm()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Form :.
        private void NewProductForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public override void Refresh()
        {
            this.lookUpEditProductType.Properties.DataSource = this.ServiceClient.GetAllProductTypes();
            this.lookUpEditItem.Properties.DataSource = this.ServiceClient.GetAllItems();
            this.lookUpEditCategory.Properties.DataSource = this.ServiceClient.GetAllCategories();
            this.lookUpEditBrand.Properties.DataSource = this.ServiceClient.GetAllBrands();
            this.lookUpEditModel.Properties.DataSource = this.ServiceClient.GetAllModels();
            this.lookUpEditLocation.Properties.DataSource = this.ServiceClient.GetAllLocations();
            this.lookUpEditPaperReference.Properties.DataSource = this.ServiceClient.GetAllPaperReferences();
        }
        #endregion
    }
}
