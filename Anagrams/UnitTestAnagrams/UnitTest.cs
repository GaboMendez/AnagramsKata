using System;
using Anagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAnagrams
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsAnagramsRiesgoAndSergio()
        {
            // Arrange
            bool expectedResult = true;

            //Act
            bool actualResult = Program.IsAnagrams("Riesgo", "Sergio");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsAnagramsPoderAndPedro()
        {
            // Arrange
            bool expectedResult = true;

            //Act
            bool actualResult = Program.IsAnagrams("Poder", "Pedro");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
