using Domain.Classes.Ativo;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtivoController : ControllerBase
    {
        private readonly IAtivoService _ativoService;
        public AtivoController(IAtivoService ativoService)
        {
            _ativoService = ativoService;
        }

        [HttpPost]
        public IActionResult Post(CreateAtivoRequest ativo)
        {
            return Ok(_ativoService.Insert(ativo));
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            return Ok(_ativoService.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ativoService.GetAll());
        }
    }
}
