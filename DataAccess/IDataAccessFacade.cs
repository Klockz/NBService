using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess
{
    public interface IDataAccessFacade
    {
        List<ICustomerEntity> LoadCustomers(int start, int count, bool asc);
        bool saveCustomer(ICustomerEntity customer);
        ICustomerEntity LoadCustomer(int id);
        bool updateCustomer(ICustomerEntity customer);
        bool deleteCustomer(ICustomerEntity customer);
        ICustomerEntity CreateCustomer();
    }
}
