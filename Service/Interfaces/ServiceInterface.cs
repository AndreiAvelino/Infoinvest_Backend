using Resource.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ServiceInterface<T>
    {
        Response Get(Guid id);
        Response GetAll();
        Response Delete(Guid id);
        Response Update(T t);
        Response Insert(T t);
    }
}
