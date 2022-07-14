using AutoMapper;
using Domain.Carteira;
using Domain.Classes.Usuario;
using Domain.User;
using Repository.Interface;
using Resource.Criptografia;
using Resource.Response;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository,IMapper mapper)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public Response Delete(Guid id)
        {

            try
            {
                var usuario = _usuarioRepository.Get(id);

                if(usuario != null)
                {
                    _usuarioRepository.Delete(usuario);

                    return ResponseBuilder
                                        .Build()
                                        .Sucesso()
                                        .ComMensagem("Usuário excluído com sucesso!")
                                        .Nova();

                } else
                {
                    return ResponseBuilder
                                        .Build()
                                        .Aviso()
                                        .ComMensagem("Usuário não encontrado")
                                        .Nova();
                }


            } catch (Exception e)
            {
                return ResponseBuilder
                           .Build()
                           .Erro()
                           .ComMensagem(e.Message)
                           .Nova();
                                    
            }
        }

        public Response Get(Guid id)
        {
            try
            {
                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .Nova(_usuarioRepository.Get(id));
            } catch (Exception e)
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
                        .Nova(_usuarioRepository.GetAll());
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

        public Response Insert(CreateUsuarioRequest createUsuario)
        {
            var hash = new Hash(SHA512.Create());

            try
            {
                var usuario = _mapper.Map<Usuario>(createUsuario);

                usuario.Id = Guid.NewGuid();
                usuario.Password = hash.CriptografarSenha(usuario.Password);
                usuario.ListaCarteira = new List<CarteiraDAO>();

                _usuarioRepository.Insert(usuario);

                return ResponseBuilder
                        .Build()
                        .Sucesso()
                        .ComMensagem("Usuario inserido com sucesso!")
                        .Nova();

            } catch (Exception e)
            {
                return ResponseBuilder
                        .Build()
                        .Erro()
                        .ComMensagem(e.Message)
                        .Nova();
            }
        }

        public Response Update(Usuario t)
        {
            throw new NotImplementedException();
        }
    }
}
