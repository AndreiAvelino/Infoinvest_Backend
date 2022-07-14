using Domain.Ativo;
using Domain.Carteira;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CarteiraAtivo
{
    public class CarteiraAtivoDAO
    {
        public Guid Id { get; set; }    
        public Guid CarteiraId { get; set; }
        public virtual CarteiraDAO Carteira { get; set; }
        public Guid AtivoId { get; set; }
        public virtual AtivoDAO Ativo { get; set; }
        public int Quantidade { get; set; }
    }
}
