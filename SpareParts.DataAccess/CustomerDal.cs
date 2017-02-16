using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class CustomerDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Customer GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Customer
                    .Include(c => c.CustomerType)
                    .FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Customer
                    .Include(c => c.CustomerType)
                    .ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Searches the specified f name.
        /// </summary>
        /// <param name="fName">Name of the f.</param>
        /// <param name="lName">Name of the l.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobile">The mobile.</param>
        /// <param name="phone">The phone.</param>
        /// <returns></returns>
        public List<Customer> Search(string fName, string lName, string email, string mobile, string phone)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                List<Customer> retVal = null;
                var query = model.Customer.Include(c => c.CustomerType);

                query = !string.IsNullOrEmpty(fName) ? query.Where(c => c.FirstName.Equals(fName)) : query;
                query = !string.IsNullOrEmpty(lName) ? query.Where(c => c.LastName.Equals(lName)) : query;
                query = !string.IsNullOrEmpty(email) ? query.Where(c => c.Email.Equals(email)) : query;
                query = !string.IsNullOrEmpty(phone) ? query.Where(c => c.Phone.Equals(phone)) : query;
                query = !string.IsNullOrEmpty(mobile) ? query.Where(c => c.Mobile.Equals(mobile)) : query;

                retVal = query.ToList();

                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified f name.
        /// </summary>
        /// <param name="fName">Name of the f.</param>
        /// <param name="lName">Name of the l.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobile">The mobile.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="customerTypeId">The customer type identifier.</param>
        /// <returns></returns>
        public Customer Create(string fName, string lName, string email, string mobile, string phone, int customerTypeId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var item = new Customer
                {
                    FirstName = fName,
                    LastName = lName,
                    Email = email,
                    Mobile = mobile,
                    Phone = phone,
                    CustomerTypeId = customerTypeId
                };

                model.Customer.AddObject(item);
                model.SaveChanges();

                var retVal = model.Customer.Include(c => c.CustomerType).FirstOrDefault(c => c.Id.Equals(item.Id));
                return retVal;
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fName">Name of the f.</param>
        /// <param name="lName">Name of the l.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobile">The mobile.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="customerTypeId">The customer type identifier.</param>
        /// <returns></returns>
        public Customer Save(int id, string fName, string lName, string email, string mobile, string phone, int customerTypeId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var item = model.Customer.FirstOrDefault(c => c.Id.Equals(id));

                if (item != null)
                {
                    item.FirstName = fName;
                    item.LastName = lName;
                    item.Email= email;
                    item.Mobile = mobile;
                    item.Phone = phone;
                    item.CustomerTypeId = customerTypeId;

                    model.SaveChanges();
                }

                var retVal = model.Customer.Include(c => c.CustomerType).FirstOrDefault(c => c.Id.Equals(item.Id));
                return retVal;
            }
        }
        #endregion
    }
}