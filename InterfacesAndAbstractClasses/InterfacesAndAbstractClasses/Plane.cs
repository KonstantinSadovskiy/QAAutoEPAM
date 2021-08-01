using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that defines planes
    /// </summary>
    public class Plane : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        //Plane has starting speed
        private int StartingSpeedKPH { get; set; }
        //Planehas acceleration which depends on traveled distance
        private int AccelerationKPHH { get; set; }
        //Distance that needs to be travelled to apply acceleration
        private double RangeForAcceleration { get; set; }
        //Plane has max speed
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
            double range = this.Coordinates.FindRange(newCoordinates);
            return Math.Round(((range / (this.StartingSpeedKPH + Helper.CountAverageAccelerationSpeed(range, this.AccelerationKPHH, this.RangeForAcceleration, this.MaxSpeed))) * 60), 4);
        }
    }
}
