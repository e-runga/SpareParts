namespace SpareParts.Explorer.Controls
{
    partial class AdminModelsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminModelsControl));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlModels = new DevExpress.XtraGrid.GridControl();
            this.modelDtoBindingSource = new System.Windows.Forms.BindingSource();
            this.imageCollectionNavigator = new DevExpress.Utils.ImageCollection();
            this.gridViewModels = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditModelName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSubModels = new DevExpress.XtraGrid.GridControl();
            this.subModelDtoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewSubModels = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditSubModelName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnModels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkedComboBoxEditModels = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modelDtoBindingSource1 = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditModelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subModelDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubModelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(950, 636);
            this.splitContainerControl1.SplitterPosition = 310;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlModels);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(950, 310);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Models";
            // 
            // gridControlModels
            // 
            this.gridControlModels.DataSource = this.modelDtoBindingSource;
            this.gridControlModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlModels.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlModels.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlModels.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlModels.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlModels.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlModels.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlModels.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlModels.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlModels.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlModels.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlModels.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlModels.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlModels.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlModels_EmbeddedNavigator_ButtonClick);
            this.gridControlModels.Location = new System.Drawing.Point(2, 20);
            this.gridControlModels.MainView = this.gridViewModels;
            this.gridControlModels.Name = "gridControlModels";
            this.gridControlModels.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditModelName});
            this.gridControlModels.Size = new System.Drawing.Size(946, 288);
            this.gridControlModels.TabIndex = 0;
            this.gridControlModels.UseEmbeddedNavigator = true;
            this.gridControlModels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModels});
            // 
            // modelDtoBindingSource
            // 
            this.modelDtoBindingSource.DataSource = typeof(SpareParts.Dto.ModelDto);
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
            // gridViewModels
            // 
            this.gridViewModels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colId});
            this.gridViewModels.GridControl = this.gridControlModels;
            this.gridViewModels.Name = "gridViewModels";
            this.gridViewModels.NewItemRowText = "Click to add a new Model";
            this.gridViewModels.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewModels.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewModels.OptionsView.ShowGroupPanel = false;
            this.gridViewModels.RowHeight = 25;
            this.gridViewModels.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.GridView_CalcRowHeight);
            this.gridViewModels.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewModels_RowUpdated);
            // 
            // colName
            // 
            this.colName.Caption = "Model";
            this.colName.ColumnEdit = this.textEditModelName;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.Caption = "Model name:";
            this.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // textEditModelName
            // 
            this.textEditModelName.AutoHeight = false;
            this.textEditModelName.Name = "textEditModelName";
            this.textEditModelName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditModelName_Validating);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlSubModels);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(950, 321);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Sub Models";
            // 
            // gridControlSubModels
            // 
            this.gridControlSubModels.DataSource = this.subModelDtoBindingSource;
            this.gridControlSubModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.First.ImageIndex = 2;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.ImageList = this.imageCollectionNavigator;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Last.ImageIndex = 3;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Next.ImageIndex = 8;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.NextPage.ImageIndex = 4;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Prev.ImageIndex = 9;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.PrevPage.ImageIndex = 5;
            this.gridControlSubModels.EmbeddedNavigator.Buttons.Remove.ImageIndex = 1;
            this.gridControlSubModels.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlSubModels_EmbeddedNavigator_ButtonClick);
            this.gridControlSubModels.Location = new System.Drawing.Point(2, 20);
            this.gridControlSubModels.MainView = this.gridViewSubModels;
            this.gridControlSubModels.Name = "gridControlSubModels";
            this.gridControlSubModels.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.textEditSubModelName,
            this.checkedComboBoxEditModels});
            this.gridControlSubModels.Size = new System.Drawing.Size(946, 299);
            this.gridControlSubModels.TabIndex = 0;
            this.gridControlSubModels.UseEmbeddedNavigator = true;
            this.gridControlSubModels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSubModels});
            // 
            // subModelDtoBindingSource
            // 
            this.subModelDtoBindingSource.DataSource = typeof(SpareParts.Dto.SubModelDto);
            // 
            // gridViewSubModels
            // 
            this.gridViewSubModels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubModelName,
            this.gridColumnModels,
            this.colId1});
            this.gridViewSubModels.GridControl = this.gridControlSubModels;
            this.gridViewSubModels.Name = "gridViewSubModels";
            this.gridViewSubModels.NewItemRowText = "Click to add a new Sub Model";
            this.gridViewSubModels.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewSubModels.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewSubModels.OptionsView.ShowGroupPanel = false;
            this.gridViewSubModels.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.GridView_CalcRowHeight);
            this.gridViewSubModels.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewSubModels_RowUpdated);
            this.gridViewSubModels.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewSubModels_CustomUnboundColumnData);
            // 
            // colSubModelName
            // 
            this.colSubModelName.Caption = "Sub Model";
            this.colSubModelName.ColumnEdit = this.textEditSubModelName;
            this.colSubModelName.FieldName = "Name";
            this.colSubModelName.Name = "colSubModelName";
            this.colSubModelName.Visible = true;
            this.colSubModelName.VisibleIndex = 0;
            // 
            // textEditSubModelName
            // 
            this.textEditSubModelName.AutoHeight = false;
            this.textEditSubModelName.Name = "textEditSubModelName";
            this.textEditSubModelName.Validating += new System.ComponentModel.CancelEventHandler(this.textEditSubModelName_Validating);
            // 
            // gridColumnModels
            // 
            this.gridColumnModels.Caption = "Model";
            this.gridColumnModels.ColumnEdit = this.checkedComboBoxEditModels;
            this.gridColumnModels.FieldName = "Models.Name";
            this.gridColumnModels.Name = "gridColumnModels";
            this.gridColumnModels.OptionsEditForm.Caption = "Models";
            this.gridColumnModels.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumnModels.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumnModels.Visible = true;
            this.gridColumnModels.VisibleIndex = 1;
            // 
            // checkedComboBoxEditModels
            // 
            this.checkedComboBoxEditModels.AllowMultiSelect = true;
            this.checkedComboBoxEditModels.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.checkedComboBoxEditModels.AutoHeight = false;
            this.checkedComboBoxEditModels.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditModels.DataSource = this.modelDtoBindingSource;
            this.checkedComboBoxEditModels.DisplayMember = "Name";
            this.checkedComboBoxEditModels.Name = "checkedComboBoxEditModels";
            this.checkedComboBoxEditModels.ValueMember = "Name";
            this.checkedComboBoxEditModels.Validating += new System.ComponentModel.CancelEventHandler(this.checkedComboBoxEditModels_Validating);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // modelDtoBindingSource1
            // 
            this.modelDtoBindingSource1.DataSource = typeof(SpareParts.Dto.ModelDto);
            // 
            // AdminModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "AdminModels";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditModelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subModelDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubModelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDtoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlModels;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModels;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlSubModels;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSubModels;
        private System.Windows.Forms.BindingSource modelDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource subModelDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSubModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditSubModelName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditModelName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModels;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit checkedComboBoxEditModels;
        private System.Windows.Forms.BindingSource modelDtoBindingSource1;
        private DevExpress.Utils.ImageCollection imageCollectionNavigator;
    }
}
