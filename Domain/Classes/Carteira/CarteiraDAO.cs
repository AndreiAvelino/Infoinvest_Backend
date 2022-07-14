using Domain.CarteiraAtivo;
using Domain.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Carteira
{
    public class CarteiraDAO
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<CarteiraAtivoDAO> ListaAtivos { get; set; }
    }
}
