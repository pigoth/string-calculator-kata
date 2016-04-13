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


        [TestMethod]
        public void AddUnknowNumbersSeparatedByComma()
        {
            var result = KataStringCalculator.Add("1,2,3");
            const int expectedResult = 6;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AddNumbersWithTwoSeparator()
        {
            var result = KataStringCalculator.Add("1\n2,3");
            const int expectedResult = 6;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AddNumbersWithWrongSeparator()
        {
            const string inputNumbers = "1,\n";
            var expectedResult = string.Format(KataStringCalculator.WrongInputFormat, inputNumbers);
            try
            {
                var result = KataStringCalculator.Add(inputNumbers);
            }
            catch (ArgumentException ae)
            {
                Assert.AreEqual(ae.Message, expectedResult);

            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void AddNumbersWithCustomSeparator()
        {
            var result = KataStringCalculator.Add("1\n2;3", ';');
            const int expectedResult = 6;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AddNegativeNumber()
        {
            const string inputNumbers = "2,-1,3";
            try
            {
                var result = KataStringCalculator.Add(inputNumbers);
            }
            catch (NegativeNumberException ae)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(ae.Message));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void IgnoreBigNumbers()
        {
            var result = KataStringCalculator.Add("1,1001");
            const int expectedResult = 1;
            Assert.AreEqual(expectedResult, result);
        }

    }
}
