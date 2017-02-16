using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpareParts.Dto;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminRatingsControl : BaseControl
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
                return Properties.Resources.ManagementRatings;
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
                return Properties.Resources.star_black_32;
            }
        }

        private RatingDto newRating = new RatingDto();
        #endregion

        #region .: Constructor :.
        public AdminRatingsControl()
        {
            InitializeComponent();
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
            this.gridControlRatings.DataSource = base.ServiceClient.GetAllRatings();
        }

        #endregion

        private void textEditName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newRating.Name = input.Text;
            }
        }

        private void textEditAmount_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newRating.Amount = Convert.ToDecimal(input.Text.Replace("%", string.Empty));
            }
        }

        private void gridViewRatings_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var rating = e.Row as RatingDto ?? this.newRating;
                var updated = base.ServiceClient.SaveRating(rating);

                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlRatings_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var itemToDelete = this.gridViewRatings.GetRow(this.gridViewRatings.FocusedRowHandle) as RatingDto;

                    if (itemToDelete != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, itemToDelete.Name),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteRating(itemToDelete.Id);
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
    }
}