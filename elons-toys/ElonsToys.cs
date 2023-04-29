using System;

class RemoteControlCar
{
    public double distanceDriven = 0;
    public double batteryPercent = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();
    public string DistanceDisplay() => $"Driven {distanceDriven} meters";
    public string BatteryDisplay() => batteryPercent == 0 ? "Battery empty" : $"Battery at {batteryPercent}%";
    public void Drive()
    {
        if(batteryPercent > 0) {
            distanceDriven += 20;
            batteryPercent--;
        }
    }
}
