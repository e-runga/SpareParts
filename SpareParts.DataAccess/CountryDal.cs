using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class CountryDal : BaseDal
    {
        #region .: Public Methods :.

        #region .: COUNTRY :.
        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAllCountries()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Country.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets all countries and cities.
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAllCountriesAndCities()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Country
                    .Include(c => c.City)
                    .ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the county by.
        /// </summary>
        /// <param name="countryName">Name of the country.</param>
        /// <returns></returns>
        public Country GetCountyByName(string countryName)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Country.FirstOrDefault(c => c.Name.Equals(countryName));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the country.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Country CreateCountry(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Country.FirstOrDefault(c => c.Name.Equals(name));

                if (retVal == null)
                {
                    retVal = new Country
                    {
                        Name = name
                    };

                    model.Country.AddObject(retVal);
                    model.SaveChanges();
                }

                return retVal;
            }
        }

        /// <summary>
        /// Saves the country.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool SaveCountry(int id, string name)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                bool retVal = false;
                Country item;

                if (id == 0)
                {
                    item = dataModel.Country.FirstOrDefault(c => c.Name.Equals(name));

                    if (item == null)
                    {
                        item = new Country { Name = name };
                        dataModel.Country.AddObject(item);
                        dataModel.SaveChanges();
                        retVal = true;
                    }
                }
                else
                {
                    item = dataModel.Country.FirstOrDefault(c => c.Id.Equals(id));

                    if (item != null)
                    {
                        item.Name = name;
                        dataModel.SaveChanges();
                        retVal = true;
                    }
                }

                return retVal;
            }
        }

        public bool DeleteCountry(int id)
        {
            bool retval = false;

            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var toDelete = dataModel.Country.FirstOrDefault(c => c.Id.Equals(id));

                if (toDelete != null)
                {
                    toDelete.City.Clear();
                    dataModel.Country.DeleteObject(toDelete);
                    dataModel.SaveChanges();
                    retval = true;
                }
            }

            return retval;
        }
        #endregion

        #region .: CITY :.
        /// <summary>
        /// Gets the city by country.
        /// </summary>
        /// <param name="countryId">The country identifier.</param>
        /// <returns></returns>
        public List<City> GetCityByCountry(int countryId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.City.Where(c => c.CountryId.Equals(countryId)).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets all cities.
        /// </summary>
        /// <returns></returns>
        public List<City> GetAllCities()
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.City
                    .Include(c => c.Country)
                    .ToList();
                return retVal;
            }
        }

        public List<LocationView> GetAllLocations()
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.LocationView.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the city by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public City GetCityByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.City.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the city.
        /// </summary>
        /// <param name="countryId">The country identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public City CreateCity(int countryId, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var country = model.Country.FirstOrDefault(c => c.Id.Equals(countryId));

                if (country == null)
                {
                    return null;
                }

                var retVal = model.City.Where(c => c.Name.Equals(name) && c.Country.Equals(country)).FirstOrDefault();

                if (retVal == null)
                {
                    retVal = new City
                    {
                        Name = name,
                        Country = country
                    };

                    model.City.AddObject(retVal);
                    model.SaveChanges();
                }

                return retVal;
            }
        }

        /// <summary>
        /// Saves the city.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="countryId">The country identifier.</param>
        /// <param name="name">The City name.</param>
        /// <returns></returns>
        public bool SaveCity(int cityId, int countryId, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                City city;

                if (cityId > 0)
                {
                    city = model.City.FirstOrDefault(c => c.Id.Equals(cityId));

                    if (city != null)
                    {
                        city.Name = name;
                        city.CountryId = countryId;
                        model.SaveChanges();
                        retVal = true;
                    }
                }
                else
                {
                    city = new City { Name = name, CountryId = countryId };
                    model.City.AddObject(city);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }

        public bool DeleteCity(int id)
        {
            bool retVal = false;

            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var toDelete = dataModel.City.FirstOrDefault(c => c.Id.Equals(id));

                if (toDelete != null)
                {
                    dataModel.City.DeleteObject(toDelete);
                    dataModel.SaveChanges();
                    retVal = true;
                }
            }

            return retVal;
        }
        #endregion

        #endregion
    }
}