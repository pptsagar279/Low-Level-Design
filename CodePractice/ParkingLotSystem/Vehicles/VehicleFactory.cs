
namespace CodePractice.ParkingLotSystem.Vehicles
{
    internal class VehicleFactory
    {
        internal static IVehicle VehicleFactoryMethod(VehicleType typeOfVehicle, int id)
        {
            switch (typeOfVehicle)
            {
                case VehicleType.Car: 
                    return new Car(id);
                case VehicleType.MotorBike: 
                    return new MotorBike(id);
                case VehicleType.Truck: 
                    return new Truck(id);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
