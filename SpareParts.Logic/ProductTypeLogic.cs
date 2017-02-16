using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class ProductTypeLogic : BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The Product Type data access layer
        /// </summary>
        private readonly ProductTypeDal dal;
        #endregion

        #region .: Constructors :.
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTypeLogic"/> class.
        /// </summary>
        public ProductTypeLogic()
        {
            this.dal = new ProductTypeDal();
        }
        #endregion

        #region .: Public Methods :.
        public List<ProductTypeViewDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductTypeDto GetById(int id)
        {
            try
            {
                var retVal = this.dal.GetById(id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductTypeDto Create(ProductTypeDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name, dto.Categories.Select(c => c.Id).ToList(), dto.Brands.Select(b => b.Id).ToList()).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductTypeDto Save(ProductTypeDto dto)
        {
            try
            {
                var categoryLogic = new CategoryLogic();
                var brandLogic = new BrandLogic();

                var categories = categoryLogic.GetByNames(dto.Categories.Select(c => c.Name).ToList());
                var brands = brandLogic.GetByNames(dto.Brands.Select(b => b.Name).ToList());
                var retVal = this.dal.Save(dto.Id, dto.Name, categories.Select(c => c.Id).ToList(), brands.Select(b => b.Id).ToList()).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int productTypeId)
        {
            try
            {
                var retVal = this.dal.Delete(productTypeId);
                return retVal;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}