using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    public static class Helper
    {
        public static double FindRange(Coordinates initCoordinates, Coordinates newCoordinates)
        {
            return Math.Sqrt((newCoordinates.XCoord - initCoordinates.XCoord) * (newCoordinates.XCoord - initCoordinates.XCoord) +
                             (newCoordinates.YCoord - initCoordinates.YCoord) * (newCoordinates.YCoord - initCoordinates.YCoord) +
                             (newCoordinates.ZCoord - initCoordinates.ZCoord) * (newCoordinates.ZCoord - initCoordinates.ZCoord));
        }

        public static double CountAverageAccelerationSpeed(double range, double accelerationValue, double rangeForOneAccelerationIteration, double maxSpeed)
        {
            double fullIterationsAmount = Math.Floor(range / rangeForOneAccelerationIteration);
            double lastIteration = Math.Round((range % rangeForOneAccelerationIteration), 4) / rangeForOneAccelerationIteration;
            double allIterationsAmount = fullIterationsAmount + lastIteration;
            double eachFullIterationPercentagePart = Math.Round((1 / allIterationsAmount), 4);
            double lastIterationPercentagePart = Math.Round((lastIteration / allIterationsAmount), 4);
            double averageSpeed = 0;
            double currentSpeedFromAcceleration = 0;
            for (int iter = 0; iter < fullIterationsAmount; iter++)
            {
                averageSpeed += Math.Round((currentSpeedFromAcceleration * eachFullIterationPercentagePart), 4);
                if(currentSpeedFromAcceleration < maxSpeed)
                {
                    currentSpeedFromAcceleration += accelerationValue;
                }
            }
            averageSpeed += Math.Round((currentSpeedFromAcceleration * lastIterationPercentagePart), 4);
            return averageSpeed;
        }
    }
}
