using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarteiraAtivo
{
    public class CarteiraAtivoDTO
    {
        public Guid Id { get; set; }
        public Guid idCarteira { get; set; }
        public Guid idAtivo { get; set; }
        public string Ativo { get; set; }
        public int Quantidade { get; set; }
    }
}
