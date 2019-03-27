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
    public class CategoryCommandHandler : CommandHandler, 
        IRequestHandler<RegisterNewCategory, bool>,
        IRequestHandler<UpdateCategory, bool>
    {
        private ICategoryRepository _categoryRepository;
        private IMediatorHandler Bus;


        public CategoryCommandHandler(ICategoryRepository categoryRepository,
                                      IUnitOfWork uow,
                                      IMediatorHandler bus,
                                      INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _categoryRepository = categoryRepository;
            Bus = bus;
        }

        public Task<bool> Handle(RegisterNewCategory message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var categoria = new Category(message.Description);

            _categoryRepository.Add(categoria);

            if (Commit())
            {

            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateCategory message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var category = new Category(message.Description);
            category.Id = message.Id;

            _categoryRepository.Update(category);

            if (Commit())
            {

            }

            return Task.FromResult(true);
        }

    }
}

