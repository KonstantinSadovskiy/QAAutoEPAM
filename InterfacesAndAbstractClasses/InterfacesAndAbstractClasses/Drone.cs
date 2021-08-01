using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that defines drone
    /// </summary>
    public class Drone : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        private double Speed { get; set; }

        //Drone stops for certain amount of time every time period
        private double DroneStopPeriod { get; set; }
        private double DroneStopTime { get; set; }

        //Drone has maximum fly range
        private double MaximumRange { get; set; }

        public Drone(Coordinates coordinates, double speed, double droneStopPeriod, double droneStopTime, double maximumRange)
        {
            this.Coordinates = coordinates;
            this.Speed = speed;
            this.DroneStopPeriod = droneStopPeriod;
            this.DroneStopTime = droneStopTime;
            this.MaximumRange = maximumRange;
        }

        /// <summary>
        /// Checks if fly range is available
        /// </summary>
        /// <param name="newCoordinates">Coordinates it flies to</param>
        /// <returns>True if available, false if not</returns>
        public bool CheckIfRangeLessThanNumber(Coordinates newCoordinates)
        {
            return this.Coordinates.FindRange(newCoordinates) < this.MaximumRange;
        }

        public void FlyTo(Coordinates newCoordinates) 
        {
            if(!CheckIfRangeLessThanNumber(newCoordinates))
            {
                throw new ArgumentException($"New coordinates are in range of more than { this.MaximumRange }");
            }
            this.Coordinates = newCoordinates;
        }

        public double GetFlyTime(Coordinates newCoordinates)
        {
            if (!CheckIfRangeLessThanNumber(newCoordinates))
            {
                throw new ArgumentException($"New coordinates are in range of more than { this.MaximumRange }");
            }
            double range = this.Coordinates.FindRange(newCoordinates);
            double timeWithoutStops = (range / this.Speed) * 60;
            return Math.Round((timeWithoutStops + Math.Floor((timeWithoutStops / this.DroneStopPeriod) * DroneStopTime)), 4);
        }
    }
}
