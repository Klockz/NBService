using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public interface IAppointmentEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        string Frequency { get; set; }
        string Address { get; set; }
        int Price { get; set; }
    }
}
