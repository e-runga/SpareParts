using DevExpress.XtraEditors.Popup;
using SpareParts.Dto;
using System;
using System.Windows.Forms;

namespace SpareParts.Explorer.Dialogs
{
    public partial class NewCustomer : BaseForm
    {
        #region .: Constructor :.
        public NewCustomer()
        {
                InitializeComponent();
        }
        #endregion

        #region .: Events :.
        private void NewCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                this.lookUpEditCustomerType.Properties.DataSource = base.ServiceClient.GetAllCustomerTypes();
                base.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region .: Action buttons :.
        private void simpleButtonSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.textEditFirstName.Text.Trim())
                  && string.IsNullOrEmpty(this.textEditLastName.Text.Trim())
                  && string.IsNullOrEmpty(this.textEditMobile.Text.Trim())
                  && string.IsNullOrEmpty(this.textEditPhone.Text.Trim())
                  && this.lookUpEditCustomerType.EditValue == null)
                {
                    MessageBox.Show(Properties.Resources.Error_MandatoryFields, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Arrow;
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(this.textEditFirstName.Text.Trim()))
                    {
                        MessageBox.Show(Properties.Resources.Error_FirstNameMandatory, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(this.textEditLastName.Text.Trim()))
                    {
                        MessageBox.Show(Properties.Resources.Error_LastNameMandatory, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(this.textEditEmail.Text.Trim()))
                    {
                        MessageBox.Show(Properties.Resources.Error_EmailMandatory, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(this.textEditMobile.Text.Trim()))
                    {
                        MessageBox.Show(Properties.Resources.Error_MobileMandatory, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (this.lookUpEditCustomerType.EditValue == null)
                    {
                        MessageBox.Show(Properties.Resources.Error_CustomerTypeMandatory, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var dto = new CustomerDto
                    {
                        Id = 0,
                        FirstName = this.textEditFirstName.Text.Trim(),
                        LastName = this.textEditLastName.Text.Trim(),
                        Mobile = this.textEditMobile.Text.Trim(),
                        Phone = this.textEditPhone.Text.Trim(),
                        Email = this.textEditEmail.Text.Trim(),
                        CustomerType = new CustomerTypeDto { Id = Convert.ToInt32(this.lookUpEditCustomerType.EditValue) }
                    };

                    var result = base.ServiceClient.CreateCustomer(dto);

                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.Message_SuccessCustomerCreated, Properties.Resources.Message_Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region .: Events :.
        private void lookUpEditCustomerType_Popup(object sender, EventArgs e)
        {
            var lookUp = sender as DevExpress.XtraEditors.LookUpEdit;
            var form = (lookUp as DevExpress.Utils.Win.IPopupControl).PopupWindow as PopupLookUpEditForm;
            form.Width = lookUp.Width;
        }
        #endregion
    }
}