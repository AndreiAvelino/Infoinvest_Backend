using AutoMapper;
using Domain.Ativo;
using Domain.Carteira;
using Domain.CarteiraAtivo;
using Domain.Classes.Carteira;
using Repository.Interface;
using Resource.Response;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service.Services
{
    public class CarteiraService : ICarteiraService
    {
        private readonly IMapper _mapper;
        private readonly ICarteiraRepository _carteiraRepository;

        public CarteiraService(ICarteiraRepository carteiraRepository, IMapper mapper)
        {
            _mapper = mapper;
            _carteiraRepository = carteiraRepository;
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
                        .Nova(_carteiraRepository.Get(id));
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
                        .Nova(_carteiraRepository.GetAll());
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

        public Response Insert(CreateCarteiraRequest carteira)
        {
            try
            {
                var carteiraDao = _mapper.Map<CarteiraDAO>(carteira);

                carteiraDao.Id = Guid.NewGuid();
                carteiraDao.ListaAtivos = new List<CarteiraAtivoDAO>();

                _carteiraRepository.Insert(carteiraDao);

                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .ComMensagem("Carteira criada com sucesso!")
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

        public Response Update(CarteiraDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
