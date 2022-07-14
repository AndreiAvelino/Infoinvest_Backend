using Resource.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes.Usuario
{
    public class CreateUsuarioRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataNasc { get; set; }
        public Roles Role { get; set; }
    }
}
