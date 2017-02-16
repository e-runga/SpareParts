using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class PaperReferenceDal : BaseDal
    {
        #region .: Public Methods
        public List<PaperReference> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.PaperReference.ToList();
                return retVal;
            }
        }

        public PaperReference GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.PaperReference.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public PaperReference GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.PaperReference.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }


        public PaperReference Create(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new PaperReference
                {
                    Name = name
                };

                model.PaperReference.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public PaperReference Save(int id, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.PaperReference.FirstOrDefault(b => b.Id.Equals(id));

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
                var PaperReference = model.PaperReference.FirstOrDefault(b => b.Id.Equals(id));

                if (PaperReference != null)
                {
                    model.DeleteObject(PaperReference);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}