using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OOP.Tests
{
    [TestClass]
    public class OOPTesting
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CheckIfThrowsNegativeEnginePowerValueException()
        {
            new Engine(-1, 4.6, "Gasoline", "H5G658");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CheckIfThrowsNegativeEngineVolumeValueException()
        {
            new Engine(300, -1, "Gasoline", "H5G658");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckIfThrowsNullEngineTypeException()
        {
            new Engine(300, 4.6, null, "H5G658");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckIfThrowsNullEngineSerialNumberException()
        {
            new Engine(300, 4.6, "Gasoline", null);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CheckIfThrowsNegativeChassisAmountOfWheelsValueException()
        {
            new Chassis(-1, "514473", 8000);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckIfThrowsNullChassisNumberException()
        {
            new Chassis(4, null, 8000);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CheckIfThrowsNegativeChassisAllowedLoadValueException()
        {
            new Chassis(4, "514473", -1);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckIfThrowsNullTransmissionTypeException()
        {
            new Transmission(null, 6, "Aisin Corporation");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CheckIfThrowsNegativeTransmissionAmountOfGearsValueException()
        {
            new Transmission("Auto", -1, "Aisin Corporation");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckIfThrowsNullTransmissionManufacturerException()
        {
            new Transmission("Auto", 6, null);
        }
    }
}
