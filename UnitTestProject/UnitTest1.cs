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
        public void TestMethodProblem1()
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

        [TestMethod]
        public void TestMethodProblem2()
        {
            var problem2 = new Problem2();
            double x = 2;
            double y = 4;
            string function = "sh(x)";
            double fx;
            switch (function)
            {
                case "sh(x)":
                    fx = Math.Sinh(x);
                    break;
                case "x^2":
                    fx = Math.Pow(x, 2);
                    break;
                case "e^x":
                    fx = Math.Exp(x);
                    break;
                default:
                    fx = Math.Sinh(x);
                    break;
            }
            double test_res;
            if (x > y)
                test_res = Math.Pow(fx - y, 3) + Math.Atan(fx);
            else if (x < y)
                test_res = Math.Pow(y - fx, 3) + Math.Atan(fx);
            else
                test_res = Math.Pow(y + fx, 3) + 0.5;

            Assert.AreEqual(test_res, 1.35371373880349);
            Assert.AreNotEqual(test_res, 1.36);
            Assert.IsFalse(test_res > 1.36);
            Assert.IsTrue(test_res < 1.36);
        }

        [TestMethod]
        public void TestProblem3()
        {
            var problem3 = new Problem3();

        }
    }
}
