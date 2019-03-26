using EventBus;
using EventBus.Events;
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
        private readonly IEventBus _eventBus;
        public CategoryController(IMediatorHandler bus, IEventBus eventBus)
        {
            Bus = bus;
            _eventBus = eventBus;
        }

        [HttpPost]
        public ActionResult Post([FromBody] RegisterNewCategory command)
        {
            IntegrationEvent ie = new IntegrationEvent();

            

            var teste = Bus.SendCommand(command);
            _eventBus.Publish(ie);
            return Ok(command.ValidationResult.Errors);
            
        }

        
    }
}