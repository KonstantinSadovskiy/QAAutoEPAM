using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Struct that defines 3d coordinates
    /// </summary>
    public struct Coordinates
    {
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double ZCoord { get; set; }

        public Coordinates(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentException("Coordinates can't be negative");
            }
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
        }

        /// <summary>
        /// Counts range between initial and new coordinates
        /// </summary>
        /// <param name="newCoordinates">New coordinates</param>
        /// <returns>Range between two coordinates</returns>
        public double FindRange(Coordinates newCoordinates)
        {
            return Math.Sqrt((newCoordinates.XCoord - this.XCoord) * (newCoordinates.XCoord - this.XCoord) +
                             (newCoordinates.YCoord - this.YCoord) * (newCoordinates.YCoord - this.YCoord) +
                             (newCoordinates.ZCoord - this.ZCoord) * (newCoordinates.ZCoord - this.ZCoord));
        }
    }
}
