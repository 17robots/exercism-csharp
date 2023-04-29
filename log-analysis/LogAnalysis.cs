using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string pattern) => str.Substring(str.IndexOf(pattern) + pattern.Length);
    public static string SubstringBetween(this string str, string pattern1, string pattern2) => str.Substring(str.IndexOf(pattern1) + pattern1.Length, str.IndexOf(pattern2) - str.IndexOf(pattern1) - pattern1.Length);
    public static string Message(this string str) => str.SubstringAfter(": ");
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}