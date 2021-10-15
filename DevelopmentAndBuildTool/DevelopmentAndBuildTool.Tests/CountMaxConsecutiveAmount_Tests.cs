using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace DevelopmentAndBuildTool.Tests
{
    public class CountMaxConsecutiveAmount_Tests
    {
        [Test]
        public void CountMaxConsecutiveAmount_NullString_Test()
        {
            //ARRANGE
            string sequenceOfChars = null;

            //ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => StringOperations.CountMaxConsecutiveAmount(sequenceOfChars));
        }

        [Test]
        public void CountMaxConsecutiveAmount_EmptyString_Test()
        {
            //ARRANGE
            string sequenceOfChars = "";

            //ACT
            int actual = StringOperations.CountMaxConsecutiveAmount(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(0, actual);
        }

        [Test]
        [TestCase("aha", 3)]
        [TestCase("ahha", 2)]
        [TestCase("ahhaz", 3)]
        [TestCase("ahaac", 3)]
        [TestCase("a", 1)]
        [TestCase("aaaaaa", 1)]
        [TestCase("aaaaaaah", 2)]
        public void CountMaxConsecutiveAmount_CorrectWork_Test(string sequenceOfChars, int expect)
        {
            //ARRANGE

            //ACT
            int actual = StringOperations.CountMaxConsecutiveAmount(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(expect, actual);
        }
    }
}