using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClassLibrary
{
    /// <summary>
    /// Enterprise library logger
    /// </summary>
    public static class EnterpriseLibraryLogger
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="properties">The properties.</param>
        public static void LogInfo(string message, IDictionary<string, string> properties = null)
        {
            TraceEventType traceEventType = TraceEventType.Information;

            IDictionary<string, object> parameters = properties
                .ToDictionary(pair => pair.Key, pair => (object)pair.Value);

            Logger.Write(
                new LogEntry(
                    message,
                    "Information",
                    0,
                    100,
                    traceEventType,
                    "License Server",
                    parameters));
        }
    }
}
