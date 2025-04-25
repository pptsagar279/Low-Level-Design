using CodePractice.ParkingLotSystem.Vehicles;

namespace CodePractice.ParkingLotSystem
{
    internal class ParkingSpot
    {
        private VehicleType TypeOfVehicle {  get; set; }

        public bool Occupied {get; private set;}

        public IVehicle? ParkedVehicle { get; private set; }

        public ParkingSpot(VehicleType typeOfVehicle)
        {
            TypeOfVehicle = typeOfVehicle;
        }
            
        public VehicleType GetVehicleType()
        {
            return TypeOfVehicle;
        }

        public void Park(IVehicle vehicle)
        {
            Occupied = true;
            ParkedVehicle = vehicle;
            return;
        }

        public void Unpark()
        {
            ParkedVehicle = null;
            Occupied = false;
            return;
        }
    }
}
