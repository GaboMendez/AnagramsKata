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

        [TestMethod]
        public void IsAnagramsTramaAndMarta()
        {
            // Arrange
            bool expectedResult = true;

            //Act
            bool actualResult = Program.IsAnagrams("Trama", "Marta");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsAnagramsCardiografíaAndRadiografía()
        {
            // Arrange
            bool expectedResult = false;

            //Act
            bool actualResult = Program.IsAnagrams("Cardiografía", "Radiografía");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsAnagramsNacionalistaAndAltisonancia()
        {
            // Arrange
            bool expectedResult = true;

            //Act
            bool actualResult = Program.IsAnagrams("Nacionalista", "Altisonancia");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
