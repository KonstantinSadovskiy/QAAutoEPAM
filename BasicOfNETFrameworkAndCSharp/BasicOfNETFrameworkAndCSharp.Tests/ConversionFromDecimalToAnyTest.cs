using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicOfNETFrameworkAndCSharp.Tests
{
    [TestClass]
    public class ConversionFromDecimalToAnyTest
    {
        [DataTestMethod]
        [DataRow(256, 10, "256")]
        [DataRow(256, 11, "213")]
        [DataRow(425, 3, "120202")]
        [DataRow(25, 2, "11001")]
        [DataRow(650, 20, "1CA")]
        public void CheckIfWorkingCorrect(int decimalNumber, int newSystem, string expectedResult)
        {
            Assert.AreEqual(NumberSystemsOperations.ConvertDecimalToNewSystem(decimalNumber, newSystem), expectedResult);
        }

        [ExpectedException(typeof(ArgumentException), "Decimal number has to be natural")]
        [TestMethod]
        [DataRow(-452, 15)]
        public void CheckIfThrowsDecimalNotNaturalException(int decimalNumber, int newSystem)
        {
            NumberSystemsOperations.ConvertDecimalToNewSystem(decimalNumber, newSystem);
        }

        [ExpectedException(typeof(ArgumentException), "New system value is not correct")]
        [TestMethod]
        [DataRow(452, 1)]
        [DataRow(452, 0)]
        [DataRow(452, 21)]
        [DataRow(452, -21)]
        public void CheckIfThrowsNewSystemNotCorrectException(int decimalNumber, int newSystem)
        {
            NumberSystemsOperations.ConvertDecimalToNewSystem(decimalNumber, newSystem);
        }
    }
}
