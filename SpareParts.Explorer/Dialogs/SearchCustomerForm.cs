using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpareParts.Explorer.Dialogs
{
    public partial class SearchCustomerForm : BaseForm
    {
        #region .: Constructor :.
        public SearchCustomerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Override :.
        public override string Text
        {
            get
            {
                return Properties.Resources.Title_SearchCustomer;
            }
        }

        #endregion
    }
}
