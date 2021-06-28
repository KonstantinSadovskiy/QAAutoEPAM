using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicOfNETFrameworkAndCSharp.Tests
{
    [TestClass]
    public class ConversionFromDecimalToAnyFrom2To20Test
    {
        [DataTestMethod]
        [DataRow("485", 17, "1B9")]
        [DataRow("256", 15, "121")]
        [DataRow("425", 3, "120202")]
        [DataRow("25", 2, "11001")]
        [DataRow("650", 20, "1CA")]
        public void CheckIfWorkingCorrect(string decimalNumber, int newSystem, string expectedResult)
        {
            Assert.AreEqual(ConversionFromDecimalToAnyFrom2To20.ConvertDecimalToNewSystem(decimalNumber, newSystem), expectedResult);
        }

        [ExpectedException(typeof(ArgumentException), "Decimal number has to be natural")]
        [TestMethod]
        [DataRow("", 15)]
        [DataRow(null, 15)]
        [DataRow("-452", 15)]
        [DataRow("asdsa", 15)]
        public void CheckIfThrowsDecimalNotNaturalException(string decimalNumber, int newSystem)
        {
            ConversionFromDecimalToAnyFrom2To20.ConvertDecimalToNewSystem(decimalNumber, newSystem);
        }

        [ExpectedException(typeof(ArgumentException), "New system value is not correct")]
        [TestMethod]
        [DataRow("452", 1)]
        [DataRow("452", 0)]
        [DataRow("452", 21)]
        [DataRow("452", -21)]
        public void CheckIfThrowsNewSystemNotCorrectException(string decimalNumber, int newSystem)
        {
            ConversionFromDecimalToAnyFrom2To20.ConvertDecimalToNewSystem(decimalNumber, newSystem);
        }
    }
}
