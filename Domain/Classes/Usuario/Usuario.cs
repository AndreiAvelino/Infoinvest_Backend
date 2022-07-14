using Domain.Carteira;
using Resource.Enumerables;
using System;
using System.Collections.Generic;

namespace Domain.User
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataNasc { get; set; }
        public virtual ICollection<CarteiraDAO> ListaCarteira { get; set; }
        public Roles Role { get; set; }
    }
}
