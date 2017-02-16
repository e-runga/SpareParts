using SpareParts.Dto;
using SpareParts.Explorer.Helper;
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
    public partial class CustomerBuyingConfirmation : BaseForm
    {
        #region .: Properties :.
        private CustomerDto _Customer;

        public CustomerDto Customer
        {
            get { return this._Customer; }
            set { this._Customer = value; }
        }

        private ProductViewDto _Product;

        public ProductViewDto Product
        {
            get { return this._Product; }
            set { this._Product = value; }
        }
        #endregion

        #region .: Constructor :.
        public CustomerBuyingConfirmation()
        {
            InitializeComponent();
        }
        #endregion

        #region .: Form :.
        private void CustomerBuyingConfirmation_Load(object sender, EventArgs e)
        {
            this.textEditDate.Text = DateTime.Now.ToShortDateString();
            this.textEditProduct.Text = string.Format("{0} ({1})", this.Product.ProductName, this.Product.VIN);
            this.textEditPrice.Text = this.Product.SellPrice.ToString("f");
        }

        #endregion

        #region .: Buttons :.
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonBuyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var soldProduct = new ProductDto
                {
                    Id = this.Product.ProductId,
                    Buyer = null,
                    SellingDate = DateTime.Now,
                    SellingPrice = Convert.ToDecimal(this.textEditPrice.Text),
                    SellingOperator = Singletons.Security.Instance.LoggedUser.ToOperator(),
                    CardIdentificationNumber = this.textEditCardID.Text,
                    Mecanic = false
                };

                var result = this.ServiceClient.SaveProductSelling(soldProduct);

                if (result != null)
                {
                    MessageBox.Show(string.Format(Properties.Resources.Message_SellingSuccessfull, this.Product.ProductName, this.textEditCardID.Text), Properties.Resources.Message_Success , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Arrow;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.Error_UnableToSellProduct, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Arrow;
                    return;
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
