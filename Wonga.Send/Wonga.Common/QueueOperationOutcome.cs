using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonga.Common
{
    public class QueueOperationOutcome
    {
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public IEnumerable<Error> Errors { get; set; }
        /// <summary>
        /// Gets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        public static QueueOperationOutcome Success
        {
            get
            {
                var outcome = new QueueOperationOutcome { IsSuccessful = true };
                return outcome;
            }
        }
        /// <summary>
        /// Creates the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>The outcome.</returns>
        public static QueueOperationOutcome CreateError(Error error)
        {
            return new QueueOperationOutcome { IsSuccessful = false, Errors = new[] { error } };
        }

        /// <summary>
        /// Gets or sets a value indicating whether [was successful].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [was successful]; otherwise, <c>false</c>.
        /// </value>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Creates the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>The error outcome.</returns>
        public static QueueOperationOutcome CreateError(string message)
        {
            return new QueueOperationOutcome
            {
                IsSuccessful = false,
                Message = message
            };
        }
    }
}
