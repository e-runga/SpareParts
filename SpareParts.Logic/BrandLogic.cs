using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class BrandLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly BrandDal dal;
        #endregion

        #region .: Constructors :.
        public BrandLogic()
        {
            this.dal = new BrandDal();
        }
        #endregion

        #region .: Public Methods
        public List<BrandDto> GetAll()
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

        public List<BrandViewForUIDto> GetAllForUI()
        {
            try
            {
                var retVal = this.dal.GetAllForUI().ToDto()
                    .OrderBy(b => b.Brand)
                    .ThenBy(b => b.Models)
                    .ThenBy(b => b.ProductType)
                    .ToList();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BrandDto GetById(int id)
        {
            var retVal = this.dal.GetById(id).ToDto();
            return retVal;
        }

        public List<BrandViewForUIDto> GetByProductType(int productTypeId)
        {
            try
            {
                var retVal = this.dal.GetByProductType(productTypeId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BrandDto GetByName(string name)
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

        public List<BrandDto> GetByNames(List<string> names)
        {
            try
            {
                var retVal = new List<BrandDto>();
                names.ForEach(n => retVal.Add(this.GetByName(n)));
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BrandDto Create(BrandDto dto)
        {
            try
            {
                BrandDto retVal = null;
                var actual = this.dal.GetByName(dto.Name).ToDto();

                if (actual == null)
                {
                    retVal = this.dal.Create(dto.Name, dto.Models.Select(m => m.Id).ToArray()).ToDto();
                }
                else
                {
                    retVal = this.dal.Save(actual.Id, dto.Name, dto.Models.Select(m => m.Name).ToArray(), dto.Models.Select(m => m.Name).ToArray()).ToDto();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BrandDto Save(BrandDto dto)
        {
            try
            {
                var retVal = this.dal.GetById(dto.Id).ToDto();

                if (retVal != null)
                {
                    retVal = this.dal.Save(dto.Id, dto.Name, dto.Models.Select(m => m.Name.Trim()).ToArray(), dto.ProductType.Select(p => p.Name.Trim()).ToArray()).ToDto();
                }
                else
                {
                    retVal = this.dal.Create(dto.Name, dto.ProductType.Select(p => p.Id).ToArray()).ToDto();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(BrandDto dto)
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