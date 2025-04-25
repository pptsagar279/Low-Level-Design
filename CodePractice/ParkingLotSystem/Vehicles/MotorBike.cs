
namespace CodePractice.ParkingLotSystem.Vehicles
{
    internal class MotorBike : IVehicle
    {
        public int Id { get; set; }

        public MotorBike(int id)
        {
            Id = id;
        }

        public VehicleType GetVehicleType()
        {
            return VehicleType.MotorBike;
        }
    }
}
