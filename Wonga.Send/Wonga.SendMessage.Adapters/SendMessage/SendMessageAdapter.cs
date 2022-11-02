using RabbitMQ.Client;
using System;
using Wonga.Common;
using Wonga.SendMessage.Adapters.Contracts;
using Wonga.SendMessage.Contracts.Errors;
using Errors = Wonga.Common.Errors;

namespace Wonga.SendMessage.Adapters.SendMessage
{
    public class SendMessageAdapter : ISendMessageAdapter
    {
        
        public QueueOperationOutcome SendMessage(string fromProducer)
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
