using Domain.Classes.Usuario;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUsuarioRequest usuario)
        {            
            return Ok(_usuarioService.Insert(usuario));
        }

        [HttpGet("id")]
        public IActionResult Get([FromQuery] Guid id)
        {
            return Ok(_usuarioService.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioService.GetAll());
        }

        [HttpDelete("id")]
        public IActionResult Delete([FromQuery] Guid id)
        {
            return Ok(_usuarioService.Delete(id));
        }
    }
}
