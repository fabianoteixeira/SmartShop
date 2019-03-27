using EventBus;
using EventBus.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Notifications;
using SmartShop.Services.Api.Features.Category;
using System.Net;

namespace SmartShop.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiController
    {
        private readonly IMediatorHandler Bus;   
        public CategoryController(
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(notifications, mediator)

        {
            Bus = mediator;
        }

        /// <summary>
        /// Create a new Category
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post([FromBody] CategoryPostRequest request)
        {
             
           Bus.SendCommand(new RegisterNewCategory(request.Descricao));

            return Response(request);
            
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put([FromBody] CategoryPut request)
        {

            Bus.SendCommand(new UpdateCategory(request.Id,request.Descricao));

            return Response(request);

        }


    }
}