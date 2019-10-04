using System;
using EventBus;
using EventBusRabbitMQ;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SmartShop.Core;
using SmartShop.Domain.CommandHandlers;
using SmartShop.Domain.Commands.Category;
using SmartShop.Domain.Core.Bus;
using SmartShop.Domain.Core.Notifications;
using SmartShop.Domain.Interfaces;
using SmartShop.Domain.Queries;
using SmartShop.Domain.Queries.Categoria;
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

            //Pipeline Behavior
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(TracingBehavior<,>));

            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            //services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            services.AddScoped<IEventBus, EventBRabbitMQ>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewCategory, bool>, CategoryCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateCategory, bool>, CategoryCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteCategory, bool>, CategoryCommandHandler>();


            // Domain - Queries
            services.AddScoped<ICategoryQueries, CategoryQuery>();

            // Infra - Data
            services.AddScoped<ICategoryRepository, CategoryRepository>();
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

        private static void CategoryCommandHandler()
        {
            throw new NotImplementedException();
        }
    }
}
