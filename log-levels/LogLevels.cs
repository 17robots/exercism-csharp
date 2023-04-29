using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(" ")).Trim();
    public static string LogLevel(string logLine) => logLine.Remove(logLine.IndexOf("]")).Replace("[","").ToLower();
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
