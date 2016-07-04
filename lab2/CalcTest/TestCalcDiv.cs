using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class TestCalcDiv
    {
        [TestMethod]
        public void Calc_Div_BothPositive()
        {
            var calc = new Calc();

            double res = calc.Div(4, 2);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Calc_Div_SingleZero()
        {
            var calc = new Calc();

            double res = calc.Div(50, 0);

            Assert.AreEqual(double.PositiveInfinity, res);
        }

        [TestMethod]
        public void Calc_Div_NegNumSingleZero()
        {
            var calc = new Calc();

            double res = calc.Div(-50, 0);

            Assert.AreEqual(double.NegativeInfinity, res);
        }

        [TestMethod]
        public void Calc_Div_TwoZeros()
        {
            var calc = new Calc();

            double addResult = calc.Div(0, 0);

            Assert.AreEqual(double.NaN, addResult);
        }

        [TestMethod]
        public void Calc_Div_DivZeroByNumber()
        {
            var calc = new Calc();

            

            Assert.AreEqual(0, calc.Div(0, 1));
        }

        [TestMethod]
        public void Calc_Div_MulSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Div(1, -1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Calc_Div_MulTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Div(-1, -1);

            Assert.AreEqual(1, result);
        }
    }
}
