using Domain.CarteiraAtivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Carteira
{
    public class CarteiraDTO
    {
        public Guid Id { get; set; }
        public Guid idUsuario { get; set; }
        public string Usuario { get; set; }
        public IList<CarteiraAtivoDTO> ListaAtivos { get; set; }
    }
}
