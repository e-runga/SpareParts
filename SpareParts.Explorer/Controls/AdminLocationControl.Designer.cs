namespace SpareParts.Explorer.Controls
{
    partial class AdminLocationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLocationControl));
            this.gridControlCountries = new DevExpress.XtraGrid.GridControl();
            this.countryUIDtoBindingSource = new System.Windows.Forms.BindingSource();
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection();
            this.gridViewCountries = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditCountryName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlCities = new DevExpress.XtraGrid.GridControl();
            this.cityUIDtoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewCities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditCityName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditCountry = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryUIDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCountryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityUIDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCountries
            // 
            this.gridControlCountries.DataSource = this.countryUIDtoBindingSource;
            this.gridControlCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCountries.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCountries.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCountries.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlCountries.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlCountries.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlCountries.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlCountries.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlCountries.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlCountries_EmbeddedNavigator_ButtonClick);
            this.gridControlCountries.Location = new System.Drawing.Point(0, 0);
            this.gridControlCountries.MainView = this.gridViewCountries;
            this.gridControlCountries.Name = "gridControlCountries";
            this.gridControlCountries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditCountryName});
            this.gridControlCountries.Size = new System.Drawing.Size(955, 317);
            this.gridControlCountries.TabIndex = 0;
            this.gridControlCountries.UseEmbeddedNavigator = true;
            this.gridControlCountries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCountries});
            // 
            // countryUIDtoBindingSource
            // 
            this.countryUIDtoBindingSource.DataSource = typeof(SpareParts.Dto.CountryUIDto);
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
            this.imageCollectionNavigator.InsertGalleryImage("first_16x16.png", "images/arrows/first_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_16x16.png"), 6);
            this.imageCollectionNavigator.Images.SetKeyName(6, "first_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("last_16x16.png", "images/arrows/last_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_16x16.png"), 7);
            this.imageCollectionNavigator.Images.SetKeyName(7, "last_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("next_16x16.png", "images/arrows/next_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_16x16.png"), 8);
            this.imageCollectionNavigator.Images.SetKeyName(8, "next_16x16.png");
            this.imageCollectionNavigator.InsertGalleryImage("prev_16x16.png", "images/arrows/prev_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_16x16.png"), 9);
            this.imageCollectionNavigator.Images.SetKeyName(9, "prev_16x16.png");
            // 
            // gridViewCountries
            // 
            this.gridViewCountries.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName});
            this.gridViewCountries.GridControl = this.gridControlCountries;
            this.gridViewCountries.Name = "gridViewCountries";
            this.gridViewCountries.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewCountries.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewCountries.OptionsView.ShowGroupPanel = false;
            this.gridViewCountries.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCountries_RowUpdated);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "Country";
            this.colName.ColumnEdit = this.textEditCountryName;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // textEditCountryName
            // 
            this.textEditCountryName.AutoHeight = false;
            this.textEditCountryName.Name = "textEditCountryName";
            this.textEditCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditCountryName_Validating);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlCities);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlCountries);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(955, 644);
            this.splitContainerControl1.SplitterPosition = 322;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlCities
            // 
            this.gridControlCities.DataSource = this.cityUIDtoBindingSource;
            this.gridControlCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCities.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCities.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCities.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCities.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCities.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlCities.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlCities.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlCities.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlCities.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlCities.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlCities.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlCities.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlCities.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlCities_EmbeddedNavigator_ButtonClick);
            this.gridControlCities.Location = new System.Drawing.Point(0, 0);
            this.gridControlCities.MainView = this.gridViewCities;
            this.gridControlCities.Name = "gridControlCities";
            this.gridControlCities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpEditCountry,
            this.textEditCityName});
            this.gridControlCities.Size = new System.Drawing.Size(955, 322);
            this.gridControlCities.TabIndex = 0;
            this.gridControlCities.UseEmbeddedNavigator = true;
            this.gridControlCities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCities});
            // 
            // cityUIDtoBindingSource
            // 
            this.cityUIDtoBindingSource.DataSource = typeof(SpareParts.Dto.CityUIDto);
            // 
            // gridViewCities
            // 
            this.gridViewCities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCityName,
            this.colCountryName,
            this.colId1,
            this.colCountryId});
            this.gridViewCities.GridControl = this.gridControlCities;
            this.gridViewCities.Name = "gridViewCities";
            this.gridViewCities.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewCities.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewCities.OptionsView.ShowGroupPanel = false;
            this.gridViewCities.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCities_RowUpdated);
            // 
            // colCityName
            // 
            this.colCityName.Caption = "City";
            this.colCityName.ColumnEdit = this.textEditCityName;
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 0;
            // 
            // textEditCityName
            // 
            this.textEditCityName.AutoHeight = false;
            this.textEditCityName.Name = "textEditCityName";
            this.textEditCityName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditCityName_Validating);
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Country";
            this.colCountryName.ColumnEdit = this.lookUpEditCountry;
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 1;
            // 
            // lookUpEditCountry
            // 
            this.lookUpEditCountry.AutoHeight = false;
            this.lookUpEditCountry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCountry.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditCountry.DataSource = this.countryUIDtoBindingSource;
            this.lookUpEditCountry.DisplayMember = "Name";
            this.lookUpEditCountry.Name = "lookUpEditCountry";
            this.lookUpEditCountry.NullText = "";
            this.lookUpEditCountry.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditCountry.ValueMember = "Name";
            this.lookUpEditCountry.Validating += new System.ComponentModel.CancelEventHandler(this.lookUpEditCountry_Validating);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colCountryId
            // 
            this.colCountryId.Caption = "CountryId";
            this.colCountryId.FieldName = "CountryId";
            this.colCountryId.Name = "colCountryId";
            // 
            // AdminLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "AdminLocationControl";
            this.Size = new System.Drawing.Size(955, 644);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryUIDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCountryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityUIDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCityName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCountries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCountries;
        private System.Windows.Forms.BindingSource countryUIDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlCities;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCities;
        private System.Windows.Forms.BindingSource cityUIDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCityName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditCityName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditCountryName;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
    }
}
