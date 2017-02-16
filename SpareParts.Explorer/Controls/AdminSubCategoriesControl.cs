using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using SpareParts.Dto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminSubCategoriesControl : BaseControl
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
                return Properties.Resources.ManagementSubCategories;
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

        private SubCategory1Dto newSubCategory1 = new SubCategory1Dto { Category = new CategoryDto() };

        private SubCategory2Dto newtSubCategory2 = new SubCategory2Dto { SubCategory1 = new SubCategory1Dto() };
        #endregion
        
        #region .: Constructor :.
        public AdminSubCategoriesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Buttons :.
        private void repositoryItemButtonEditDeleteCat1_Click(object sender, EventArgs e)
        {
            try
            {
                var subCat = this.gridViewSubCategory1.GetRow(this.gridViewSubCategory1.FocusedRowHandle) as SubCategory1Dto;

                if (subCat != null)
                {
                    if (MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, subCat.Name),
                      Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if (base.ServiceClient.DeleteSubCategory1(subCat.Id))
                        //{
                        //    MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Unable to delete Sub Category level 1", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteSubcat2_Click(object sender, EventArgs e)
        {

            try
            {
                var subCat = this.gridViewSubCategory2.GetRow(this.gridViewSubCategory2.FocusedRowHandle) as SubCategory2Dto;

                if (subCat != null)
                {
                    if (MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, subCat.Name),
                      Properties.Resources.Title_ConfirmAction, MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if (base.ServiceClient.DeleteSubCategory2(subCat.Id))
                        //{
                        //    MessageBox.Show(Properties.Resources.Message_DeleteSuccessfull, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Unable to delete Sub Category level 2", Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemButtonEditDeleteCat1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newSubCategory1.Name= input.Text;
            }
        }

        private void repositoryItemLookUpEditCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(input.EditValue.ToString()))
            {
                this.newSubCategory1.Category.Name = input.EditValue.ToString();
            }
        }

        #endregion

        #region .: Override :.
        public override void Show()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                //this.gridControlSubCategory1.DataSource = base.ServiceClient.GetAllSubCategories1();
                //this.gridControlSubCategory2.DataSource = base.ServiceClient.GetAllSubCategories2();
                //this.repositoryItemLookUpEditCategory.DataSource = base.ServiceClient.GetAllCategories();
                ////this.repositoryItemLookUpEditCategory.ValueMember = "Id";
                //this.repositoryItemLookUpEditSubCategory1.DataSource = base.ServiceClient.GetAllSubCategories1();                
                
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
        #endregion

        #region .: Grid Events :.
        private void gridViewSubCategory1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentSubCat1 = e.Row as SubCategory1Dto;

                //if (currentSubCat1 != null)
                //{
                //    var update = this.ServiceClient.SaveSubCategory1(currentSubCat1);
                //}
                //else
                //{
                //    var newItem = this.ServiceClient.CreateSubCategory1(this.newSubCategory1);
                //}

                //this.gridControlSubCategory1.DataSource = this.ServiceClient.GetAllSubCategories1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
