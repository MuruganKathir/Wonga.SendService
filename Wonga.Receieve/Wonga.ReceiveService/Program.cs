using System;
using Wonga.Common;
using Wonga.ReceieveMessage.Contracts.ReceieveMessage;

namespace Wonga.ReceiveService
{
    class Program
    {
        static void Main(string[] args)
        {
            var recvMessageOrchestration = WongaFactory.CreateInstance<IReceieveMessageOrchestrations>();
            var recvMsg = recvMessageOrchestration.ReceieveMessage();

            Console.ReadLine();
        }
    }
}
