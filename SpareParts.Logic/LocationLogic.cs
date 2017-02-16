using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SpareParts.Logic.BaseLogic" />
    public class LocationLogic : BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The dal
        /// </summary>
        private readonly LocationDal dal;
        #endregion

        #region .: Constructor :.
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationLogic"/> class.
        /// </summary>
        public LocationLogic()
        {
            this.dal = new LocationDal();
        }
        #endregion

        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<LocationDto> GetAll()
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

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public LocationDto GetById(int id)
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

        /// <summary>
        /// Gets the by country.
        /// </summary>
        /// <param name="countryName">Name of the country.</param>
        /// <returns></returns>
        public List<LocationDto> GetByCountry(string countryName)
        {
            try
            {
                var retVal = this.dal.GetByCountry(countryName).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the by city.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <returns></returns>
        public List<LocationDto> GetByCity(string cityName)
        {
            try
            {
                var retVal = this.dal.GetByCity(cityName).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Creates the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public LocationDto Create(LocationDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.Name, dto.City.Id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Saves the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public LocationDto Save(LocationDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.City.Id, dto.Name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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