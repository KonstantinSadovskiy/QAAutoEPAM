using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevelopmentAndBuildTools.Tests
{
    [TestClass]
    public class MaxAmountOfDifferentConsecutiveCharsTest
    {
        [TestMethod]
        public void CheckIfStringWithAllUniqueCharNoAdjacentRepeatCorrect()
        {
            Assert.AreEqual(3, MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars("ahs"));
        }

        [TestMethod]
        public void CheckIfStringWithAllCharNoAdjacentRepeatCorrect()
        {
            Assert.AreEqual(3, MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars("aha"));
        }

        [TestMethod]
        public void CheckIfOneCharStringCorrect()
        {
            Assert.AreEqual(1, MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars("a"));
        }


        [TestMethod]
        public void CheckIfLowerCaseUsed()
        {
            Assert.AreEqual(2, MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars("amMa"));
        }

        [DataTestMethod]
        [DataRow("fasdflkafadeo", 13)]
        [DataRow("addbdbsdhujdd", 10)]
        [DataRow("afSdfoamcdDod", 10)]
        public void CheckIfWorkingCorrect(string sequenceOfChars, int maxAmountOfDifferentConsecutiveChars)
        {
            Assert.AreEqual(MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars(sequenceOfChars), maxAmountOfDifferentConsecutiveChars);
        }

        [ExpectedException(typeof(ArgumentNullException), "Empty string")]
        [TestMethod]
        public void CheckIfThrowsNullStringException()
        {
            MaxAmountOfDifferentConsecutiveChars.CountMaxAmountOfDifferentConsecutiveChars("");
        }
    }
}
