using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Controller
{
    internal interface ICRUDController<T>
    {
        T Load(int id);
        bool Save(T player);
        bool Update(T t);
        bool Delete(T t);

        List<T> loadAll(int start, int count, bool asc);
    }
}
