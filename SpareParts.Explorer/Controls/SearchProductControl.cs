using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;
using SpareParts.Dto;
using SpareParts.Explorer.Dialogs;
using DevExpress.XtraEditors.Controls;
using SpareParts.Explorer.Data;
using DevExpress.XtraEditors;
using static SpareParts.Tools.Enums;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SpareParts.Explorer.Controls
{
    public partial class SearchProductControl : BaseControl
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
                return Properties.Resources.SearchProductPanetTitle;
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
                return Properties.Resources.barcode_32;
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

        #region .: Constructor :.
        public SearchProductControl()
        {
            InitializeComponent();
        }

        #endregion

        #region .: Override :.
        public override void Show()
        {
            this.Refresh();

            //Set Visibility
            this.lookUpEditBrand.Enabled = !string.IsNullOrEmpty(this.lookUpEditProductType.Text);
            this.lookUpEditModel.Enabled = !string.IsNullOrEmpty(this.lookUpEditBrand.Text);

            //Set width
            this.checkedComboBoxEditYears.Popup += this.CommonContrrolComboBoxEditPopup;
            this.lookUpEditProductType.Popup += this.CommonControlLookupPopup;
            this.lookUpEditItem.Popup += this.CommonControlLookupPopup;
            this.lookUpEditState.Popup += this.CommonControlLookupPopup;
            this.lookUpEditBrand.Popup += this.CommonControlLookupPopup;
            this.lookUpEditCategory.Popup += this.CommonControlLookupPopup;
            this.lookUpEditModel.Popup += this.CommonControlLookupPopup;

            base.Show();
        }

        public override void Refresh()
        {
            this.checkedComboBoxEditYears.Properties.DataSource = base.ServiceClient.GetAllYears();
            this.lookUpEditProductType.Properties.DataSource = base.ServiceClient.GetAllProductTypes();
            this.lookUpEditItem.Properties.DataSource = base.ServiceClient.GetAllItems();
            this.lookUpEditState.Properties.DataSource = base.ServiceClient.GetAllStates();
            this.lookUpEditModel.Properties.DataSource = base.ServiceClient.GetAllModels();
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

        private void lookUpEditBrand_EditValueChanged(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookUp.Text))
            {
                this.lookUpEditModel.Properties.DataSource = base.ServiceClient.GetModelsByBrand(Convert.ToInt32(lookUp.EditValue));
                this.lookUpEditModel.Enabled = true;
            }
        }

        #endregion

        private void simpleButtonAddProduct_Click(object sender, EventArgs e)
        {
            var form = new SearchCustomerForm();
            form.Text = Properties.Resources.Title_SearchCustomer;
            form.ShowDialog();
        }

        private void simpleButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxVIN.Text)
                && this.lookUpEditProductType.EditValue == null
                && this.lookUpEditBrand.EditValue == null
                && this.lookUpEditCategory.EditValue == null
                && this.checkedComboBoxEditYears.EditValue == null
                && this.lookUpEditModel.EditValue == null
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

                    }
                }

                var searchResults = base.ServiceClient.SearchProduct(
                !string.IsNullOrEmpty(this.lookUpEditProductType.Text) ? this.lookUpEditProductType.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditBrand.Text) ? this.lookUpEditBrand.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditCategory.Text) ? this.lookUpEditCategory.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditModel.Text) ? this.lookUpEditModel.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditItem.Text) ? this.lookUpEditItem.Text : string.Empty,
                !string.IsNullOrEmpty(this.lookUpEditState.Text) ? this.lookUpEditState.Text : string.Empty,
                selectedYears.ToArray(),
                !string.IsNullOrEmpty(this.textBoxVIN.Text) ? this.textBoxVIN.Text : string.Empty
                    ).ToList();

                this.gridControlProductSearchResult.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lookUpEditActionButtons_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var action = (sender as LookUpEdit).EditValue.ToString();
                var product = this.gridViewSearchResults.GetRow(this.gridViewSearchResults.FocusedRowHandle) as ProductViewDto;

                switch (action)
                {

                    case "Buy":
                        using (var form = new CustomerBuyingConfirmation())
                        {
                            form.Text = Properties.Resources.Title_BuyProduct;
                            form.Product = product;
                            form.ShowDialog();
                        }
                        break;
                    case "Complain":
                        using (var form1 = new ProductActions())
                        {
                            form1.Text = Properties.Resources.Title_ProductComplaint;
                            form1.Action = ProductStatus.Complained;
                            form1.Product = product;
                            form1.ShowDialog();
                        }
                        break;
                    case "Return":
                        using (var form1 = new ProductActions())
                        {
                            form1.Text = Properties.Resources.Title_ProductReturn;
                            form1.Action = ProductStatus.Returned;
                            form1.Product = product;
                            form1.ShowDialog();
                        }
                        break;
                    case "Replace":
                        using (var form1 = new ProductActions())
                        {
                            form1.Text = Properties.Resources.Title_ProductReplacement;
                            form1.Action = ProductStatus.Replaced;
                            form1.Product = product;
                            form1.ShowDialog();
                        }
                        break;
                    case "Request":
                        using (var form1 = new ProductActions())
                        {
                            form1.Text = Properties.Resources.Title_ProductRequest;
                            form1.Action = ProductStatus.Requested;
                            form1.Product = product;
                            form1.ShowDialog();
                        }
                        break;
                    case "Order":
                        using (var form1 = new ProductActions())
                        {
                            form1.Text = Properties.Resources.Title_ProductOrdering;
                            form1.Action = ProductStatus.Ordered;
                            form1.Product = product;
                            form1.ShowDialog();
                        }
                        break;
                }

                //this.Refresh();
                this.gridControlProductSearchResult.RefreshDataSource();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<ActionItem> GetActionsFromStatus(ProductStatus status)
        {
            var actions = new List<ActionItem>();

            switch (status)
            {
                case ProductStatus.New:
                    actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Bought:
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    break;
                case ProductStatus.Sold:
                    actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Complained:
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Returned:
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Replaced:
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Requested:
                    actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
                case ProductStatus.Ordered:
                    actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    break;
                default:
                    actions.Add(new ActionItem { Name = "Buy", DisplayName = "Buy" });
                    //actions.Add(new ActionItem { Name = "Sell", DisplayName = "Sell" });
                    actions.Add(new ActionItem { Name = "Complain", DisplayName = "Complain" });
                    actions.Add(new ActionItem { Name = "Return", DisplayName = "Return" });
                    actions.Add(new ActionItem { Name = "Replace", DisplayName = "Replace" });
                    actions.Add(new ActionItem { Name = "Request", DisplayName = "Request" });
                    actions.Add(new ActionItem { Name = "Order", DisplayName = "Order" });
                    break;
            }

            return actions;
        }

        private void gridViewSearchResults_ShownEditor(object sender, EventArgs e)
        {
            var view = sender as ColumnView;

            if (view.FocusedColumn.Name == "colActions" && view.ActiveEditor is LookUpEdit)
            {
                var edit = view.ActiveEditor as LookUpEdit;
                var status = Convert.ToInt32(view.GetFocusedRowCellValue("Status"));
                edit.Properties.DataSource = this.GetActionsFromStatus((ProductStatus)status);
                edit.Popup += this.CommonControlLookupPopup;
            }
        }
    }
}