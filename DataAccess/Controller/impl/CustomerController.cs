using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Entities;

namespace DataAccess.Controller.impl
{
    public class CustomerController : ICRUDController<ICustomerEntity>
    {
        private IDataAccess<ICustomerEntity> dataAcces;

        public CustomerController(IDataAccess<ICustomerEntity> dataAcces)
        {
            this.dataAcces = dataAcces;
        }

        public ICustomerEntity Load(int id)
        {
            return dataAcces.load(id);
        }

        public bool Save(ICustomerEntity t)
        {
            return dataAcces.save(t);
        }

        public bool Update(ICustomerEntity t)
        {
            return dataAcces.update(t);
        }

        public bool Delete(ICustomerEntity t)
        {
            return dataAcces.delete(t);
        }

        public List<ICustomerEntity> loadAll(int start, int count, bool asc)
        {
            return dataAcces.LoadAll(start, count, asc);
        }
    }
}
