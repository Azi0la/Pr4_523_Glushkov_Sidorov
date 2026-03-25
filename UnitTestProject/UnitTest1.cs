using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pr4_523_Glushkov_Sidorov;
using Pr4_523_Glushkov_Sidorov.Pages;
using Microsoft.Win32;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = 2 + 2;
            Assert.AreEqual(res, 4);
            Assert.AreNotEqual(res, 5);
            Assert.IsFalse(res > 5);
            Assert.IsTrue(res < 5);
        }


        [TestMethod]
        public void TestProblem1()
        {
            var problem1 = new Problem1();
            double x = Math.PI;
            double y = Math.PI * 2;
            double z = 0;
            double res_test = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), (1 + 2 * Math.Sin(y)))
                * (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));
            double res_act = problem1.Calculate1(x, y, z);
            Assert.AreEqual(res_test, res_act, res_test * 0.05);
        }
    }
}
