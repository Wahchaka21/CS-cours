using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            System.Console.WriteLine(car.speed);
            System.Console.WriteLine(car.wheels);
            car.Go();

            System.Console.WriteLine(bicycle.speed);
            System.Console.WriteLine(bicycle.wheels);
            bicycle.Go();

            System.Console.WriteLine(boat.speed);
            System.Console.WriteLine(boat.wheels);
            boat.Go();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            System.Console.WriteLine("Cette voiture avance");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}