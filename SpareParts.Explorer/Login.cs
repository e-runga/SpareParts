using System;
using System.Windows.Forms;

namespace SpareParts.Explorer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = this.simpleButtonLogin;
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textEditUserName.Text) && string.IsNullOrEmpty(this.textEditPassword.Text))
            {
                MessageBox.Show("Please fill in your user name and password");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Singletons.Security.Instance.CurrentUserName = this.textEditUserName.Text;

                if (!string.IsNullOrEmpty(this.textEditPassword.Text))
                {
                    DataService.IDataService serviceClient = new DataService.DataServiceClient();
                    var encryptedPassword = Tools.Encryption.TripleDESHelper.Encrypt(this.textEditPassword.Text);
                    var authenticated = serviceClient.Authenticate(this.textEditUserName.Text, encryptedPassword);

                    Cursor.Current = Cursors.Default;

                    if (authenticated)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User name and password do not match. Please enter valid credentials !", "Error", MessageBoxButtons.OK);
                    }
                }
                
            }
        }
    }
}
