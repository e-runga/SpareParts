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
    public partial class CustomerBuyProductControl : BaseControl
    {
        #region .: Properties :.
        /// <summary>
        /// The _ current customer
        /// </summary>
        private CustomerDto _CurrentCustomer;

        /// <summary>
        /// Gets or sets the current customer.
        /// </summary>
        /// <value>
        /// The current customer.
        /// </value>
        public CustomerDto CurrentCustomer
        {
            get { return this._CurrentCustomer; }
            set { this._CurrentCustomer = value; }
        }

        /// <summary>
        /// The _ customer products
        /// </summary>
        private List<ProductDto> _CustomerProducts;

        /// <summary>
        /// Gets the customer products.
        /// </summary>
        /// <value>
        /// The customer products.
        /// </value>
        public List<ProductDto> CustomerProducts
        {
            get
            {
                if (this._CustomerProducts == null)
                {
                    this._CustomerProducts = base.ServiceClient.GetProductByCustomerId(this._CurrentCustomer.Id).ToList();
                }

                return this._CustomerProducts;
            }
        }

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
                return Properties.Resources.BuyDepositProduct;
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
                return Properties.Resources.boy_32;
            }
        }

        #endregion

        #region .: Constructors :.
        public CustomerBuyProductControl()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Overrides :.
        public override void Show()
        {
            try
            {
                this.textEditCustomerName.Text = string.Format("{0} {1}", this._CurrentCustomer.LastName, this._CurrentCustomer.FirstName);
                this.textEditCustomerEmail.Text = this._CurrentCustomer.Email;
                this.textEditCustomerMobile.Text = this._CurrentCustomer.Mobile;
                this.textEditCustomerPhone.Text = this._CurrentCustomer.Phone;
                this.gridControlCustomerProducts.DataSource = this._CustomerProducts;

                this.textEditOperatorName.Text = Singletons.Security.Instance.LoggedDisplayName;
                this.textEditOperatorEmail.Text = Singletons.Security.Instance.LoggedUser.Email;

                base.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
