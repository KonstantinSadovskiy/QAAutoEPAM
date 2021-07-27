using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
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
    }
}
