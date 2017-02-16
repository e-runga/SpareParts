using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class ItemDal : BaseDal
    {
        #region .: Public Methods
        public List<Item> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Item.ToList();
                return retVal;
            }
        }

        public Item GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Item.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public Item GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Item.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }

        public Item Create(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Item
                {
                    Name = name
                };

                model.Item.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public Item Save(int id, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Item.FirstOrDefault(b => b.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Name = name;
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
                var item = model.Item.FirstOrDefault(b => b.Id.Equals(id));

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