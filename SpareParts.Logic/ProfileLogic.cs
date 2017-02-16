using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class ProfileLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly ProfilesDal dal;
        #endregion

        #region .: Constructors :.
        public ProfileLogic()
        {
            this.dal = new ProfilesDal();
        }
        #endregion

        #region .: Public Methods
        public ProfileDto GetById(int id)
        {
            try
            {
                var retVal = this.dal.GetProfileById(id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[ProfileLogic - GetById] An error occurred", ex);
                throw;
            }
        }

        public ProfileDto GetByName(string name)
        {
            try
            {
                var retVal = this.dal.GetProfileByName(name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[ProfileLogic - GetByName] An error occurred", ex);
                throw;
            }
        }

        public List<ProfileDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[ProfileLogic - GetAll] An error occurred", ex);
                throw;
            }
        }

        public bool Save(ProfileDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.Name);
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[ProfileLogic - Save] An error occurred", ex);
                throw;
            }
        }
        #endregion
    }
}