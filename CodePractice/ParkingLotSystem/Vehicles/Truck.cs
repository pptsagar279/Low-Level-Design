
namespace CodePractice.ParkingLotSystem.Vehicles
{
    internal class Truck : IVehicle
    {
        public int Id { get; set; }

        public Truck(int id)
        {
            Id = id;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.Truck;
        }
    }
}
