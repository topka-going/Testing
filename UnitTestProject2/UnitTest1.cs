using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Minus()
        {
            //range
            double n1 = 14;
            double n2 = 13;

            double ex = 1;
            //act
            var res = Testing.Plus.Minus(n1,n2);
            //assert
            Assert.AreEqual(ex, res);

        }
        [TestMethod]
        public void TestMethod1Minus2()
        {
            //range
            double n1 = 145;
            double n2 = 10;

            double ex = 135;
            //act
            var res = Testing.Plus.Minus(n1, n2);
            //assert
            Assert.AreEqual(ex, res);

        }
        [TestMethod]
        public void TestMethod1Minus3()
        {
            //range
            double n1 = 2;
            double n2 = 1.3;

            double ex = 0.7;
            //act
            var res = Testing.Plus.Minus(n1, n2);
            //assert
            Assert.AreEqual(ex, res);

        }
        [TestMethod]
        public void TestMethodPlus()
        {
            //range
            double n1 = 12;
            double n2 = 13;

            double ex = 25;
            //act
            var res = Testing.Plus.Pluss(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlus2()
        {
            //range
            double n1 = 120;
            double n2 = 45;

            double ex = 165;
            //act
            var res = Testing.Plus.Pluss(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlus3()
        {
            //range
            double n1 = 1.4;
            double n2 = 1.3;

            double ex = 2.7;
            //act
            var res = Testing.Plus.Pluss(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDegree()
        {
            //range
            double n1 = 12;
            double n2 = 3;

            double ex = 1728;
            //act
            var res = Testing.Plus.Degree(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDegree2()
        {
            //range
            double n1 = 11;
            double n2 = 3;

            double ex = 1331;
            //act
            var res = Testing.Plus.Degree(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDegree3()
        {
            //range
            double n1 = 30;
            double n2 = 5;

            double ex = 24300000;
            //act
            var res = Testing.Plus.Degree(n1, n2);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusMultiplication()
        {
            //range
            double a = 12;
            double b = 13;

            double ex = 156;
            //act
            var res = Testing.Plus.Multiplication(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusMultiplication2()
        {
            //range
            double a = 100;
            double b = 75;

            double ex = 7500;
            //act
            var res = Testing.Plus.Multiplication(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusMultiplication3()
        {
            //range
            double a = 745;
            double b = 29;

            double ex = 21605;
            //act
            var res = Testing.Plus.Multiplication(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDivision()
        {
            //range
            double a = 12;
            double b = 6;

            double ex = 2;
            //act
            var res = Testing.Plus.Division(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDivision2()
        {
            //range
            double a = 120;
            double b = 6;

            double ex = 20;
            //act
            var res = Testing.Plus.Division(a, b);
            Assert.AreEqual(ex, res);
        }
        [TestMethod]
        public void TestMethodPlusDivision3()
        {
            //range
            double a = 724;
            double b = 5;

            double ex = 144.8;
            //act
            var res = Testing.Plus.Division(a, b);
            Assert.AreEqual(ex, res);
        }
    }
}
