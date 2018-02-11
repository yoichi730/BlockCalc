using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlockCalc_2;
namespace TestBlockCalc_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_SUM()
        {
            //Arrange
            My_Expression exp = new My_Expression();
            double[] arguments = { 10, 5, 3, 2, 5 };
            
            //Act
            double res = exp.SUM(5, arguments);

            //Assert
            Assert.AreEqual(25, res);
        }

        [TestMethod]
        public void TestMethod_SUB()
        {
            //Arrange
            My_Expression exp = new My_Expression();
            double[] arguments = { 10, 5, 3, 2, 5 };

            //Act
            double res = exp.SUB(5, arguments);

            //Assert
            Assert.AreEqual(-5, res);
        }

        [TestMethod]
        public void TestMethod_DIV()
        {
            //Arrange
            My_Expression exp = new My_Expression();
            double[] arguments = { 10, 5, 2 };

            //Act
            double res = exp.DIV(3, arguments);

            //Assert
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethod_MUL()
        {
            //Arrange
            My_Expression exp = new My_Expression();
            double[] arguments = { 10, 5, 2 };

            //Act
            double res = exp.MUL(3, arguments);

            //Assert
            Assert.AreEqual(100, res);
        }

    }

}
