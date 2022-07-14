using Domain.Classes.Carteira;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarteiraController : ControllerBase
    {
        private readonly ICarteiraService _carteiraService;

        public CarteiraController(ICarteiraService carteiraService)
        {
            _carteiraService = carteiraService;
        }

        [HttpPost]
        public IActionResult Post(CreateCarteiraRequest carteira)
        {
            return Ok(_carteiraService.Insert(carteira));
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            return Ok(_carteiraService.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_carteiraService.GetAll());
        }
    }
}
