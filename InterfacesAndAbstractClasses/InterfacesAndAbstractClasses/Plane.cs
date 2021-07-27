using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public class Plane : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        private int StartingSpeedKPH { get; set; }
        private int AccelerationKPHH { get; set; }
        private double RangeForAcceleration { get; set; }
        private double MaxSpeed { get; set; }

        public Plane(Coordinates coordinates, int startingSpeedKPH, int accelerationKPHH, double rangeForAcceleration, double maxSpeed)
        {
            this.Coordinates = coordinates;
            this.StartingSpeedKPH = startingSpeedKPH;
            this.AccelerationKPHH = accelerationKPHH;
            this.RangeForAcceleration = rangeForAcceleration;
            this.MaxSpeed = maxSpeed;
        }

        public void FlyTo(Coordinates newCoordinates)
        {
            this.Coordinates = newCoordinates;
        }

        public double GetFlyTime(Coordinates newCoordinates)
        {
            double range = Helper.FindRange(this.Coordinates, newCoordinates);
            return Math.Round(((range / (this.StartingSpeedKPH + Helper.CountAverageAccelerationSpeed(range, this.AccelerationKPHH, this.RangeForAcceleration, this.MaxSpeed))) * 60), 4);
        }
    }
}
