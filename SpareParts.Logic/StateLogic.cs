using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class StateLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly StateDal dal;
        #endregion

        #region .: Constructors :.
        public StateLogic()
        {
            this.dal = new StateDal();
        }
        #endregion

        #region .: Public Methods :.
        public List<StateDto> GetAll()
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

        public StateDto GetById(int id)
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

        public StateDto GetByName(string name)
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

        public StateDto Create(StateDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StateDto Save(StateDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.Name).ToDto();
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