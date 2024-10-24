using System.Diagnostics;

const string eventLogSource = "MyApplicationExample";

string logName = "MyApplicationLog";

if (!EventLog.SourceExists(eventLogSource))
{
    EventLog.CreateEventSource(eventLogSource, logName);
    Console.WriteLine($"Event Log has been created : {logName}");
}
string logMessage = $"Event Log Message: {DateTime.Now}";
Console.WriteLine(logMessage);
EventLog.WriteEntry(eventLogSource, logMessage, EventLogEntryType.Information);
Console.WriteLine("Log has been written");
Process.Start("eventvwr.exe"); 