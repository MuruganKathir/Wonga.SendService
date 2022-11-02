using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wonga.SendMessage.Adapters.Contracts;
using Wonga.SendMessage.Contracts;
using Wonga.SendMessage.Contracts.Errors;
using Wonga.SendMessage.Contracts.SendMessage;

namespace Wonga.SendMessage.Orchestrations.SendMessage
{
    public class SendMessageOrchestrations : ISendMessageOrchestrations
    {

        private readonly ISendMessageAdapter sendMessageAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfServiceOrchestrations" /> class.
        /// </summary>
        /// <param name="selfServiceAdapter">The self service adapter.</param>
        public SendMessageOrchestrations(
            ISendMessageAdapter sendMessageAdapterter)
        {
            this.sendMessageAdapter = sendMessageAdapterter;            
        }

        /// <summary>
        /// Send Message Business Logic Implementation
        /// </summary>
        /// <param name="fromProducer"></param>
        /// <returns></returns>
        public OperationOutcome SendMessage(string fromProducer)
        {
            var errors = new List<Error>();

            if (string.IsNullOrEmpty(fromProducer))
            {
                errors.Add(Errors.InvalidMessage);
            }

            var outcome = this.sendMessageAdapter.SendMessage(fromProducer);
            if (outcome.IsSuccessful)
            {
                return OperationOutcome.Success;
            }

            return OperationOutcome.CreateError(Errors.UnexpectedInternalError);
        }
    }
}
