using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// Product Type data access layer class
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class ProductTypeDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<ProductTypeView> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.ProductTypeView.ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ProductType GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.ProductType
                    .Include(p => p.Category)
                    .Include(p => p.Brand)
                    .FirstOrDefault(p => p.Id.Equals(id));
                return retVal;
            }
        }

        public ProductType Create(string name, List<int> categoryIds, List<int> brandIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new ProductType
                {
                    Name = name,
                    Brand = new System.Data.Objects.DataClasses.EntityCollection<Brand>(),
                    Category = new System.Data.Objects.DataClasses.EntityCollection<Category>()
                };

                model.ProductType.AddObject(retVal);
                model.SaveChanges();

                var brands = model.Brand.Where(b => brandIds.Contains(b.Id)).ToList();
                var categories = model.Category.Where(c => categoryIds.Contains(c.Id)).ToList();

                categories.ForEach(c => retVal.Category.Add(c));
                brands.ForEach(b => retVal.Brand.Add(b));
                model.SaveChanges();

                return model.ProductType
                    .Include(p => p.Category)
                    .Include(p => p.Brand)
                    .FirstOrDefault(p => p.Id.Equals(retVal.Id));
            }
        }

        public ProductType Save(int id, string name, List<int> categoryIds, List<int> brandIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                ProductType retVal;

                if (id > 0)
                {
                    retVal = model.ProductType.FirstOrDefault(p => p.Id.Equals(id));

                    if (retVal != null)
                    {
                        retVal.Brand.Clear();
                        retVal.Category.Clear();
                        model.SaveChanges();
                    }
                }
                else
                {
                    retVal = new ProductType { Brand = new System.Data.Objects.DataClasses.EntityCollection<Brand>(), Category = new System.Data.Objects.DataClasses.EntityCollection<Category>() };
                }

                var brands = model.Brand.Where(b => brandIds.Contains(b.Id)).ToList();
                var categories = model.Category.Where(c => categoryIds.Contains(c.Id)).ToList();

                retVal.Name = name;

                foreach (var category in categories)
                {
                    retVal.Category.Add(category);
                }

                foreach (var brand in brands)
                {
                    retVal.Brand.Add(brand);
                }
                //categories.ForEach(c => retVal.Category.Add(c));
                //brands.ForEach(b => retVal.Brand.Add(b));

                if (id == 0)
                {
                    model.ProductType.AddObject(retVal);
                }

                model.SaveChanges();

                return model.ProductType
                    .Include(p => p.Category)
                    .Include(p => p.Brand)
                    .FirstOrDefault(p => p.Id.Equals(retVal.Id));
            }
        }

        public bool Delete(int productTypeId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                var item = model.ProductType.FirstOrDefault(p => p.Id.Equals(productTypeId));

                if (item != null)
                {
                    item.Brand.Clear();
                    item.Category.Clear();
                    model.ProductType.DeleteObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}