using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SpareParts.DataAccess
{
    public class CategoryDal : BaseDal
    {
        #region .: Public Methods :.
        public List<Category> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Category.Where(c => c.ParentId == null).ToList();
                return retVal;
            }
        }

        public List<CategoryView> GetAllForUIView()
        {
            using (var dataModel = new DataModelEntities())
            {
                var retVal = dataModel.CategoryView.ToList();
                return retVal;
            }
        }

        public List<Category> GetCategories()
        {
            using (var dataModel = new DataModelEntities())
            {
                var retVal = dataModel.Category.Where(c => !c.ParentId.HasValue).ToList();
                return retVal;
            }
        }

        public List<CategoryView> GetSubcategory1(List<int> parentIds)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.CategoryView.Where(c => parentIds.Contains(c.Id)).ToList();
                return retVal;
            }
        }

        public List<CategoryView> GetSubcategory2(List<int> parentIds)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.CategoryView.Where(c => parentIds.Contains(c.Id)).ToList();
                return retVal;
            }
        }

        public Category GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Category.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public Category GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Category.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }

        public Category Create(string name, int? parentId, int[] productTypeIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Category
                {
                    Name = name,
                    ParentId = parentId
                };

                foreach (var productTypeId in productTypeIds)
                {
                    retVal.ProductType.Add(new ProductType { Id = productTypeId });
                }

                model.Category.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public List<CategoryView> GetByProductTypeId(int productTypeId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                List<CategoryView> retVal = null;

                if (productTypeId > 0)
                {
                    var productType = model.ProductType.FirstOrDefault(p => p.Id.Equals(productTypeId));

                    if (productType != null)
                    {
                        retVal = (from cat in model.CategoryView
                                      join typ in model.Category on cat.Id equals typ.Id
                                      where typ.ProductType.Any(p => p.Id.Equals(productTypeId))
                                      select cat).ToList();

                    }
                }
                return retVal;
            }
        }

        public List<Category> GetByProductType(int productTypeId)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = new List<Category>();
                var productType = dataModel.ProductType.FirstOrDefault(t => t.Id.Equals(productTypeId));

                if (productType != null)
                {
                    retVal = productType.Category.Where(c => c.ParentId == null).ToList();
                }

                return retVal;
            }
        }

        public Category Save(int id, string name, int? parentId, int[] productTypeIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Category.FirstOrDefault(b => b.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
                    retVal.ParentId = parentId;
                    //retVal.ProductType = new System.Data.Objects.DataClasses.EntityCollection<ProductType>();

                    foreach (var productTypeId in productTypeIds)
                    {
                        retVal.ProductType.Add(new ProductType { Id = productTypeId });
                    }

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
                var item = model.Category.FirstOrDefault(b => b.Id.Equals(id));

                if (item != null)
                {
                    item.IsActive = false;
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }

        #endregion
    }
}