using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes.Ativo
{
    public class CreateAtivoRequest
    {
        public string Descricao { get; set; }
        public float Cotacao { get; set; }
        public Guid idClassificacaoAtivo { get; set; }
    }
}
