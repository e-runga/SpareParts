using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// Brand data access layer
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class BrandDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Brand
                    .Include(b => b.ProductType)
                    .Include(b => b.Model)
                    .ToList();
                return retVal;
            }
        }

        public List<BrandViewForUI> GetAllForUI()
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.BrandViewForUI.ToList();
                return retVal;
            }
        }

        public List<BrandViewForUI> GetByProductType(int productTypeId)
        {
            using (var dataModel = new DataModelEntities())
            {
                var retVal = dataModel.BrandViewForUI
                    .Where(b => b.ProductTypeId.Equals(productTypeId))
                    .ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Brand GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Brand
                    .Include(b => b.ProductType)
                    .Include(b => b.Model)
                    .FirstOrDefault(b => b.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="brandName">Name of the brand.</param>
        /// <returns></returns>
        public Brand GetByName(string brandName)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Brand
                    .Include(b => b.ProductType)
                    .Include(b => b.Model)
                    .FirstOrDefault(b => b.Name.Equals(brandName));
                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Brand Create(string name, int[] modelIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Brand
                {
                    Name = name,
                    Model = new System.Data.Objects.DataClasses.EntityCollection<Model>()
                };

                foreach (var modelId in modelIds)
                {
                    retVal.Model.Add(new Model { Id = modelId });
                }

                model.Brand.AddObject(retVal);
                model.SaveChanges();

                return model.Brand
                    .Include(b => b.Model)
                    .FirstOrDefault(b => b.Id.Equals(retVal.Id));
            }
        }

        public Brand Save(int id, string name, string[] modelNames, string[] productTypeNames)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.Brand.FirstOrDefault(b => b.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
                    retVal.Model.Clear();
                    retVal.ProductType.Clear();
                    dataModel.SaveChanges();

                    foreach (var modelName in modelNames)
                    {
                        var model = dataModel.Model.FirstOrDefault(m => m.Name.Equals(modelName));
                        retVal.Model.Add(model);
                    }

                    foreach (var typeName in productTypeNames)
                    {
                        var type = dataModel.ProductType.FirstOrDefault(t => t.Name.Equals(typeName));
                        retVal.ProductType.Add(type);
                    }

                    dataModel.SaveChanges();
                }

                return dataModel.Brand
                    .Include(b => b.Model)
                    .FirstOrDefault(b => b.Id.Equals(retVal.Id));
            }
        }

        public bool Delete(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                bool retVal = false;
                var item = model.Brand.FirstOrDefault(b => b.Id.Equals(id));

                if (item != null)
                {
                    model.DeleteObject(item);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}