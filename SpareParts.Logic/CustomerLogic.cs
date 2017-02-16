using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    /// <summary>
    /// Customer business logic layer
    /// </summary>
    /// <seealso cref="SpareParts.Logic.BaseLogic" />
    public class CustomerLogic :  BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The dal
        /// </summary>
        private readonly CustomerDal dal;
        #endregion

        #region .: Constructors :.
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLogic"/> class.
        /// </summary>
        public CustomerLogic()
        {
            this.dal = new CustomerDal();
        }
        #endregion

        #region .: Public Members :.
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public CustomerDto GetById(int id)
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
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<CustomerDto> GetAll()
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

        public List<CustomerUIDto> GetAllForUI()
        {
            try
            {
                var retVal = this.dal.GetAll().ToUIDto();
                return retVal;
            }
            catch (Exception)
            {

                throw;
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
        public List<CustomerDto> Search(string fName, string lName, string email, string mobile, string phone)
        {
            try
            {
                var retVal = this.dal.Search(fName, lName, email, mobile, phone).ToDto();
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
        public CustomerDto Create(CustomerDto dto)
        {
            try
            {
                var retVal = this.dal.Create(dto.FirstName, dto.LastName, dto.Email, dto.Mobile, dto.Phone, dto.CustomerType.Id).ToDto();
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
        public CustomerDto Save(CustomerDto dto)
        {
            try
            {
                var retVal = this.dal.Save(dto.Id, dto.FirstName, dto.LastName, dto.Email, dto.Mobile, dto.Phone, dto.CustomerType.Id).ToDto();
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