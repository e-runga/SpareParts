using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.Logic
{
    public class CountryLogic : BaseLogic
    {
        #region .: Private Properties :.
        private readonly CountryDal dal;
        #endregion

        #region .: Constructor :.
        public CountryLogic()
        {
            this.dal = new CountryDal();
        }
        #endregion

        #region .: Public Methods :.
        #region .: COUNTRY :.
        public List<CountryDto> GetAllCountries()
        {
            try
            {
                var retval = this.dal.GetAllCountries().ToDto();
                return retval;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CountryUIDto> GetAllCountriesForUI()
        {
            try
            {
                var retval = this.dal.GetAllCountriesAndCities().ToUIDto();
                return retval;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CountryDto> GetAllCountriesAndCities()
        {
            try
            {
                var retVal = this.dal.GetAllCountriesAndCities().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CountryDto GetCountryByName(string name)
        {
            try
            {
                var retVal = this.dal.GetCountyByName(name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CountryDto CreateCountry(CountryDto dto)
        {
            try
            {
                var retVal = this.dal.CreateCountry(dto.Name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveCountry(CountryUIDto dto)
        {
            try
            {
                var retVal = this.dal.SaveCountry(dto.Id, dto.Name);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCountry(int id)
        {
            try
            {
                var retVal = this.dal.DeleteCountry(id);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region .: CITY :.
        public List<CityDto> GetCityByCountry(int countryId)
        {
            try
            {
                var retVal = this.dal.GetCityByCountry(countryId).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CityUIDto> GetAllCities()
        {
            try
            {
                var retVal = this.dal.GetAllCities().ToUIDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LocationViewDto> GetAllLocations()
        {
            try
            {
                var retVal = this.dal.GetAllLocations().ToDto().OrderBy(l => l.Location).ToList();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CityDto GetCityByName(string name)
        {
            try
            {
                var retVal = this.dal.GetCityByName(name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CityDto CreateCity(CityDto dto)
        {
            try
            {
                var retVal = this.dal.CreateCity(dto.Country.Id, dto.Name).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveCity(CityUIDto dto)
        {
            try
            {
                if (dto.CountryId.Equals(0))
                {
                    dto.CountryId = this.dal.GetCountyByName(dto.CountryName).Id;
                }

                var retVal = this.dal.SaveCity(dto.Id, dto.CountryId, dto.CityName);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCity(int id)
        {
            try
            {
                var retVal = this.dal.DeleteCity(id);
                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion
    }
}