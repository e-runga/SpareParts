using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class ProfilesDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets the profil by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Profile GetProfileById(int id)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Profiles.FirstOrDefault(p => p.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the profile by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Profile GetProfileByName(string name)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Profiles.FirstOrDefault(p => p.Name.Equals(name));
                return retVal;
            }
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Profile> GetAll()
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                var retVal = model.Profiles.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="groupId">The group identifier.</param>
        /// <returns></returns>
        public bool Save(int id, string name)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                bool retVal = false;

                if (id > 0)
                {
                    var item = model.Profiles.FirstOrDefault(p => p.Id.Equals(id));

                    if (item != null)
                    {
                        item.Name = name;
                    }

                    model.SaveChanges();
                    retVal = true;
                }
                else
                {
                    var item = new Profile
                    {
                        Name = name
                    };

                    model.Profiles.AddObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
            #endregion
        }
    }
}