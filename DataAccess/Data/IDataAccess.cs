using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    internal interface IDataAccess<T>
    {
        T load(int id);
        bool save(T t);
        bool update(T t);
        bool delete(T t);

        List<T> LoadAll(int start, int count, bool asc);

        bool CanConnect();
    }
}
