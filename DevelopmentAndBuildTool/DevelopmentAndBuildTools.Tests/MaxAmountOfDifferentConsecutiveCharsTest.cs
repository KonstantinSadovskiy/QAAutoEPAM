using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevelopmentAndBuildTools.Tests
{
    [TestClass]
    public class MaxAmountOfDifferentConsecutiveCharsTest
    {
        [DataTestMethod]
        [DataRow("ahaee", 4)]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("avvjklrfgg", 7)]
        [DataRow("aha", 3)]
        [DataRow(null, 0)]
        public void CheckIfWorkingCorrect(string sequenceOfChars, int maxAmountOfDifferentConsecutiveChars)
        {
            Assert.AreEqual(StringOperations.CountMaxConsecutiveAmount(sequenceOfChars), maxAmountOfDifferentConsecutiveChars);
        }
    }
}
