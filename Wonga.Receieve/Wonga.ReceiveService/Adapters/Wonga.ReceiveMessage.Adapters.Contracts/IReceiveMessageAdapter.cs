using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wonga.Common;

namespace Wonga.ReceieveMessage.Adapters.Contracts
{
    public interface IReceieveMessageAdapter
    {
        /// <summary>
        /// Send Message method from Adapter Contract
        /// </summary>
        /// <param name="fromProducer"></param>
        /// <returns>Queue Operation outcome return either call successfull or not with data.</returns>
        QueueOperationOutcome ReceieveMessage(string fromProducer);
    }
}
