using Domain.Ativo;
using Domain.Classes.Ativo;
using Resource.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IAtivoService
    {
        Response Get(Guid id);
        Response GetAll();
        Response Delete(Guid id);
        Response Update(AtivoDTO t);
        Response Insert(CreateAtivoRequest t);
    }
}
