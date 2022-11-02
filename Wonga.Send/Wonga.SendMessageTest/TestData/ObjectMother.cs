using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonga.SendMessageTest.TestData
{
    public static class ObjectMother
    {
        private static string validMessage = null;
        private static string inValidMessage = null;
        private static string inValidQueueUrl = null;
        private static string validQueueUrl = null;

        public static string ValidMessage
        {
            get
            {
                if (validMessage == null)
                {
                    validMessage = "Valid";
                    return validMessage;
                }

                return validMessage;
            }
        }

        public static string InValidMessage
        {
            get
            {
                if (inValidMessage == null)
                {
                    inValidMessage = " ";
                    return inValidMessage;
                }

                return inValidMessage;
            }
        }

        public static string ValidRabbitQueueURL
        {
            get
            {
                if (validQueueUrl == null)
                {
                    validQueueUrl = "amqp://guest:guest@localhost:5672";
                    return validQueueUrl;
                }

                return inValidMessage;
            }
        }

        public static string InValidRabbitQueueURL
        {
            get
            {
                if (inValidQueueUrl == null)
                {
                    inValidQueueUrl = "http://guest:guest@localhost:5672";
                    return inValidQueueUrl;
                }

                return inValidQueueUrl;
            }
        }
    }
}
