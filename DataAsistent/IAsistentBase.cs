using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAsistent
{
    interface IAsistentBase<T> where T:new()
    {
        int Add(T t);

        int Delete(T t);

        bool Delete(int id);

        T Get(int id);

        List<T> GetList(T t);

        int Update(int id, T t);
    }
}
