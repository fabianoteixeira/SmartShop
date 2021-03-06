﻿using MediatR;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Commands;
using SmartShop.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartShop.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
       // private readonly IEventStore _eventStore;

        public InMemoryBus(
            //IEventStore eventStore
            IMediator mediator)
        {
           // _eventStore = eventStore;
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            //if (!@event.MessageType.Equals("DomainNotification"))
            //    _eventStore?.Save(@event);

            return _mediator.Publish(@event);
        }
    }
}
