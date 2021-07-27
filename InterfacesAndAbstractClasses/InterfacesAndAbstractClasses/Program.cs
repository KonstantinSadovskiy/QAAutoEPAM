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
                Drone drone = new Drone(droneInitCoordinates, 30, 10, 1000);

                Coordinates birdNewCooordinates = new Coordinates(100, 100, 100);
                Coordinates planeNewCooordinates = new Coordinates(100, 100, 100);
                Coordinates droneNewCooordinates = new Coordinates(100, 100, 100);

                Console.WriteLine("Fly times (in minutes): \n" + 
                                  "Bird fly time: " + bird.GetFlyTime(birdNewCooordinates).ToString() + "\n" +
                                  "Plane fly time: " + plane.GetFlyTime(planeNewCooordinates).ToString() + "\n" +
                                  "Drone fly time: " + drone.GetFlyTime(droneNewCooordinates).ToString() + "\n");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
