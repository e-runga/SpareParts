namespace SpareParts.Explorer.Controls
{
    partial class AdminUsersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersControl));
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.userUIDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection(this.components);
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditUserName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditFName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditLName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditProfile = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.profileDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditEmail = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditMobile = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditPassword = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUIDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.DataSource = this.userUIDtoBindingSource;
            this.gridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlUsers.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlUsers.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlUsers.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlUsers.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Next.ImageIndex = 6;
            this.gridControlUsers.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Prev.ImageIndex = 7;
            this.gridControlUsers.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlUsers.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlUsers.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlUsers_EmbeddedNavigator_ButtonClick);
            this.gridControlUsers.Location = new System.Drawing.Point(0, 0);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditUserName,
            this.textEditLName,
            this.textEditFName,
            this.textEditEmail,
            this.textEditMobile,
            this.lookUpEditProfile,
            this.textEditPassword});
            this.gridControlUsers.Size = new System.Drawing.Size(950, 636);
            this.gridControlUsers.TabIndex = 0;
            this.gridControlUsers.UseEmbeddedNavigator = true;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // userUIDtoBindingSource
            // 
            this.userUIDtoBindingSource.DataSource = typeof(SpareParts.Dto.UserUIDto);
            // 
            // imageCollectionNavigator
            // 
            this.imageCollectionNavigator.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNavigator.ImageStream")));
            this.imageCollectionNavigator.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0);
            this.imageCollectionNavigator.Images.SetKeyName(0, "apply_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 1);
            this.imageCollectionNavigator.Images.SetKeyName(1, "cancel_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("doublefirst_16x16.png", "images/arrows/doublefirst_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublefirst_16x16.png"), 2);
            this.imageCollectionNavigator.Images.SetKeyName(2, "doublefirst_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("doublelast_16x16.png", "images/arrows/doublelast_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublelast_16x16.png"), 3);
            this.imageCollectionNavigator.Images.SetKeyName(3, "doublelast_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("doublenext_16x16.png", "images/arrows/doublenext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doublenext_16x16.png"), 4);
            this.imageCollectionNavigator.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("doubleprev_16x16.png", "images/arrows/doubleprev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/doubleprev_16x16.png"), 5);
            this.imageCollectionNavigator.Images.SetKeyName(5, "doubleprev_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("next_16x16.png", "images/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_16x16.png"), 6);
            this.imageCollectionNavigator.Images.SetKeyName(6, "next_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("prev_16x16.png", "images/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_16x16.png"), 7);
            this.imageCollectionNavigator.Images.SetKeyName(7, "prev_16x16.png");
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colFirstName,
            this.colLastName,
            this.colProfile,
            this.colEmail,
            this.colMobile,
            this.colPassword,
            this.colId,
            this.colEnabled});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewUsers.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewUsers.OptionsView.ShowGroupPanel = false;
            this.gridViewUsers.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewUsers_RowUpdated);
            // 
            // colUserName
            // 
            this.colUserName.ColumnEdit = this.textEditUserName;
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsEditForm.Caption = "User Name (*):";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // textEditUserName
            // 
            this.textEditUserName.AutoHeight = false;
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditUserName_Validating);
            // 
            // colFirstName
            // 
            this.colFirstName.ColumnEdit = this.textEditFName;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsEditForm.Caption = "First Name (*):";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // textEditFName
            // 
            this.textEditFName.AutoHeight = false;
            this.textEditFName.Name = "textEditFName";
            this.textEditFName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditFName_Validating);
            // 
            // colLastName
            // 
            this.colLastName.ColumnEdit = this.textEditLName;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsEditForm.Caption = "Last Name (*):";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // textEditLName
            // 
            this.textEditLName.AutoHeight = false;
            this.textEditLName.Name = "textEditLName";
            this.textEditLName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditLName_Validating);
            // 
            // colProfile
            // 
            this.colProfile.ColumnEdit = this.lookUpEditProfile;
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.OptionsEditForm.Caption = "Profile (*):";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 5;
            // 
            // lookUpEditProfile
            // 
            this.lookUpEditProfile.AutoHeight = false;
            this.lookUpEditProfile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProfile.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEditProfile.DataSource = this.profileDtoBindingSource;
            this.lookUpEditProfile.DisplayMember = "Name";
            this.lookUpEditProfile.Name = "lookUpEditProfile";
            this.lookUpEditProfile.NullText = "";
            this.lookUpEditProfile.ValueMember = "Name";
            this.lookUpEditProfile.Validating += new System.ComponentModel.CancelEventHandler(this.lookUpEditProfile_Validating);
            // 
            // profileDtoBindingSource
            // 
            this.profileDtoBindingSource.DataSource = typeof(SpareParts.Dto.ProfileDto);
            // 
            // colEmail
            // 
            this.colEmail.ColumnEdit = this.textEditEmail;
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsEditForm.Caption = "Email (*):";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // textEditEmail
            // 
            this.textEditEmail.AutoHeight = false;
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEditEmail_Validating);
            // 
            // colMobile
            // 
            this.colMobile.ColumnEdit = this.textEditMobile;
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 4;
            // 
            // textEditMobile
            // 
            this.textEditMobile.AutoHeight = false;
            this.textEditMobile.Name = "textEditMobile";
            this.textEditMobile.Validating += new System.ComponentModel.CancelEventHandler(this.textEditMobile_Validating);
            // 
            // colPassword
            // 
            this.colPassword.ColumnEdit = this.textEditPassword;
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsEditForm.Caption = "Password (*):";
            this.colPassword.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // textEditPassword
            // 
            this.textEditPassword.AutoHeight = false;
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textEditPassword_Validating);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // userDtoBindingSource
            // 
            this.userDtoBindingSource.DataSource = typeof(SpareParts.Dto.UserDto);
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            // 
            // AdminUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUsers);
            this.Name = "AdminUsersControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUIDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditUserName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditFName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditLName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditProfile;
        private System.Windows.Forms.BindingSource profileDtoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditMobile;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditPassword;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
        private System.Windows.Forms.BindingSource userUIDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
    }
}
