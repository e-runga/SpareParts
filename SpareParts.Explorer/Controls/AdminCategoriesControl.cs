using DevExpress.XtraGrid.Views.Grid;
using SpareParts.Dto;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminCategoriesControl : BaseControl
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
                return Properties.Resources.ManagementCategories;
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

        private CategoryDto newCategory = new CategoryDto();

        private CategoryDto newSubCategory1 = new CategoryDto();

        private CategoryDto newSubCategory2 = new CategoryDto();
        #endregion

        #region .: Constructor :.
        public AdminCategoriesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Buttons :.

        private void gridControlCategories_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var category = this.gridViewCategories.GetRow(this.gridViewCategories.FocusedRowHandle) as CategoryViewDto;

                    if (category != null)
                    {
                        if (MessageBox.Show(string.Format(Properties.Resources.MessageDeleteCategory_Confirmation, category.Category),
                          Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (base.ServiceClient.DeleteCategory(category.Id))
                            {
                                MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Unable to delete Category", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        this.Refresh();
                    }
                }
                else
                {
                    throw new Exception("The item does not exist !");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void gridControlSubCategory1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var subCat1 = this.gridViewSubCategory1.GetRow(this.gridViewSubCategory1.FocusedRowHandle) as CategoryViewDto;

                    if (subCat1 != null)
                    {
                        if (MessageBox.Show(string.Format(Properties.Resources.MessageDeleteCategory_Confirmation, subCat1.SubCategory1),
                          Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (base.ServiceClient.DeleteCategory(subCat1.Id))
                            {
                                MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Unable to delete Sub Category Level 1", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        this.Refresh();
                    }
                }
                else
                {
                    throw new Exception("The item does not exist !");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridControlSubCategory2_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var subCat2 = this.gridViewSubCategory2.GetRow(this.gridViewSubCategory2.FocusedRowHandle) as CategoryViewDto;

                    if (subCat2 != null)
                    {
                        if (MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, subCat2.SubCategory2),
                          Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (base.ServiceClient.DeleteCategory(subCat2.Id))
                            {
                                MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Unable to delete Sub Category level 2", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        this.Refresh();
                    }
                }
                else
                {
                    throw new Exception("The item does not exist !");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void repositoryItemButtonEditDeleteCat1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newSubCategory1.Name = input.Text;
            }
        }

        private void repositoryItemLookUpEditCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(input.EditValue.ToString()))
            {
                this.newSubCategory1.Parent = input.EditValue.ToString();
            }
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
            base.Show();
        }

        public override void Refresh()
        {
            this.Cursor = Cursors.WaitCursor;

            this.gridControlCategories.DataSource = base.ServiceClient.GetCategories();
            this.gridControlSubCategory1.DataSource = base.ServiceClient.GetSubCategories().ToList().Where(c => c.SubCategory1Id > 0);
            this.gridControlSubCategory2.DataSource = base.ServiceClient.GetSubCategories().ToList().Where(c => c.SubCategory2Id > 0);
            this.repositoryItemLookUpEditCategory.DataSource = base.ServiceClient.GetCategories();
            this.repositoryItemLookUpEditSubCategory1.DataSource = base.ServiceClient.GetSubCategories().ToList().Where(c => c.SubCategory1Id > 0);

            this.Cursor = Cursors.Default;
        }
        #endregion

        #region .: Grid Events :.

        private void gridViewCategories_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentCategory = e.Row as CategoryDto;

                if (currentCategory != null)
                {
                    var category = new CategoryDto { Id = currentCategory.Id, Name = currentCategory.Name, ParentId = null, ProductType = new System.Collections.Generic.List<ProductTypeDto>() };
                    var update = base.ServiceClient.SaveCategory(category);
                }
                else
                {
                    var newItem = base.ServiceClient.CreateCategory(this.newCategory);
                }

                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridViewSubCategory1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentCategory = e.Row as CategoryViewDto;

                if (currentCategory != null)
                {
                    var category = new CategoryDto
                    {
                        Id = currentCategory.SubCategory1Id,
                        Name = currentCategory.SubCategory1,
                        ParentId = currentCategory.SubCategory1ParentId,
                        ProductType = new System.Collections.Generic.List<ProductTypeDto>()
                    };

                    var update = base.ServiceClient.SaveCategory(category);
                }
                else
                {
                    var newItem = base.ServiceClient.CreateCategory(this.newSubCategory1);
                }

                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridViewSubCategory2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentCategory = e.Row as CategoryDto;

                if (currentCategory != null)
                {
                    var category = new CategoryDto
                    {
                        Id = currentCategory.Id,
                        Name = currentCategory.Name,
                        ParentId = currentCategory.ParentId,
                        ProductType = new System.Collections.Generic.List<ProductTypeDto>()
                    };

                    var update = base.ServiceClient.SaveCategory(category);
                }
                else
                {
                    var newItem = base.ServiceClient.CreateCategory(this.newSubCategory2);
                }

                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void repositoryItemLookUpEditSubCategory1_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(input.EditValue.ToString()))
            {
                this.newSubCategory2.Parent = input.EditValue.ToString();
            }
        }

        private void textEditSubCat2Name_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newSubCategory2.Name = input.Text;
            }
        }

        private void textEditCategory_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newCategory.Name = input.Text;
            }
        }

        private void repositoryItemTextEditSubCat1_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newSubCategory1.Name = input.Text;
            }
        }

        #endregion

        private void textEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newCategory.Name = input.Text;
            }
        }

        private void gridViewCategories_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((e as EditFormValidateEditorEventArgs).Column.Name != "colName") return;

            this.newCategory.Name = e.Value.ToString();
        }

        private void gridViewSubCategory1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((e as EditFormValidateEditorEventArgs).Column.Name != "colSubCategory1Name") return;

            this.newSubCategory1.Name = e.Value.ToString();
        }

        private void gridViewSubCategory2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((e as EditFormValidateEditorEventArgs).Column.Name != "colNameSubCat2") return;

            this.newSubCategory2.Name = e.Value.ToString();
        }
    }
}