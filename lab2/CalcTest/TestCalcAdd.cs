using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class TestCalcAdd
    {
        [TestMethod]
        public void Calc_Add_BothPositive()
        {
            var calc = new Calc();

            double res=calc.Add(1, 1);

            Assert.AreEqual(2,res);
        }

        [TestMethod]
        public void Calc_Add_SingleZero()
        {
            var calc = new Calc();

            double res = calc.Add(50, 0);

            Assert.AreEqual(50, res);
        }

        [TestMethod]
        public void Calc_Add_TwoZeros()
        {
            var calc = new Calc();

            double addResult = calc.Add(0, 0);

            Assert.AreEqual(0, addResult);
        }

        [TestMethod]
        public void Calc_Add_Commutative()
        {
            var calc = new Calc();

            var first = 42;
            var second = 777;

            Assert.AreEqual(calc.Add(first, second), calc.Add(second, first));
        }

        [TestMethod]
        public void Calc_Add_AddSingleNegative()
        {
            var calc = new Calc();

            var result = calc.Add(1, -1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calc_Add_AddTwoNegative()
        {
            var calc = new Calc();

            var result = calc.Add(-1, -1);

            Assert.AreEqual(-2, result);
        }

    }
}
