using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonga.SendMessage.Contracts.Errors
{
    public static class Errors
    {
        /// <summary>
        /// Gets the application not found.
        /// </summary>
        /// <value>
        /// The application not found.
        /// </value>
        public static Error InvalidMessage
        {
            get
            {
                return new Error
                {
                    Code = "InvalidMessage",
                    Description = "Invalid message on Send Method."
                };
            }
        }
        /// <summary>
        /// ConnectionFailed
        /// </summary>
        public static Error ConnectionFailed
        {
            get
            {
                return new Error
                {
                    Code = "ConnectionFailed",
                    Description = "Failed to Connect RabbitMQ Url."
                }; 
            }
        }
        /// <summary>
        /// ChannelFailed
        /// </summary>
        public static Error ChannelFailed
        {
            get
            {
                return new Error
                {
                    Code = "ChannelFailed",
                    Description = "Failed to Connect Channel Url."
                };
            }
        }

        /// <summary>
        /// Gets the unexpected internal error error.
        /// </summary>
        /// <value>
        /// The unexpected internal error error.
        /// </value>
        public static Error UnexpectedInternalError
        {
            get
            {
                return new Error { Code = "UnexpectedInternalError", Description = "Something unexpected went wrong." };
            }
        }
    }
}
