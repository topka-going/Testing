using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arange
            double a = 12;
            double b = 13;
            double result = 25;

            //ex
            var ex = Testing.Plus.Summa(a, b);
        }
    }
}
