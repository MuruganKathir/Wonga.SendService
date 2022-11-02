using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wonga.ReceieveMessage.Adapters.ReceieveMessage
{
    public class DirectExchangePublisher
    {
        public static void Publish(IModel channel)
        {
            var ttl = new Dictionary<string, object>
            {
                {"x-message-ttl", 30000 }
            };
            channel.ExchangeDeclare("wonga-direct-exchange", ExchangeType.Direct, arguments: ttl);
            var count = 0;

            while (true)
            {
                var message = new { Name = "Producer", Message = $"Name" };
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish("wonga-direct-exchange", "account.init", null, body);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}
