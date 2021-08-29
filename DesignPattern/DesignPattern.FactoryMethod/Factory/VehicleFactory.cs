namespace DesignPattern.FactoryMethod.Factory
{
    //// <summary>
    //// The Creator abstract class
    //// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle (string vehicle);
    }
}