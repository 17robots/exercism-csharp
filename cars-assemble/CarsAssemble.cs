using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed == 10 ? 0.77 : speed == 9 ? 0.8 : speed >= 5 ? 0.9 : speed >= 1 ? 1.0 : 0;
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);
    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
