using AutoMapper;
using Domain.Ativo;
using Domain.Carteira;
using Domain.Classes.Ativo;
using Domain.Classes.Carteira;
using Domain.Classes.Usuario;
using Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            UsuarioMap();
            AtivoMap();
            CarteiraMap();
        }

        private void UsuarioMap()
        {
            CreateMap<CreateUsuarioRequest, Usuario>();                
        }

        private void AtivoMap()
        {
            CreateMap<CreateAtivoRequest, AtivoDAO>();
            CreateMap<AtivoDTO, AtivoDAO>()
                .ForPath(d => d.ClassificacaoAtivo.Id, o => o.MapFrom(x => x.idClassificacaoAtivo));
            CreateMap<AtivoDAO, AtivoDTO>()
                .ForPath(d => d.idClassificacaoAtivo, o => o.MapFrom(x => x.ClassificacaoAtivo.Id))
                .ForPath(d => d.ClassificacaoAtivo, o => o.MapFrom(x => x.ClassificacaoAtivo));
        }

        private void CarteiraMap()
        {
            CreateMap<CarteiraDTO, CarteiraDAO>();
            CreateMap<CarteiraDAO, CarteiraDTO>();
            CreateMap<CreateCarteiraRequest, CarteiraDAO>()
                .ForPath(d => d.UsuarioId, o => o.MapFrom(x => x.idUsuario));
        }
       
    }
}
