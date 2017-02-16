namespace SpareParts.Explorer.Controls
{
    partial class AdminRatingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRatingsControl));
            this.gridControlRatings = new DevExpress.XtraGrid.GridControl();
            this.ratingDtoBindingSource = new System.Windows.Forms.BindingSource();
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection();
            this.gridViewRatings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRatings
            // 
            this.gridControlRatings.DataSource = this.ratingDtoBindingSource;
            this.gridControlRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlRatings.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlRatings.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlRatings.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlRatings.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlRatings.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlRatings.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlRatings.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlRatings.EmbeddedNavigator.Buttons.Remove.Hint = "Delete";
            this.gridControlRatings.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlRatings.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlRatings_EmbeddedNavigator_ButtonClick);
            this.gridControlRatings.Location = new System.Drawing.Point(0, 0);
            this.gridControlRatings.MainView = this.gridViewRatings;
            this.gridControlRatings.Name = "gridControlRatings";
            this.gridControlRatings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditName,
            this.textEditAmount});
            this.gridControlRatings.Size = new System.Drawing.Size(950, 636);
            this.gridControlRatings.TabIndex = 0;
            this.gridControlRatings.UseEmbeddedNavigator = true;
            this.gridControlRatings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRatings});
            // 
            // ratingDtoBindingSource
            // 
            this.ratingDtoBindingSource.DataSource = typeof(SpareParts.Dto.RatingDto);
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
            // gridViewRatings
            // 
            this.gridViewRatings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAmount,
            this.colId});
            this.gridViewRatings.GridControl = this.gridControlRatings;
            this.gridViewRatings.Name = "gridViewRatings";
            this.gridViewRatings.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRatings.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewRatings.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewRatings.OptionsView.ShowGroupPanel = false;
            this.gridViewRatings.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewRatings_RowUpdated);
            // 
            // colName
            // 
            this.colName.ColumnEdit = this.textEditName;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // textEditName
            // 
            this.textEditName.AutoHeight = false;
            this.textEditName.Name = "textEditName";
            this.textEditName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditName_Validating);
            // 
            // colAmount
            // 
            this.colAmount.ColumnEdit = this.textEditAmount;
            this.colAmount.DisplayFormat.FormatString = "p0";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // textEditAmount
            // 
            this.textEditAmount.AutoHeight = false;
            this.textEditAmount.DisplayFormat.FormatString = "p0";
            this.textEditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditAmount.Name = "textEditAmount";
            this.textEditAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textEditAmount_Validating);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // AdminRatingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlRatings);
            this.Name = "AdminRatingsControl";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRatings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRatings;
        private System.Windows.Forms.BindingSource ratingDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
    }
}
