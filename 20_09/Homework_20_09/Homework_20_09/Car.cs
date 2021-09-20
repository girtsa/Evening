using System;

namespace Homework_20_09
{
    public class Car
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Volvo");
            Car car2 = car;

            Console.WriteLine("What is yor car brand");
            string brandText = Console.ReadLine();
            int brand = int.Parse(brandText);

            car.Brand = brand;
            car.CanStartDrive = true;
            car.CanDriveFaster = true;
            car.CanStopMoving = true;
            car.CanReduceSpeed = true;
            car.CanSignalToo = true;

            string "Beep + beep" = car.GetGreeting();

            Console.WriteLine("Beep + beep");

            }
    }
}
