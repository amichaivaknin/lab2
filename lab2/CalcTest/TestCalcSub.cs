using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class TestCalcSub
    {
        [TestMethod]
        public void Calc_Sub_BothPositiveAndPositiveResult()
        {
            var calc = new Calc();

            double res = calc.Sub(2, 1);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Calc_Sub_BothPositiveAndNegativeResult()
        {
            var calc = new Calc();

            double res = calc.Sub(1, 2);

            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void Calc_Sub_BothPositiveAndZeroResult()
        {
            var calc = new Calc();

            double res = calc.Sub(1, 1);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Calc_Sub_SingleZero()
        {
            var calc = new Calc();

            double res = calc.Sub(50, 0);

            Assert.AreEqual(50, res);
        }

        [TestMethod]
        public void Calc_Sub_TwoZeros()
        {
            var calc = new Calc();

            double addResult = calc.Sub(0, 0);

            Assert.AreEqual(0, addResult);
        }

        [TestMethod]
        public void Calc_Sub_SubTwoNegativeAndPositiveResult()
        {
            var calc = new Calc();

            var result = calc.Sub(-1, -10);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Calc_Sub_SubTwoNegativeAndNegetiveResult()
        {
            var calc = new Calc();

            var result = calc.Sub(-10, -1);

            Assert.AreEqual(-9, result);
        }

        [TestMethod]
        public void Calc_Sub_SubTwoNegativeAndZeroResult()
        {
            var calc = new Calc();

            var result = calc.Sub(-10, -10);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calc_Sub_SubSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Sub(1, -1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Calc_Sub_SubSinglePositive()
        {
            var calc = new Calc();

            var result = calc.Sub(-10, 1);

            Assert.AreEqual(-11, result);
        }
    }
}
