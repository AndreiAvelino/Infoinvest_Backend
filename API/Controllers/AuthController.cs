using Domain.Classes.Login;
using Microsoft.AspNetCore.Mvc;
using Resource.Response;
using Service.Interfaces;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Login login)
        {
            var response = _authService.Auth(login);

            if (response != null)
            {
                return response;
            }
            else
            {
                return ResponseBuilder
                            .Build()
                            .Aviso()
                            .ComMensagem("Não foi possível realizar o login")
                            .Nova();
            }

        }
    }
}
