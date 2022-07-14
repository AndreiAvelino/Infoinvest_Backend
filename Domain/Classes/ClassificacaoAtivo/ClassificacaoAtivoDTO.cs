using Domain.Ativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ClassificacaoAtivo
{
    public class ClassificacaoAtivoDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public IList<AtivoDTO> ListaAtivo { get; set; }
    }
}
