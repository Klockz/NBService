using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }
        string ContactPerson { get; set; }
        string Address { get; set; }
        string ZipCode { get; set; }
        string City { get; set; }
        string PhoneNumber { get; set; }
        List<IAppointment> Appointments { get; set; }
    }
}
