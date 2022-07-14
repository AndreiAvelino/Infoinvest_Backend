using Resource.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resource.Response
{
    public class Response
    {
        public string Descricao { get; set; }
        public Status Status { get; set; }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }

    }

    public class ResponseBuilder
    {
        private Status Status { get; set; }
        private string Descricao { get; set; }

        public static ResponseBuilder Build()
        {
            return new ResponseBuilder();
        }

        public ResponseBuilder Sucesso()
        {
            Status = Status.Sucesso;
            return this;
        }

        public ResponseBuilder Aviso()
        {
            Status = Status.Aviso;
            return this;
        }

        public ResponseBuilder Erro()
        {
            Status = Status.Erro;
            return this;
        }

        public ResponseBuilder ComMensagem(string Descricao)
        {
            this.Descricao = Descricao;
            return this;
        }

        public Response Nova()
        {
            return new Response()
            {
                Status = Status,
                Descricao = Descricao
            };
        }

        public Response<T> Nova<T>(T t)
        {
            return new Response<T>()
            {
                Status = Status,
                Descricao = Descricao,
                Data = t
            };
        }
    }
}
