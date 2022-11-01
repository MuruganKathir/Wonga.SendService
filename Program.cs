using RabbitMQ.Client;
using System;
using Wonga.Common;
using Wonga.SendMessage.Adapters.SendMessage;
using Wonga.SendMessage.Contracts;
using Wonga.SendMessage.Contracts.SendMessage;
using Wonga.SendMessage.Orchestrations;

namespace SendService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var inputString = Console.ReadLine();

            var sendMessageOrchestration = WongaFactory.CreateInstance<ISendMessageOrchestrations>();
            var profile = sendMessageOrchestration.SendMessage(inputString);

            //var factory = new ConnectionFactory
            //{
            //    Uri = new Uri("amqp://guest:guest@localhost:5672")
            //};
            //var connection = factory.CreateConnection();
            //var channel = connection.CreateModel();
            //DirectExchangePublisher.Publish(channel);

            Console.Read();
        }
    }
}
