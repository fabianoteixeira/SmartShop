using EventBus;
using EventBus.Events;
using EventBus.Interfaces;
using RabbitMQ.Client;
using System;
using System.Text;

namespace EventBusRabbitMQ
{
    public class EventBRabbitMQ : IEventBus, IDisposable
    {
        public void Dispose()
        {
            GC.Collect();
        }

        // Implementation using RabbitMQ API
        //...
        public void Publish(IntegrationEvent @event)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "dev-fabiano-server.eastus.cloudapp.azure.com",
                UserName = "fabiano",
                Password = "fabiano"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                while (true)
                {

                    string message = "teste";

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "hello",
                                         basicProperties: null,
                                         body: body);

                }
            }
        }

        public void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void SubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler
        {
            throw new NotImplementedException();
        }
    }
}
