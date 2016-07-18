using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quad;

namespace QuadraticEquationTest
{
    //You could have added Unit Tests
    [TestClass]
    public class SolveEquationTest
    {
        [TestMethod]
        public void QuadraticEquation_SolveEquation_NoSolutions()
        {
            QuadraticEquation qe = new QuadraticEquation();
            int roots=qe.SolveEquation(1, 2, 3);
            Assert.AreEqual(0, roots);
        }

        [TestMethod]
        public void QuadraticEquation_SolveEquation_OneSolution()
        {
            QuadraticEquation qe = new QuadraticEquation();
            int roots = qe.SolveEquation(1, 2, 1);
            Assert.AreEqual(1, roots);
        }

        [TestMethod]
        public void QuadraticEquation_SolveEquation_TowSolutions()
        {
            QuadraticEquation qe = new QuadraticEquation();
            int roots = qe.SolveEquation(1,10, 2);
            Assert.AreEqual(2, roots);
        }
    }
}
