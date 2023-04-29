using System;
using System.Linq;

public static class Bob
{
    private static bool isCaps(string statement) => statement.ToList().FindAll(x => Char.IsLetter(x)).Any() && statement.ToList().FindAll(x => Char.IsLetter(x)).All(x => Char.IsUpper(x));
    public static string Response(string statement) =>
        String.IsNullOrEmpty(statement.Trim())
            ? "Fine. Be that way!" : (isCaps(statement.Trim()) && statement.Trim().EndsWith('?'))
            ? "Calm down, I know what I'm doing!" : isCaps(statement.Trim())
            ? "Whoa, chill out!" : statement.Trim().EndsWith('?')
            ? "Sure." : "Whatever.";
}