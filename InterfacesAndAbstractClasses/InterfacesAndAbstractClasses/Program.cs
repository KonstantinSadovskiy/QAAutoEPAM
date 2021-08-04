using System;

namespace InterfacesAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinates birdInitCoordinates = new Coordinates(0, 0, 0);
                Bird bird = new Bird(birdInitCoordinates, 0, 20, 10);

                Coordinates planeInitCoordinates = new Coordinates(0, 0, 0);
                Plane plane = new Plane(planeInitCoordinates, 200, 10, 10, 300);

                Coordinates droneInitCoordinates = new Coordinates(0, 0, 0);
                Drone drone = new Drone(droneInitCoordinates, 30, 10, 1, 1000);

                Coordinates newCooordinates = new Coordinates(100, 100, 100);

                IFlyable[] flyingItem = new IFlyable[3];
                flyingItem[0] = bird;
                flyingItem[1] = plane;
                flyingItem[2] = drone;

                foreach (IFlyable item in flyingItem)
                {
                    Console.WriteLine($"{ item.GetType().Name } fly time: " + item.GetFlyTime(newCooordinates).ToString());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
