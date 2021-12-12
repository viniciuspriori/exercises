using System;

namespace ex_cardistance
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlCar car = RemoteControlCar.Buy();

            Console.WriteLine($"Your brand new car has {car.BatteryDisplay()}");
            Console.WriteLine($"You have {car.DistanceDisplay()} with your brand new car\n");

            for (int i = 1; i <= 100; i++)
            {
                car.Drive();
                if(i==50) Console.WriteLine(car.BatteryDisplay());
            }

            Console.WriteLine(car.BatteryDisplay());
            Console.WriteLine(car.DistanceDisplay());

            car.Drive();
        }
    }
}
