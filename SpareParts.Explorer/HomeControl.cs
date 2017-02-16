using DevExpress.XtraBars;
using DevExpress.XtraTab;
using System;
using System.Windows.Forms;

namespace SpareParts.Explorer
{
    public partial class HomeControl : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region .: Constructor :.
        public HomeControl()
        {
            try
            {
                InitializeComponent();
                this.labelWelcome.Text = string.Format(Properties.Resources.WelcomeMessage, Singletons.Security.Instance.LoggedDisplayName);

                if (Singletons.Security.Instance.LoggedUser.Profile.Name.Equals("Administrator"))
                {
                    this.ribbonPageAdministration.Visible = true;
                }
                else
                {
                    this.ribbonPageAdministration.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Tabs

        #region .: Action Buttons :.
        private void barButtonItemCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.SearchCustomerControl());
        }

        private void barButtonItemProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.SearchProductControl());
        }

        private void barButtonItemProductTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminProductTypeControl());
        }

        private void barButtonItemBrands_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminBrandControl());
        }

        private void barButtonItemCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminCategoriesControl());
        }

        private void barButtonItemModels_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminModelsControl());
        }

        private void barButtonItemLocations_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminLocationControl());
        }

        private void barButtonItemRatings_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminRatingsControl());
        }

        private void barButtonItemUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.AddControl(new Controls.AdminUsersControl());
            //this.AddControl(new Controls.UserManagement());
        }
        #endregion

        /// <summary>
        /// Adds the control.
        /// </summary>
        /// <param name="baseControl">The base control.</param>
        private void AddControl(Controls.BaseControl baseControl)
        {
            baseControl.Dock = DockStyle.Fill;

            var tabPage = new XtraTabPage();
            tabPage.Text = " " + baseControl.Title; // Add a space for visual effect...
            tabPage.Image = baseControl.ImageTitle;

            baseControl.AddNewTab += baseControl_AddNewTab;
            tabPage.Controls.Add(baseControl);

            this.xtraTabControl.SelectedPageChanged -= xtraTabControl_SelectedPageChanged;
            this.xtraTabControl.CloseButtonClick -= this.xtraTabControl_CloseButtonClick;

            this.xtraTabControl.TabPages.Add(tabPage);

            this.xtraTabControl.SelectedTabPage = tabPage;
            this.xtraTabControl.HeaderButtonsShowMode = TabButtonShowMode.WhenNeeded;
            this.xtraTabControl.ClosePageButtonShowMode = ClosePageButtonShowMode.InTabControlHeader;
            baseControl.Show();

            this.xtraTabControl.SelectedPageChanged += xtraTabControl_SelectedPageChanged;
            this.xtraTabControl.CloseButtonClick += this.xtraTabControl_CloseButtonClick;
        }

        /// <summary>
        /// Bases the control_ add new tab.
        /// </summary>
        /// <param name="baseControl">The base control.</param>
        private void baseControl_AddNewTab(Controls.BaseControl baseControl)
        {
            this.AddControl(baseControl);
        }

        /// <summary>
        /// Handles the CloseButtonClick event of the xtraTabControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            if (xtraTabControl.SelectedTabPage != null)
                this.xtraTabControl.TabPages.Remove(xtraTabControl.SelectedTabPage);
        }

        /// <summary>
        /// Handles the SelectedPageChanged event of the xtraTabControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TabPageChangedEventArgs"/> instance containing the event data.</param>
        private void xtraTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page != null && e.Page.Controls.Count > 0)
            {
                var baseControl = e.Page.Controls[0] as Controls.BaseControl;
                if (baseControl != null)
                    baseControl.ReShow();
            }
        }

        #endregion
    }
}