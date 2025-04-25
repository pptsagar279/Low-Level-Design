using CodePractice.ParkingLotSystem.Vehicles;

namespace CodePractice.ParkingLotSystem
{
    internal class Client
    {       
        internal void Process()
        {
            ParkingBuilding parkingLot = ParkingBuilding.GetInstance();

            parkingLot.AddLevel(new Level(100));
            parkingLot.AddLevel(new Level(80));

            var car = VehicleFactory.VehicleFactoryMethod(VehicleType.Car, 1);
            var motorBike = VehicleFactory.VehicleFactoryMethod(VehicleType.MotorBike, 2);
            var truck = VehicleFactory.VehicleFactoryMethod( VehicleType.Truck, 3);

            parkingLot.Park(car);
            parkingLot.Park(truck);
            parkingLot.Park(motorBike);

            var user1 = new Users.Users("user1");
            var user2 = new Users.Users("user2");

            parkingLot.AddSubcriber(user1);
            parkingLot.AddSubcriber(user2);

            parkingLot.DisplayAvailability();

            parkingLot.Unpark(car);

            parkingLot.DisplayAvailability();

        }

    }
}
