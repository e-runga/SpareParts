using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class PaperReferenceLogic : BaseLogic
    {
        #region .: Private Members :.
        private readonly PaperReferenceDal dal;
        #endregion

        #region .: Constructors :.
        public PaperReferenceLogic()
        {
            this.dal = new PaperReferenceDal();
        }
        #endregion

        #region .: Public Methods
        public List<PaperReferenceDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>() as List<PaperReferenceDto>;
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaperReferenceDto GetById(int id)
        {
            var retVal = this.dal.GetById(id).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
            return retVal;
        }

        public PaperReferenceDto GetByName(string name)
        {
            try
            {
                var retVal = this.dal.GetByName(name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaperReferenceDto Create(PaperReferenceDto dto)
        {
            try
            {
                PaperReferenceDto retVal = null;
                var actual = this.dal.GetByName(dto.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();

                if (actual == null)
                {
                    retVal = this.dal.Create(dto.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
                }
                else
                {
                    retVal = this.dal.Save(actual.Id, dto.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaperReferenceDto Save(PaperReferenceDto dto)
        {
            try
            {
                var retVal = this.dal.GetByName(dto.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();

                if (retVal != null)
                {
                    retVal = this.dal.Save(retVal.Id, retVal.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
                }
                else
                {
                    retVal = this.dal.Create(dto.Name).ToBasic<DataAccess.Models.PaperReference, PaperReferenceDto>();
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(PaperReferenceDto dto)
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