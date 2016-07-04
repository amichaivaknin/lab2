using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class TestCalcMul
    {
        [TestMethod]
        public void Calc_Mul_BothPositive()
        {
            var calc = new Calc();

            double res = calc.Mul(1, 1);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Calc_Mul_SingleZero()
        {
            var calc = new Calc();

            double res = calc.Mul(50, 0);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Calc_Mul_TwoZeros()
        {
            var calc = new Calc();

            double addResult = calc.Mul(0, 0);

            Assert.AreEqual(0, addResult);
        }

        [TestMethod]
        public void Calc_Mul_Commutative()
        {
            var calc = new Calc();

            var first = 42;
            var second = 777;

            Assert.AreEqual(calc.Mul(first, second), calc.Mul(second, first));
        }

        [TestMethod]
        public void Calc_Mul_MulSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Mul(1, -1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Calc_Mul_MulTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Mul(-1, -1);

            Assert.AreEqual(1, result);
        }
    }
}
