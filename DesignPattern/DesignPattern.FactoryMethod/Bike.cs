using System;

namespace DesignPattern.FactoryMethod
{
    public class Bike : IFactory
    {
        //// <summary>
        //// a 'Concrete Product' class
        //// </summary>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}