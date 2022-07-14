using Domain.ClassificacaoAtivo;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Ativo
{
    public class AtivoDAO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public float Cotacao { get; set; }
        public Guid ClassificacaoAlvoId { get; set; }
        public virtual ClassificacaoAtivoDAO ClassificacaoAtivo { get; set; }
    }
}
