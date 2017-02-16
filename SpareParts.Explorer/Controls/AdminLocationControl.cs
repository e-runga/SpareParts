using SpareParts.Dto;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SpareParts.Explorer.Controls
{
    public partial class AdminLocationControl : BaseControl
    {
        #region .: Properties :.
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public override string Title
        {
            get
            {
                return Properties.Resources.ManagementModels;
            }
        }

        /// <summary>
        /// Gets the image title.
        /// </summary>
        /// <value>
        /// The image title.
        /// </value>
        public override Image ImageTitle
        {
            get
            {
                return Properties.Resources.location_pin32x32;
            }
        }

        private CountryUIDto newCountry = new CountryUIDto();

        private CityUIDto newCity = new CityUIDto();
        #endregion

        #region .: Constructor :.
        public AdminLocationControl()
        {
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;

            try
            {
                this.RefreshData();
            }
            catch (System.ServiceModel.FaultException ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }
        #endregion

        #region .: Override :.
        public override void Show()
        {
            base.Show();
        }

        public void RefreshData()
        {
            this.gridControlCountries.DataSource = base.ServiceClient.GetAllCountriesForUI();
            this.gridControlCities.DataSource = base.ServiceClient.GetAllCities();
            this.lookUpEditCountry.DataSource = base.ServiceClient.GetAllCountriesForUI();
        }

        #endregion

        #region .: Grid Events :.
        private void gridViewCities_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var city = e.Row as CityUIDto ?? this.newCity;
                var update = base.ServiceClient.SaveCity(city);

                this.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCountries_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                var country = e.Row as CountryUIDto ?? this.newCountry;
                var updated = base.ServiceClient.SaveCountry(country);

                this.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lookUpEditCountry_Validating(object sender, CancelEventArgs e)
        {
            var lookup = sender as DevExpress.XtraEditors.LookUpEdit;

            if (!string.IsNullOrEmpty(lookup.EditValue.ToString()))
            {
                this.newCity.CountryName = lookup.EditValue.ToString();
            }
        }

        private void textEditCityName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newCity.CityName = input.Text;
            }
        }

        private void textEditCountryName_Validating(object sender, CancelEventArgs e)
        {
            var input = sender as DevExpress.XtraEditors.TextEdit;

            if (!string.IsNullOrEmpty(input.Text))
            {
                this.newCountry.Name = input.Text;
            }
        }
        #endregion

        #region .: Buttons :.
        private void gridControlCities_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var city = this.gridViewCities.GetRow(this.gridViewCities.FocusedRowHandle) as CityUIDto;

                    if (city != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDelete_Confirmation, city.CityName),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteCity(city.Id);
                        }
                    }
                    else
                    {
                        throw new Exception("The item does not exist !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlCountries_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
                {
                    var country = this.gridViewCities.GetRow(this.gridViewCities.FocusedRowHandle) as CountryUIDto;

                    if (country != null)
                    {
                        if ((MessageBox.Show(string.Format(Properties.Resources.MessageDeleteCountry_Confirmation, country.Name),
                            Properties.Resources.Title_ConfirmAction,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            e.Handled = base.ServiceClient.DeleteCountry(country.Id);
                        }
                    }
                    else
                    {
                        throw new Exception("The item does not exist !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}