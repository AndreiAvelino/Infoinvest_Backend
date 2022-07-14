using Domain.Ativo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ClassificacaoAtivo
{
    public class ClassificacaoAtivoDAO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AtivoDAO> ListaAtivo { get; set; }
    }
}
