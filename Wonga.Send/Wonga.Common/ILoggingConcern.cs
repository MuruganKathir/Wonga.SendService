using System.Diagnostics;

namespace Wonga.Common
{
    public interface ILoggingConcern
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="level">The level.</param>
        void Log(string message, string category, EventLogEntryType level);
    }
}
