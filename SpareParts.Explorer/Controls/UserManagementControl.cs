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

namespace SpareParts.Explorer.Controls
{
    public partial class UserManagementControl : BaseControl
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

        public UserDto currentUser = new UserDto { Profile = new ProfileDto() };
        #endregion

        #region .: Constructor :.
        public UserManagementControl()
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
            //this.gridControlUsers.DataSource = base.ServiceClient.GetAllUsers();
            //this.lookUpEditProfile.DataSource = base.ServiceClient.GetAllProfiles();
        }
        #endregion

        
    }
}