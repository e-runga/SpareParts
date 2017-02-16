namespace SpareParts.Explorer.Dialogs
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSaveCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCustomerType = new DevExpress.XtraEditors.LookUpEdit();
            this.customerTypeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.textEditMobile = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(86, 304);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonCancel.TabIndex = 28;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonSaveCustomer
            // 
            this.simpleButtonSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSaveCustomer.Image")));
            this.simpleButtonSaveCustomer.Location = new System.Drawing.Point(181, 304);
            this.simpleButtonSaveCustomer.Name = "simpleButtonSaveCustomer";
            this.simpleButtonSaveCustomer.Size = new System.Drawing.Size(75, 38);
            this.simpleButtonSaveCustomer.TabIndex = 27;
            this.simpleButtonSaveCustomer.Text = "Save";
            this.simpleButtonSaveCustomer.Click += new System.EventHandler(this.simpleButtonSaveCustomer_Click);
            // 
            // lookUpEditCustomerType
            // 
            this.lookUpEditCustomerType.Location = new System.Drawing.Point(86, 252);
            this.lookUpEditCustomerType.Name = "lookUpEditCustomerType";
            this.lookUpEditCustomerType.Properties.AutoHeight = false;
            this.lookUpEditCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCustomerType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEditCustomerType.Properties.DataSource = this.customerTypeDtoBindingSource;
            this.lookUpEditCustomerType.Properties.DisplayMember = "Name";
            this.lookUpEditCustomerType.Properties.NullText = "";
            this.lookUpEditCustomerType.Properties.ValueMember = "Id";
            this.lookUpEditCustomerType.Size = new System.Drawing.Size(170, 25);
            this.lookUpEditCustomerType.TabIndex = 26;
            this.lookUpEditCustomerType.Popup += new System.EventHandler(this.lookUpEditCustomerType_Popup);
            // 
            // customerTypeDtoBindingSource
            // 
            this.customerTypeDtoBindingSource.DataSource = typeof(SpareParts.Dto.CustomerTypeDto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Type *:";
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(86, 221);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.AutoHeight = false;
            this.textEditEmail.Size = new System.Drawing.Size(170, 25);
            this.textEditEmail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email *:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone:";
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(86, 190);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.AutoHeight = false;
            this.textEditPhone.Size = new System.Drawing.Size(170, 25);
            this.textEditPhone.TabIndex = 21;
            // 
            // textEditMobile
            // 
            this.textEditMobile.Location = new System.Drawing.Point(86, 159);
            this.textEditMobile.Name = "textEditMobile";
            this.textEditMobile.Properties.AutoHeight = false;
            this.textEditMobile.Size = new System.Drawing.Size(170, 25);
            this.textEditMobile.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mobile *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name *:";
            // 
            // textEditLastName
            // 
            this.textEditLastName.Location = new System.Drawing.Point(86, 128);
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Properties.AutoHeight = false;
            this.textEditLastName.Size = new System.Drawing.Size(170, 25);
            this.textEditLastName.TabIndex = 17;
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Location = new System.Drawing.Point(86, 97);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Properties.AutoHeight = false;
            this.textEditFirstName.Size = new System.Drawing.Size(170, 25);
            this.textEditFirstName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name *:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpareParts.Explorer.Properties.Resources.boy;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonSaveCustomer);
            this.Controls.Add(this.lookUpEditCustomerType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEditEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditPhone);
            this.Controls.Add(this.textEditMobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditLastName);
            this.Controls.Add(this.textEditFirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewCustomer";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSaveCustomer;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCustomerType;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.TextEdit textEditMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource customerTypeDtoBindingSource;
    }
}