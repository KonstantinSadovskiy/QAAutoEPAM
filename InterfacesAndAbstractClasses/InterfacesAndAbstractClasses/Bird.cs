using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that defines bird
    /// </summary>
    public class Bird : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        //Bird has random speed
        //Max random bird speed
        private int MaxSpeedKPH { get; set; }
        //Min random bird speed
        private int MinSpeedKPH { get; set; }
        //Bird arrives at coordinates that randomly deviates from oringinal
        //Amount of deviation from original coordinates
        private int CoordinatesDeviation { get; set; }

        public Bird(Coordinates coordinates, int minSpeedKPH, int maxSpeedKPH, int coordinatesDispersion)
        {
            this.Coordinates = coordinates;
            this.MaxSpeedKPH = maxSpeedKPH;
            this.MinSpeedKPH = minSpeedKPH;
            this.CoordinatesDeviation = coordinatesDispersion;
        }
        /// <summary>
        /// Get random bird speed in range from Min to Max
        /// </summary>
        /// <returns>Randomly chosen bird speed</returns>
        public double GetBirdSpeed()
        {
            Random rnd = new Random();
            return rnd.Next(this.MinSpeedKPH, this.MaxSpeedKPH);
        }

        public void FlyTo(Coordinates newCoordinates)
        {
            Coordinates temp = new Coordinates(newCoordinates.XCoord + GetCoordinateDeviation(),
                                               newCoordinates.YCoord + GetCoordinateDeviation(),
                                               newCoordinates.ZCoord + GetCoordinateDeviation());
            this.Coordinates = temp;
        }

        public double GetFlyTime(Coordinates newCoordinates)
        {
            double range = this.Coordinates.FindRange(newCoordinates);
            double birdSpeed = GetBirdSpeed();
            //If birds speed equals to 0, it flies infinitely long
            if(birdSpeed == 0)
            {
                return Double.PositiveInfinity;
            }
            return Math.Round((range / birdSpeed * 60), 4);
        }

        /// <summary>
        /// Randomly choses coordinate axis deviation amount in chosen range
        /// </summary>
        /// <returns>Axis deviation value</returns>
        public int GetCoordinateDeviation()
        {
            Random rnd = new Random();
            return rnd.Next(-this.CoordinatesDeviation, this.CoordinatesDeviation);
        }
    }
}
