using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SpareParts.DataAccess
{
    /// <summary>
    /// SubModel data access layer class
    /// </summary>
    /// <seealso cref="SpareParts.DataAccess.BaseDal" />
    public class SubModelDal : BaseDal
    {
        #region .: Public Methods :.
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<SubModel> GetAll()
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.SubModel
                    .Include(s => s.Model)
                    .ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public SubModel GetById(int id)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.SubModel
                    .Include(s => s.Model)
                    .FirstOrDefault(p => p.Id.Equals(id));
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by model identifier.
        /// </summary>
        /// <param name="modelId">The model identifier.</param>
        /// <returns></returns>
        public List<SubModel> GetByModelId(int modelId)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.SubModel
                    .Include(s => s.Model)
                    .Where(s => s.Model.Any(m => m.Id.Equals(modelId))).ToList();
                return retVal;
            }
        }

        /// <summary>
        /// Gets the by models.
        /// </summary>
        /// <param name="modelIds">The model ids.</param>
        /// <returns></returns>
        public List<SubModel> GetByModels(List<int> modelIds)
        {

            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = dataModel.SubModel
                    .Include(s => s.Model)
                    .Where(s => modelIds.Contains(s.Id))
                    .Distinct()
                    .ToList();

                return retVal;
            }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public SubModel Create(string name, int[] modelIds)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var models = dataModel.Model.Where(m => modelIds.Contains(m.Id)).ToList();

                var retVal = new SubModel
                {
                    Name = name
                };

                models.ForEach(m => retVal.Model.Add(m));
                dataModel.SubModel.AddObject(retVal);
                dataModel.SaveChanges();

                return dataModel.SubModel.Include(s => s.Model).FirstOrDefault(s => s.Id.Equals(retVal.Id));
            }
        }

        /// <summary>
        /// Saves the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="modelNames">The model names.</param>
        /// <returns></returns>
        public SubModel Save(int id, string name, string[] modelNames)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                var retVal = new SubModel();
                var models = dataModel.Model.Where(m => modelNames.Contains(m.Name)).ToList();
                SubModel item;

                if (id > 0)
                {
                    item = dataModel.SubModel.FirstOrDefault(s => s.Id.Equals(id));

                    if (item != null)
                    {
                        item.Name = name;
                        item.Model.Clear();
                        dataModel.SaveChanges();
                    }
                }
                else
                {
                    item = new SubModel { Name = name };
                    dataModel.SubModel.AddObject(item);
                    dataModel.SaveChanges();
                }

                models.ForEach(m => item.Model.Add(m));
                dataModel.SaveChanges();
                retVal = dataModel.SubModel.Include(m => m.Model).FirstOrDefault(s => s.Id.Equals(item.Id));
                return retVal;
            }
        }

        public bool Delete(int id)
        {
            using (DataModelEntities dataModel = new DataModelEntities())
            {
                bool retval = false;
                var itemToDelete = dataModel.SubModel.FirstOrDefault(s => s.Id.Equals(id));

                if (itemToDelete != null)
                {
                    //Deletes links with models
                    itemToDelete.Model.Clear();
                    dataModel.SaveChanges();
                    dataModel.SubModel.DeleteObject(itemToDelete);
                    dataModel.SaveChanges();
                    retval = true;
                }

                return retval;
            }
        }
        #endregion
    }
}