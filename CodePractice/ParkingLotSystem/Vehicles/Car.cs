
namespace CodePractice.ParkingLotSystem.Vehicles
{
    internal class Car : IVehicle
    {
        public int Id { get; set; }

        public Car(int id) 
        {
            Id = id;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.Car;
        }
    }
}
