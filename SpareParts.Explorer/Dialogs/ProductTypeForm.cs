using DevExpress.XtraEditors.Controls;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SpareParts.Explorer.Dialogs
{
    public partial class ProductTypeForm : BaseForm
    {
        public ProductTypeForm()
        {
            InitializeComponent();
        }

        #region .: Public Properties :.
        public ProductTypeDto CurrentProductType { get; set; }

        #endregion

        void ProductTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.checkedComboBoxEditCategories.Properties.DataSource = base.ServiceClient.GetAllCategories();
                this.checkedComboBoxEditBrands.Properties.DataSource = base.ServiceClient.GetAllBrands();

                if (this.CurrentProductType != null)
                {
                    this.textEditName.Text = this.CurrentProductType.Name;
                    var productCategories = base.ServiceClient.GetCategoriesByProductType(this.CurrentProductType.Id);
                    var productBrands = base.ServiceClient.GetBrandsByProductType(this.CurrentProductType.Id);
                    var selectedProductTypes = string.Join(",", productCategories.Select(s => s.Id.ToString()));
                    var selectedBrands = string.Join(",", productBrands.Select(b => b.BrandId.ToString()));
                    this.checkedComboBoxEditCategories.SetEditValue(selectedProductTypes);
                    this.checkedComboBoxEditBrands.SetEditValue(selectedBrands);
                }
                else
                {
                    this.CurrentProductType = new ProductTypeDto { Id = 0, Categories = new List<CategoryDto>(), Brands = new List<BrandDto>() };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new ProductTypeDto
                {
                    Id = this.CurrentProductType.Id,
                    Name = this.textEditName.Text,
                    Brands = new List<BrandDto>(),
                    Categories = new List<CategoryDto>()
                };

                var brandIds = (from CheckedListBoxItem item in this.checkedComboBoxEditBrands.Properties.GetItems()
                                where item.CheckState == System.Windows.Forms.CheckState.Checked
                                select (int)item.Value).ToList<int>();
                var categoryIds = (from CheckedListBoxItem item in this.checkedComboBoxEditCategories.Properties.GetItems()
                                   where item.CheckState == System.Windows.Forms.CheckState.Checked
                                   select (int)item.Value).ToList<int>();
                brandIds.ForEach(b => dto.Brands.Add(new BrandDto { Id = b }));
                categoryIds.ForEach(c => dto.Categories.Add(new CategoryDto { Id = c }));

                var result = this.ServiceClient.SaveProductType(dto);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}