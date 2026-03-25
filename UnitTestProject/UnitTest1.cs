using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using Pr4_523_Glushkov_Sidorov;
using Pr4_523_Glushkov_Sidorov.Pages;
using System;
using System.Collections.Generic;

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

            double act_res = problem2.Calcus2(x, y, function);

            Assert.AreEqual(test_res, act_res, test_res * 0.05);
        }

        [TestMethod]
        public void TestMethodProblem3()
        {
            var problem3 = new Problem3();
            double xo = 0;
            double xk = 3.8;
            double dx = 0.2;
            double a = 6;
            double b = 7;
                        
            if (xo > xk)
            {
                double t = xo;
                xo = xk;
                xk = t;
            }

            double test_res;
            List<double> test_results = new List<double>();

            for (double i = xo; i <= xk; i += dx)
            {
                test_res = a * Math.Pow(i, 3) + Math.Pow(Math.Cos(Math.Pow(i, 3) - b), 2);
                test_results.Add(test_res);
            }

            var act_results = problem3.Calculate3(xo, xk, dx, a, b);

            Assert.AreEqual(test_results.Count, act_results.Count);

            for(int i = 0; i < test_results.Count; i++)
            {
                Assert.AreEqual(test_results[i], act_results[i], test_results[i] * 0.05);
            }








        }
    }
}
