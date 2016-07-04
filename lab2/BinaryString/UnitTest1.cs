using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryDisplay;

// ReSharper disable once CheckNamespace
namespace BinaryStringTest
{
    [TestClass]
    public class TestIntToBinary
    {
        [TestMethod]
        public void BinaryString_IntToBinary_StringOfZero()
        {
            var bs = new BinaryString();
            var str = bs.IntToBinary(0);
            Assert.AreEqual("0", str);
            Assert.AreEqual(0,bs.Cnt);
        }

        [TestMethod]
        public void BinaryString_IntToBinary_StringOfOnes()
        {
            var bs = new BinaryString();
            var str = bs.IntToBinary(7);
            Assert.AreEqual("111", str);
            Assert.AreEqual(3, bs.Cnt);
        }

        public void BinaryString_IntToBinary_String()
        {
            var bs = new BinaryString();
            var str = bs.IntToBinary(5);
            Assert.AreEqual("101", str);
            Assert.AreEqual(2, bs.Cnt);
        }

    }
}
