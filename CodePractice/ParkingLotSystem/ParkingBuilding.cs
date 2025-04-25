using CodePractice.ParkingLotSystem.Users;
using CodePractice.ParkingLotSystem.Vehicles;

namespace CodePractice.ParkingLotSystem
{
    public class ParkingBuilding
    {
        private List<Level> Levels;

        private List<IUsers> Subscribers;
        private ParkingBuilding()
        {
            Levels = new List<Level>();
            Subscribers = new List<IUsers>();
        }

        private static class ParkingBuildingInstance
        {
            internal static ParkingBuilding PInstance = new ParkingBuilding();
        }

        public static ParkingBuilding GetInstance()
        {    
            return ParkingBuildingInstance.PInstance; 
        }

        internal void AddLevel(Level level)
        {
            Levels.Add(level);
            return;
        }

        internal bool Park(IVehicle vehicle)
        {
            foreach (var level in Levels)
            {
                if(level.Park(vehicle))return true;
            }
            return false;
        }

        internal bool Unpark(IVehicle vehicle)
        {
            foreach (var level in Levels)
            {
                if (level.Unpark(vehicle))
                {
                    Notify(vehicle);
                    return true;
                }
            }
            return false;
        }

        internal void AddSubcriber(IUsers user)
        {
            Subscribers.Add(user);
        }
        internal void RemoveSubcriber(IUsers user)
        {
            if (Subscribers.Contains(user))
            {
                Subscribers.Remove(user);
            }
        }

        private void Notify(IVehicle vehicle)
        {
            foreach(var subscriber in Subscribers)
            {
                subscriber.Update(vehicle);
            }
        }

        internal void DisplayAvailability()
        {
            for (int i = 0; i < Levels.Count(); i++)
            {
                Console.WriteLine($"Level : {i + 1}");
                Levels[i].DisplayAvailability();
            }
        }
    }
}
