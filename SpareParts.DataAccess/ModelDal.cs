using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// The Model data access layer class
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class ModelDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Model> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retval = model.Model
                    .Include(m => m.Brand)
                    .Include(m => m.SubModel)
                    .ToList();
                return retval;
            }
        }
        public List<ModelView> GetAllForUI()
        {
            return new DataModelEntities().ModelView.ToList();
        }

        /// <summary>
        /// Gets the by brand.
        /// </summary>
        /// <param name="brandId">The brand identifier.</param>
        /// <returns></returns>
        public List<Model> GetByBrand(int brandId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Model
                    .Include(m => m.Brand)
                    .Include(m => m.SubModel)
                    .Where(m => m.Brand.Any(b => b.Id.Equals(brandId)))
                    .ToList();

                return retVal;
            }
        }

        /// <summary>
        /// Gets the by brands.
        /// </summary>
        /// <param name="brandIds">The brand ids.</param>
        /// <returns></returns>
        public List<Model> GetByBrands(List<int> brandIds)
        {
            var retVal = new List<Model>();
            brandIds.ForEach(i => retVal.AddRange(this.GetByBrand(i)));

            return retVal;
        }

        public Model GetById(int modelId)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Model
                    .Include(m => m.Brand)
                    .Include(m => m.SubModel)
                    .FirstOrDefault(m => m.Id.Equals(modelId));
                return retVal;
            }
        }

        public List<Model> GetBySubModelId(int subModelId)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = new List<Model>();
                var subModel = dataModel.SubModel.FirstOrDefault(s => s.Id.Equals(subModelId));

                if (subModel != null)
                {
                    retVal = dataModel.Model
                        .Include(m => m.Brand)
                        .Include(m => m.SubModel)
                        .Where(m => m.SubModel.Contains(subModel))
                        .ToList();
                }

                return retVal;
            }
        }

        public Model Create(string name, int[] subModelIds, int[] brandIds)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Model
                {
                    Name = name,
                    Brand = new System.Data.Objects.DataClasses.EntityCollection<Brand>(),
                    SubModel = new System.Data.Objects.DataClasses.EntityCollection<SubModel>()
                };

                foreach (var brandId in brandIds)
                {
                    retVal.Brand.Add(new Brand { Id = brandId });
                }

                foreach (var subModelId in subModelIds)
                {
                    retVal.SubModel.Add(new SubModel { Id = subModelId });
                }

                model.Model.AddObject(retVal);
                model.SaveChanges();

                return model.Model
                    .Include(m => m.Brand)
                    .Include(m => m.SubModel)
                    .FirstOrDefault(m => m.Id.Equals(retVal.Id));
            }
        }

        public Model Save(int modelId, int[] subModelIds, int[] brandIds, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Model.FirstOrDefault(m => m.Id.Equals(modelId));
                retVal.Brand.Clear();
                retVal.SubModel.Clear();
                model.SaveChanges();

                retVal.Brand = new System.Data.Objects.DataClasses.EntityCollection<Brand>();
                retVal.SubModel = new System.Data.Objects.DataClasses.EntityCollection<SubModel>();

                foreach (var brandId in brandIds)
                {
                    retVal.Brand.Add(new Brand { Id = brandId });
                }

                foreach (var subModelId in subModelIds)
                {
                    retVal.SubModel.Add(new SubModel { Id = subModelId });
                }

                model.SaveChanges();
                return model.Model
                    .Include(m => m.Brand)
                    .Include(m => m.SubModel)
                    .FirstOrDefault(m => m.Id.Equals(retVal.Id));
            }
        }

        public bool Delete(int id)
        {
            bool retVal = false;

            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var toDelete = dataModel.Model.FirstOrDefault(m => m.Id.Equals(id));

                if (toDelete != null)
                {
                    toDelete.SubModel.Clear();
                    dataModel.Model.DeleteObject(toDelete);
                    dataModel.SaveChanges();
                    retVal = true;
                }
            }

            return retVal;
        }
        #endregion
    }
}