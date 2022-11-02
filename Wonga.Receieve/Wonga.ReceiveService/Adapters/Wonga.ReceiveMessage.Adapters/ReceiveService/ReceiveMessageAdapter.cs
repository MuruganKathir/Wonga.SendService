using RabbitMQ.Client;
using System;
using Wonga.Common;
using Wonga.ReceieveMessage.Adapters.Contracts;
using Wonga.ReceieveMessage.Contracts.Errors;
using Errors = Wonga.Common.Errors;

namespace Wonga.ReceieveMessage.Adapters.ReceieveMessage
{
    public class ReceieveMessageAdapter : IReceieveMessageAdapter
    {
        
        public QueueOperationOutcome ReceieveMessage(string fromProducer)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            var connection = factory.CreateConnection() ;
            if (connection == null)
            {
                return QueueOperationOutcome.CreateError(Errors.ConnectionFailed);
            }
            var channel = connection.CreateModel();
            if (channel == null)
            {
                return QueueOperationOutcome.CreateError(Errors.ChannelFailed);
            }
            DirectExchangePublisher.Publish(channel);
            return QueueOperationOutcome.Success;           
        }
    }
}
