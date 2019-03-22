using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SmartShop.Domain.CommandHandlers;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Notifications;
using SmartShop.Domain.Interfaces;
using SmartShop.Infra.CrossCutting.Bus;
using SmartShop.Infra.Data.Context;
using SmartShop.Infra.Data.Repository;
using SmartShop.Infra.Data.UoW;

namespace SmartShop.Cross.Cutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            //services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewCategoria, bool>, CategoriaCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<IRepositoryCategoria, CategoriaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SmartShopContext>();

            // Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSQLContext>();

            //// Infra - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            //// Infra - Identity
            //services.AddScoped<IUser, AspNetUser>();
        }
    }
}
