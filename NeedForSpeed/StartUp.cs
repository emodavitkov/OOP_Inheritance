using System;
using System.IO;

namespace NeedForSpeed
{
    public class StartUp
    { 
        public static void Main(string[] args)
        {
            Vehicle test = new Vehicle(10, 20);
            
            test.Drive(10);
            Console.WriteLine(test.Fuel);

            SportCar test1 = new SportCar(10, 20);

            test1.Drive(10);
            Console.WriteLine(test1.Fuel);

            FamilyCar familyCar = new FamilyCar(150, 50);
            System.Console.WriteLine(familyCar);

        }
    }
}