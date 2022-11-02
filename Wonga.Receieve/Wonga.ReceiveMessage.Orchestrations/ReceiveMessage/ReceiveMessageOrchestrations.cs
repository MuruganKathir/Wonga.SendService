using System.Collections.Generic;
using Wonga.Common;
using Wonga.ReceieveMessage.Contracts;
using Wonga.ReceieveMessage.Contracts.ReceieveMessage;
using Wonga.ReceiveMessage.Adapters.Contracts;

namespace Wonga.ReceieveMessage.Orchestrations.ReceieveMessage
{
    public class ReceieveMessageOrchestrations : IReceieveMessageOrchestrations
    {

        private readonly IReceieveMessageAdapter receieveMessageAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceieveMessageOrchestrations" /> class.
        /// </summary>
        /// <param name="ReceieveMessageAdapterter">The self service adapter.</param>
        public ReceieveMessageOrchestrations(
            IReceieveMessageAdapter ReceieveMessageAdapterter)
        {
            this.receieveMessageAdapter = ReceieveMessageAdapterter;            
        }

        /// <summary>
        /// Send Message Business Logic Implementation
        /// </summary>
        /// <param name="fromProducer"></param>
        /// <returns></returns>
        public OperationOutcome ReceieveMessage()
        {
            var errors = new List<Error>();

            if (this.receieveMessageAdapter.IsMessageListened())
            {
                return OperationOutcome.CreateError(Errors.ConnectionFailed);
            }

            var outcome = this.receieveMessageAdapter.ReceieveMessage();
            if (outcome.IsSuccessful)
            {
                return OperationOutcome.Success;
            }

            return OperationOutcome.CreateError(Errors.UnexpectedInternalError);
        }   
    }
}
