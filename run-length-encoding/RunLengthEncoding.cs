using System;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (String.IsNullOrEmpty(input)) return "";
        char current = input[0];
        int counter = 0;
        string ret = "";
        foreach (char x in input)
        {
            if (x != current)
            {
                ret += $"{(counter == 1 ? "" : counter)}{current}";
                current = x;
                counter = 1;
            }
            else { ++counter; }
        }
        ret += $"{(counter == 1 ? "" : counter)}{current}";
        return ret;
    }
    public static string Decode(string input)
    {
        string currentNum = "";
        string ret = "";
        foreach (char x in input)
        {
            if (Char.IsLetter(x) || Char.IsWhiteSpace(x))
            {
                ret += new String(x, currentNum == "" ? 1 : int.Parse(currentNum));
                currentNum = "";
            }
            else
            {
                currentNum += x;
            }
        }
        return ret;
    }
}
