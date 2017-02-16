using SpareParts.Dto;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminBrandControl : BaseControl
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
                return Properties.Resources.ManagementBrands;
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
                return Properties.Resources.brand_new_car_with_dollar_price_tag32x32;
            }
        }

        private BrandDto newItem = new BrandDto { ProductType = new System.Collections.Generic.List<ProductTypeDto>(), Models = new System.Collections.Generic.List<ModelDto>() };
        #endregion

        #region .: Constructors :.
        public AdminBrandControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Form :.
        private void AdminBrandControl_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region .: Override :.
        public override void Show()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                this.Refresh();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        public override void Refresh()
        {
            this.gridControlBrand.DataSource = this.ServiceClient.GetAllBrandsForUI();
            this.lookUpEditProductType.DataSource = this.ServiceClient.GetAllProductTypes();
            this.checkedComboBoxEditModels.DataSource = this.ServiceClient.GetAllModels();
        }
        #endregion

        #region .: Buttons :.

        private void gridControlBrand_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var brand = this.gridViewBrand.GetRow(this.gridViewBrand.FocusedRowHandle) as BrandDto;

                    if (brand != null)
                    {
                        if (MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, brand.Name),
                          Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var success = base.ServiceClient.DeleteBrand(brand);

                            if (!success)
                            {
                                MessageBox.Show("Unable to delete brand", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            e.Handled = success;
                        }
                    }
                }
                else
                {
                    throw new Exception("The item does not exist !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region .: Grid Events :.
        private void gridViewBrand_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentBrand = e.Row as BrandViewForUIDto;

                if (currentBrand != null)
                {
                    var toSave = new BrandDto { Id = currentBrand.BrandId, Name = currentBrand.Brand, Models = new System.Collections.Generic.List<ModelDto>(), ProductType = new System.Collections.Generic.List<ProductTypeDto>() };
                    var models = currentBrand.Models.Split(',');

                    foreach (var model in models)
                    {
                        toSave.Models.Add(new ModelDto { Name = model });
                    }

                    toSave.ProductType.Add(new ProductTypeDto { Name = currentBrand.ProductType });
                    var update = this.ServiceClient.SaveBrand(toSave);
                }

                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemTextEditName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newItem.Name = input.Text;
            }
        }
        #endregion

        private void gridViewBrand_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.Name == "colModels")
            {
                var dataSource = (IList)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource;
                var subModel = (SubModelDto)dataSource[e.ListSourceRowIndex];
                var allModels = this.ServiceClient.GetAllModels().ToList();

                if (e.IsGetData)
                {
                    var result = new StringBuilder();
                    foreach (ModelDto model in subModel.Models)
                    {
                        result.AppendFormat("{0}{1}", model.Name, this.checkedComboBoxEditModels.SeparatorChar);
                    }

                    e.Value = result.ToString().TrimEnd(' ', this.checkedComboBoxEditModels.SeparatorChar);
                }
            }
        }

        private void checkedComboBoxEditModels_Validating(object sender, CancelEventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var modelNames = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                  where item.CheckState == CheckState.Checked
                                  select (string)item.Value).ToList();

                foreach (var item in modelNames)
                {
                    if (!this.newItem.Models.Any(m => m.Name.Equals(item)))
                    {
                        this.newItem.Models.Add(new ModelDto { Name = item });
                    }
                }
            }
        }

        private void lookUpEditProductType_Validating(object sender, CancelEventArgs e)
        {
            var lookup = sender as DevExpress.XtraEditors.LookUpEdit;
            var selected = lookup.EditValue.ToString();

            if (!string.IsNullOrEmpty(lookup.EditValue.ToString()))
            {
                if (!this.newItem.ProductType.Any(p => p.Name.Equals(selected)))
                    this.newItem.ProductType.Add(new ProductTypeDto { Name = selected });
            }
        }
    }
}