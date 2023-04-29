using System.Linq;
using System.Collections.Generic;
public static class RomanNumeralExtension
{
    public static Dictionary<int, string> Buckets = new Dictionary<int, string>()
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"},
        };
    public static string ToRoman(this int value)
    {
        if (Buckets.ContainsKey(value)) return Buckets[value];
        int closestInd = Buckets.Keys.ToList().FindAll(x => value > x).Last();
        return Buckets[closestInd] + ToRoman(value - closestInd);
    }
}