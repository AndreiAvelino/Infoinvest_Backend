using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ativo
{
    public class AtivoDTO
    {
        public Guid Id { get; set; }   
        public string Descricao { get; set; }
        public float Cotacao { get; set; }
        public Guid idClassificacaoAtivo { get; set; }
        public string ClassificacaoAtivo { get; set; }
    }
}
