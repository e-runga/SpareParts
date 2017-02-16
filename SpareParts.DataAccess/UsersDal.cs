using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// Users data access layer class
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class UsersDal : BaseDal
    {
        #region .: Public Methods
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<User> GetAll()
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Users.Include(u => u.Profile).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public User GetByUserName(string userName)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Users
                    .Include(u => u.Profile)
                    .FirstOrDefault(u => u.UserName.Equals(userName));
                return model.Users.Include(u => u.Profile).FirstOrDefault(u => u.Id.Equals(retVal.Id));
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User GetById(int id)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Users
                    .Include(u => u.Profile)
                    .FirstOrDefault(u => u.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobile">The mobile.</param>
        /// <param name="password">The password.</param>
        /// <param name="profileId">The profile identifier.</param>
        /// <returns></returns>
        public User Create(string userName, string firstName, string lastName, string email, string mobile, string password, int profileId)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                User retVal = null;

                if (!model.Users.Any(u => u.UserName.Equals(userName)))
                {
                    var user = new User
                    {
                        UserName = userName,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Mobile = mobile,
                        Password = password,
                        ProfilesId = profileId
                    };

                    model.Users.AddObject(user);
                    model.SaveChanges();
                    retVal = this.GetById(user.Id);
                }

                return model.Users.Include(u => u.Profile).FirstOrDefault(u => u.Id.Equals(retVal.Id));
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobile">The mobile.</param>
        /// <param name="password">The password.</param>
        /// <param name="profileId">The profile identifier.</param>
        /// <returns></returns>
        public User Save(int id, string userName, string firstName, string lastName, string email, string mobile, string password, int profileId, bool enabled)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var user = model.Users.FirstOrDefault(u => u.UserName.Equals(userName));

                if (user != null)
                {
                    user.UserName = userName;
                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.Email = email;
                    user.Mobile = mobile;
                    user.Password = !string.IsNullOrEmpty(password) ? password : user.Password;
                    user.ProfilesId = profileId;
                    user.Enabled = enabled;
                }
                else
                {
                    user = new User
                    {
                        UserName = userName,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Mobile = mobile,
                        Password = password,
                        ProfilesId = profileId,
                        Enabled = true
                    };

                    model.Users.AddObject(user);
                }

                model.SaveChanges();
                return model.Users.Include(u => u.Profile).FirstOrDefault(u => u.Id.Equals(user.Id));
            }
        }

        /// <summary>
        /// Authenticates the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Authenticate(string userName, string password)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Users.Any(u => u.UserName.Equals(userName) && u.Password.Equals(password));
                return retVal;
            }
        }

        /// <summary>
        /// Disables the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>True if operation is successfull</returns>
        public bool Disable(string userName)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                bool retVal = false;
                var user = model.Users.FirstOrDefault(u => u.UserName.Equals(userName));
                user.Enabled = false;
                model.SaveChanges();
                retVal = true;
                return retVal;
            }
        }
        #endregion
    }
}
