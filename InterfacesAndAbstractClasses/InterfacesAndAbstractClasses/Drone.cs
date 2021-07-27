using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public class Drone : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        private double Speed { get; set; }
        private double DroneStopPeriod { get; set; }
        private double MaximumRange { get; set; }

        public Drone(Coordinates coordinates, double speed, double droneStopPeriod, double maximumRange)
        {
            this.Coordinates = coordinates;
            this.Speed = speed;
            this.DroneStopPeriod = droneStopPeriod;
            this.MaximumRange = maximumRange;
        }

        public bool CheckIfRangeLessThan1000(Coordinates newCoordinates)
        {
            return Helper.FindRange(this.Coordinates, newCoordinates) < this.MaximumRange;
        }

        public void FlyTo(Coordinates newCoordinates) 
        {
            if(!CheckIfRangeLessThan1000(newCoordinates))
            {
                throw new ArgumentException($"New coordinates are in range of more than { this.MaximumRange }");
            }
            this.Coordinates = newCoordinates;
        }

        public double GetFlyTime(Coordinates newCoordinates)
        {
            if (!CheckIfRangeLessThan1000(newCoordinates))
            {
                throw new ArgumentException($"New coordinates are in range of more than { this.MaximumRange }");
            }
            double range = Helper.FindRange(this.Coordinates, newCoordinates);
            double timeWithoutStops = (range / this.Speed) * 60;
            return Math.Round((timeWithoutStops + Math.Floor(timeWithoutStops / this.DroneStopPeriod)), 4);
        }
    }
}
