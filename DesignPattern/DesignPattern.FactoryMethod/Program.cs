using System;
using DesignPattern.FactoryMethod.Factory;

namespace DesignPattern.FactoryMethod
{
    //// <summary>
    //// Factory Pattern Demo
    //// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
