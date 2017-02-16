using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SpareParts.DataAccess
{
    public class SubCategory1Dal : BaseDal
    {
        #region .: Public Methods :.
        public List<SubCategory1> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory1
                    .Include(s => s.Category)
                    .ToList();
                return retVal;
            }
        }

        public List<SubCategory1> GetByCategoryId(int categoryId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory1
                    .Include(s => s.Category)
                    .Where(s => s.CategoryId.Equals(categoryId)).ToList();
                return retVal;
            }
        }

        public SubCategory1 GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory1
                    .FirstOrDefault(s => s.Id.Equals(id));
                return retVal;
            }
        }

        public SubCategory1 GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var reteVal = model.SubCategory1
                    .Include(s => s.Category)
                    .FirstOrDefault(s => s.Name.Equals(name.Trim()));
                return reteVal;
            }
        }

        public SubCategory1 Create(string name, int categoryId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                SubCategory1 retVal = null;

                if (!model.SubCategory1.Any(s => s.CategoryId.Equals(categoryId) && s.Name.Equals(name)))
                {
                    retVal = new SubCategory1
                    {
                        Name = name,
                        CategoryId = categoryId
                    };

                    model.SubCategory1.AddObject(retVal);
                    model.SaveChanges();
                }

                return model.SubCategory1
                    .Include(s => s.Category)
                    .FirstOrDefault(s => s.Id.Equals(retVal.Id));
            }
        }

        public SubCategory1 Save(int id, string name, int categoryId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.SubCategory1.FirstOrDefault(s => s.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
                    retVal.CategoryId = categoryId;
                    model.SaveChanges();
                }

                return model.SubCategory1.Include(s => s.Category).FirstOrDefault(s => s.Id.Equals(retVal.Id));
            }
        }
        public bool Delete(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                var item = model.SubCategory1.FirstOrDefault(s => s.Id.Equals(id));

                if (item != null)
                {
                    item.SubCategory2.Clear();
                    model.SubCategory1.DeleteObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}
