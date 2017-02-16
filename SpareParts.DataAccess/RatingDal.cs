using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class RatingDal : BaseDal
    {
        #region .: Public Methods
        public List<Rating> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Rating.ToList();
                return retVal;
            }
        }

        public Rating GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Rating.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public Rating GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.Rating.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }

        public Rating Create(string name, decimal amount)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new Rating
                {
                    Name = name,
                    Amount = amount
                };

                model.Rating.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public Rating Save(int id, string name, decimal amount)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                Rating retVal;

                if (id == 0)
                {
                    retVal = model.Rating.FirstOrDefault(r => r.Name.Equals(name));

                    if (retVal == null)
                    {
                        retVal = new Rating { Name = name, Amount = amount };
                        model.Rating.AddObject(retVal);
                        model.SaveChanges();
                    }
                }
                else
                {
                    retVal = model.Rating.FirstOrDefault(b => b.Id.Equals(id));
                    retVal.Name = name;
                    retVal.Amount = amount;
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
                var Rating = model.Rating.FirstOrDefault(b => b.Id.Equals(id));

                if (Rating != null)
                {
                    model.DeleteObject(Rating);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}