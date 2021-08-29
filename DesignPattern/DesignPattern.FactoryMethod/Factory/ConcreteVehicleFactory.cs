using System;

namespace DesignPattern.FactoryMethod.Factory
{
    //// <summary>
    //// a 'ConcreteCreator' class
    //// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            return vehicle switch 
            {
                "Scooter" => new Scooter(),
                "Bike" =>   new Bike(),
                _ => throw new ApplicationException(
                    string.Format("Vehicle '{0}' cannot be created", vehicle)
                )
            };
        }
    }
}