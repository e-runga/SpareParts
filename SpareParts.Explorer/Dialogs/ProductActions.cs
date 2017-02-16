using SpareParts.Dto;
using SpareParts.Explorer.Helper;
using System;
using System.Linq;
using System.Windows.Forms;
using static SpareParts.Tools.Enums;

namespace SpareParts.Explorer.Dialogs
{
    public partial class ProductActions : BaseForm
    {
        #region .: Properties :.
        private ProductViewDto _Product;

        public ProductViewDto Product
        {
            get { return this._Product; }
            set { this._Product = value; }
        }

        private bool _IsRequestOrOrder;

        public bool IsRequestOrOrder
        {
            get { return this._IsRequestOrOrder; }
            set { this._IsRequestOrOrder = value; }
        }

        public ProductStatus Action;
        #endregion

        #region .: Constructor :.
        public ProductActions()
        {
            InitializeComponent();
        }

        #endregion

        #region .: Overrirde :.
        protected override void OnLoad(EventArgs e)
        {
            this.labelPrice.Visible = this._IsRequestOrOrder;
            this.textEditAdvancePayment.Visible = this._IsRequestOrOrder;
            this.labelAdvance.Visible = this._IsRequestOrOrder;
            this.textEditPrice.Visible = this._IsRequestOrOrder;

            this.textEditDate.Text = DateTime.Now.ToShortDateString();
            this.textEditProduct.Text = string.Format("{0} - {1} - {2}", this._Product.ProductType, this._Product.Brand, this._Product.Model);

            switch (this.Action)
            {
                case ProductStatus.New:
                    break;
                case ProductStatus.Complained:
                    this.pictureBox1.Image = Properties.Resources.Complaint_64;
                    this.textEditNumber.Visible = false;
                    this.labelNumber.Visible = false;
                    this.lookUpEditReplacedProduct.Visible = false;
                    this.labelReplacedProduct.Visible = false;
                    break;
                case ProductStatus.Returned:
                    this.pictureBox1.Image = Properties.Resources.return_64;
                    this.textEditNumber.Visible = false;
                    this.labelNumber.Visible = false;
                    this.lookUpEditReplacedProduct.Visible = false;
                    this.labelReplacedProduct.Visible = false;
                    break;
                case ProductStatus.Replaced:
                    this.lookUpEditReplacedProduct.Properties.DataSource = this.ServiceClient.GetAllProductSummaries()
                        .Where(p => p.ProductId != this._Product.ProductId);
                    this.lookUpEditReplacedProduct.Popup += this.CommonControlLookupPopup;
                    this.pictureBox1.Image = Properties.Resources.find_replace_64;
                    this.lookUpEditReplacedProduct.Visible = true;
                    this.labelReplacedProduct.Visible = true;
                    this.textEditNumber.Visible = false;
                    this.labelNumber.Visible = false;
                    break;
                case ProductStatus.Requested:
                    this.pictureBox1.Image = Properties.Resources.Search_Product_64;
                    this.textEditNumber.Visible = true;
                    this.labelNumber.Visible = true;
                    this.labelNumber.Text = "Request Nr.:";
                    this.lookUpEditReplacedProduct.Visible = false;
                    this.labelReplacedProduct.Visible = false;
                    break;
                case ProductStatus.Ordered:
                    this.pictureBox1.Image = Properties.Resources.purchase_order_64;
                    this.textEditNumber.Visible = true;
                    this.labelNumber.Visible = true;
                    this.labelNumber.Text = "Order Nr.:";
                    this.lookUpEditReplacedProduct.Visible = false;
                    this.labelReplacedProduct.Visible = false;
                    break;
            }

            base.OnLoad(e);
        }
        #endregion

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonBuyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Action == ProductStatus.Requested || this.Action == ProductStatus.Ordered)
                {
                    var action = this.Action.ToString().Substring(this.Action.ToString().Length - 2);

                    if (string.IsNullOrEmpty(this.textEditNumber.Text))
                    {
                        MessageBox.Show(string.Format(Properties.Resources.Error_FillNumber, action), Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Arrow;
                        return;
                    }
                }
                else if (this.Action == ProductStatus.Ordered)
                {
                    if (string.IsNullOrEmpty(this.textEditPrice.Text) || string.IsNullOrEmpty(this.textEditAdvancePayment.Text))
                    {
                        MessageBox.Show(Properties.Resources.Error_FillAmounts, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Arrow;
                        return;
                    }
                }
                else if (this.Action == ProductStatus.Replaced)
                {
                    if (string.IsNullOrEmpty(this.lookUpEditReplacedProduct.EditValue.ToString()))
                    {
                        MessageBox.Show(Properties.Resources.Error_SelectReplacementProduct, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Arrow;
                        return;
                    }
                }

                var product = new ProductDto
                {
                    Id = this.Product.ProductId
                };

                switch (this.Action)
                {
                    case ProductStatus.Bought:
                        break;
                    case ProductStatus.Sold:
                        break;
                    case ProductStatus.Complained:
                        product.HasComplaint = true;
                        product.ComplaintDate = DateTime.Now;
                        product.ComplaintOperator = Singletons.Security.Instance.LoggedUser.ToOperator();
                        this.ServiceClient.SaveProductComplaint(product);
                        break;
                    case ProductStatus.Returned:
                        product.IsReturn = true;
                        product.ReturnOperator = Singletons.Security.Instance.LoggedUser.ToOperator();
                        product.ReturnDate = DateTime.Now;
                        this.ServiceClient.SaveProductReturn(product);
                        break;
                    case ProductStatus.Replaced:
                        product.IsReplace = true;
                        product.ReplaceDate = DateTime.Now;
                        product.ReplacementOperator = Singletons.Security.Instance.LoggedUser.ToOperator();
                        product.ReplaceProductId = Convert.ToInt32(this.lookUpEditReplacedProduct.EditValue);
                        this.ServiceClient.SaveProductReplacement(product);
                        break;
                    case ProductStatus.Requested:
                        product.RequestDate = DateTime.Now;
                        product.RequestNumber = this.textEditNumber.Text;
                        product.RequestOperator = Singletons.Security.Instance.LoggedUser.ToOperator();
                        this.ServiceClient.SaveProductRequest(product);
                        break;
                    case ProductStatus.Ordered:
                        product.HasOrder = true;
                        product.OrderDate = DateTime.Now;
                        product.OrderNumber = this.textEditNumber.Text;
                        product.OrderOperator = Singletons.Security.Instance.LoggedUser.ToOperator();
                        product.OrderSellingPrice = Convert.ToDecimal(this.textEditPrice.Text);
                        product.AdvancePaymentAmount = Convert.ToDecimal(this.textEditAdvancePayment.Text);
                        this.ServiceClient.SaveProductOrdering(product);
                        break;
                }

                MessageBox.Show(Properties.Resources.Message_SuccessProductUpdate, Properties.Resources.Message_Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Arrow;
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
