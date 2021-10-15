using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace DevelopmentAndBuildTool.Tests
{
    public class CountMaxSameLetters_Tests
    {
        [Test]
        public void CountMaxSameLetters_NullString_Test()
        {
            //ARRANGE
            string sequenceOfChars = null;

            //ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => StringOperations.CountMaxSameLetters(sequenceOfChars));
        }

        [Test]
        public void CountMaxSameLetters_EmptyString_Test()
        {
            //ARRANGE
            string sequenceOfChars = "";

            //ACT
            int actual = StringOperations.CountMaxSameLetters(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(0, actual);
        }

        [Test]
        [TestCase("aha", 1)]
        [TestCase("ahha", 2)]
        [TestCase("aahhaa", 2)]
        [TestCase("aaah3aaaa", 4)]
        [TestCase("a", 1)]
        [TestCase("aaa", 3)]
        [TestCase("ah33a", 1)]
        [TestCase("3", 0)]
        public void CountMaxSameLetters_CorrectWork_Test(string sequenceOfChars, int expect)
        {
            //ARRANGE

            //ACT
            int actual = StringOperations.CountMaxSameLetters(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(expect, actual);
        }
    }
}