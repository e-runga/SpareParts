using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class RatingLogic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly RatingDal dal;
        #endregion

        #region .: Constructor :.
        public RatingLogic()
        {
            this.dal = new RatingDal();
        }
        #endregion

        #region .: Public Methods :.
        public List<RatingDto> GetAll()
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

        public RatingDto GetById(int id)
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

        public RatingDto GetByName(string name)
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

        public RatingDto Create(RatingDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name, dto.Amount).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RatingDto Save(RatingDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.Name, dto.Amount).ToDto();
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