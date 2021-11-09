using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace DevelopmentAndBuildTool.Tests
{
    public class CountMaxSameDigits_Tests
    {
        [Test]
        public void CountMaxSameDigits_NullString_Test()
        {
            //ARRANGE
            string sequenceOfChars = null;

            //ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => StringOperations.CountMaxSameDigits(sequenceOfChars));
        }

        [Test]
        public void CountMaxSameDigits_EmptyString_Test()
        {
            //ARRANGE
            string sequenceOfChars = string.Empty;

            //ACT
            int actual = StringOperations.CountMaxSameDigits(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(0, actual);
        }

        [TestCase("343", 1)]
        [TestCase("3443", 2)]
        [TestCase("334433", 2)]
        [TestCase("3334a3333", 4)]
        [TestCase("3", 1)]
        [TestCase("333", 3)]
        [TestCase("34aa3", 1)]
        [TestCase("a", 0)]
        public void CountMaxSameDigits_CorrectWork_Test(string sequenceOfChars, int expect)
        {
            //ACT
            int actual = StringOperations.CountMaxSameDigits(sequenceOfChars);

            //ASSERT
            Assert.AreEqual(expect, actual);
        }
    }
}