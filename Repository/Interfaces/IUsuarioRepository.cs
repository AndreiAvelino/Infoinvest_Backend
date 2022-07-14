using Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUsuarioRepository : IRepositoryInterface<Usuario>
    {
        Usuario Get(string Email);
    }
}
