using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class SubCategory2Logic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly SubCategory2Dal dal;
        #endregion

        #region .: Constructors :.
        public SubCategory2Logic()
        {
            this.dal = new SubCategory2Dal();
        }
        #endregion

        #region .: Public Methods :.
        public List<SubCategory2Dto> GetAll()
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

        
        public List<SubCategory2Dto> GetBySubCategory1Id(int subCategoryId)
        {
            try
            {
                var retVal = this.dal.GetBySubCategory1Id(subCategoryId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SubCategory2Dto Create(SubCategory2Dto dto)
        {
            try
            {
                SubCategory1Dto subCategory1;

                if (!string.IsNullOrEmpty(dto.SubCategory1.Name))
                {
                    subCategory1 = new SubCategory1Dal().GetByName(dto.SubCategory1.Name).ToDto();
                }
                else
                {
                    subCategory1 = new SubCategory1Dal().GetById(dto.SubCategory1.Id).ToDto();
                }

                var retVal = this.dal.Create(dto.Name, subCategory1.Id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SubCategory2Dto Save(SubCategory2Dto dto)
        {
            try
            {
                SubCategory1Dto subCategory1;

                if (!string.IsNullOrEmpty(dto.SubCategory1.Name))
                {
                    subCategory1 = new SubCategory1Logic().GetByName(dto.SubCategory1.Name);
                }
                else
                {
                    subCategory1 = new SubCategory1Dto { Id = dto.SubCategory1.Id };
                }

                var retVal = this.dal.Save(dto.Id, dto.Name, subCategory1.Id).ToDto();
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