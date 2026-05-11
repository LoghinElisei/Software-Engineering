using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathOps
{
    [TestClass]
    public class UnitTestMathOps
    {
        [TestMethod]
        public void Addition()
        {
            Assert.AreEqual(3, MathOps.Add(1, 2));
        }
        [TestMethod]
        public void Subtraction()
        {
            Assert.AreEqual(-1, MathOps.Sub(1, 2));
        }
        [TestMethod]
        public void Multiplication()
        {
            Assert.AreEqual(12, MathOps.Mul(3, 4));
        }
        [TestMethod]
        public void Division()
        {
            Assert.AreEqual(2.0 / 3.0, MathOps.Div(2, 3));
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DivisionExc1()
        {
            MathOps.Div(0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DivisionExc2()
        {
            MathOps.Div(5, 0);
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(8, MathOps.Pow(2, 3));
        }


        //[TestMethod]
        //[Timeout(2000)]  // Milliseconds
        //public void My_Test()
        //{ //...
        //}

    }
}
