using CodePractice.ParkingLotSystem.Vehicles;

namespace CodePractice.ParkingLotSystem
{
    internal class Level
    {
        private readonly object _lock = new object();

        private int ParkingSpots { get; set; }

        private List<ParkingSpot> ParkingSpotList { get; set; }
        public Level(int parkingSpots) 
        {
            ParkingSpots = parkingSpots;
            ParkingSpotList = new List<ParkingSpot>(ParkingSpots);

            double spotsForBikes = 0.50;
            double spotsForCars = 0.40;

            int numBikes = (int)(parkingSpots * spotsForBikes);
            int numCars = (int)(parkingSpots * spotsForCars);

            for (int i = 1; i <= numBikes; i++)
            {
                ParkingSpotList.Add(new ParkingSpot(VehicleType.MotorBike));
            }
            for (int i = numBikes + 1; i <= numBikes + numCars; i++)
            {
                ParkingSpotList.Add(new ParkingSpot(VehicleType.Car));
            }
            for (int i = numBikes + numCars + 1; i <= parkingSpots; i++)
            {
                ParkingSpotList.Add(new ParkingSpot(VehicleType.Truck));
            }
        }

        public void AddParkingSpot(ParkingSpot parkingSpot)
        {
            ParkingSpotList.Add(parkingSpot);
        }
        public bool TryPark(IVehicle vehicle, ParkingSpot spot)
        {
            lock (_lock)
            {
                if (!spot.Occupied && spot.GetVehicleType() == vehicle.GetVehicleType())
                {
                    spot.Park(vehicle); // This sets Occupied = true internally
                    return true;
                }
                return false;
            }
        }
        public bool Park(IVehicle vehicle)
        {
            foreach(var spot in ParkingSpotList)
            {
                if (TryPark(vehicle, spot))
                {
                    return true;
                }
            }

            return false;
        }
        public bool TryUnpark(IVehicle vehicle, ParkingSpot spot)
        {
            lock (_lock)
            {
                if (spot.Occupied && vehicle == spot.ParkedVehicle)
                {
                    spot.Unpark();
                    return true;
                }
                return false;
            }
        }
        public bool Unpark(IVehicle vehicle)
        {
            foreach (var spot in ParkingSpotList)
            {
                if (TryUnpark(vehicle, spot))
                {
                    return true;
                }
            }

            return false;
        }

        internal void DisplayAvailability()
        {
            int count = 0;
            foreach (var spot in ParkingSpotList)
            {
                if (!spot.Occupied) count++;
            }

            Console.WriteLine($"Number of Available spots: {count}");
        }
    }
}
