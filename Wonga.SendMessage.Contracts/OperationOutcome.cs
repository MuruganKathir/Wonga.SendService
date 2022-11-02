using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wonga.SendMessage.Contracts.Errors;

namespace Wonga.SendMessage.Contracts
{
    public class OperationOutcome
    {
        /// <summary>
        /// Gets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        public static OperationOutcome Success
        {
            get
            {
                return new OperationOutcome
                {
                    IsSuccessful = true
                };
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is successful.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is successful; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public IEnumerable<Error> Errors { get; set; }

        /// <summary>
        /// Evaluates the specified errors.
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <returns>The outcome.</returns>
        public static OperationOutcome Evaluate(IEnumerable<Error> errors)
        {
            if (errors.Any())
            {
                return new OperationOutcome
                {
                    IsSuccessful = false,
                    Errors = errors
                };
            }

            return OperationOutcome.Success;
        }

        /// <summary>
        /// Creates the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>The outcome.</returns>
        public static OperationOutcome CreateError(Error error)
        {
            return new OperationOutcome { IsSuccessful = false, Errors = new[] { error } };
        }
    }
}
