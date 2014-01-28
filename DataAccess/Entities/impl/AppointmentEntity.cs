using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.impl
{
    [Serializable]
    internal class AppointmentEntity : IAppointmentEntity
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
       public string Description{ get; set; }
       public DateTime StartDate{ get; set; }
       public string Frequency{ get; set; }
       public string Address{ get; set; }
       public int Price { get; set; }
    }
}
