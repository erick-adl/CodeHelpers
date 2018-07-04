public class LogCategory
{
 private LogCategory(string value) { Value = value; }

 public string Value { get; set; }

 public static LogCategory Trace { get { return new LogCategory("Trace"); } }
 public static LogCategory Debug { get { return new LogCategory("Debug"); } }
 public static LogCategory Info { get { return new LogCategory("Info"); } }
 public static LogCategory Warning { get { return new LogCategory("Warning"); } }
 public static LogCategory Error { get { return new LogCategory("Error"); } }
}


/*Pass in type-safe string values as a parameter:

public static void Write(string message, LogCategory logCategory)
{
   var log = new LogEntry { Message = message };
   Logger.Write(log, logCategory.Value);
}
Usage:

Logger.Write("This is almost like an enum.", LogCategory.Info);

*/