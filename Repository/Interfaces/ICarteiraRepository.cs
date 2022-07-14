using Domain.Carteira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ICarteiraRepository : IRepositoryInterface<CarteiraDAO>
    {
        IEnumerable<CarteiraDAO> GetAllPerUser(Guid id);
    }
}
