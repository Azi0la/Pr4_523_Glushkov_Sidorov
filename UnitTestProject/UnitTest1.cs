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
        public void Problem1_Calculate1_WithValidArgs_Calculating()
        {
            // Arrange
            var problem1 = new Problem1();
            double x = Math.PI;
            double y = Math.PI * 2;
            double z = 0;
            double res_test = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), (1 + 2 * Math.Sin(y)))
                * (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));

            // Act
            double res_act = problem1.Calculate1(x, y, z);
            
            // Assert
            Assert.AreEqual(res_test, res_act, Math.Abs(res_test * 0.05));
        }

        [TestMethod]
        public void Problem1_Calculate1_AllZeros_Calculating()
        {
            // Arrange
            var problem1 = new Problem1();
            double x = 0;
            double y = 0;
            double z = 0;
            double res_test = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), (1 + 2 * Math.Sin(y)))
                * (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));

            // Act
            double res_act = problem1.Calculate1(x, y, z);

            // Assert
            Assert.AreEqual(res_test, res_act, Math.Abs(res_test * 0.05));
        }


        [TestMethod]
        public void Problem2_Calculate1_WithValidArgs_Calculating()
        {
            // Arrange
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

            // Act
            double act_res = problem2.Calcus2(x, y, function);
            // Assert
            Assert.AreEqual(test_res, act_res, Math.Abs(test_res * 0.05));
        }

        [TestMethod]
        public void Problem2_Calculate2_FunctionDoesntExist_SelectDefaut()
        {
            // Arrange
            var problem2 = new Problem2();
            double x = -3.25;
            double y = Math.Exp(1);
            string function = "NOT A FUNC, JUST A FIH";
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

            // Act
            double act_res = problem2.Calcus2(x, y, function);
            // Assert
            Assert.AreEqual(test_res, act_res, Math.Abs(test_res * 0.05));
        }

        [TestMethod]
        public void Problem3_Calculate1_WithValidArgs_Calculating()
        {
            //Arrange
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

            // Act
            List<double> act_results = problem3.Calculate3(xo, xk, dx, a, b);

            // Assert
            // Проверка количества точек
            Assert.AreEqual(test_results.Count, act_results.Count);
            for(int i = 0; i < test_results.Count; i++)
            {
                // Проверка правильности расчётов
                Assert.AreEqual(test_results[i], act_results[i], Math.Abs(test_results[i] * 0.05));
            }

        }


        [TestMethod]
        public void Problem3_Calulate3_WrongDxSign_ReverseDx()
        {
            //Arrange
            var problem3 = new Problem3();
            // Негативный тест-кейс
            // dx имеет другой знак
            double xo = 1;
            double xk = -9;
            double dx = 0.5;
            double a = 3;
            double b = 4.62;

            if (xo > xk)
            {
                double t = xo;
                xo = xk;
                xk = t;
            }

            double test_res_wrongdx;
            List<double> test_results_wrongdx = new List<double>();

            for (double i = xo; i <= xk; i += dx)
            {
                test_res_wrongdx = a * Math.Pow(i, 3) + Math.Pow(Math.Cos(Math.Pow(i, 3) - b), 2);
                test_results_wrongdx.Add(test_res_wrongdx);
            }

            // Act
            List<double> act_results_wrongdx = problem3.Calculate3(xo, xk, dx, a, b);

            // Assert
            // Проверка количества точек
            Assert.AreEqual(test_results_wrongdx.Count, act_results_wrongdx.Count);
            for (int i = 0; i < test_results_wrongdx.Count; i++)
            {
                // Проверка правильности расчётов
                Assert.AreEqual(test_results_wrongdx[i], act_results_wrongdx[i], Math.Abs(test_results_wrongdx[i] * 0.05));
            }
        }
    }
}
