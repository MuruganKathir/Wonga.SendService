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
            var inputString = Console.ReadLine();

            var sendMessageOrchestration = WongaFactory.CreateInstance<ISendMessageOrchestrations>();
            var profile = sendMessageOrchestration.SendMessage(inputString);

            Console.Read();
        }
    }
}
