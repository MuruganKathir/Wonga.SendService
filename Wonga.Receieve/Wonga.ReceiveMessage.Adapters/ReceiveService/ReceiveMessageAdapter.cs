using RabbitMQ.Client;
using System;
using Wonga.Common;
using Wonga.ReceiveMessage.Adapters.Contracts;
using Errors = Wonga.Common.Errors;

namespace Wonga.ReceieveMessage.Adapters.ReceieveMessage
{
    public class ReceieveMessageAdapter : IReceieveMessageAdapter
    {
        
        public QueueOperationOutcome ReceieveMessage()
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
            DirectExchangeConsumer.Consume(channel);
            return QueueOperationOutcome.Success;           
        }
        public bool IsMessageListened()
        {
            bool iListened =false;
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            var connection = factory.CreateConnection();
            if (connection == null)
            {
                return iListened =true;
                
            }
            var channel = connection.CreateModel();
            if (channel == null)
            {
                return iListened = true;
                //return QueueOperationOutcome.CreateError(Errors.ChannelFailed);
            }
            return iListened;
        }
    }
}
