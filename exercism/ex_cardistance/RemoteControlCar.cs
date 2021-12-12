using System;

class RemoteControlCar
{
     public static int distance = 0;
     public static int battery = 100;
     public static bool canDrive = true;
    
    public static RemoteControlCar Buy() =>
        new RemoteControlCar();

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(canDrive == false) 
        {
            battery = 0;
            return "Battery empty";
        } else
        {
            return $"Battery at {battery}%";
        }
    }

    public void Drive()
    {
        battery = battery - 1;

        if(canDrive == true) 
        {
            distance = distance + 20;
        }
        
        if(battery <= 0)
        {
            battery = 0;
            canDrive = false;
            BatteryDisplay();
        } 
   
    }
}
