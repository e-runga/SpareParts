using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class CustomerTypeLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly CustomerTypeDal dal;
        #endregion

        #region .: Constructors :.
        public CustomerTypeLogic()
        {
            this.dal = new CustomerTypeDal();
        }
        #endregion

        #region .: Public Methods
        public List<CustomerTypeDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>() as List<CustomerTypeDto>;
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerTypeDto GetById(int id)
        {
            var retVal = this.dal.GetById(id).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
            return retVal;
        }

        public CustomerTypeDto GetByName(string name)
        {
            try
            {
                var retVal = this.dal.GetByName(name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerTypeDto Create(string name)
        {
            try
            {
                CustomerTypeDto retVal = null;
                var actual = this.dal.GetByName(name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();

                if (actual == null)
                {
                    retVal = this.dal.Create(name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
                }
                else
                {
                    retVal = this.dal.Save(actual.Id, name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerTypeDto Save(CustomerTypeDto dto)
        {
            try
            {
                var retVal = this.dal.GetByName(dto.Name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();

                if (retVal != null)
                {
                    retVal = this.dal.Save(retVal.Id, retVal.Name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
                }
                else
                {
                    retVal = this.dal.Create(dto.Name).ToBasic<DataAccess.Models.CustomerType, CustomerTypeDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(CustomerTypeDto dto)
        {
            try
            {
                var retVal = this.dal.Delete(dto.Id);
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