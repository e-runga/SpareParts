using SpareParts.DataAccess;
using SpareParts.DataHelpers;
using SpareParts.Dto;
using System;
using System.Collections.Generic;

namespace SpareParts.Logic
{
    public class UserLogic : BaseLogic
    {
        #region .: Private Members :.
        /// <summary>
        /// The local data access layer instance
        /// </summary>
        private readonly UsersDal dal;
        #endregion

        #region .: Constructors :.
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogic"/> class.
        /// </summary>
        public UserLogic()
        {
            this.dal = new UsersDal();
        }
        #endregion

        #region .: Public Methods .:
        /// <summary>
        /// Gets all the <see cref="SpareParts.Dto.UserDto"/>.
        /// </summary>
        /// <returns>A list of <see cref="SpareParts.Dto.UserDto"/></returns>
        public List<UserDto> GetAll()
        {
            try
            {
                var retVal = this.dal.GetAll().ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - GetAll] An error occurred", ex);
                throw;
            }
        }
        
        /// <summary>
        /// Gets all the users for the UI.
        /// </summary>
        /// <returns></returns>
        public List<UserUIDto> GetAllForUI()
        {
            try
            {
                var retVal = this.dal.GetAll().ToUIDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - GetAllForUI] An error occurred", ex);
                throw ex;
            }
        }

        /// <summary>
        /// Gets a <see cref="SpareParts.Dto.UserDto"/> by providing its UserName
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>An instance of <see cref="SpareParts.Dto.UserDto"/></returns>
        public UserDto GetByUserName(string userName)
        {
            try
            {
                var retVal = this.dal.GetByUserName(userName).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - GetByUserName] An error occurred", ex);
                throw;
            }
        }

        /// <summary>
        /// Gets a <see cref="SpareParts.Dto.UserDto"/> by providing its identifier
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>An instance of <see cref="SpareParts.Dto.UserDto"/></returns>
        public UserDto GetById(int id)
        {
            try
            {
                var retVal = this.dal.GetById(id).ToDto();
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - GetById] An error occurred", ex);
                throw;
            }
        }

        /// <summary>
        /// Creates the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>An instance of <see cref="SpareParts.Dto.UserDto"/></returns>
        public UserDto Create(UserDto user)
        {
            try
            {
                UserDto retVal = null;

                if (user != null)
                {
                    retVal = this.dal.Create(user.UserName, user.FirstName, user.LastName, user.Email, user.Mobile, SpareParts.Tools.Encryption.TripleDESHelper.Encrypt(user.Password), user.Profile.Id).ToDto();
                }
                else
                {
                    throw new ArgumentNullException("user", "The UserDto instance cannot be null");
                }

                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - Create] An error occurred", ex);
                throw;
            }
        }

        /// <summary>
        /// Saves the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>An instance of <see cref="SpareParts.Dto.UserDto"/></returns>
        public UserUIDto Save(UserUIDto user)
        {
            try
            {
                UserUIDto retVal = null;
                var profile = new ProfilesDal().GetProfileByName(user.Profile);

                if (profile != null)
                {
                    retVal = this.dal.Save(user.Id, user.UserName, user.FirstName, user.LastName, user.Email, user.Mobile, SpareParts.Tools.Encryption.TripleDESHelper.Encrypt(user.Password), profile.Id, user.Enabled).ToUIDto();
                }
                else
                {
                    throw new Exception("The profile is not valid");
                }

                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - Save] An error occurred", ex);
                throw;
            }
        }

        /// <summary>
        /// Authenticates the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if authentication succeeded</returns>
        public bool Authenticate(string userName, string password)
        {
            try
            {
                var retVal = this.dal.Authenticate(userName, password);
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - Authenticate] An error occurred", ex);
                throw;
            }
        }

        /// <summary>
        /// Disables the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public bool Disable(string userName)
        {
            try
            {
                var retVal = this.dal.Disable(userName);
                return retVal;
            }
            catch (Exception ex)
            {
                base.Logger.Error("[UserLogic - Disable] An error occurred", ex);
                throw ex;
            }
        }
        #endregion
    }
}