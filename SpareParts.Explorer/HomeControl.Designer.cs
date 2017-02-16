namespace SpareParts.Explorer
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBrands = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModels = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLocations = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRatings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProductTypes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCommon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHome = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCustomers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageAdministration = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAdministration = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupReferenceData = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItemCustomer,
            this.barButtonItemUsers,
            this.barButtonItemBrands,
            this.barButtonItemCategories,
            this.barButtonItemModels,
            this.barButtonItemLocations,
            this.barButtonItemRatings,
            this.barButtonItemProducts,
            this.barButtonItem2,
            this.barButtonItemProductTypes});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCommon,
            this.ribbonPageAdministration});
            this.ribbon.Size = new System.Drawing.Size(1136, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Home";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.home32x32;
            this.barButtonItem1.LargeWidth = 80;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItemCustomer
            // 
            this.barButtonItemCustomer.Caption = "Customer";
            this.barButtonItemCustomer.Id = 2;
            this.barButtonItemCustomer.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.boy_64;
            this.barButtonItemCustomer.LargeWidth = 80;
            this.barButtonItemCustomer.Name = "barButtonItemCustomer";
            this.barButtonItemCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCustomer_ItemClick);
            // 
            // barButtonItemUsers
            // 
            this.barButtonItemUsers.Caption = "Users";
            this.barButtonItemUsers.Id = 3;
            this.barButtonItemUsers.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.users_black_64;
            this.barButtonItemUsers.LargeWidth = 80;
            this.barButtonItemUsers.Name = "barButtonItemUsers";
            this.barButtonItemUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUsers_ItemClick);
            // 
            // barButtonItemBrands
            // 
            this.barButtonItemBrands.Caption = "Brands";
            this.barButtonItemBrands.Id = 4;
            this.barButtonItemBrands.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.NewCarWithPriceTag;
            this.barButtonItemBrands.LargeWidth = 80;
            this.barButtonItemBrands.Name = "barButtonItemBrands";
            this.barButtonItemBrands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBrands_ItemClick);
            // 
            // barButtonItemCategories
            // 
            this.barButtonItemCategories.Caption = "Categories";
            this.barButtonItemCategories.Id = 5;
            this.barButtonItemCategories.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.SettingsForCategories;
            this.barButtonItemCategories.LargeWidth = 80;
            this.barButtonItemCategories.Name = "barButtonItemCategories";
            this.barButtonItemCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCategories_ItemClick);
            // 
            // barButtonItemModels
            // 
            this.barButtonItemModels.Caption = "Models";
            this.barButtonItemModels.Id = 6;
            this.barButtonItemModels.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.car_64;
            this.barButtonItemModels.LargeWidth = 80;
            this.barButtonItemModels.Name = "barButtonItemModels";
            this.barButtonItemModels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModels_ItemClick);
            // 
            // barButtonItemLocations
            // 
            this.barButtonItemLocations.Caption = "Locations";
            this.barButtonItemLocations.Id = 8;
            this.barButtonItemLocations.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.LocationPin;
            this.barButtonItemLocations.LargeWidth = 80;
            this.barButtonItemLocations.Name = "barButtonItemLocations";
            this.barButtonItemLocations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLocations_ItemClick);
            // 
            // barButtonItemRatings
            // 
            this.barButtonItemRatings.Caption = "Ratings";
            this.barButtonItemRatings.Id = 9;
            this.barButtonItemRatings.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.star_black_64;
            this.barButtonItemRatings.LargeWidth = 80;
            this.barButtonItemRatings.Name = "barButtonItemRatings";
            this.barButtonItemRatings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRatings_ItemClick);
            // 
            // barButtonItemProducts
            // 
            this.barButtonItemProducts.Caption = "Products";
            this.barButtonItemProducts.Id = 10;
            this.barButtonItemProducts.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.barcode_32;
            this.barButtonItemProducts.LargeWidth = 80;
            this.barButtonItemProducts.Name = "barButtonItemProducts";
            this.barButtonItemProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProducts_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItemProductTypes
            // 
            this.barButtonItemProductTypes.Caption = "Product Types";
            this.barButtonItemProductTypes.Id = 12;
            this.barButtonItemProductTypes.LargeGlyph = global::SpareParts.Explorer.Properties.Resources.twocogwheels;
            this.barButtonItemProductTypes.LargeWidth = 80;
            this.barButtonItemProductTypes.Name = "barButtonItemProductTypes";
            this.barButtonItemProductTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProductTypes_ItemClick);
            // 
            // ribbonPageCommon
            // 
            this.ribbonPageCommon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHome,
            this.ribbonPageGroupCustomers,
            this.ribbonPageGroupProducts});
            this.ribbonPageCommon.Name = "ribbonPageCommon";
            this.ribbonPageCommon.Text = "Home";
            // 
            // ribbonPageGroupHome
            // 
            this.ribbonPageGroupHome.Glyph = global::SpareParts.Explorer.Properties.Resources.PistonsCross;
            this.ribbonPageGroupHome.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroupHome.Name = "ribbonPageGroupHome";
            this.ribbonPageGroupHome.Text = "Parts";
            // 
            // ribbonPageGroupCustomers
            // 
            this.ribbonPageGroupCustomers.ItemLinks.Add(this.barButtonItemCustomer);
            this.ribbonPageGroupCustomers.Name = "ribbonPageGroupCustomers";
            this.ribbonPageGroupCustomers.Text = "Customer";
            // 
            // ribbonPageGroupProducts
            // 
            this.ribbonPageGroupProducts.Glyph = global::SpareParts.Explorer.Properties.Resources.engine;
            this.ribbonPageGroupProducts.ItemLinks.Add(this.barButtonItemProducts);
            this.ribbonPageGroupProducts.Name = "ribbonPageGroupProducts";
            this.ribbonPageGroupProducts.Text = "Products";
            // 
            // ribbonPageAdministration
            // 
            this.ribbonPageAdministration.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAdministration,
            this.ribbonPageGroupReferenceData});
            this.ribbonPageAdministration.Name = "ribbonPageAdministration";
            this.ribbonPageAdministration.Text = "Administration";
            // 
            // ribbonPageGroupAdministration
            // 
            this.ribbonPageGroupAdministration.ItemLinks.Add(this.barButtonItemUsers);
            this.ribbonPageGroupAdministration.Name = "ribbonPageGroupAdministration";
            this.ribbonPageGroupAdministration.Text = "Users";
            // 
            // ribbonPageGroupReferenceData
            // 
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemProductTypes);
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemBrands);
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemCategories);
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemModels);
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemLocations);
            this.ribbonPageGroupReferenceData.ItemLinks.Add(this.barButtonItemRatings);
            this.ribbonPageGroupReferenceData.Name = "ribbonPageGroupReferenceData";
            this.ribbonPageGroupReferenceData.Text = "Reference datas";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 642);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1136, 31);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 143);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl.Size = new System.Drawing.Size(1136, 499);
            this.xtraTabControl.TabIndex = 2;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Image = global::SpareParts.Explorer.Properties.Resources.home32x32;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1130, 452);
            this.xtraTabPage2.Text = "Home";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(899, 32);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(62, 13);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome ";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 673);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeControl";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Mekano Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCommon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHome;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCustomers;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageAdministration;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAdministration;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBrands;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReferenceData;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModels;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLocations;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRatings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProductTypes;
        private System.Windows.Forms.Label labelWelcome;
    }
}