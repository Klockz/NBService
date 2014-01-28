using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Entities;

namespace DataAccess.Controller.impl
{
    internal class AppointmentController : ICRUDController<IAppointmentEntity>
    {
        private IDataAccess<IAppointmentEntity> dataAcces;

        public AppointmentController(IDataAccess<IAppointmentEntity> dataAcces)
        {
            this.dataAcces = dataAcces;
        }

        public IAppointmentEntity Load(int id)
        {
            return dataAcces.load(id);
        }

        public bool Save(IAppointmentEntity t)
        {
            return dataAcces.save(t);
        }

        public bool Update(IAppointmentEntity t)
        {
            return dataAcces.update(t);
        }

        public bool Delete(IAppointmentEntity t)
        {
            return dataAcces.delete(t);
        }

        public List<IAppointmentEntity> loadAll(int start, int count, bool asc)
        {
            return dataAcces.LoadAll(start, count, asc);
        }
    }
}
