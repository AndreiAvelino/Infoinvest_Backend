using Domain.Classes.Usuario;
using Domain.User;
using Resource.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        Response Get(Guid Id);
        Response GetAll();
        Response Delete(Guid id);
        Response Update(Usuario t);
        Response Insert(CreateUsuarioRequest usuario);
    }
}
