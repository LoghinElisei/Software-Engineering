using Calendar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectCalendar
{
    [TestClass]
    public class ZileTest
    {
        [TestMethod]
        public void Test_04_07_2003()
        {
            Zile z = new Zile(4, 7, 2003);
            Assert.AreEqual(1280, z.Diferenta);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_29_02_2100()
        {
            Zile z = new Zile(29, 2, 2100);
        }

        [TestMethod]
        public void Test_10_05_2000()
        {
            Zile z = new Zile(10, 5, 2000);
            Assert.AreEqual(130, z.Diferenta);
        }

        [TestMethod]
        public void Test_05_01_2000()
        {
            Zile z = new Zile(5, 1, 2000);
            Assert.AreEqual(4, z.Diferenta);
        }

        [TestMethod]
        public void Test_15_10_3404()
        {
            Zile z = new Zile(15, 10, 3404);
            Assert.AreEqual(513088, z.Diferenta);
        }

        [TestMethod]
        public void Test_02_01_2009()
        {
            Zile z = new Zile(2, 1, 2009);
            Assert.AreEqual(3289, z.Diferenta);
        }

        [TestMethod]
        public void Test_30_04_1972()
        {
            Zile z = new Zile(30, 4, 1972);
            Assert.AreEqual(-10107, z.Diferenta);
        }

        [TestMethod]
        public void Test_15_12_1999()
        {
            Zile z = new Zile(15, 12, 1999);
            Assert.AreEqual(-17, z.Diferenta);
        }

        [TestMethod]
        public void Test_01_01_1976()
        {
            Zile z = new Zile(1, 1, 1976);
            Assert.AreEqual(-8766, z.Diferenta);
        }

        [TestMethod]
        public void Test_05_11_1997()
        {
            Zile z = new Zile(5, 11, 1997);
            Assert.AreEqual(-787, z.Diferenta);
        }

        [TestMethod]
        public void Test_20_03_79()
        {
            Zile z = new Zile(20, 3, 79);
            Assert.AreEqual(-701552, z.Diferenta);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_32_12_1988()
        {
            Zile z = new Zile(32, 12, 1988);
        }
    }
}
