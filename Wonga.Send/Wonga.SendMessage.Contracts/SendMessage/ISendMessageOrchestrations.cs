using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonga.SendMessage.Contracts.SendMessage
{
    public interface ISendMessageOrchestrations
    {
       /// <summary>
       /// Send Message from Orchestration Contract
       /// </summary>
       /// <param name="fromProducer"></param>
       /// <returns></returns>
        OperationOutcome SendMessage(string fromProducer);
    }
}
