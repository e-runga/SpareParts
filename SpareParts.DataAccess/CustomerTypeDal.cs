using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// CustomerType data access layer
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class CustomerTypeDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<CustomerType> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.CustomerType.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public CustomerType GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.CustomerType.FirstOrDefault(b => b.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">Name of the brand.</param>
        /// <returns></returns>
        public CustomerType GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.CustomerType.FirstOrDefault(b => b.Name.Equals(name));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public CustomerType Create(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new CustomerType
                {
                    Name = name
                };

                model.CustomerType.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public CustomerType Save(int id, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.CustomerType.FirstOrDefault(b => b.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
                    model.SaveChanges();
                }

                return retVal;
            }
        }

        public bool Delete(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                var item = model.CustomerType.FirstOrDefault(b => b.Id.Equals(id));

                if (item != null)
                {
                    model.DeleteObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}