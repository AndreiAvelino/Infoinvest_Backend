using Domain.Carteira;
using Domain.Classes.Carteira;
using Resource.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICarteiraService 
    {
        Response Get(Guid id);
        Response GetAll();
        Response Delete(Guid id);
        Response Update(CarteiraDTO carteira);
        Response Insert(CreateCarteiraRequest createCarteira);
    }
}
