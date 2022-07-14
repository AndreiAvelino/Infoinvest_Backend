using AutoMapper;
using Domain.Ativo;
using Domain.Classes.Ativo;
using Repository.Interface;
using Resource.Response;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AtivoService : IAtivoService
    {
        private readonly IMapper _mapper;
        private readonly IAtivoRepository _ativoRepository;

        public AtivoService(IMapper mapper, IAtivoRepository ativoRepository)
        {
            _mapper = mapper;
            _ativoRepository = ativoRepository;
        }

        public Response Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Response Get(Guid id)
        {
            try
            {
                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .Nova(_ativoRepository.Get(id));
            }
            catch (Exception e)
            {
                return ResponseBuilder
                        .Build()
                        .Erro()
                        .ComMensagem(e.Message)
                        .Nova();
            }
        }

        public Response GetAll()
        {
            try
            {
                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .Nova(_ativoRepository.GetAll());
            }
            catch (Exception e)
            {
                return ResponseBuilder
                        .Build()
                        .Erro()
                        .ComMensagem(e.Message)
                        .Nova();
            }
        }

        public Response Insert(CreateAtivoRequest ativo)
        {
            try
            {
                var ativoDao = _mapper.Map<AtivoDAO>(ativo);

                ativoDao.Id = Guid.NewGuid();

                _ativoRepository.Insert(ativoDao);

                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .ComMensagem("Ativo cadastrado com sucesso!")
                        .Nova();

            }
            catch (Exception e)
            {
                return ResponseBuilder
                        .Build()
                        .Erro()
                        .ComMensagem(e.Message)
                        .Nova();
            }
        }

        public Response Update(AtivoDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
