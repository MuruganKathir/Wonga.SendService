using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonga.ReceieveMessage.Contracts.ReceieveMessage
{
    public interface IReceieveMessageOrchestrations
    {
       /// <summary>
       /// Send Message from Orchestration Contract
       /// </summary>
       /// <param name="fromProducer"></param>
       /// <returns></returns>
        OperationOutcome ReceieveMessage();
    }
}
