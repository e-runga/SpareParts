using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SpareParts.DataAccess
{
    public class SubCategory2Dal : BaseDal
    {
        #region .: Public Methods :.
        public List<SubCategory2> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory2
                    .Include(s => s.SubCategory1)
                    .ToList();
                return retVal;
            }
        }

        public List<SubCategory2> GetBySubCategory1Id(int subCategory1Id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory2
                    .Include(s => s.SubCategory1)
                    .Where(s => s.SubCategory1Id.Equals(subCategory1Id)).ToList();
                return retVal;
            }
        }

        public SubCategory2 GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory2.FirstOrDefault(s => s.Name.Equals(name));
                return retVal;
            }
        }

        public SubCategory2 GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory2.FirstOrDefault(s => s.Id.Equals(id));
                return retVal;
            }
        }

        public SubCategory2 Create(string name, int subCategory1Id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                SubCategory2 retVal = null;

                if (!model.SubCategory2.Any(s => s.SubCategory1Id.Equals(subCategory1Id) && s.Name.Equals(name)))
                {
                    retVal = new SubCategory2
                    {
                        Name = name,
                        SubCategory1Id = subCategory1Id
                    };

                    model.SubCategory2.AddObject(retVal);
                    model.SaveChanges();
                }

                return model.SubCategory2
                    .Include(s => s.SubCategory1)
                    .FirstOrDefault(s => s.Id.Equals(retVal.Id));
            }
        }

        public SubCategory2 Save(int id, string name, int subCategory1Id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory2.FirstOrDefault(s => s.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
                    retVal.SubCategory1Id = subCategory1Id;
                    model.SaveChanges();
                }

                return model.SubCategory2
                    .Include(s => s.SubCategory1)
                    .FirstOrDefault(s => s.Id.Equals(id));
            }
        }

        public bool Delete(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                var item = model.SubCategory2.FirstOrDefault(s => s.Id.Equals(id));

                if (item != null)
                {
                    model.SubCategory2.DeleteObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}
