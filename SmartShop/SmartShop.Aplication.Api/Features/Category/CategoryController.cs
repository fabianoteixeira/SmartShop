using EventBus;
using EventBus.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartShop.Domain.Commands.Category;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Notifications;
using SmartShop.Domain.Queries;
using SmartShop.Services.Api.Features.Category;
using System.Collections.Generic;
using System.Net;

namespace SmartShop.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiController
    {
        private readonly IMediatorHandler Bus;
        private readonly ICategoryQueries _categegoryQueries;
        public CategoryController(
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator,
            ICategoryQueries query
            ) : base(notifications, mediator)

        {
            _categegoryQueries = query;
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
        /// <summary>
        /// Update a category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put([FromBody] CategoryPut request)
        {

            Bus.SendCommand(new UpdateCategory(request.Id,request.Descricao));

            return Response(request);

        }


        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete([FromBody] CategoryPut request)
        {
            Bus.SendCommand(new DeleteCategory(request.Id));

            return Response(request);

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categegoryQueries.GetAll());
        }

    }
}