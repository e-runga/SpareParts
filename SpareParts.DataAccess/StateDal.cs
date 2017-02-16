using SpareParts.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpareParts.DataAccess
{
    public class StateDal : BaseDal
    {
        #region .: Public Methods
        public List<State> GetAll()
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.State.ToList();
                return retVal;
            }
        }

        public State GetById(int id)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.State.FirstOrDefault(c => c.Id.Equals(id));
                return retVal;
            }
        }

        public State GetByName(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.State.FirstOrDefault(c => c.Name.Equals(name));
                return retVal;
            }
        }


        public State Create(string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = new State
                {
                    Name = name
                };

                model.State.AddObject(retVal);
                model.SaveChanges();

                return retVal;
            }
        }

        public State Save(int id, string name)
        {
            using (DataModelEntities model = new DataModelEntities())
            {
                var retVal = model.State.FirstOrDefault(b => b.Id.Equals(id));

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
                var State = model.State.FirstOrDefault(b => b.Id.Equals(id));

                if (State != null)
                {
                    model.DeleteObject(State);
                    model.SaveChanges();
                    retVal = true;
                }

                return retVal;
            }
        }
        #endregion
    }
}