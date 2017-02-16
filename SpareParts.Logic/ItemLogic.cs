using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class ItemLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly ItemDal dal;
        #endregion

        #region .: Constructors :.
        public ItemLogic()
        {
            this.dal = new ItemDal();
        }
        #endregion

        #region .: Public Methods
        public List<ItemDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToBasic<DataAccess.Models.Item, ItemDto>() as List<ItemDto>;
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemDto GetById(int id)
        {
            var retVal = this.dal.GetById(id).ToBasic<DataAccess.Models.Item, ItemDto>();
            return retVal;
        }

        public ItemDto GetByName(string name)
        {
            try
            {
                var retVal = this.dal.GetByName(name).ToBasic<DataAccess.Models.Item, ItemDto>();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemDto Create(ItemDto dto)
        {
            try
            {
                ItemDto retVal = null;
                var actual = this.dal.GetByName(dto.Name).ToBasic<DataAccess.Models.Item, ItemDto>();

                if (actual == null)
                {
                    retVal = this.dal.Create(dto.Name).ToBasic<DataAccess.Models.Item, ItemDto>();
                }
                else
                {
                    retVal = this.dal.Save(actual.Id, dto.Name).ToBasic<DataAccess.Models.Item, ItemDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemDto Save(ItemDto dto)
        {
            try
            {
                var retVal = this.dal.GetByName(dto.Name).ToBasic<DataAccess.Models.Item, ItemDto>();

                if (retVal != null)
                {
                    retVal = this.dal.Save(retVal.Id, retVal.Name).ToBasic<DataAccess.Models.Item, ItemDto>();
                }
                else
                {
                    retVal = this.dal.Create(dto.Name).ToBasic<DataAccess.Models.Item, ItemDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(ItemDto dto)
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