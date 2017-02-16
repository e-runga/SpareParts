using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class ModelLogic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly ModelDal dal;
        #endregion

        #region .: Constructors :.
        public ModelLogic()
        {
            this.dal = new ModelDal();
        }
        #endregion

        #region .: Public Methods :.s
        public List<ModelDto> GetAll()
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

        public List<ModelViewDto> GetAllForUI()
        {
            try
            {
                var retVal = this.dal.GetAllForUI().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ModelDto> GetBySubModelId(int subModelId)
        {
            try
            {
                var retVal = this.dal.GetBySubModelId(subModelId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ModelDto> GetByBrand(int brandId)
        {
            try
            {
                var retVal = this.dal.GetByBrand(brandId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ModelDto> GetByBrands(List<int> brandIds)
        {
            try
            {
                var retVal = this.dal.GetByBrands(brandIds).ToDto();
                return retVal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModelDto GetById(int id)
        {
            try
            {
                var dto = this.dal.GetById(id).ToDto();
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ModelDto Create(ModelDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name,
                    dto.SubModels != null ? dto.SubModels.Select(s => s.Id).ToArray() : new int[0],
                    dto.Brands != null ? dto.Brands.Select(b => b.Id).ToArray() : new int[0]
                    ).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ModelDto Save(ModelDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id,
                    dto.SubModels != null ? dto.SubModels.Select(s => s.Id).ToArray() : new int[0],
                    dto.Brands != null ? dto.Brands.Select(b => b.Id).ToArray() : new int[0],
                    dto.Name).ToDto();
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