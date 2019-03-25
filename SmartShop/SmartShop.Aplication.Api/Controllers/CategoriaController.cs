using Microsoft.AspNetCore.Mvc;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;

namespace SmartShop.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IMediatorHandler Bus;
        public CategoriaController(IMediatorHandler bus)
        {
            Bus = bus;
        }

        [HttpPost]
        public ActionResult Post([FromBody] RegisterNewCategoria command)
        {
            var teste = Bus.SendCommand(command);
            return Ok(command.ValidationResult.Errors);
        }

        
    }
}