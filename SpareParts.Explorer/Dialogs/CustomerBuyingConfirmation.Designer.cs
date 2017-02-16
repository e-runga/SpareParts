namespace SpareParts.Explorer.Dialogs
{
    partial class CustomerBuyingConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBuyingConfirmation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditCardID = new DevExpress.XtraEditors.TextEdit();
            this.textEditProduct = new DevExpress.XtraEditors.TextEdit();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBuyProduct = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEditDate = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // textEditCardID
            // 
            this.textEditCardID.Location = new System.Drawing.Point(88, 124);
            this.textEditCardID.Name = "textEditCardID";
            this.textEditCardID.Size = new System.Drawing.Size(172, 20);
            this.textEditCardID.TabIndex = 3;
            // 
            // textEditProduct
            // 
            this.textEditProduct.Enabled = false;
            this.textEditProduct.Location = new System.Drawing.Point(88, 150);
            this.textEditProduct.Name = "textEditProduct";
            this.textEditProduct.Size = new System.Drawing.Size(172, 20);
            this.textEditProduct.TabIndex = 4;
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(88, 177);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Properties.Mask.EditMask = "n2";
            this.textEditPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditPrice.Size = new System.Drawing.Size(172, 20);
            this.textEditPrice.TabIndex = 5;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(59, 223);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonCancel.TabIndex = 30;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonBuyProduct
            // 
            this.simpleButtonBuyProduct.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBuyProduct.Image")));
            this.simpleButtonBuyProduct.Location = new System.Drawing.Point(154, 223);
            this.simpleButtonBuyProduct.Name = "simpleButtonBuyProduct";
            this.simpleButtonBuyProduct.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonBuyProduct.TabIndex = 29;
            this.simpleButtonBuyProduct.Text = "Save";
            this.simpleButtonBuyProduct.Click += new System.EventHandler(this.simpleButtonBuyProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpareParts.Explorer.Properties.Resources.cash_register64;
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textEditDate
            // 
            this.textEditDate.Enabled = false;
            this.textEditDate.Location = new System.Drawing.Point(88, 98);
            this.textEditDate.Name = "textEditDate";
            this.textEditDate.Size = new System.Drawing.Size(172, 20);
            this.textEditDate.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date:";
            // 
            // CustomerBuyingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.textEditDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonBuyProduct);
            this.Controls.Add(this.textEditPrice);
            this.Controls.Add(this.textEditProduct);
            this.Controls.Add(this.textEditCardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerBuyingConfirmation";
            this.Load += new System.EventHandler(this.CustomerBuyingConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCardID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditCardID;
        private DevExpress.XtraEditors.TextEdit textEditProduct;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBuyProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit textEditDate;
        private System.Windows.Forms.Label label4;
    }
}