using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class GroupsDal : BaseDal
    {
        #region .: Constructor :.
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsDal"/> class.
        /// </summary>
        public GroupsDal() : base()
        {
        }
        #endregion

        #region .: Public Methods :.
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Group GetById(int id)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                Group retVal = model.Groups.FirstOrDefault(g => g.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Group GetByName(string name)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                Group retVal = model.Groups.FirstOrDefault(g => g.Name.Equals(name));
                return retVal;
            }
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Group> GetAll()
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                List<Group> retVal = model.Groups.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool Save(int id, string name)
        {
            using (SecurityModelEntities model = new SecurityModelEntities())
            {
                bool retVal = false;

                if (id > 0)
                {
                    Group item = model.Groups.FirstOrDefault(g => g.Id.Equals(id));

                    if (item != null)
                    {
                        item.Name = name;

                        model.SaveChanges();
                        retVal = true;
                    }
                }
                else
                {
                    Group item = new Group()
                    {
                        Name = name
                    };

                    model.Groups.AddObject(item);
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}
