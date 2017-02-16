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
using SpareParts.Tools;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminUsersControl : BaseControl
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
                return Properties.Resources.ManagementUsers;
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
                return Properties.Resources.users_black_32;
            }
        }

        public UserUIDto currentUser = new UserUIDto();
        #endregion

        #region .: Constructor :.
        public AdminUsersControl()
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
            base.Show();
        }

        public override void Refresh()
        {
            var dtUsers = base.ServiceClient.GetAllUsersForUI().ToDataTable<UserUIDto>();
            this.gridControlUsers.DataSource = dtUsers;
            this.lookUpEditProfile.DataSource = base.ServiceClient.GetAllProfiles();
        }
        #endregion

        #region .: Grid :.
        private void textEditUserName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.UserName = input.Text;
            }
        }

        private void textEditLName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.LastName = input.Text;
            }
        }

        private void textEditFName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.FirstName = input.Text;
            }
        }

        private void textEditEmail_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.Email = input.Text;
            }
        }

        private void textEditMobile_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.Mobile = input.Text;
            }
        }

        private void lookUpEditProfile_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(input.EditValue.ToString()))
            {
                this.currentUser.Profile = input.EditValue.ToString();
            }
        }

        private void textEditPassword_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.currentUser.Password = input.Text;
            }
        }
        
        private void gridViewUsers_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var result = base.ServiceClient.SaveUser(this.currentUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridControlUsers_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var dataRow = this.gridViewUsers.GetDataRow(this.gridViewUsers.FocusedRowHandle) as DataRow;
                    var userName = dataRow["UserName"].ToString();

                    if (!string.IsNullOrEmpty(userName))
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDisable_Confirmation, userName),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DisableUser(userName);
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }

                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
