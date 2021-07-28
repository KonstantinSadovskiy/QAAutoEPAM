using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfacesAndAbstractClasses.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [TestMethod]
        [DataRow(500, 10, 10, 1500, 245)]
        [DataRow(1000, -10, 5, 1500, -995)]
        [DataRow(20, 30, 15, 1000, 7.5)]
        public void CheckIfCountAverageAccelerationSpeedWorkingCorrect(double range, double accelerationValue, double rangeForOneAccelerationIteration, double maxSpeed, double result)
        {
            Assert.AreEqual(Helper.CountAverageAccelerationSpeed(range, accelerationValue, rangeForOneAccelerationIteration, maxSpeed), result);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        [DataRow(-1, 10, 10)]
        [DataRow(10, -5, 0)]
        [DataRow(4, 0.5, -100)]
        public void CheckIfCoordinatesArgumentExeptionIsThrown(double x, double y, double z)
        {
            new Coordinates(x, y, z);
        }
    }
}
