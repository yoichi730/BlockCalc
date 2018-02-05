using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlockCalc_2;
namespace TestBlockCalc_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_SUM1()
        {
            //Arrange
            _Expression exp = new _Expression();
            exp.x = 10;
            exp.y = 30;

            //Act
            double res = exp.SUM();

            //Assert
            Assert.AreEqual(exp.x+exp.y, res);
        }

        public void TestMethod_SUB()
        {
            //Arrange
            _Expression exp2 = new _Expression();
            exp2.x = 10;
            exp2.y = 30;

            //Act
            double res = exp2.SUB();

            //Assert
            Assert.AreEqual(exp2.x - exp2.y, res);
        }

        public void TestMethod_MUL()
        {
            //Arrange
            _Expression exp = new _Expression();
            exp.x = 10;
            exp.y = 30;

            //Act
            double res = exp.MUL();

            //Assert
            Assert.AreEqual(exp.x * exp.y, res);
        }
        public void TestMethod_DIV()
        {
            //Arrange
            _Expression exp = new _Expression();
            exp.x = 10;
            exp.y = 30;

            //Act
            double res = exp.DIV();

            //Assert
            Assert.AreEqual(exp.x / exp.y, res);
        }

        public void TestMethod_DIV_Y0()
        {
            //Arrange
            _Expression exp = new _Expression();
            exp.x = 10;
            exp.y = 0;

            //Act
            int err = exp.getErrCode();

            //Assert
            Assert.AreEqual(1, err);
        }

    }
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod_SUB()
        {
            //Arrange
            _Expression exp = new _Expression();
            exp.x = 10;
            exp.y = 30;

            //Act
            double res = exp.SUB();

            //Assert
            Assert.AreEqual(exp.x - exp.y, res);
        }
    }

}
