using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public class Bird : IFlyable
    {
        private Coordinates Coordinates { get; set; }
        private int MaxSpeedKPH { get; set; }
        private int MinSpeedKPH { get; set; }
        private int CoordinatesDispersion { get; set; }

        public Bird(Coordinates coordinates, int minSpeedKPH, int maxSpeedKPH, int coordinatesDispersion)
        {
            this.Coordinates = coordinates;
            this.MaxSpeedKPH = maxSpeedKPH;
            this.MinSpeedKPH = minSpeedKPH;
            this.CoordinatesDispersion = coordinatesDispersion;
        }

        public double GetBirdSpeed()
        {
            Random rnd = new Random();
            return rnd.Next(this.MinSpeedKPH, this.MaxSpeedKPH);
        }

        public void FlyTo(Coordinates newCoordinates)
        {
            Coordinates temp = new Coordinates(newCoordinates.XCoord + GetRandomBirdCoordinateAxisDeviation(),
                                               newCoordinates.YCoord + GetRandomBirdCoordinateAxisDeviation(),
                                               newCoordinates.ZCoord + GetRandomBirdCoordinateAxisDeviation());
            this.Coordinates = temp;
        }

        public double GetFlyTime(Coordinates newCoordinates)
        {
            double range = Helper.FindRange(this.Coordinates, newCoordinates);
            double birdSpeed = GetBirdSpeed();
            if(birdSpeed == 0)
            {
                return 0;
            }
            return Math.Round((range / birdSpeed * 60), 4);
        }

        public int GetRandomBirdCoordinateAxisDeviation()
        {
            Random rnd = new Random();
            return rnd.Next(-this.CoordinatesDispersion, this.CoordinatesDispersion);
        }
    }
}
