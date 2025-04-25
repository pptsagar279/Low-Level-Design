using CodePractice.ParkingLotSystem.Vehicles;

namespace CodePractice.ParkingLotSystem.Users
{
    internal class Users : IUsers
    {
        public string UserName { get; set; }

        public Users(string userName)
        {
            UserName = userName;
        }
        public void Update(IVehicle vehicle)
        {
            Console.WriteLine($"A parking of Vehicle type {vehicle.GetVehicleType()} got free");
        }
    }
}
