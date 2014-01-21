using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Controller;
using DataAccess.Controller.impl;
using DataAccess.Entities;

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

            IDataAccess<ICustomerEntity> customerDataAccess = new PlayerSQLDataAccess(SQLStrings.CONNECTION_STRING);
            if (!customerDataAccess.CanConnect())
            {
                customerDataAccess = new CustomerBinaryDataAccess();
            }
            customerController = new CustomerController(customerDataAccess);
        }

        public List<Entities.ICustomerEntity> LoadCustomers(int start, int count, bool asc)
        {
            throw new NotImplementedException();
        }

        public bool saveCustomer(Entities.ICustomerEntity customer)
        {
            throw new NotImplementedException();
        }

        public Entities.ICustomerEntity LoadCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool updateCustomer(Entities.ICustomerEntity customer)
        {
            throw new NotImplementedException();
        }

        public bool deleteCustomer(Entities.ICustomerEntity customer)
        {
            throw new NotImplementedException();
        }

        public Entities.ICustomerEntity CreateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
