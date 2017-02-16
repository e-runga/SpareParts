namespace SpareParts.Explorer.Controls
{
    partial class SearchCustomerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlSearchCustomer = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCustomerType = new DevExpress.XtraEditors.LookUpEdit();
            this.customerTypeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.textEditPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditMobile = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.customerDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditActionButtons = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSearchCustomer)).BeginInit();
            this.groupControlSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditActionButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlSearchCustomer);
            this.splitContainerControl1.Panel1.Text = "PanelCriteria";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlCustomers);
            this.splitContainerControl1.Panel2.Text = "PanelResult";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 636);
            this.splitContainerControl1.SplitterPosition = 122;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControlSearchCustomer
            // 
            this.groupControlSearchCustomer.Controls.Add(this.simpleButtonAddCustomer);
            this.groupControlSearchCustomer.Controls.Add(this.lookUpEditCustomerType);
            this.groupControlSearchCustomer.Controls.Add(this.label6);
            this.groupControlSearchCustomer.Controls.Add(this.simpleButtonCancel);
            this.groupControlSearchCustomer.Controls.Add(this.simpleButtonSearch);
            this.groupControlSearchCustomer.Controls.Add(this.textEditPhoneNumber);
            this.groupControlSearchCustomer.Controls.Add(this.label5);
            this.groupControlSearchCustomer.Controls.Add(this.textEditEmail);
            this.groupControlSearchCustomer.Controls.Add(this.label4);
            this.groupControlSearchCustomer.Controls.Add(this.textEditMobile);
            this.groupControlSearchCustomer.Controls.Add(this.label3);
            this.groupControlSearchCustomer.Controls.Add(this.textEditLastName);
            this.groupControlSearchCustomer.Controls.Add(this.label2);
            this.groupControlSearchCustomer.Controls.Add(this.textEditFirstName);
            this.groupControlSearchCustomer.Controls.Add(this.label1);
            this.groupControlSearchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlSearchCustomer.Location = new System.Drawing.Point(0, 0);
            this.groupControlSearchCustomer.Name = "groupControlSearchCustomer";
            this.groupControlSearchCustomer.ShowCaption = false;
            this.groupControlSearchCustomer.Size = new System.Drawing.Size(950, 122);
            this.groupControlSearchCustomer.TabIndex = 0;
            this.groupControlSearchCustomer.Text = "Search Customer";
            // 
            // simpleButtonAddCustomer
            // 
            this.simpleButtonAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAddCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButtonAddCustomer.Image = global::SpareParts.Explorer.Properties.Resources.customer_add_48;
            this.simpleButtonAddCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonAddCustomer.Location = new System.Drawing.Point(889, 60);
            this.simpleButtonAddCustomer.Name = "simpleButtonAddCustomer";
            this.simpleButtonAddCustomer.Size = new System.Drawing.Size(58, 57);
            this.simpleButtonAddCustomer.TabIndex = 14;
            this.simpleButtonAddCustomer.ToolTip = "Create customer";
            this.simpleButtonAddCustomer.Click += new System.EventHandler(this.simpleButtonAddCustomer_Click);
            // 
            // lookUpEditCustomerType
            // 
            this.lookUpEditCustomerType.Location = new System.Drawing.Point(640, 46);
            this.lookUpEditCustomerType.Name = "lookUpEditCustomerType";
            this.lookUpEditCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCustomerType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpEditCustomerType.Properties.DataSource = this.customerTypeDtoBindingSource;
            this.lookUpEditCustomerType.Properties.DisplayMember = "Name";
            this.lookUpEditCustomerType.Properties.NullText = "";
            this.lookUpEditCustomerType.Properties.ValueMember = "Id";
            this.lookUpEditCustomerType.Size = new System.Drawing.Size(147, 20);
            this.lookUpEditCustomerType.TabIndex = 6;
            this.lookUpEditCustomerType.Popup += new System.EventHandler(this.lookUpEditCustomerType_Popup);
            // 
            // customerTypeDtoBindingSource
            // 
            this.customerTypeDtoBindingSource.DataSource = typeof(SpareParts.Dto.CustomerTypeDto);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Type: ";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(339, 85);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 11;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonSearch
            // 
            this.simpleButtonSearch.Location = new System.Drawing.Point(445, 85);
            this.simpleButtonSearch.Name = "simpleButtonSearch";
            this.simpleButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSearch.TabIndex = 7;
            this.simpleButtonSearch.Text = "Search";
            this.simpleButtonSearch.Click += new System.EventHandler(this.simpleButtonSearch_Click);
            // 
            // textEditPhoneNumber
            // 
            this.textEditPhoneNumber.Location = new System.Drawing.Point(373, 46);
            this.textEditPhoneNumber.Name = "textEditPhoneNumber";
            this.textEditPhoneNumber.Size = new System.Drawing.Size(147, 20);
            this.textEditPhoneNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number: ";
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(640, 20);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Size = new System.Drawing.Size(147, 20);
            this.textEditEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail: ";
            // 
            // textEditMobile
            // 
            this.textEditMobile.Location = new System.Drawing.Point(106, 46);
            this.textEditMobile.Name = "textEditMobile";
            this.textEditMobile.Size = new System.Drawing.Size(147, 20);
            this.textEditMobile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile Number: ";
            // 
            // textEditLastName
            // 
            this.textEditLastName.Location = new System.Drawing.Point(373, 20);
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Size = new System.Drawing.Size(147, 20);
            this.textEditLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Location = new System.Drawing.Point(106, 20);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(147, 20);
            this.textEditFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.DataSource = this.customerDtoBindingSource;
            this.gridControlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomers.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomers.MainView = this.gridViewCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpEditActionButtons});
            this.gridControlCustomers.Size = new System.Drawing.Size(950, 509);
            this.gridControlCustomers.TabIndex = 0;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // customerDtoBindingSource
            // 
            this.customerDtoBindingSource.DataSource = typeof(SpareParts.Dto.CustomerDto);
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colMobile,
            this.colPhone,
            this.colCustomerType,
            this.colId,
            this.colAction});
            this.gridViewCustomers.GridControl = this.gridControlCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.AllowEdit = false;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colCustomerType
            // 
            this.colCustomerType.Caption = "Type";
            this.colCustomerType.FieldName = "CustomerType.Name";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.OptionsColumn.AllowEdit = false;
            this.colCustomerType.Visible = true;
            this.colCustomerType.VisibleIndex = 5;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colAction
            // 
            this.colAction.Caption = "Sell / Buy";
            this.colAction.ColumnEdit = this.lookUpEditActionButtons;
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 6;
            // 
            // lookUpEditActionButtons
            // 
            this.lookUpEditActionButtons.Appearance.Image = global::SpareParts.Explorer.Properties.Resources.PriceTag16x16;
            this.lookUpEditActionButtons.Appearance.Options.UseImage = true;
            this.lookUpEditActionButtons.AppearanceDropDown.Image = global::SpareParts.Explorer.Properties.Resources.PriceTag16x16;
            this.lookUpEditActionButtons.AppearanceDropDown.Options.UseImage = true;
            this.lookUpEditActionButtons.AutoHeight = false;
            this.lookUpEditActionButtons.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SpareParts.Explorer.Properties.Resources.PriceTag16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, true)});
            this.lookUpEditActionButtons.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Action", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Display Name", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditActionButtons.DisplayMember = "DisplayName";
            this.lookUpEditActionButtons.Name = "lookUpEditActionButtons";
            this.lookUpEditActionButtons.NullText = "";
            this.lookUpEditActionButtons.ShowFooter = false;
            this.lookUpEditActionButtons.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.lookUpEditActionButtons.ValueMember = "Name";
            this.lookUpEditActionButtons.EditValueChanged += new System.EventHandler(this.lookUpEditActionButtons_EditValueChanged);
            // 
            // SearchCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "SearchCustomerControl";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSearchCustomer)).EndInit();
            this.groupControlSearchCustomer.ResumeLayout(false);
            this.groupControlSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditActionButtons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControlSearchCustomer;
        private DevExpress.XtraEditors.TextEdit textEditPhoneNumber;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditMobile;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSearch;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private System.Windows.Forms.BindingSource customerDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCustomerType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource customerTypeDtoBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditActionButtons;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
    }
}
