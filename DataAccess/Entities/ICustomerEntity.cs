using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public interface ICustomerEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string ContactPerson { get; set; }
        string Address { get; set; }
        int Phone { get; set; }
    }
}
