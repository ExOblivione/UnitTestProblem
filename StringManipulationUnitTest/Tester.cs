using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulationUnitTest
{
    [TestClass]
    public class SMUTest
    {
        Stringmanipulation1 testing = new Stringmanipulation1();


        [TestMethod]
        public void TestMethod1()
        {
            // This should fail, because the number is bigger than the length of the string
            string expectedResult = "testword";
            string actualString = "testword>>11";
            
            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // This should pass, and would give this output: cereferen
            string expectedResult = "cereferen";
            string actualString = "reference<<2";

            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // This should pass, and would give this output: alyzean
            string expectedResult = "alyzean";
            string actualString = "analyze>>2";

            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // This should pass, and would give this output: ionsolu
            string expectedResult = "ionsolu";
            string actualString = "solution<<3";

            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // This should pass, and would give this output: rtiesprope
            string expectedResult = "rtiesprope";
            string actualString = "properties>>5";

            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // This should pass, and would give this output: urationconfig
            string expectedResult = "urationconfig";
            string actualString = "configuration<<7";

            string actualResult = testing.StringShift(actualString);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
