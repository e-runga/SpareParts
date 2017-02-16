namespace SpareParts.Explorer.Dialogs
{
    partial class ProductTypeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.checkedComboBoxEditCategories = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkedComboBoxEditBrands = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditBrands.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Categories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name:";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(193, 179);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 25);
            this.simpleButtonCancel.TabIndex = 5;
            this.simpleButtonCancel.Text = "&Close";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(112, 179);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 25);
            this.simpleButtonSave.TabIndex = 4;
            this.simpleButtonSave.Text = "&Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(111, 49);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.AutoHeight = false;
            this.textEditName.Size = new System.Drawing.Size(199, 25);
            this.textEditName.TabIndex = 1;
            // 
            // checkedComboBoxEditCategories
            // 
            this.checkedComboBoxEditCategories.EditValue = "";
            this.checkedComboBoxEditCategories.Location = new System.Drawing.Point(111, 89);
            this.checkedComboBoxEditCategories.Name = "checkedComboBoxEditCategories";
            this.checkedComboBoxEditCategories.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEditCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditCategories.Properties.DataSource = this.categoryDtoBindingSource;
            this.checkedComboBoxEditCategories.Properties.DisplayMember = "Name";
            this.checkedComboBoxEditCategories.Properties.ValueMember = "Id";
            this.checkedComboBoxEditCategories.Size = new System.Drawing.Size(199, 20);
            this.checkedComboBoxEditCategories.TabIndex = 2;
            // 
            // checkedComboBoxEditBrands
            // 
            this.checkedComboBoxEditBrands.EditValue = "";
            this.checkedComboBoxEditBrands.Location = new System.Drawing.Point(111, 127);
            this.checkedComboBoxEditBrands.Name = "checkedComboBoxEditBrands";
            this.checkedComboBoxEditBrands.Properties.AllowMultiSelect = true;
            this.checkedComboBoxEditBrands.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditBrands.Properties.DataSource = this.categoryDtoBindingSource;
            this.checkedComboBoxEditBrands.Properties.DisplayMember = "Name";
            this.checkedComboBoxEditBrands.Properties.ValueMember = "Id";
            this.checkedComboBoxEditBrands.Size = new System.Drawing.Size(199, 20);
            this.checkedComboBoxEditBrands.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Brands:";
            // 
            // categoryDtoBindingSource
            // 
            this.categoryDtoBindingSource.DataSource = typeof(SpareParts.Dto.CategoryDto);
            // 
            // ProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 273);
            this.Controls.Add(this.checkedComboBoxEditBrands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedComboBoxEditCategories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.textEditName);
            this.Name = "ProductTypeForm";
            this.Text = "ProductTypeForm";
            this.Load += new System.EventHandler(this.ProductTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditBrands.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEditCategories;
        private System.Windows.Forms.BindingSource categoryDtoBindingSource;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEditBrands;
        private System.Windows.Forms.Label label1;
    }
}