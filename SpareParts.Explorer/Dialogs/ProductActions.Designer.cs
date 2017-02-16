namespace SpareParts.Explorer.Dialogs
{
    partial class ProductActions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductActions));
            this.textEditDate = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEditProduct = new DevExpress.XtraEditors.TextEdit();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBuyProduct = new DevExpress.XtraEditors.SimpleButton();
            this.textEditAdvancePayment = new DevExpress.XtraEditors.TextEdit();
            this.labelAdvance = new System.Windows.Forms.Label();
            this.textEditNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelNumber = new System.Windows.Forms.Label();
            this.lookUpEditReplacedProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.productSummaryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelReplacedProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdvancePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReplacedProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSummaryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditDate
            // 
            this.textEditDate.Enabled = false;
            this.textEditDate.Location = new System.Drawing.Point(88, 104);
            this.textEditDate.Name = "textEditDate";
            this.textEditDate.Size = new System.Drawing.Size(172, 20);
            this.textEditDate.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpareParts.Explorer.Properties.Resources.cash_register64;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(88, 158);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Properties.Mask.EditMask = "n2";
            this.textEditPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditPrice.Size = new System.Drawing.Size(172, 20);
            this.textEditPrice.TabIndex = 39;
            // 
            // textEditProduct
            // 
            this.textEditProduct.Enabled = false;
            this.textEditProduct.Location = new System.Drawing.Point(88, 130);
            this.textEditProduct.Name = "textEditProduct";
            this.textEditProduct.Size = new System.Drawing.Size(172, 20);
            this.textEditProduct.TabIndex = 38;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(38, 161);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 36;
            this.labelPrice.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Product:";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(60, 297);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonCancel.TabIndex = 44;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonBuyProduct
            // 
            this.simpleButtonBuyProduct.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBuyProduct.Image")));
            this.simpleButtonBuyProduct.Location = new System.Drawing.Point(155, 297);
            this.simpleButtonBuyProduct.Name = "simpleButtonBuyProduct";
            this.simpleButtonBuyProduct.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonBuyProduct.TabIndex = 43;
            this.simpleButtonBuyProduct.Text = "Save";
            this.simpleButtonBuyProduct.Click += new System.EventHandler(this.simpleButtonBuyProduct_Click);
            // 
            // textEditAdvancePayment
            // 
            this.textEditAdvancePayment.Location = new System.Drawing.Point(88, 184);
            this.textEditAdvancePayment.Name = "textEditAdvancePayment";
            this.textEditAdvancePayment.Properties.Mask.EditMask = "n2";
            this.textEditAdvancePayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditAdvancePayment.Size = new System.Drawing.Size(172, 20);
            this.textEditAdvancePayment.TabIndex = 46;
            // 
            // labelAdvance
            // 
            this.labelAdvance.AutoSize = true;
            this.labelAdvance.Location = new System.Drawing.Point(19, 187);
            this.labelAdvance.Name = "labelAdvance";
            this.labelAdvance.Size = new System.Drawing.Size(53, 13);
            this.labelAdvance.TabIndex = 45;
            this.labelAdvance.Text = "Advance:";
            // 
            // textEditNumber
            // 
            this.textEditNumber.Location = new System.Drawing.Point(88, 210);
            this.textEditNumber.Name = "textEditNumber";
            this.textEditNumber.Size = new System.Drawing.Size(172, 20);
            this.textEditNumber.TabIndex = 48;
            this.textEditNumber.Visible = false;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(5, 213);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(67, 13);
            this.labelNumber.TabIndex = 47;
            this.labelNumber.Text = "Request Nr.:";
            this.labelNumber.Visible = false;
            // 
            // lookUpEditReplacedProduct
            // 
            this.lookUpEditReplacedProduct.Location = new System.Drawing.Point(88, 237);
            this.lookUpEditReplacedProduct.Name = "lookUpEditReplacedProduct";
            this.lookUpEditReplacedProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditReplacedProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductId", "Product Id", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Product", "Product", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditReplacedProduct.Properties.DataSource = this.productSummaryDtoBindingSource;
            this.lookUpEditReplacedProduct.Properties.DisplayMember = "Product";
            this.lookUpEditReplacedProduct.Properties.NullText = "";
            this.lookUpEditReplacedProduct.Properties.ValueMember = "ProductId";
            this.lookUpEditReplacedProduct.Size = new System.Drawing.Size(172, 20);
            this.lookUpEditReplacedProduct.TabIndex = 49;
            // 
            // productSummaryDtoBindingSource
            // 
            this.productSummaryDtoBindingSource.DataSource = typeof(SpareParts.Dto.ProductSummaryDto);
            // 
            // labelReplacedProduct
            // 
            this.labelReplacedProduct.AutoSize = true;
            this.labelReplacedProduct.Location = new System.Drawing.Point(5, 240);
            this.labelReplacedProduct.Name = "labelReplacedProduct";
            this.labelReplacedProduct.Size = new System.Drawing.Size(73, 13);
            this.labelReplacedProduct.TabIndex = 50;
            this.labelReplacedProduct.Text = "Replacement:";
            // 
            // ProductActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 382);
            this.Controls.Add(this.labelReplacedProduct);
            this.Controls.Add(this.lookUpEditReplacedProduct);
            this.Controls.Add(this.textEditNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textEditAdvancePayment);
            this.Controls.Add(this.labelAdvance);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonBuyProduct);
            this.Controls.Add(this.textEditDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textEditPrice);
            this.Controls.Add(this.textEditProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label2);
            this.Name = "ProductActions";
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdvancePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReplacedProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSummaryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private DevExpress.XtraEditors.TextEdit textEditProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBuyProduct;
        private DevExpress.XtraEditors.TextEdit textEditAdvancePayment;
        private System.Windows.Forms.Label labelAdvance;
        private DevExpress.XtraEditors.TextEdit textEditNumber;
        private System.Windows.Forms.Label labelNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditReplacedProduct;
        private System.Windows.Forms.Label labelReplacedProduct;
        private System.Windows.Forms.BindingSource productSummaryDtoBindingSource;
    }
}