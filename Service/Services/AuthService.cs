using API.Auth;
using Domain.Classes.Login;
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
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AuthService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Response Auth(Login login)
        {
            Hash hash = new Hash(SHA512.Create());

            try
            {
                var usuario = _usuarioRepository.Get(login.Email);

                if(usuario != null)
                {
                    if (hash.VerificarSenha(login.Senha, usuario.Password))
                    {
                        return ResponseBuilder
                                .Build()
                                .Sucesso()
                                .Nova(new
                                {
                                    token = TokenService.GenerateToken(usuario),
                                    expires_in = 86400,
                                    token_type = "Bearer",
                                    role = usuario.Role
                                });

                    }
                }
                

                return null;

            } catch (Exception e)
            {
                return null;
            }

        }
    }
}
