namespace SpareParts.Explorer.Dialogs
{
    partial class SearchCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomerForm));
            this.searchCustomer1 = new SpareParts.Explorer.Controls.SearchCustomerControl();
            this.SuspendLayout();
            // 
            // searchCustomer1
            // 
            this.searchCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCustomer1.Location = new System.Drawing.Point(0, 0);
            this.searchCustomer1.Name = "searchCustomer1";
            this.searchCustomer1.Size = new System.Drawing.Size(952, 638);
            this.searchCustomer1.TabIndex = 0;
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 638);
            this.Controls.Add(this.searchCustomer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchCustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SearchCustomerControl searchCustomer1;
    }
}