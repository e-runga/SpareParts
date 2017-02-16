using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class YearDal : BaseDal
    {
        #region .: Public Methods
        public List<Year> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Year.ToList();
                return retVal;
            }
        }

        public Year GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Year.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public Year Create(short year)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Year
                {
                    Year1 = year
                };

                model.Year.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public Year Save(int id, short year)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Year.FirstOrDefault(b => b.Id.Equals(id));

                if (retVal != null)
                {
                    retVal.Year1 = year;
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
                var Year = model.Year.FirstOrDefault(b => b.Id.Equals(id));

                if (Year != null)
                {
                    model.DeleteObject(Year);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}