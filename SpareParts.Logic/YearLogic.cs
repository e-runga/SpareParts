using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpareParts.Logic
{
    public class YearLogic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly YearDal dal;
        #endregion

        #region .: Constructors :.
        public YearLogic()
        {
            this.dal = new YearDal();
        }
        #endregion

        #region .: Public Methods :.
        public List<YearDto> GetAll()
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

        public YearDto GetById(int id)
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

        public YearDto Create(YearDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Year).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public YearDto Save(YearDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.Year).ToDto();
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
