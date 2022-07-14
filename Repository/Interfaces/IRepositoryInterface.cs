using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IRepositoryInterface<T>
    {
        T Get(Guid id);
        IEnumerable<T> GetAll();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
    }
}
