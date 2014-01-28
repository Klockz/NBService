using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Controller;
using DataAccess.Controller.impl;
using DataAccess.Entities;
using DataAccess.Entities.impl;
using Model.DomainModel.impl;

namespace DataAccess
{
    public class DataAccessFacade : IDataAccessFacade
    {
        private ICRUDController<ICustomerEntity> customerController;

        public DataAccessFacade()
        {
            initControllers();
        }

        private void initControllers()
        {
            throw new NotImplementedException();
        }

        public List<Entities.ICustomerEntity> LoadCustomers(int start, int count, bool asc)
        {
            return customerController.loadAll(start, count, asc);
        }

        public bool saveCustomer(Entities.ICustomerEntity customer)
        {
            return customerController.Save(customer);
        }

        public Entities.ICustomerEntity LoadCustomer(int id)
        {
            return customerController.Load(id);
        }

        public bool updateCustomer(Entities.ICustomerEntity customer)
        {
            return customerController.Update(customer);
        }

        public bool deleteCustomer(Entities.ICustomerEntity customer)
        {
            return customerController.Delete(customer);
        }

        public Entities.ICustomerEntity CreateCustomer()
        {
            return new Customer();
        }
    }
}
