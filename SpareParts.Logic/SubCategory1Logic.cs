using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class SubCategory1Logic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly SubCategory1Dal dal;
        #endregion

        #region .: Constructors :.
        public SubCategory1Logic()
        {
            this.dal = new SubCategory1Dal();
        }
        #endregion

        #region .: Public Methods :.
        public List<SubCategory1Dto> GetAll()
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

        public List<SubCategory1Dto> GetByCategoryId(int categoryId)
        {
            try
            {
                var retVal = this.dal.GetByCategoryId(categoryId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SubCategory1Dto GetByName(string name)
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

        public SubCategory1Dto Create(SubCategory1Dto dto)
        {
            try
            {
                CategoryDto category;

                if (!string.IsNullOrEmpty(dto.Category.Name))
                {
                    category = new CategoryLogic().GetByName(dto.Category.Name);
                }
                else
                {
                    category = new CategoryLogic().GetById(dto.Category.Id);
                }

                var retVal = this.dal.Create(dto.Name, category.Id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SubCategory1Dto Save(SubCategory1Dto dto)
        {
            try
            {
                CategoryDto category;

                if (!string.IsNullOrEmpty(dto.Category.Name))
                {
                    category = new CategoryLogic().GetByName(dto.Category.Name);
                }
                else
                {
                    category = new CategoryDto { Id = dto.Category.Id };
                }

                var retVal = this.dal.Save(dto.Id, dto.Name, category.Id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return this.dal.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}