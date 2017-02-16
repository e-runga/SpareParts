using SpareParts.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminModelsControl : BaseControl
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
                return Properties.Resources.ManagementModels;
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
                return Properties.Resources.car_32;
            }
        }

        private ModelDto newModel = new ModelDto { SubModels = new List<SubModelDto>() };

        private SubModelDto newSubModel = new SubModelDto { Models = new List<ModelDto>() };
        #endregion

        #region .: Constructor :.
        public AdminModelsControl()
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
        }

        public override void Refresh()
        {
            this.gridControlModels.DataSource = base.ServiceClient.GetAllModels();
            this.gridControlSubModels.DataSource = base.ServiceClient.GetAllSubModels();
            this.checkedComboBoxEditModels.DataSource = base.ServiceClient.GetAllModels();
        }

        #endregion

        #region .: Buttons Actions :.
        private void gridControlModels_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var itemToDelete = this.gridViewModels.GetRow(this.gridViewModels.FocusedRowHandle) as ModelDto;

                    if (itemToDelete != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDeleteModel_Confirmation, itemToDelete.Name),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteModel(itemToDelete.Id);
                            this.Refresh();
                        }
                    }
                    else
                    {
                        throw new Exception("The item does not exist !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlSubModels_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var itemToDelete = this.gridViewSubModels.GetRow(this.gridViewSubModels.FocusedRowHandle) as SubModelDto;

                    if (itemToDelete != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, itemToDelete.Name),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteSubModel(itemToDelete.Id);
                            this.Refresh();
                        }
                    }
                    else
                    {
                        throw new Exception("The item does not exist !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region .: Grid :.

        #region .: Model Grid :.
        private void gridViewModels_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var currentModel = e.Row as ModelDto;

                if (currentModel != null)
                {
                    var update = base.ServiceClient.SaveModel(currentModel);
                }
                else
                {
                    var newItem = base.ServiceClient.CreateModel(this.newModel);
                }

                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textEditModelName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newModel.Name = input.Text;
            }
        }
        #endregion

        #region .: Sub Model Grid :.
        private void gridViewSubModels_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var result = base.ServiceClient.SaveSubModel(this.newSubModel);

                this.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textEditSubModelName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newSubModel.Name = input.Text;
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
                    if (!this.newSubModel.Models.Any(m => m.Name.Equals(item)))
                    {
                        this.newSubModel.Models.Add(new ModelDto { Name = item });
                    }
                }
            }
        }

        private void gridViewSubModels_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.Name == "gridColumnModels")
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

        #endregion

        #endregion

        #region .: Delegates :.
        private void GridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = 25;
        }
        #endregion
    }
}
