using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.impl
{
    [Serializable]
    internal class CustomerEntity : ICustomerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        
    }
}
