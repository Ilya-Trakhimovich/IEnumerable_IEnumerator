using System;
using System.Diagnostics;

namespace TestEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string logName = "ProCSharpLog";
            string sourceName = "EventLogDemoApp";
            if (!EventLog.SourceExists(sourceName))
            {
                var eventSourceData = new EventSourceCreationData(sourceName, logName);
                EventLog.CreateEventSource(eventSourceData);
            }
        }
    }
}
