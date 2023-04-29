using System;

public static class Leap
{
    public static bool IsLeapYear(int year) => year % 400 == 0 ? true : year % 100 == 0 ? false : year % 4 == 0;
}