using MediatR;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Notifications;
using SmartShop.Domain.Entities;
using SmartShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartShop.Domain.CommandHandlers
{
    public class CategoriaCommandHandler : CommandHandler, 
        IRequestHandler<RegisterNewCategoria, bool>
    {
        private IRepositoryCategoria _repositoryCategoria;
        private IMediatorHandler Bus;


        public CategoriaCommandHandler(IRepositoryCategoria customerRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _repositoryCategoria = customerRepository;
            Bus = bus;
        }

        public Task<bool> Handle(RegisterNewCategoria message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var categoria = new Categoria(message.Descricao);

            _repositoryCategoria.Add(categoria);

            if (Commit())
            {

            }

            return Task.FromResult(true);
        }

    }
}

