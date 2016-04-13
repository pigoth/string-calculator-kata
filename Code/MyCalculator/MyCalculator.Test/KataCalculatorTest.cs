using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculator.Test
{
    [TestClass]
    public class KataCalculatorTest
    {
        [TestMethod]
        public void StringEmptyTest()
        {
            var result = KataStringCalculator.Add(string.Empty);
            const int expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        } 
        
        [TestMethod]
        public void AddOneNumberString()
        {
            var result = KataStringCalculator.Add("1");
            const int expectedResult = 1;
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void AddTwoNumbersSeparatedByComma()
        {
            var result = KataStringCalculator.Add("1,2");
            const int expectedResult = 3;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
