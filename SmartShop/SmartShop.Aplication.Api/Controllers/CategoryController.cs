using Microsoft.AspNetCore.Mvc;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;

namespace SmartShop.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediatorHandler Bus;
        public CategoryController(IMediatorHandler bus)
        {
            Bus = bus;
        }

        [HttpPost]
        public ActionResult Post([FromBody] RegisterNewCategory command)
        {
            var teste = Bus.SendCommand(command);
            return Ok(command.ValidationResult.Errors);
        }

        
    }
}