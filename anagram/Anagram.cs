using System;
using System.Linq;

public class Anagram
{
    public string orig;
    public Anagram(string baseWord) => orig = baseWord;

    public string[] FindAnagrams(string[] potentialMatches) => Array.FindAll(potentialMatches, x =>
    {
        string tmpStr = orig; return x.Length == orig.Length && x.ToLower() != orig.ToLower() && x.All(x =>
        {
            bool tmp = tmpStr.ToLower().Contains(Char.ToLower(x));
            if (tmp && tmpStr != "")
                tmpStr = tmpStr.Remove(tmpStr.ToLower().IndexOf(Char.ToLower(x)), 1);
            return tmp;
        });
    });
}