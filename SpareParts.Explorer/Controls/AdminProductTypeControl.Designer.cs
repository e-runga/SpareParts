namespace SpareParts.Explorer.Controls
{
    partial class AdminProductTypeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductTypeControl));
            this.gridControlProductType = new DevExpress.XtraGrid.GridControl();
            this.productTypeViewDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection(this.components);
            this.gridViewProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCategories = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkedComboBoxEditCategories = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.categoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBrands = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkedComboBoxEditBrands = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.brandDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTypeDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeViewDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProductType
            // 
            this.gridControlProductType.DataSource = this.productTypeViewDtoBindingSource;
            this.gridControlProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlProductType.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlProductType.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlProductType.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlProductType.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlProductType.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlProductType.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlProductType.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlProductType.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlProductType_EmbeddedNavigator_ButtonClick);
            this.gridControlProductType.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductType.MainView = this.gridViewProductType;
            this.gridControlProductType.Name = "gridControlProductType";
            this.gridControlProductType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditName,
            this.checkedComboBoxEditCategories,
            this.checkedComboBoxEditBrands});
            this.gridControlProductType.Size = new System.Drawing.Size(860, 555);
            this.gridControlProductType.TabIndex = 0;
            this.gridControlProductType.UseEmbeddedNavigator = true;
            this.gridControlProductType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductType});
            // 
            // productTypeViewDtoBindingSource
            // 
            this.productTypeViewDtoBindingSource.DataSource = typeof(SpareParts.Dto.ProductTypeViewDto);
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
            // gridViewProductType
            // 
            this.gridViewProductType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCategories,
            this.colBrands,
            this.colId});
            this.gridViewProductType.GridControl = this.gridControlProductType;
            this.gridViewProductType.Name = "gridViewProductType";
            this.gridViewProductType.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewProductType.OptionsEditForm.PopupEditFormWidth = 400;
            this.gridViewProductType.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewProductType.OptionsView.ShowGroupPanel = false;
            this.gridViewProductType.RowHeight = 25;
            this.gridViewProductType.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridViewProductType_CalcRowHeight);
            this.gridViewProductType.ShownEditor += new System.EventHandler(this.gridViewProductType_ShownEditor);
            this.gridViewProductType.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewProductType_RowUpdated);
            this.gridViewProductType.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewProductType_CustomUnboundColumnData);
            this.gridViewProductType.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewProductType_ValidatingEditor);
            // 
            // colName
            // 
            this.colName.ColumnEdit = this.textEditName;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 200;
            // 
            // textEditName
            // 
            this.textEditName.AutoHeight = false;
            this.textEditName.Name = "textEditName";
            this.textEditName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditName_Validating);
            // 
            // colCategories
            // 
            this.colCategories.Caption = "Categories";
            this.colCategories.ColumnEdit = this.checkedComboBoxEditCategories;
            this.colCategories.FieldName = "Categories";
            this.colCategories.Name = "colCategories";
            this.colCategories.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colCategories.Visible = true;
            this.colCategories.VisibleIndex = 1;
            this.colCategories.Width = 300;
            // 
            // checkedComboBoxEditCategories
            // 
            this.checkedComboBoxEditCategories.AutoHeight = false;
            this.checkedComboBoxEditCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditCategories.DataSource = this.categoryDtoBindingSource;
            this.checkedComboBoxEditCategories.DisplayMember = "Name";
            this.checkedComboBoxEditCategories.Name = "checkedComboBoxEditCategories";
            this.checkedComboBoxEditCategories.ValueMember = "Name";
            this.checkedComboBoxEditCategories.Validating += new System.ComponentModel.CancelEventHandler(this.checkedComboBoxEditCategories_Validating);
            // 
            // categoryDtoBindingSource
            // 
            this.categoryDtoBindingSource.DataSource = typeof(SpareParts.Dto.CategoryDto);
            // 
            // colBrands
            // 
            this.colBrands.Caption = "Brands";
            this.colBrands.ColumnEdit = this.checkedComboBoxEditBrands;
            this.colBrands.FieldName = "Brands";
            this.colBrands.Name = "colBrands";
            this.colBrands.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colBrands.Visible = true;
            this.colBrands.VisibleIndex = 2;
            this.colBrands.Width = 300;
            // 
            // checkedComboBoxEditBrands
            // 
            this.checkedComboBoxEditBrands.AutoHeight = false;
            this.checkedComboBoxEditBrands.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditBrands.DataSource = this.brandDtoBindingSource;
            this.checkedComboBoxEditBrands.DisplayMember = "Name";
            this.checkedComboBoxEditBrands.Name = "checkedComboBoxEditBrands";
            this.checkedComboBoxEditBrands.ValueMember = "Name";
            this.checkedComboBoxEditBrands.Validating += new System.ComponentModel.CancelEventHandler(this.checkedComboBoxEditBrands_Validating);
            // 
            // brandDtoBindingSource
            // 
            this.brandDtoBindingSource.DataSource = typeof(SpareParts.Dto.BrandDto);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // productTypeDtoBindingSource1
            // 
            this.productTypeDtoBindingSource1.DataSource = typeof(SpareParts.Dto.ProductTypeDto);
            // 
            // productTypeDtoBindingSource
            // 
            this.productTypeDtoBindingSource.DataSource = typeof(SpareParts.Dto.ProductTypeDto);
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // AdminProductTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlProductType);
            this.Name = "AdminProductTypeControl";
            this.Size = new System.Drawing.Size(860, 555);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeViewDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProductType;
        private System.Windows.Forms.BindingSource productTypeDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductType;
        private System.Windows.Forms.BindingSource productTypeDtoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit checkedComboBoxEditCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit checkedComboBoxEditBrands;
        private System.Windows.Forms.BindingSource categoryDtoBindingSource;
        private System.Windows.Forms.BindingSource brandDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colBrands;
        private System.Windows.Forms.BindingSource productTypeViewDtoBindingSource;
    }
}
