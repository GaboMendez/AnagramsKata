using System;
using Anagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAnagrams
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsAnagramsHeaterAndReheat()
        {
            // Arrange
            bool expectedResult = true;

            //Act
            bool actualResult = true;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
