namespace SpareParts.Explorer.Controls
{
    partial class AdminBrandControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBrandControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlBrand = new DevExpress.XtraGrid.GridControl();
            this.brandViewForUIDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection(this.components);
            this.gridViewBrand = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditBrand = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditProductType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productTypeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkedComboBoxEditModels = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.modelDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandDtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.brandDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.brandDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandViewForUIDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBrand
            // 
            this.gridControlBrand.DataSource = this.brandViewForUIDtoBindingSource;
            this.gridControlBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlBrand.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlBrand.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlBrand.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlBrand.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlBrand.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlBrand.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlBrand.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlBrand.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlBrand_EmbeddedNavigator_ButtonClick);
            this.gridControlBrand.Location = new System.Drawing.Point(0, 0);
            this.gridControlBrand.MainView = this.gridViewBrand;
            this.gridControlBrand.Name = "gridControlBrand";
            this.gridControlBrand.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditBrand,
            this.checkedComboBoxEditModels,
            this.lookUpEditProductType});
            this.gridControlBrand.Size = new System.Drawing.Size(794, 549);
            this.gridControlBrand.TabIndex = 0;
            this.gridControlBrand.UseEmbeddedNavigator = true;
            this.gridControlBrand.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrand});
            // 
            // brandViewForUIDtoBindingSource
            // 
            this.brandViewForUIDtoBindingSource.DataSource = typeof(SpareParts.Dto.BrandViewForUIDto);
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
            // gridViewBrand
            // 
            this.gridViewBrand.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrand,
            this.colProductType,
            this.colModels,
            this.colBrandId,
            this.colProductTypeId});
            this.gridViewBrand.GridControl = this.gridControlBrand;
            this.gridViewBrand.Name = "gridViewBrand";
            this.gridViewBrand.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewBrand.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewBrand.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewBrand.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gridViewBrand.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewBrand.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewBrand.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewBrand.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewBrand.OptionsView.ShowGroupPanel = false;
            this.gridViewBrand.RowHeight = 25;
            this.gridViewBrand.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewBrand_RowUpdated);
            this.gridViewBrand.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewBrand_CustomUnboundColumnData);
            // 
            // colBrand
            // 
            this.colBrand.ColumnEdit = this.textEditBrand;
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 0;
            // 
            // textEditBrand
            // 
            this.textEditBrand.AutoHeight = false;
            this.textEditBrand.Name = "textEditBrand";
            this.textEditBrand.NullText = "<Brand name>";
            this.textEditBrand.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemTextEditName_Validating);
            // 
            // colProductType
            // 
            this.colProductType.Caption = "Product Type";
            this.colProductType.ColumnEdit = this.lookUpEditProductType;
            this.colProductType.FieldName = "ProductType";
            this.colProductType.Name = "colProductType";
            this.colProductType.Visible = true;
            this.colProductType.VisibleIndex = 2;
            // 
            // lookUpEditProductType
            // 
            this.lookUpEditProductType.AutoHeight = false;
            this.lookUpEditProductType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProductType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEditProductType.DataSource = this.productTypeDtoBindingSource;
            this.lookUpEditProductType.DisplayMember = "Name";
            this.lookUpEditProductType.Name = "lookUpEditProductType";
            this.lookUpEditProductType.NullText = "";
            this.lookUpEditProductType.ValueMember = "Name";
            this.lookUpEditProductType.Validating += new System.ComponentModel.CancelEventHandler(this.lookUpEditProductType_Validating);
            // 
            // productTypeDtoBindingSource
            // 
            this.productTypeDtoBindingSource.DataSource = typeof(SpareParts.Dto.ProductTypeDto);
            // 
            // colModels
            // 
            this.colModels.ColumnEdit = this.checkedComboBoxEditModels;
            this.colModels.FieldName = "Models";
            this.colModels.Name = "colModels";
            this.colModels.Visible = true;
            this.colModels.VisibleIndex = 1;
            // 
            // checkedComboBoxEditModels
            // 
            this.checkedComboBoxEditModels.AutoHeight = false;
            this.checkedComboBoxEditModels.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditModels.DataSource = this.modelDtoBindingSource;
            this.checkedComboBoxEditModels.DisplayMember = "Name";
            this.checkedComboBoxEditModels.Name = "checkedComboBoxEditModels";
            this.checkedComboBoxEditModels.ValueMember = "Name";
            this.checkedComboBoxEditModels.Validating += new System.ComponentModel.CancelEventHandler(this.checkedComboBoxEditModels_Validating);
            // 
            // modelDtoBindingSource
            // 
            this.modelDtoBindingSource.DataSource = typeof(SpareParts.Dto.ModelDto);
            // 
            // colBrandId
            // 
            this.colBrandId.FieldName = "BrandId";
            this.colBrandId.Name = "colBrandId";
            // 
            // colProductTypeId
            // 
            this.colProductTypeId.FieldName = "ProductTypeId";
            this.colProductTypeId.Name = "colProductTypeId";
            // 
            // brandDtoBindingSource2
            // 
            this.brandDtoBindingSource2.DataSource = typeof(SpareParts.Dto.BrandDto);
            // 
            // brandDtoBindingSource
            // 
            this.brandDtoBindingSource.DataSource = typeof(SpareParts.Dto.BrandDto);
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, true)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // brandDtoBindingSource1
            // 
            this.brandDtoBindingSource1.DataSource = typeof(SpareParts.Dto.BrandDto);
            // 
            // AdminBrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBrand);
            this.Name = "AdminBrandControl";
            this.Size = new System.Drawing.Size(794, 549);
            this.Load += new System.EventHandler(this.AdminBrandControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandViewForUIDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlBrand;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private System.Windows.Forms.BindingSource brandDtoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditBrand;
        private System.Windows.Forms.BindingSource brandDtoBindingSource2;
        private System.Windows.Forms.BindingSource brandDtoBindingSource1;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit checkedComboBoxEditModels;
        private System.Windows.Forms.BindingSource modelDtoBindingSource;
        private System.Windows.Forms.BindingSource brandViewForUIDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModels;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditProductType;
        private System.Windows.Forms.BindingSource productTypeDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
    }
}
