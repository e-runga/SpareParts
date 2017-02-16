using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class CategoryLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly CategoryDal dal;
        #endregion

        #region .: Constructors :.
        public CategoryLogic()
        {
            this.dal = new CategoryDal();
        }
        #endregion

        #region .: Public Methods
        public List<CategoryDto> GetAll()
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

        public List<CategoryViewDto> GetAllForUIView()
        {
            try
            {
                var retVal = this.dal.GetAllForUIView().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDto> GetCategories()
        {
            try
            {
                var retVal = this.dal.GetCategories().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryViewDto> GetSubCategories()
        {
            try
            {
                var retVal = this.GetAllForUIView()
                    .Where(c => !c.SubCategory1Id.Equals(0))
                    .ToList();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoryDto GetById(int id)
        {
            var retVal = this.dal.GetById(id).ToDto();
            return retVal;
        }

        public CategoryDto GetByName(string name)
        {
            try
            {
                var retVal = this.dal.GetByName(name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDto> GetByNames(List<string> names)
        {
            try
            {
                var retVal = new List<CategoryDto>();
                names.ForEach(n => retVal.Add(this.GetByName(n)));
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryViewDto> GetByProductTypeId(int productTypeId)
        {
            try
            {
                var retVal = this.dal.GetByProductTypeId(productTypeId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the type of the by product.
        /// </summary>
        /// <param name="productTypeId">The product type identifier.</param>
        /// <returns></returns>
        public List<CategoryDto> GetByProductType(int productTypeId)
        {
            try
            {
                var retVal = this.dal.GetByProductType(productTypeId).ToDto();
                return retVal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CategoryViewDto> GetSubCategory1(List<int> parentIds)
        {
            try
            {
                var retVal = this.dal.GetSubcategory1(parentIds).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryViewDto> GetSubCategory2(List<int> parentIds)
        {
            try
            {
                var retVal = this.dal.GetSubcategory2(parentIds).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoryDto Create(CategoryDto dto)
        {
            try
            {
                CategoryDto retVal = null;

                if (!dto.ParentId.HasValue && !string.IsNullOrEmpty(dto.Parent))
                {
                    dto.ParentId = this.dal.GetByName(dto.Parent).Id;
                }

                var actual = this.dal.GetByName(dto.Name).ToDto();

                if (actual == null)
                {
                    retVal = this.dal.Create(dto.Name, dto.ParentId, dto.ProductType != null ? dto.ProductType.Select(p => p.Id).ToArray() : new int[0]).ToDto();
                }
                else
                {
                    retVal = this.dal.Save(actual.Id, dto.Name, dto.ParentId, dto.ProductType.Select(p => p.Id).ToArray()).ToDto();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoryDto Save(CategoryDto dto)
        {
            try
            {
                var retVal = this.dal.GetById(dto.Id).ToDto();

                if (retVal != null)
                {
                    retVal = this.dal.Save(retVal.Id, dto.Name, dto.ParentId, dto.ProductType.Select(p => p.Id).ToArray()).ToDto();
                }
                else
                {
                    retVal = this.dal.Create(dto.Name, dto.ParentId, dto.ProductType.Select(p => p.Id).ToArray()).ToDto();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int categoryId)
        {
            try
            {
                var retVal = this.dal.Delete(categoryId);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}