using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class SubModelLogic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly SubModelDal dal;
        #endregion

        #region .: Constructor :.
        public SubModelLogic()
        {
            this.dal = new SubModelDal();
        }
        #endregion

        #region .: Public Methods :.
        public List<SubModelDto> GetAll()
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

        public SubModelDto GetById(int id)
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

        public List<SubModelDto> GetByModelId(int modelId)
        {
            try
            {
                var retVal = this.dal.GetByModelId(modelId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the by models.
        /// </summary>
        /// <param name="modelIds">The model ids.</param>
        /// <returns></returns>
        public List<SubModelDto> GetByModels(List<int> modelIds)
        {
            try
            {
                var retVal = this.dal.GetByModels(modelIds).ToDto();
                return retVal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SubModelDto Create(SubModelDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name, dto.Models != null ? dto.Models.Select(m => m.Id).ToArray() : new int[0]).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SubModelDto Save(SubModelDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.Name, dto.Models != null ? dto.Models.Select(m => m.Name).ToArray() : new string[0]).ToDto();
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
                var retVal = this.dal.Delete(id);
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