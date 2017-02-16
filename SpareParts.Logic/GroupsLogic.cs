using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class GroupsLogic : BaseLogic
    {
        #region .: Private Members :.
        private GroupsDal dal = null;
        #endregion

        #region .: Constructors :.
        public GroupsLogic()
        {
            this.dal = new GroupsDal();
        }
        #endregion

        #region .: Public Methods :.
        public GroupDto GetById(int id)
        {
            try
            {
                GroupDto retVal = this.dal.GetById(id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[GroupLogic] An error occurred", ex);
                throw ex;
            }
        }

        public GroupDto GetByName(string name)
        {
            try
            {
                GroupDto retVal = this.dal.GetByName(name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[GroupLogic] An error occurred", ex);
                throw ex;
            }
        }

        public List<GroupDto> GetAll()
        {
            try
            {
                List<GroupDto> retVal = this.dal.GetAll().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[GroupLogic] An error occurred", ex);
                throw;
            }
        }

        public bool Save(GroupDto dto)
        {
            try
            {
                bool retVal = this.dal.Save(dto.Id, dto.Name);
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[GroupLogic] An error occurred", ex);
                throw;
            }
        }
        #endregion
    }
}