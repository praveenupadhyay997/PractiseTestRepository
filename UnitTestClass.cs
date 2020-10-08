using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProjectPractise;

namespace TestProjectPractise
{
    [TestClass]
    public class UnitTestClass
    {
        [TestCategory("Addition")]
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            TestClass testClass = new TestClass();
            int expected = 35;
            int numOne = 20;
            int numTwo = 15;
            //Act
            var actual = testClass.addNumber(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory("Subtraction")]
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            TestClass testClass = new TestClass();
            int expected = 5;
            int numOne = 15;
            int numTwo = 10;
            //Act
            var actual = testClass.subtractNumber(numOne, numTwo);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
