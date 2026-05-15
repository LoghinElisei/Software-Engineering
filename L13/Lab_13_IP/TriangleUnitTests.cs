using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangles;

namespace Lab_13_IP
{
    [TestClass]
    public abstract class TriangleUnitTests
    {

         protected ITriangle _triangle;
         public abstract void Init();

        private string EvaluateTriangle()
        {
            if (_triangle.IsInvalid())
                return "0";
            string s = "";
            if (_triangle.IsScalene())
                s += "1";
            else
                s += "0";
            if (_triangle.IsIsosceles())
                s += "1";
            else
                s += "0";
            if (_triangle.IsEquilateral())
                s += "1";
            else
                s += "0";
            return s;
        }

        [TestMethod]
        public void ValidScalene1()
        {
            _triangle.SetSides(10, 8, 5);
            Assert.AreEqual("100", EvaluateTriangle(), "10-8-5 (Scalen valid)");
        }

        [TestMethod]
        public void ValidScalene2()
        {
            _triangle.SetSides(5, 6, 7);
            Assert.AreEqual("100", EvaluateTriangle(), "5-6-7 (Scalen valid)");
        }

        [TestMethod]
        public void ValidEquilateral()
        {
            _triangle.SetSides(10, 10, 10);
            Assert.AreEqual("001", EvaluateTriangle(), "10-10-10 (Echilateral valid)");
        }

        [TestMethod]
        public void ValidIsosceles()
        {
            _triangle.SetSides(10, 15, 10);
            Assert.AreEqual("010", EvaluateTriangle(), "10-15-10 (Isoscel valid)");
        }


        [TestMethod]
        public void IsoscelesPermutation1()
        {
            _triangle.SetSides(3, 3, 4);
            Assert.AreEqual("010", EvaluateTriangle(), "3-3-4 (Isoscel)");
        }

        [TestMethod]
        public void IsoscelesPermutation2()
        {
            _triangle.SetSides(3, 4, 3);
            Assert.AreEqual("010", EvaluateTriangle(), "3-4-3 (Isoscel)");
        }

        [TestMethod]
        public void IsoscelesPermutation3()
        {
            _triangle.SetSides(4, 3, 3);
            Assert.AreEqual("010", EvaluateTriangle(), "4-3-3 (Isoscel)");
        }

        [TestMethod]
        public void IsoscelesOddPerimeter1()
        {
            _triangle.SetSides(2, 2, 3);
            Assert.AreEqual("010", EvaluateTriangle(), "2-2-3 (Suma impară)");
        }

        [TestMethod]
        public void IsoscelesOddPerimeter2()
        {
            _triangle.SetSides(2, 3, 2);
            Assert.AreEqual("010", EvaluateTriangle(), "2-3-2 (Suma impară)");
        }

        [TestMethod]
        public void IsoscelesOddPerimeter3()
        {
            _triangle.SetSides(3, 2, 2);
            Assert.AreEqual("010", EvaluateTriangle(), "3-2-2 (Suma impară)");
        }


        [TestMethod]
        public void OneSideZero()
        {
            _triangle.SetSides(0, 5, 5);
            Assert.AreEqual("0", EvaluateTriangle(), "0-5-5 (O latură e 0)");
        }

        [TestMethod]
        public void NegativeSide()
        {
            _triangle.SetSides(-1, 5, 5);
            Assert.AreEqual("0", EvaluateTriangle(), "-1-5-5 (O latură e negativă)");
        }

        [TestMethod]
        public void AllSidesZero()
        {
            _triangle.SetSides(0, 0, 0);
            Assert.AreEqual("0", EvaluateTriangle(), "0-0-0 (Toate laturile sunt 0)");
        }


        [TestMethod]
        public void SumEqualsThird1()
        {
            _triangle.SetSides(1, 2, 3);
            Assert.AreEqual("0", EvaluateTriangle(), "1-2-3 (Laturi degenerate)");
        }

        [TestMethod]
        public void SumEqualsThird2()
        {
            _triangle.SetSides(1, 3, 2);
            Assert.AreEqual("0", EvaluateTriangle(), "1-3-2 (Laturi degenerate)");
        }

        [TestMethod]
        public void SumEqualsThird3()
        {
            _triangle.SetSides(3, 1, 2);
            Assert.AreEqual("0", EvaluateTriangle(), "3-1-2 (Laturi degenerate)");
        }

        [TestMethod]
        public void SumLessThanThird1()
        {
            _triangle.SetSides(1, 2, 4);
            Assert.AreEqual("0", EvaluateTriangle(), "1-2-4 (Nu formează triunghi)");
        }

        [TestMethod]
        public void SumLessThanThird2()
        {
            _triangle.SetSides(1, 4, 2);
            Assert.AreEqual("0", EvaluateTriangle(), "1-4-2 (Nu formează triunghi)");
        }

        [TestMethod]
        public void SumLessThanThird3()
        {
            _triangle.SetSides(4, 1, 2);
            Assert.AreEqual("0", EvaluateTriangle(), "4-1-2 (Nu formează triunghi)");
        }

        [TestMethod]
        public void InvalidIsosceles()
        {
            _triangle.SetSides(10, 20, 10);
            Assert.AreEqual("0", EvaluateTriangle(), "10-20-10 (Isoscel invalid)");
        }


        [TestMethod]
        public void IntegerOverflow()
        {
            _triangle.SetSides(int.MaxValue, int.MaxValue, int.MaxValue);
            Assert.AreEqual("001", EvaluateTriangle(), "MaxInt-MaxInt-MaxInt (Overflow test)");
        }


    }
}
