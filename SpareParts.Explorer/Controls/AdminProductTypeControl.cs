using SpareParts.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminProductTypeControl : BaseControl
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
                return Properties.Resources.ManagementProductTypes;
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
                return Properties.Resources.two_cogwheels32x32;
            }
        }

        private ProductTypeDto currentItem = new ProductTypeDto { Brands = new System.Collections.Generic.List<BrandDto>(), Categories = new System.Collections.Generic.List<CategoryDto>() };
        #endregion

        #region .: Constructor :.
        public AdminProductTypeControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Overrides :.
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
            base.Show();
        }

        public override void Refresh()
        {
            this.gridControlProductType.DataSource = this.ServiceClient.GetAllProductTypes();
            this.checkedComboBoxEditBrands.DataSource = this.ServiceClient.GetAllBrands();
            this.checkedComboBoxEditCategories.DataSource = this.ServiceClient.GetAllCategories();
        }
        #endregion

        #region .: Grid :.

        private void gridViewProductType_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var dataSource = (IList)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource;
            var productType = (ProductTypeDto)dataSource[e.ListSourceRowIndex];

            if (e.Column.Name == "colCategories")
            {
                if (e.IsGetData)
                {
                    var result = new StringBuilder();

                    foreach (CategoryDto category in productType.Categories)
                    {
                        result.AppendFormat("{0}{1}", category.Name, this.checkedComboBoxEditCategories.SeparatorChar);
                    }

                    e.Value = result.ToString().TrimEnd(' ', this.checkedComboBoxEditCategories.SeparatorChar);
                }
            }
            else if (e.Column.Name == "colBrands")
            {
                if (e.IsGetData)
                {
                    var result = new StringBuilder();

                    foreach (BrandDto brand in productType.Brands)
                    {
                        result.AppendFormat("{0}{1}", brand.Name, this.checkedComboBoxEditBrands.SeparatorChar);
                    }

                    e.Value = result.ToString().TrimEnd(' ', this.checkedComboBoxEditBrands.SeparatorChar);
                }
            }
        }

        private void gridViewProductType_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var result = base.ServiceClient.SaveProductType(this.currentItem);
                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridViewProductType_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = 25;
        }

        private void checkedComboBoxEditCategories_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var categoryNames = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                     where item.CheckState == CheckState.Checked
                                     select (string)item.Value).ToList();

                foreach (var item in categoryNames)
                {
                    if (!this.currentItem.Categories.Any(c => c.Name.Equals(item)))
                    {
                        this.currentItem.Categories.Add(new CategoryDto { Name = item });
                    }
                }
            }
        }

        private void checkedComboBoxEditBrands_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var combo = sender as DevExpress.XtraEditors.CheckedComboBoxEdit;

            if (combo != null)
            {
                var brandNames = (from DevExpress.XtraEditors.Controls.CheckedListBoxItem item in combo.Properties.GetItems()
                                     where item.CheckState == CheckState.Checked
                                     select (string)item.Value).ToList();

                foreach (var item in brandNames)
                {
                    if (!this.currentItem.Brands.Any(c => c.Name.Equals(item)))
                    {
                        this.currentItem.Brands.Add(new BrandDto { Name = item });
                    }
                }
            }
        }

        private void gridControlProductType_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var itemToDelete = this.gridViewProductType.GetRow(this.gridViewProductType.FocusedRowHandle) as ProductTypeDto;

                    if (itemToDelete != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDeleteModel_Confirmation, itemToDelete.Name),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteProductType(itemToDelete.Id);
                        }
                    }
                    else
                    {
                        throw new Exception("The item does not exist !");
                    }

                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEditName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentItem.Name = input.Text;
            }
        }

        #endregion

        private void gridViewProductType_ShownEditor(object sender, EventArgs e)
        {
        }

        private void gridViewProductType_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var selected = this.gridViewProductType.GetRow(this.gridViewProductType.FocusedRowHandle) as ProductTypeViewDto;
            this.currentItem.Id = selected.Id;
        }
    }
}