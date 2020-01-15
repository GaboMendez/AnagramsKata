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
    }
}
