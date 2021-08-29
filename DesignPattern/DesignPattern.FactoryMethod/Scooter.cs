using System;

namespace DesignPattern.FactoryMethod
{
    //// <summary>
    //// a 'Concrete Product' class
    //// </summary>
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the scooter : " +  miles.ToString() + "km");
        }
    }
}