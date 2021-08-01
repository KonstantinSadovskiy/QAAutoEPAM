using System;

namespace InterfacesAndAbstractClasses
{
    public static class Helper
    {
        /// <summary>
        /// This method counts average speed on a range if acceleration depends on traveled distance. Uses same algorithm as expectation in statistics.
        /// </summary>
        /// <param name="range">Traveled distance</param>
        /// <param name="accelerationValue">Amount of acceleration gained on travelling certain distance</param>
        /// <param name="accelerationRange">Amount of distance that need to be travelled to gain acceleration</param>
        /// <param name="maxSpeed">Max available speed</param>
        /// <returns>Average speed on travelled range</returns>
        public static double CountAverageAccelerationSpeed(double range, double accelerationValue, double accelerationRange, double maxSpeed)
        {
            //Number of acceleration ranges that can fully fit in overall range
            double fullIterationsAmount = Math.Floor(range / accelerationRange);
            //Percentage of acceleration range that fits in residuals
            double lastIteration = Math.Round((range % accelerationRange), 4) / accelerationRange;
            //Number(may be fractional) of acceleration ranges that fits in range
            double allIterationsAmount = fullIterationsAmount + lastIteration;
            //Percentage of range taken by 1 full acceleration range
            double fullIterationPercentagePart = Math.Round((1 / allIterationsAmount), 4);
            //Percentage of range taken by last acceleration range
            double lastIterationPercentagePart = Math.Round((lastIteration / allIterationsAmount), 4);
            double averageSpeed = 0;
            //Speed on certain section of range
            double currentSpeedFromAcceleration = 0;

            //Counting average speed by multiplying speed in each section of range by percentage that this secton takes from overall range
            //Similar to expectation in statistics
            for (int iter = 0; iter < fullIterationsAmount; iter++)
            {
                averageSpeed += Math.Round((currentSpeedFromAcceleration * fullIterationPercentagePart), 4);
                if(currentSpeedFromAcceleration < maxSpeed)
                {
                    currentSpeedFromAcceleration += accelerationValue;
                }
            }
            averageSpeed += Math.Round((currentSpeedFromAcceleration * lastIterationPercentagePart), 4);
            return Math.Round(averageSpeed, 4);
        }
    }
}
